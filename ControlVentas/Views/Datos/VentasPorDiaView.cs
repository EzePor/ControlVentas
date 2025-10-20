using ControlVentas.Data;
using ControlVentas.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlVentas.Views.Datos
{
    public partial class VentasPorDiaView : Form
    {
        private readonly ControlVentaContext _context;

        // Constructor para diseñador
        public VentasPorDiaView()
        {
            InitializeComponent();
        }

        // Constructor real que recibe contexto
        public VentasPorDiaView(ControlVentaContext context) : this()
        {
            _context = context ?? new ControlVentaContext();
            // inicializar filtros con hoy
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

            // Suscribir eventos (evita duplicar)
            btnFiltrar.Click -= BtnFiltrar_Click;
            btnFiltrar.Click += BtnFiltrar_Click;

            btnSemana.Click -= BtnSemana_Click;
            btnSemana.Click += BtnSemana_Click;

            btnMes.Click -= BtnMes_Click;
            btnMes.Click += BtnMes_Click;

            btnAnio.Click -= BtnAnio_Click;
            btnAnio.Click += BtnAnio_Click;

            // Cargar
            CargarResumenPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
        }

        private void BtnFiltrar_Click(object? sender, EventArgs e)
        {
            CargarResumenPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
        }

        private void BtnSemana_Click(object? sender, EventArgs e)
        {
            var inicioSemana = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            var finSemana = inicioSemana.AddDays(6);
            dtpDesde.Value = inicioSemana;
            dtpHasta.Value = finSemana;
            CargarResumenPorRango(inicioSemana, finSemana);
        }

        private void BtnMes_Click(object? sender, EventArgs e)
        {
            var inicioMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);
            dtpDesde.Value = inicioMes;
            dtpHasta.Value = finMes;
            CargarResumenPorRango(inicioMes, finMes);
        }

        private void BtnAnio_Click(object? sender, EventArgs e)
        {
            var inicioAnio = new DateTime(DateTime.Today.Year, 1, 1);
            var finAnio = new DateTime(DateTime.Today.Year, 12, 31);
            dtpDesde.Value = inicioAnio;
            dtpHasta.Value = finAnio;
            CargarResumenPorRango(inicioAnio, finAnio);
        }

        private void CargarResumenPorRango(DateTime desde, DateTime hasta)
        {
            if (_context == null)
            {
                MessageBox.Show("Contexto no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ventas = _context.Ventas
                    .Where(v => v.fecha.Date >= desde && v.fecha.Date <= hasta && !v.eliminado)
                    .Include(v => v.detalles)
                    .ThenInclude(d => d.producto)
                    .ToList();

                var porDia = ventas
                    .GroupBy(v => v.fecha.Date)
                    .Select(g =>
                    {
                        var detalles = g.SelectMany(v => v.detalles).Where(d => d != null && d.producto != null).ToList();

                        var detallesProductos = detalles.Where(d => d.producto.Rubro != RubroEnum.Fotografia).ToList();
                        int cantidadProductos = detallesProductos.Sum(d => d.cantidad);
                        decimal totalProductos = detallesProductos.Sum(d => d.cantidad * d.precioUnitario);

                        var detallesFotos = detalles.Where(d => d.producto.Rubro == RubroEnum.Fotografia).ToList();
                        int cantidadFotos = detallesFotos.Sum(d => d.cantidad);
                        decimal totalFotos = detallesFotos.Sum(d => d.cantidad * d.precioUnitario);

                        int cantidadVentas = g.Count();
                        decimal totalDia = g.Sum(v => v.total);

                        return new
                        {
                            Fecha = g.Key.ToShortDateString(),
                            FechaKey = g.Key,
                            CantidadProductos = cantidadProductos,
                            TotalProductos = totalProductos,
                            CantidadFotos = cantidadFotos,
                            TotalFotos = totalFotos,
                            CantidadVentas = cantidadVentas,
                            TotalDia = totalDia
                        };
                    })
                    .OrderByDescending(x => x.FechaKey)
                    .ToList();

                dgvPorDia.DataSource = porDia
                    .Select(x => new
                    {
                        Fecha = x.Fecha,
                        CantidadProductos = x.CantidadProductos,
                        TotalProductos = x.TotalProductos,
                        CantidadFotos = x.CantidadFotos,
                        TotalFotos = x.TotalFotos,
                        CantidadVentas = x.CantidadVentas,
                        TotalDia = x.TotalDia
                    })
                    .ToList();

                // Renombrar encabezados para mayor legibilidad
                if (dgvPorDia.Columns.Contains("CantidadProductos"))
                    dgvPorDia.Columns["CantidadProductos"].HeaderText = "Cantidad de Productos";
                if (dgvPorDia.Columns.Contains("TotalProductos"))
                    dgvPorDia.Columns["TotalProductos"].HeaderText = "Total Productos";
                if (dgvPorDia.Columns.Contains("CantidadFotos"))
                    dgvPorDia.Columns["CantidadFotos"].HeaderText = "Cantidad de Fotos";
                if (dgvPorDia.Columns.Contains("TotalFotos"))
                    dgvPorDia.Columns["TotalFotos"].HeaderText = "Total Fotografías";
                if (dgvPorDia.Columns.Contains("CantidadVentas"))
                    dgvPorDia.Columns["CantidadVentas"].HeaderText = "Cantidad de Ventas";
                if (dgvPorDia.Columns.Contains("TotalDia"))
                    dgvPorDia.Columns["TotalDia"].HeaderText = "Total del Día";

                // Formatos numéricos
                if (dgvPorDia.Columns.Contains("CantidadProductos"))
                    dgvPorDia.Columns["CantidadProductos"].DefaultCellStyle.Format = "N0";
                if (dgvPorDia.Columns.Contains("CantidadFotos"))
                    dgvPorDia.Columns["CantidadFotos"].DefaultCellStyle.Format = "N0";
                if (dgvPorDia.Columns.Contains("CantidadVentas"))
                    dgvPorDia.Columns["CantidadVentas"].DefaultCellStyle.Format = "N0";

                if (dgvPorDia.Columns.Contains("TotalProductos"))
                    dgvPorDia.Columns["TotalProductos"].DefaultCellStyle.Format = "N2";
                if (dgvPorDia.Columns.Contains("TotalFotos"))
                    dgvPorDia.Columns["TotalFotos"].DefaultCellStyle.Format = "N2";
                if (dgvPorDia.Columns.Contains("TotalDia"))
                    dgvPorDia.Columns["TotalDia"].DefaultCellStyle.Format = "N2";

                // Alineaciones: todos los valores numéricos a la derecha, fecha a la izquierda
                var rightAlign = DataGridViewContentAlignment.MiddleRight;
                var leftAlign = DataGridViewContentAlignment.MiddleLeft;

                if (dgvPorDia.Columns.Contains("CantidadProductos"))
                    dgvPorDia.Columns["CantidadProductos"].DefaultCellStyle.Alignment = rightAlign;
                if (dgvPorDia.Columns.Contains("TotalProductos"))
                    dgvPorDia.Columns["TotalProductos"].DefaultCellStyle.Alignment = rightAlign;
                if (dgvPorDia.Columns.Contains("CantidadFotos"))
                    dgvPorDia.Columns["CantidadFotos"].DefaultCellStyle.Alignment = rightAlign;
                if (dgvPorDia.Columns.Contains("TotalFotos"))
                    dgvPorDia.Columns["TotalFotos"].DefaultCellStyle.Alignment = rightAlign;
                if (dgvPorDia.Columns.Contains("CantidadVentas"))
                    dgvPorDia.Columns["CantidadVentas"].DefaultCellStyle.Alignment = rightAlign;
                if (dgvPorDia.Columns.Contains("TotalDia"))
                    dgvPorDia.Columns["TotalDia"].DefaultCellStyle.Alignment = rightAlign;
                if (dgvPorDia.Columns.Contains("Fecha"))
                    dgvPorDia.Columns["Fecha"].DefaultCellStyle.Alignment = leftAlign;

                // Estilos por columna: colores suaves para distinguir secciones (opcional)
                if (dgvPorDia.Columns.Contains("CantidadProductos"))
                {
                    dgvPorDia.Columns["CantidadProductos"].DefaultCellStyle.BackColor = Color.FromArgb(235, 248, 255); // azul claro
                    dgvPorDia.Columns["CantidadProductos"].DefaultCellStyle.ForeColor = Color.Black;
                }
                if (dgvPorDia.Columns.Contains("TotalProductos"))
                {
                    dgvPorDia.Columns["TotalProductos"].DefaultCellStyle.BackColor = Color.FromArgb(213, 235, 255);
                }

                if (dgvPorDia.Columns.Contains("CantidadFotos"))
                {
                    dgvPorDia.Columns["CantidadFotos"].DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 244); // rosa claro
                }
                if (dgvPorDia.Columns.Contains("TotalFotos"))
                {
                    dgvPorDia.Columns["TotalFotos"].DefaultCellStyle.BackColor = Color.FromArgb(255, 230, 233);
                }

                if (dgvPorDia.Columns.Contains("CantidadVentas"))
                {
                    dgvPorDia.Columns["CantidadVentas"].DefaultCellStyle.BackColor = Color.FromArgb(243, 240, 255); // lila claro
                }
                if (dgvPorDia.Columns.Contains("TotalDia"))
                {
                    dgvPorDia.Columns["TotalDia"].DefaultCellStyle.BackColor = Color.FromArgb(224, 255, 233); // verde claro
                    dgvPorDia.Columns["TotalDia"].DefaultCellStyle.Font = new Font(dgvPorDia.Font, FontStyle.Bold);
                }

                // Mejorar apariencia de encabezados
                dgvPorDia.EnableHeadersVisualStyles = false;
                dgvPorDia.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                dgvPorDia.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvPorDia.ColumnHeadersDefaultCellStyle.Font = new Font(dgvPorDia.Font, FontStyle.Bold);
                dgvPorDia.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Actualizar totales externos si existen labels en el Designer
                var lblTotalPeriodo = this.Controls.Find("lblTotalPeriodo", true).FirstOrDefault() as Label;
                var lblCantidadVentas = this.Controls.Find("lblCantidadVentas", true).FirstOrDefault() as Label;
                if (lblTotalPeriodo != null) lblTotalPeriodo.Text = $"Total período: $ {porDia.Sum(p => p.TotalDia):N2}";
                if (lblCantidadVentas != null) lblCantidadVentas.Text = $"Total ventas período: {porDia.Sum(p => p.CantidadVentas)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
