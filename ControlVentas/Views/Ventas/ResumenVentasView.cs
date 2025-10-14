using ControlVentas.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.Views.Ventas
{
    public partial class ResumenVentasView : Form
    {

        private readonly ControlVentaContext _context;
       
        public ResumenVentasView(ControlVentaContext context)
        {
            InitializeComponent();
            _context = context;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            CargarVentasPorRango(DateTime.Today, DateTime.Today);
            dgvVentas.CellPainting += dgvVentas_CellPainting;
        }


        private void btnHoy_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            CargarVentasPorRango(DateTime.Today, DateTime.Today);
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            var inicioSemana = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            var finSemana = inicioSemana.AddDays(6);
            dtpDesde.Value = inicioSemana;
            dtpHasta.Value = finSemana;
            CargarVentasPorRango(inicioSemana, finSemana);
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            var inicioMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);
            dtpDesde.Value = inicioMes;
            dtpHasta.Value = finMes;
            CargarVentasPorRango(inicioMes, finMes);
        }

        private void btnAnio_Click(object sender, EventArgs e)
        {
            var inicioAnio = new DateTime(DateTime.Today.Year, 1, 1);
            var finAnio = new DateTime(DateTime.Today.Year, 12, 31);
            dtpDesde.Value = inicioAnio;
            dtpHasta.Value = finAnio;
            CargarVentasPorRango(inicioAnio, finAnio);
        }

        private void CargarVentasPorRango(DateTime desde, DateTime hasta)
        {
            var ventas = _context.Ventas
                .Where(v => v.fecha.Date >= desde && v.fecha.Date <= hasta && !v.eliminado)
                .OrderByDescending(v => v.fecha)
                .Include(v => v.detalles)
                .ToList();

            dgvVentas.DataSource = ventas
                .Select(v => new
                {
                    v.id,
                    Fecha = v.fecha.ToShortDateString(),
                    Total = v.total,
                    FormaDePago = v.detalles.FirstOrDefault()?.formaPagoEnum.ToString() ?? ""
                })
                .ToList();

            lblTotalPeriodo.Text = $"Total del período: $ {ventas.Sum(v => v.total):N2}";
            lblCantidadVentas.Text = $"Cantidad de ventas: {ventas.Count}";

            // Cambia el nombre del encabezado de la columna si existe
            if (dgvVentas.Columns.Contains("FormaDePago"))
            {
                dgvVentas.Columns["FormaDePago"].HeaderText = "Forma de Pago";
            }

            if (!dgvVentas.Columns.Contains("Detalle"))
            {
                var btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "Detalle";
                btnCol.HeaderText = "Ver Detalle";
                btnCol.Text = "Detalle";
                btnCol.UseColumnTextForButtonValue = true;
                dgvVentas.Columns.Add(btnCol);
            }
            if (!dgvVentas.Columns.Contains("Eliminar"))
            {
                var btnEliminar = new DataGridViewButtonColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.UseColumnTextForButtonValue = true;
                dgvVentas.Columns.Add(btnEliminar);
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null) return;
            int ventaId = Convert.ToInt32(dgvVentas.CurrentRow.Cells["id"].Value);
            var venta = _context.Ventas
                .Where(v => v.id == ventaId)
                .FirstOrDefault();

            if (venta != null)
            {
                var detalles = venta.detalles.Select(d => new
                {
                    Producto = d.producto.nombre,
                    Cantidad = d.cantidad,
                    PrecioUnitario = d.precioUnitario,
                    Subtotal = d.cantidad * d.precioUnitario,
                    FormaPago = d.formaPagoEnum.ToString()
                }).ToList();

                // Muestra los detalles en un MessageBox o en otro DataGridView
                string mensaje = string.Join(Environment.NewLine, detalles.Select(d =>
                    $"{d.Producto} - {d.Cantidad} x {d.PrecioUnitario:C2} = {d.Subtotal:C2} ({d.FormaPago})"));
                MessageBox.Show(mensaje, "Detalle de la venta");
            }
        }

        private void btnAyer_Click(object sender, EventArgs e)
        {
            // Filtro para ayer
            var ayer = DateTime.Today.AddDays(-1);
            dtpDesde.Value = ayer;
            dtpHasta.Value = ayer;
            CargarVentasPorRango(ayer, ayer);

        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvVentas.Columns[e.ColumnIndex].Name == "Detalle")
            {
                int ventaId = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["id"].Value);
                var venta = _context.Ventas
                    .Include(v => v.detalles)
                    .ThenInclude(d => d.producto)
                    .FirstOrDefault(v => v.id == ventaId);

                if (venta != null)
                {
                    // Aquí puedes abrir un formulario modal con el detalle
                    var frmDetalle = new DetalleDeVentaView(venta);
                    frmDetalle.ShowDialog();
                }
            }

            if (e.RowIndex >= 0 && dgvVentas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int ventaId = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["id"].Value);
                var venta = _context.Ventas.FirstOrDefault(v => v.id == ventaId);
                if (venta != null)
                {
                    var confirm = MessageBox.Show("¿Seguro que deseas eliminar esta venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        venta.eliminado = true;
                        _context.SaveChanges();
                        CargarVentasPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
                    }
                }
            }
        }

        private void dgvVentas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Botón "Detalle"
                if (dgvVentas.Columns[e.ColumnIndex].Name == "Detalle")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Fondo verde
                    using (var brush = new SolidBrush(Color.FromArgb(0, 192, 0)))
                        e.Graphics.FillRectangle(brush, e.CellBounds);

                    // Borde verde oscuro
                    using (var pen = new Pen(Color.DarkGreen, 2))
                        e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);

                    // Icono delante del texto
                    var icon = Properties.Resources.detail32;
                    int iconX = e.CellBounds.Left + 6;
                    int iconY = e.CellBounds.Top + (e.CellBounds.Height - icon.Height) / 2;
                    e.Graphics.DrawImage(icon, new Rectangle(iconX, iconY, icon.Width, icon.Height));

                    // Texto "Ver Detalle"
                    var textRect = new Rectangle(iconX + icon.Width + 4, e.CellBounds.Top, e.CellBounds.Width - icon.Width - 10, e.CellBounds.Height);
                    TextRenderer.DrawText(
                        e.Graphics,
                        "Ver Detalle",
                        new Font(dgvVentas.Font, FontStyle.Bold),
                        textRect,
                        Color.White,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Left
                    );

                    e.Handled = true;
                }
                // Botón "Eliminar"
                else if (dgvVentas.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Fondo rojo
                    using (var brush = new SolidBrush(Color.FromArgb(220, 50, 50)))
                        e.Graphics.FillRectangle(brush, e.CellBounds);

                    // Borde rojo oscuro
                    using (var pen = new Pen(Color.DarkRed, 2))
                        e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);

                    // Icono delante del texto
                    var icon = Properties.Resources.eliminar32;
                    int iconX = e.CellBounds.Left + 6;
                    int iconY = e.CellBounds.Top + (e.CellBounds.Height - icon.Height) / 2;
                    e.Graphics.DrawImage(icon, new Rectangle(iconX, iconY, icon.Width, icon.Height));

                    // Texto "Eliminar"
                    var textRect = new Rectangle(iconX + icon.Width + 4, e.CellBounds.Top, e.CellBounds.Width - icon.Width - 10, e.CellBounds.Height);
                    TextRenderer.DrawText(
                        e.Graphics,
                        "Eliminar",
                        new Font(dgvVentas.Font, FontStyle.Bold),
                        textRect,
                        Color.White,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Left
                    );

                    e.Handled = true;
                }
            }
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            CargarVentasPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarVentasPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;

            var ventas = _context.Ventas
                .Where(v => v.fecha.Date >= desde && v.fecha.Date <= hasta && !v.eliminado)
                .Include(v => v.detalles)
                .ThenInclude(d => d.producto)
                .ToList();

            using (var workbook = new ClosedXML.Excel.XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Ventas");

                // Encabezados
                worksheet.Cell(1, 1).Value = "ID";
                worksheet.Cell(1, 2).Value = "Fecha";
                worksheet.Cell(1, 3).Value = "Total";
                worksheet.Cell(1, 4).Value = "Forma de Pago";
                worksheet.Cell(1, 5).Value = "Productos";
                // Formato de encabezados
                var headerRange = worksheet.Range(1, 1, 1, 5);
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightGray;
                headerRange.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                headerRange.Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                headerRange.Style.Border.TopBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                headerRange.Style.Border.LeftBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                headerRange.Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                
                // Datoss
                int row = 2;
                foreach (var v in ventas)
                {
                    worksheet.Cell(row, 1).Value = v.id;
                    worksheet.Cell(row, 2).Value = v.fecha.ToShortDateString();
                    worksheet.Cell(row, 3).Value = v.total;
                    worksheet.Cell(row, 4).Value = v.detalles.FirstOrDefault()?.formaPagoEnum.ToString() ?? "";
                    worksheet.Cell(row, 5).Value = string.Join(", ", v.detalles.Select(d => $"{d.cantidad}x {d.producto?.nombre ?? "-"}"));
                    row++;
                }

                worksheet.Columns().AdjustToContents();

                // Guardar archivo
                var sfd = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = $"Ventas_{desde:yyyyMMdd}_{hasta:yyyyMMdd}.xlsx"
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Reporte exportado correctamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       
    }
}
