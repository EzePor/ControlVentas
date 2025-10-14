using ControlVentas.Data;
using ControlVentas.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ControlVentas.Views.Gastos
{
    public partial class ResumenGastosView : Form
    {
        private readonly ControlVentaContext _context;
     

        public ResumenGastosView(ControlVentaContext context)
        {
            InitializeComponent();
            _context = context;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            CargarGastosPorRango(DateTime.Today, DateTime.Today);
            dgvGastos.CellClick += dgvGastos_CellClick;
            dgvGastos.CellPainting += dgvGastos_CellPainting;
        }

        private void CargarGastosPorRango(DateTime desde, DateTime hasta)
        {
            var gastos = _context.Gastos
                .Where(g => g.fecha.Date >= desde && g.fecha.Date <= hasta && !g.eliminado)
                .OrderByDescending(g => g.fecha)
                .ToList();

            dgvGastos.DataSource = gastos
                .Select(g => new
                {
                    g.id,
                    Fecha = g.fecha.ToShortDateString(),
                    Descripción = g.descripcion, // Cambia el nombre aquí
                    Monto = g.monto
                })
                .ToList();

            // Si necesitas asegurarte del encabezado por código:
            if (dgvGastos.Columns.Contains("Descripción"))
                dgvGastos.Columns["Descripción"].HeaderText = "Descripción";

            lblTotalGastos.Text = $"Total de gastos: $ {gastos.Sum(g => g.monto):N2}";

            // Agregar columna de edición si no existe
            if (!dgvGastos.Columns.Contains("Editar"))
            {
                var btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "Editar";
                btnCol.HeaderText = "Editar";
                btnCol.Text = "Editar";
                btnCol.UseColumnTextForButtonValue = true;
                dgvGastos.Columns.Add(btnCol);
            }
            // agregar columna de eliminación si no existe
            if (!dgvGastos.Columns.Contains("Eliminar"))
            {
                var btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "Eliminar";
                btnCol.HeaderText = "Eliminar";
                btnCol.Text = "Eliminar";
                btnCol.UseColumnTextForButtonValue = true;
                dgvGastos.Columns.Add(btnCol);
            }
        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            var frmGasto = new AgregarGastoView(_context);
            if (frmGasto.ShowDialog() == DialogResult.OK)
            {
                CargarGastosPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
            }
        }

        private void dgvGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvGastos.Columns[e.ColumnIndex].Name == "Editar")
            {
                int gastoId = Convert.ToInt32(dgvGastos.Rows[e.RowIndex].Cells["id"].Value);
                var gasto = _context.Gastos.FirstOrDefault(g => g.id == gastoId);
                if (gasto != null)
                {
                    var frmGasto = new AgregarGastoView(_context, gasto);
                    if (frmGasto.ShowDialog() == DialogResult.OK)
                    {
                        CargarGastosPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
                    }
                }
            }

            if (e.RowIndex >= 0 && dgvGastos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int gastoId = Convert.ToInt32(dgvGastos.Rows[e.RowIndex].Cells["id"].Value);
                var gasto = _context.Gastos.FirstOrDefault(g => g.id == gastoId);
                if (gasto != null)
                {
                    var confirm = MessageBox.Show("¿Seguro que deseas eliminar este gasto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        gasto.eliminado = true;
                        _context.SaveChanges();
                        CargarGastosPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
                    }
                }
            }
        }

        private void btnAgregarGasto_Click_1(object sender, EventArgs e)
        {
            // abrir formulario para agregar gasto
            var frmGasto = new AgregarGastoView(_context);
            if (frmGasto.ShowDialog() == DialogResult.OK)
            {
                CargarGastosPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
            }

        }

        private void btnAyer_Click_1(object sender, EventArgs e)
        {
            var ayer = DateTime.Today.AddDays(-1);
            dtpDesde.Value = ayer;
            dtpHasta.Value = ayer;
            CargarGastosPorRango(ayer, ayer);
        }

        private void btnHoy_Click_1(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            CargarGastosPorRango(DateTime.Today, DateTime.Today);
        }

        private void btnSemana_Click_1(object sender, EventArgs e)
        {
            var inicioSemana = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            var finSemana = inicioSemana.AddDays(6);
            dtpDesde.Value = inicioSemana;
            dtpHasta.Value = finSemana;
            CargarGastosPorRango(inicioSemana, finSemana);
        }

        private void btnMes_Click_1(object sender, EventArgs e)
        {
            var inicioMes = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);
            dtpDesde.Value = inicioMes;
            dtpHasta.Value = finMes;
            CargarGastosPorRango(inicioMes, finMes);
        }

        private void btnAnio_Click_1(object sender, EventArgs e)
        {
            var inicioAnio = new DateTime(DateTime.Today.Year, 1, 1);
            var finAnio = new DateTime(DateTime.Today.Year, 12, 31);
            dtpDesde.Value = inicioAnio;
            dtpHasta.Value = finAnio;
            CargarGastosPorRango(inicioAnio, finAnio);
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            CargarGastosPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
        }

        private void dgvGastos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                // Botón "Editar"
                if (dgvGastos.Columns[e.ColumnIndex].Name == "Editar")
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Fondo azul
                    using (var brush = new SolidBrush(Color.FromArgb(30, 144, 255))) // DodgerBlue
                        e.Graphics.FillRectangle(brush, e.CellBounds);

                    // Borde azul oscuro
                    using (var pen = new Pen(Color.MidnightBlue, 2))
                        e.Graphics.DrawRectangle(pen, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);

                    // Icono delante del texto
                    var icon = Properties.Resources.editar23;
                    int iconX = e.CellBounds.Left + 6;
                    int iconY = e.CellBounds.Top + (e.CellBounds.Height - icon.Height) / 2;
                    e.Graphics.DrawImage(icon, new Rectangle(iconX, iconY, icon.Width, icon.Height));

                    // Texto "Editar"
                    var textRect = new Rectangle(iconX + icon.Width + 4, e.CellBounds.Top, e.CellBounds.Width - icon.Width - 10, e.CellBounds.Height);
                    TextRenderer.DrawText(
                        e.Graphics,
                        "Editar",
                        new Font(dgvGastos.Font, FontStyle.Bold),
                        textRect,
                        Color.White,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Left
                    );

                    e.Handled = true;
                }
                // Botón "Eliminar"
                else if (dgvGastos.Columns[e.ColumnIndex].Name == "Eliminar")
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
                        new Font(dgvGastos.Font, FontStyle.Bold),
                        textRect,
                        Color.White,
                        TextFormatFlags.VerticalCenter | TextFormatFlags.Left
                    );

                    e.Handled = true;
                }
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            // debo generar un reporte con salida de excel con la librería ClosedXML de los gastos 
            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;
            var gastos = _context.Gastos
                .Where(g => g.fecha.Date >= desde && g.fecha.Date <= hasta && !g.eliminado)
                .OrderByDescending(g => g.fecha)
                .ToList();
            var saveFileDialog = new SaveFileDialog
                {
                Filter = "Archivos de Excel (*.xlsx)|*.xlsx",
                Title = "Guardar reporte de gastos",
                FileName = $"Reporte_Gastos_{desde:yyyyMMdd}_a_{hasta:yyyyMMdd}.xlsx"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new ClosedXML.Excel.XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Gastos");
                        // Encabezados
                        worksheet.Cell(1, 1).Value = "Fecha";
                        worksheet.Cell(1, 2).Value = "Descripción";
                        worksheet.Cell(1, 3).Value = "Monto";
                        // Formato de encabezados
                        var headerRange = worksheet.Range(1, 1, 1, 3);
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.LightGray;
                        headerRange.Style.Alignment.Horizontal = ClosedXML.Excel.XLAlignmentHorizontalValues.Center;
                        headerRange.Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                        headerRange.Style.Border.TopBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                        headerRange.Style.Border.LeftBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;
                        headerRange.Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Thin;

                        // Datos
                        for (int i = 0; i < gastos.Count; i++)
                        {
                            var gasto = gastos[i];
                            worksheet.Cell(i + 2, 1).Value = gasto.fecha.ToShortDateString();
                            worksheet.Cell(i + 2, 2).Value = gasto.descripcion;
                            worksheet.Cell(i + 2, 3).Value = gasto.monto;
                            worksheet.Cell(i + 2, 3).Style.NumberFormat.Format = "$ #,##0.00";
                        }
                        // Ajustar ancho de columnas
                        worksheet.Columns().AdjustToContents();
                        workbook.SaveAs(saveFileDialog.FileName);
                    }
                    MessageBox.Show("Reporte guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private bool ValidarGasto(Gasto gasto)
        {
            if (string.IsNullOrWhiteSpace(gasto.descripcion))
            {
                MessageBox.Show("La descripción es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (gasto.monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

       
    }
}
