using ControlVentas.Data;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace ControlVentas.Views.Detalles
{
    public partial class BalanceView : Form
    {
        private readonly ControlVentaContext _context;
        private ToolTip toolTipDetalle = new ToolTip();

        private enum FiltroBalance { Todos, SoloVentas, SoloGastos }
        private FiltroBalance filtroActual = FiltroBalance.Todos;

        private int paginaActual = 1;
        private int tamanioPagina = 50;

        public BalanceView(ControlVentaContext context)
        {
            InitializeComponent();
            _context = context;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

            // Conectar eventos
            btnAyer.Click += btnAyer_Click;
            btnHoy.Click += btnHoy_Click;
            btnSemana.Click += btnSemana_Click;
            btnMes.Click += btnMes_Click;
            btnAnio.Click += btnAnio_Click;
            btnFiltrar.Click += btnFiltrar_Click;
            btnVerVentas.Click += btnVerVentas_Click;
            btnVerGastos.Click += btnVerGastos_Click;
            btnVerTodo.Click += btnVerTodo_Click;
            dtpDesde.ValueChanged += dtpFecha_ValueChanged;
            dtpHasta.ValueChanged += dtpFecha_ValueChanged;
            dgvBalance.RowPrePaint += dgvBalance_RowPrePaint;
            dgvBalance.CellClick += dgvBalance_CellClick;
            dgvBalance.CellPainting += dgvBalance_CellPainting;
            dgvBalance.CellMouseEnter += dgvBalance_CellMouseEnter;
          
            CargarBalance();
        }

        private bool ValidarFiltros()
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void CargarBalance()
        {
            if (!ValidarFiltros()) return;

            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;

            // Traer ventas con detalles y productos
            var ventas = _context.Ventas
                .Where(v => v.fecha.Date >= desde && v.fecha.Date <= hasta && !v.eliminado)
                .Include(v => v.detalles)
                .ThenInclude(d => d.producto)
                .ToList();

            var ventasBalance = ventas.Select(v => new
            {
                id = v.id,
                Fecha = v.fecha,
                Tipo = "Venta",
                Descripcion = $"Venta #{v.id}",
                Monto = v.total
            }).ToList();

            var gastos = _context.Gastos
                .Where(g => g.fecha.Date >= desde && g.fecha.Date <= hasta && !g.eliminado)
                .ToList();

            var gastosBalance = gastos.Select(g => new
            {
                id = g.id,
                Fecha = g.fecha,
                Tipo = "Gasto",
                Descripcion = g.descripcion,
                Monto = -g.monto
            }).ToList();

            // Aplica el filtro solo a la grilla
            var movimientos = filtroActual switch
            {
                FiltroBalance.SoloVentas => ventasBalance.OrderBy(m => m.Fecha).ToList(),
                FiltroBalance.SoloGastos => gastosBalance.OrderBy(m => m.Fecha).ToList(),
                _ => ventasBalance.Concat(gastosBalance).OrderBy(m => m.Fecha).ToList()
            };

            int totalRegistros = movimientos.Count();
            var movimientosPaginados = movimientos
                .Skip((paginaActual - 1) * tamanioPagina)
                .Take(tamanioPagina)
                .ToList();

            dgvBalance.DataSource = movimientosPaginados
                .Select(m => new
                {
                    m.id,
                    Fecha = m.Fecha.ToShortDateString(),
                    m.Tipo,
                    m.Descripcion,
                    Monto = m.Monto
                })
                .ToList();

           

            if (dgvBalance.Columns.Contains("id"))
                dgvBalance.Columns["id"].Visible = false;

            // Agregar columna Detalle solo una vez
            if (!dgvBalance.Columns.Contains("Detalle"))
            {
                var btnDetalle = new DataGridViewButtonColumn();
                btnDetalle.Name = "Detalle";
                btnDetalle.HeaderText = "Detalle";
                btnDetalle.Text = "Ver Detalle";
                btnDetalle.UseColumnTextForButtonValue = true;
                btnDetalle.Width = 90;
                dgvBalance.Columns.Add(btnDetalle);
            }

            // Deshabilitar el botón "Detalle" para los gastos
            foreach (DataGridViewRow row in dgvBalance.Rows)
            {
                if (row.Cells["Tipo"].Value?.ToString() == "Gasto")
                {
                    var cell = row.Cells["Detalle"] as DataGridViewButtonCell;
                    if (cell != null)
                    {
                        cell.Value = "";
                        cell.ReadOnly = true;
                        cell.Style.BackColor = dgvBalance.DefaultCellStyle.BackColor;
                        cell.FlatStyle = FlatStyle.Flat;
                    }
                }
            }

            // Totales y resultado SIEMPRE calculados con ambos
            decimal totalVentas = ventasBalance.Sum(v => v.Monto);
            decimal totalGastos = gastosBalance.Sum(g => -g.Monto);
            decimal resultado = totalVentas - totalGastos;

            lblTotalVentas.Text = $"Total Ventas: $ {totalVentas:N2}";
            lblTotalGastos.Text = $"Total Gastos: $ {totalGastos:N2}";
            lblResultado.Text = $"Resultado: $ {resultado:N2}";
            lblResultado.ForeColor = resultado >= 0 ? Color.Green : Color.Red;
        }

        // Colorea las filas según el tipo
        private void dgvBalance_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var tipo = dgvBalance.Rows[e.RowIndex].Cells["Tipo"].Value?.ToString();
            if (tipo == "Venta")
                dgvBalance.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
            else if (tipo == "Gasto")
                dgvBalance.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
        }

        // Botón "Ayer"
        private void btnAyer_Click(object sender, EventArgs e)
        {
            var ayer = DateTime.Today.AddDays(-1);
            dtpDesde.Value = ayer;
            dtpHasta.Value = ayer;
            CargarBalance();
        }

        // Botón "Hoy"
        private void btnHoy_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            CargarBalance();
        }

        // Botón "Semana"
        private void btnSemana_Click(object sender, EventArgs e)
        {
            var inicioSemana = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            var finSemana = inicioSemana.AddDays(6);
            dtpDesde.Value = inicioSemana;
            dtpHasta.Value = finSemana;
            CargarBalance();
        }

        // Botón "Mes"
        private void btnMes_Click(object sender, EventArgs e)
        {
            var inicioMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);
            dtpDesde.Value = inicioMes;
            dtpHasta.Value = finMes;
            CargarBalance();
        }

        // Botón "Año"
        private void btnAnio_Click(object sender, EventArgs e)
        {
            var inicioAnio = new DateTime(DateTime.Today.Year, 1, 1);
            var finAnio = new DateTime(DateTime.Today.Year, 12, 31);
            dtpDesde.Value = inicioAnio;
            dtpHasta.Value = finAnio;
            CargarBalance();
        }

        // Botón "Filtrar" manual
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarBalance();
        }

        // Filtrado automático al cambiar fechas
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarBalance();
        }

        // Mostrar detalle de venta al hacer click en el botón "Detalle"
        private void dgvBalance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBalance.Columns[e.ColumnIndex].Name == "Detalle")
            {
                var tipo = dgvBalance.Rows[e.RowIndex].Cells["Tipo"].Value?.ToString();
                if (tipo == "Venta")
                {
                    int ventaId = Convert.ToInt32(dgvBalance.Rows[e.RowIndex].Cells["id"].Value);
                    var venta = _context.Ventas
                        .Include(v => v.detalles)
                        .ThenInclude(d => d.producto)
                        .FirstOrDefault(v => v.id == ventaId);

                    if (venta != null)
                    {
                        var frmDetalle = new ControlVentas.Views.Ventas.DetalleDeVentaView(venta);
                        frmDetalle.ShowDialog();
                    }
                }
            }
        }

        private void dgvBalance_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvBalance.Columns[e.ColumnIndex].Name == "Detalle" && e.RowIndex >= 0)
            {
                var tipo = dgvBalance.Rows[e.RowIndex].Cells["Tipo"].Value?.ToString();
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                if (tipo == "Venta")
                {
                    using (var brush = new SolidBrush(Color.FromArgb(0, 192, 0)))
                        e.Graphics.FillRectangle(brush, e.CellBounds);

                    using (var pen = new Pen(Color.DarkGreen, 2))
                        e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);

                    var icon = Properties.Resources.detail32;
                    int iconX = e.CellBounds.Left + 6;
                    int iconY = e.CellBounds.Top + (e.CellBounds.Height - icon.Height) / 2;
                    e.Graphics.DrawImage(icon, new Rectangle(iconX, iconY, icon.Width, icon.Height));

                    var textRect = new Rectangle(iconX + icon.Width + 4, e.CellBounds.Top, e.CellBounds.Width - icon.Width - 10, e.CellBounds.Height);
                    TextRenderer.DrawText(
                        e.Graphics,
                        "Ver Detalle",
                        new Font(dgvBalance.Font, FontStyle.Bold),
                        textRect,
                        Color.White,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Left
                    );
                }
                else
                {
                    using (var brush = new SolidBrush(dgvBalance.DefaultCellStyle.BackColor))
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                }
                e.Handled = true;
            }
        }

        private void dgvBalance_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvBalance.Columns[e.ColumnIndex].Name == "Detalle")
            {
                var tipo = dgvBalance.Rows[e.RowIndex].Cells["Tipo"].Value?.ToString();
                if (tipo == "Venta")
                    toolTipDetalle.SetToolTip(dgvBalance, "Ver detalle de la venta");
                else
                    toolTipDetalle.SetToolTip(dgvBalance, "");
            }
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            filtroActual = FiltroBalance.SoloVentas;
            CargarBalance();
        }

        private void btnVerGastos_Click(object sender, EventArgs e)
        {
            filtroActual = FiltroBalance.SoloGastos;
            CargarBalance();
        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            filtroActual = FiltroBalance.Todos;
            CargarBalance();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
                sfd.FileName = $"Balance_{dtpDesde.Value:yyyyMMdd}_{dtpHasta.Value:yyyyMMdd}.xlsx";
                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                var desde = dtpDesde.Value.Date;
                var hasta = dtpHasta.Value.Date;

                var ventas = _context.Ventas
                    .Where(v => v.fecha.Date >= desde && v.fecha.Date <= hasta && !v.eliminado)
                    .Include(v => v.detalles)
                    .ThenInclude(d => d.producto)
                    .ToList();

                var gastos = _context.Gastos
                    .Where(g => g.fecha.Date >= desde && g.fecha.Date <= hasta && !g.eliminado)
                    .ToList();

                using (var wb = new ClosedXML.Excel.XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("Balance");

                    // Encabezados
                    ws.Cell(1, 1).Value = "Fecha";
                    ws.Cell(1, 2).Value = "Tipo";
                    ws.Cell(1, 3).Value = "Descripción";
                    ws.Cell(1, 4).Value = "Monto";
                    ws.Range(1, 1, 1, 4).Style.Font.Bold = true;

                    int row = 2;

                    // Ventas (verde)
                    foreach (var v in ventas.OrderBy(x => x.fecha))
                    {
                        ws.Cell(row, 1).Value = v.fecha.ToShortDateString();
                        ws.Cell(row, 2).Value = "Venta";
                        ws.Cell(row, 3).Value = $"Venta #{v.id}";
                        ws.Cell(row, 4).Value = v.total;
                        ws.Range(row, 1, row, 4).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightGreen;
                        row++;
                    }

                    //estilos para encabezado 
                    ws.Range(1, 1, 1, 4).Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                    ws.Range(1, 1, 1, 4).Style.Alignment.Vertical = ClosedXML.Excel.XLAlignmentVerticalValues.Center;
                    ws.Range(1, 1, 1, 4).Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                    ws.Range(1, 1, 1, 4).Style.Border.InsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                    ws.Range(1, 1, 1, 4).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightGray;
                    ws.Range(1, 1, 1, 4).Style.Font.FontColor = ClosedXML.Excel.XLColor.Black;
                    ws.Range(1, 1, 1, 4).Style.Font.FontSize = 12;
                    ws.Range(1, 1, 1, 4).Style.Font.Bold = true;
                    ws.Range(1, 1, 1, 4).Style.Alignment.WrapText = true;

                    // Gastos (rojo)
                    foreach (var g in gastos.OrderBy(x => x.fecha))
                    {
                        ws.Cell(row, 1).Value = g.fecha.ToShortDateString();
                        ws.Cell(row, 2).Value = "Gasto";
                        ws.Cell(row, 3).Value = g.descripcion;
                        ws.Cell(row, 4).Value = -g.monto;
                        ws.Range(row, 1, row, 4).Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightCoral;
                        row++;
                    }

                    // Totales
                    decimal totalVentas = ventas.Sum(v => v.total);
                    decimal totalGastos = gastos.Sum(g => g.monto);
                    decimal resultado = totalVentas - totalGastos;

                    ws.Cell(row + 1, 3).Value = "Total Ventas:";
                    ws.Cell(row + 1, 4).Value = totalVentas;
                    ws.Cell(row + 2, 3).Value = "Total Gastos:";
                    ws.Cell(row + 2, 4).Value = totalGastos;
                    ws.Cell(row + 3, 3).Value = "Resultado:";
                    ws.Cell(row + 3, 4).Value = resultado;
                    ws.Range(row + 1, 3, row + 3, 4).Style.Font.Bold = true;

                    ws.Columns().AdjustToContents();

                    wb.SaveAs(sfd.FileName);
                }

                MessageBox.Show("Reporte generado correctamente.", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarBalance();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            paginaActual++;
            CargarBalance();
        }
    }
}

