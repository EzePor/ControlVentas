using ControlVentas.Data;
using ControlVentas.Enums;
using ControlVentas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlVentas.Views.Datos
{
    public partial class EstadisticasVentasView : Form
    {
        private readonly ControlVentaContext _context;
        private bool filtroManual = false;
        private int paginaActual = 1;
        private int tamanioPagina = 50;

        public EstadisticasVentasView(ControlVentaContext context)
        {
            InitializeComponent();
            _context = new ControlVentaContext();
            InicializarFiltros();
            CargarComboBoxRubros();
            CargarEstadisticas();
        }

        private void InicializarFiltros()
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            btnHoy.Click += (s, e) => FiltroHoy();
            btnAyer.Click += (s, e) => FiltroAyer();
            btnSemana.Click += (s, e) => FiltroSemana();
            btnMes.Click += (s, e) => FiltroMes();
            btnAnio.Click += (s, e) => FiltroAnio();
            btnFiltrar.Click += (s, e) => CargarEstadisticas();
            dtpDesde.ValueChanged += (s, e) => CargarEstadisticas();
            dtpHasta.ValueChanged += (s, e) => CargarEstadisticas();
            cmbRubro.SelectedIndexChanged += (s, e) => CargarEstadisticas();
        }

        private void CargarComboBoxRubros()
        {
            cmbRubro.DataSource = Enum.GetValues(typeof(RubroEnum));
            cmbRubro.SelectedIndex = -1;
        }

        // Filtros rápidos
        private void FiltroHoy()
        {
            filtroManual = true;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            CargarEstadisticas();
        }
        private void FiltroAyer()
        {
            filtroManual = true;
            var ayer = DateTime.Today.AddDays(-1);
            dtpDesde.Value = ayer;
            dtpHasta.Value = ayer;
            CargarEstadisticas();
        }
        private void FiltroSemana()
        {
            filtroManual = true;
            var inicioSemana = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            var finSemana = inicioSemana.AddDays(6);
            dtpDesde.Value = inicioSemana;
            dtpHasta.Value = finSemana;
            CargarEstadisticas();
        }
        private void FiltroMes()
        {
            filtroManual = true;
            var inicioMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);
            dtpDesde.Value = inicioMes;
            dtpHasta.Value = finMes;
            CargarEstadisticas();
        }
        private void FiltroAnio()
        {
            filtroManual = true;
            var inicioAnio = new DateTime(DateTime.Today.Year, 1, 1);
            var finAnio = new DateTime(DateTime.Today.Year, 12, 31);
            dtpDesde.Value = inicioAnio;
            dtpHasta.Value = finAnio;
            CargarEstadisticas();
        }

        private bool ValidarFiltros()
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Si el rubro es obligatorio:
            // if (cmbRubro.SelectedIndex == -1) { ... }
            return true;
        }

        private void CargarEstadisticas()
        {
            if (!ValidarFiltros()) return;

            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;
            RubroEnum? rubroSeleccionado = cmbRubro.SelectedItem as RubroEnum?;

            var ventas = _context.Ventas
                .Where(v => v.fecha.Date >= desde && v.fecha.Date <= hasta && !v.eliminado)
                .Include(v => v.detalles)
                .ThenInclude(d => d.producto)
                .ToList();

            var detalles = ventas
                .SelectMany(v => v.detalles)
                .Where(d => d != null && d.producto != null && !d.producto.eliminado)
                .ToList();

            if (rubroSeleccionado.HasValue)
            {
                detalles = detalles
                    .Where(d => d.producto.Rubro == rubroSeleccionado.Value)
                    .ToList();
            }

            if (detalles.Count == 0)
            {
                dgvEstadisticas.DataSource = null;
                lblProductoMasVendido.Text = "Producto más vendido: -";
                lblRubroMasVendido.Text = "Rubro más vendido: -";
                lblTotalProductos.Text = "Total productos vendidos: 0";
                lblTotalFacturadoProductos.Text = "Total facturado: $ 0.00";
                return;
            }

            // Filtro para la grilla
            List<VentaDetalle> detallesParaGrilla;
            if (chkIncluirFotografia.Checked)
                detallesParaGrilla = detalles;
            else
                detallesParaGrilla = detalles.Where(d => d.producto.Rubro != RubroEnum.Fotografia).ToList();

            // Estadística: productos más vendidos (según filtro)
            var rankingProductos = detallesParaGrilla
                .GroupBy(d => d.producto.nombre)
                .Select(g => new
                {
                    Producto = g.Key,
                    CantidadVendida = g.Sum(x => x.cantidad),
                    TotalFacturado = g.Sum(x => x.cantidad * x.precioUnitario)
                })
                .OrderByDescending(x => x.CantidadVendida)
                .ToList();

            // Paginación sobre el ranking agrupado
            var rankingPaginado = rankingProductos
                .Skip((paginaActual - 1) * tamanioPagina)
                .Take(tamanioPagina)
                .ToList();

            dgvEstadisticas.DataSource = rankingPaginado;

            // Personalizar encabezados
            if (dgvEstadisticas.Columns.Contains("CantidadVendida"))
                dgvEstadisticas.Columns["CantidadVendida"].HeaderText = "Cantidad Vendida";
            if (dgvEstadisticas.Columns.Contains("TotalFacturado"))
                dgvEstadisticas.Columns["TotalFacturado"].HeaderText = "Total Facturado";
            if (dgvEstadisticas.Columns.Contains("Producto"))
                dgvEstadisticas.Columns["Producto"].HeaderText = "Producto";

            var productoMasVendido = rankingProductos.FirstOrDefault();

            // Estadística: rubros más vendidos (según filtro)
            var rankingRubros = detallesParaGrilla
                .GroupBy(d => d.producto.Rubro)
                .Select(g => new
                {
                    Rubro = g.Key.ToString(),
                    CantidadVendida = g.Sum(x => x.cantidad),
                    TotalFacturado = g.Sum(x => x.cantidad * x.precioUnitario)
                })
                .OrderByDescending(x => x.CantidadVendida)
                .ToList();

            var rubroMasVendido = rankingRubros.FirstOrDefault();

            // Mostrar ranking de productos en el DataGridView
            dgvEstadisticas.DataSource = rankingProductos;

            // Labels: siguen excluyendo Fotografía
            var detallesSinFoto = detalles.Where(d => d.producto.Rubro != RubroEnum.Fotografia).ToList();

            lblProductoMasVendido.Text = productoMasVendido != null
                ? $"Producto más vendido: {productoMasVendido.Producto} ({productoMasVendido.CantidadVendida})"
                : "Producto más vendido: -";

            lblRubroMasVendido.Text = rubroMasVendido != null
                ? $"Rubro más vendido: {rubroMasVendido.Rubro} ({rubroMasVendido.CantidadVendida})"
                : "Rubro más vendido: -";

            lblTotalProductos.Text = $"Total productos vendidos: {detallesSinFoto.Sum(x => x.cantidad)}";
            lblTotalFacturadoProductos.Text = $"Total facturado en Productos: $ {detallesSinFoto.Sum(x => x.cantidad * x.precioUnitario):N2}";

            // Estadística solo para Fotografía
            var fotoDetalles = detalles.Where(d => d.producto.Rubro == RubroEnum.Fotografia).ToList();
            int cantidadFotos = fotoDetalles.Sum(x => x.cantidad);
            lblFotografia.Text = $"Fotos vendidas: {cantidadFotos}";

            // NUEVO: total facturado en fotografía
            decimal totalFacturadoFotos = fotoDetalles.Sum(x => x.cantidad * x.precioUnitario);
            lblTotalFacturadoFotos.Text = $"Total facturado en fotografía: $ {totalFacturadoFotos:N2}";
        }

        private void btnVerPorRubro_Click(object sender, EventArgs e)
        {
            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;
            RubroEnum? rubroSeleccionado = cmbRubro.SelectedItem as RubroEnum?;

            var ventas = _context.Ventas
                .Where(v => v.fecha.Date >= desde && v.fecha.Date <= hasta && !v.eliminado)
                .Include(v => v.detalles)
                .ThenInclude(d => d.producto)
                .ToList();

            var detalles = ventas
                .SelectMany(v => v.detalles)
                .Where(d => d != null && d.producto != null && !d.producto.eliminado)
                .ToList();

            if (rubroSeleccionado.HasValue)
            {
                detalles = detalles
                    .Where(d => d.producto.Rubro == rubroSeleccionado.Value)
                    .ToList();
            }

            // Filtro para la grilla por rubro
            List<VentaDetalle> detallesParaGrilla;
            if (chkIncluirFotografia.Checked)
                detallesParaGrilla = detalles;
            else
                detallesParaGrilla = detalles.Where(d => d.producto.Rubro != RubroEnum.Fotografia).ToList();

            // Agrupa por rubro
            var rankingRubros = detallesParaGrilla
                .GroupBy(d => d.producto.Rubro)
                .Select(g => new
                {
                    Rubro = g.Key.ToString(),
                    CantidadVendida = g.Sum(x => x.cantidad),
                    TotalFacturado = g.Sum(x => x.cantidad * x.precioUnitario)
                })
                .OrderByDescending(x => x.CantidadVendida)
                .ToList();

            dgvEstadisticas.DataSource = rankingRubros;
        }

        private void btnVerPorProducto_Click(object sender, EventArgs e)
        {
            CargarEstadisticas(); // Vuelve a la vista por producto
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvEstadisticas.DataSource == null || dgvEstadisticas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
                sfd.FileName = $"Estadisticas_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                using (var wb = new ClosedXML.Excel.XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Estadísticas");

                    // Encabezados
                    for (int col = 0; col < dgvEstadisticas.Columns.Count; col++)
                    {
                        ws.Cell(1, col + 1).Value = dgvEstadisticas.Columns[col].HeaderText;
                        ws.Cell(1, col + 1).Style.Font.Bold = true;
                        ws.Cell(1, col + 1).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightGray;
                    }

                    // Datos
                    for (int row = 0; row < dgvEstadisticas.Rows.Count; row++)
                    {
                        for (int col = 0; col < dgvEstadisticas.Columns.Count; col++)
                        {
                            ws.Cell(row + 2, col + 1).Value = dgvEstadisticas.Rows[row].Cells[col].Value?.ToString() ?? "";
                        }
                    }

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Reporte exportado correctamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarEstadisticas();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            CargarEstadisticas();
        }
    }
}
