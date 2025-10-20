using ControlVentas.Data;
using ControlVentas.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlVentas.Views.Ventas
{
    public partial class DatosFormaPagoView : Form
    {
        private readonly ControlVentaContext _context;

        // Constructor usado por el diseñador
        public DatosFormaPagoView()
        {
            InitializeComponent();
            this.Load += DatosFormaPagoView_Load_DesignerCtor;
        }

        // Constructor que se usará en ejecución (recibe el contexto)
        public DatosFormaPagoView(ControlVentaContext context) : this()
        {
            _context = context ?? new ControlVentaContext();
            this.Load -= DatosFormaPagoView_Load_DesignerCtor;
            this.Load += DatosFormaPagoView_Load;
        }

        // Load handler para el caso del diseñador (no tiene contexto)
        private void DatosFormaPagoView_Load_DesignerCtor(object? sender, EventArgs e)
        {
            AttachButtonHandlers();
            EnsureSummaryControls();
        }

        // Load handler con contexto
        private void DatosFormaPagoView_Load(object? sender, EventArgs e)
        {
            AttachButtonHandlers();
            EnsureSummaryControls();
            CargarResumenPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
        }

        private void AttachButtonHandlers()
        {
            btnFiltrar.Click -= BtnFiltrar_Click;
            btnHoy.Click -= BtnHoy_Click;
            btnAyer.Click -= BtnAyer_Click;
            btnSemana.Click -= BtnSemana_Click;
            btnMes.Click -= BtnMes_Click;
            btnAnio.Click -= BtnAnio_Click;

            btnFiltrar.Click += BtnFiltrar_Click;
            btnHoy.Click += BtnHoy_Click;
            btnAyer.Click += BtnAyer_Click;
            btnSemana.Click += BtnSemana_Click;
            btnMes.Click += BtnMes_Click;
            btnAnio.Click += BtnAnio_Click;
        }

        private void EnsureSummaryControls()
        {
            // Crea labels/panel si no existen en el Designer (evita duplicados)
            if (Controls.Find("lblTotalPeriodo", true).FirstOrDefault() == null)
            {
                var lblTotalPeriodo = new Label
                {
                    Name = "lblTotalPeriodo",
                    AutoSize = true,
                    ForeColor = Color.White,
                    Font = new Font("Bahnschrift SemiCondensed", 11F, FontStyle.Bold),
                    Location = new Point(dtpHasta.Right + 16, dtpHasta.Top + 4)
                };
                Controls.Add(lblTotalPeriodo);
            }

            if (Controls.Find("lblCantidadVentas", true).FirstOrDefault() == null)
            {
                var lblCantidadVentas = new Label
                {
                    Name = "lblCantidadVentas",
                    AutoSize = true,
                    ForeColor = Color.White,
                    Font = new Font("Bahnschrift SemiCondensed", 11F, FontStyle.Bold),
                    Location = new Point(dtpHasta.Right + 16, dtpHasta.Top + 28)
                };
                Controls.Add(lblCantidadVentas);
            }

            if (Controls.Find("flpFormasPago", true).FirstOrDefault() == null)
            {
                var flpX = dgvVentas.Right + 16;
                var flpY = dgvVentas.Top;
                var flpWidth = Math.Max(260, this.ClientSize.Width - flpX - 24);
                var flpHeight = dgvVentas.Height;

                var flpFormasPago = new FlowLayoutPanel
                {
                    Name = "flpFormasPago",
                    Location = new Point(flpX, flpY),
                    Size = new Size(flpWidth, flpHeight),
                    AutoScroll = true,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    BackColor = Color.FromArgb(48, 48, 48)
                };
                Controls.Add(flpFormasPago);

                this.Resize += (s, e) =>
                {
                    var flp = Controls.Find("flpFormasPago", true).FirstOrDefault() as FlowLayoutPanel;
                    if (flp != null)
                    {
                        var newX = dgvVentas.Right + 16;
                        var newW = Math.Max(260, this.ClientSize.Width - newX - 24);
                        flp.Location = new Point(newX, dgvVentas.Top);
                        flp.Size = new Size(newW, dgvVentas.Height);
                    }
                };
            }
        }

        private void BtnFiltrar_Click(object? sender, EventArgs e)
        {
            CargarResumenPorRango(dtpDesde.Value.Date, dtpHasta.Value.Date);
        }

        private void BtnHoy_Click(object? sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            CargarResumenPorRango(DateTime.Today, DateTime.Today);
        }

        private void BtnAyer_Click(object? sender, EventArgs e)
        {
            var ayer = DateTime.Today.AddDays(-1);
            dtpDesde.Value = ayer;
            dtpHasta.Value = ayer;
            CargarResumenPorRango(ayer, ayer);
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
            if (_context == null) return;

            try
            {
                var ventas = _context.Ventas
                    .Where(v => v.fecha.Date >= desde && v.fecha.Date <= hasta && !v.eliminado)
                    .OrderByDescending(v => v.fecha)
                    .Include(v => v.detalles)
                    .ThenInclude(d => d.producto)
                    .ToList();

                // ---- 1) Grilla: mostrar detalle de ventas (similar a ResumenVentasView) ----
                var detalleParaGrilla = ventas
                    .Select(v => new
                    {
                        v.id,
                        Fecha = v.fecha.ToShortDateString(),
                        Total = v.total,
                        FormaDePago = v.detalles.FirstOrDefault()?.formaPagoEnum.ToString() ?? "",
                        Productos = string.Join(", ", v.detalles.Select(d => $"{d.cantidad}x {d.producto?.nombre ?? "-"}"))
                    })
                    .ToList();

                dgvVentas.DataSource = detalleParaGrilla;
                if (dgvVentas.Columns.Contains("FormaDePago"))
                    dgvVentas.Columns["FormaDePago"].HeaderText = "Forma de Pago";
                if (dgvVentas.Columns.Contains("Productos"))
                    dgvVentas.Columns["Productos"].HeaderText = "Productos";
                if (dgvVentas.Columns.Contains("Total"))
                {
                    dgvVentas.Columns["Total"].HeaderText = "Total";
                    dgvVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
                }

                // Actualizar labels resumen rápido
                var lblTotalPeriodo = Controls.Find("lblTotalPeriodo", true).FirstOrDefault() as Label;
                var lblCantidadVentas = Controls.Find("lblCantidadVentas", true).FirstOrDefault() as Label;
                if (lblTotalPeriodo != null) lblTotalPeriodo.Text = $"Total período: $ {ventas.Sum(v => v.total):N2}";
                if (lblCantidadVentas != null) lblCantidadVentas.Text = $"Cantidad ventas: {ventas.Count}";

                // ---- 2) FlowLayoutPanel: resumen agregado por forma de pago (cantidad y total) ----
                var agrupado = ventas
                    .GroupBy(v => v.detalles.FirstOrDefault()?.formaPagoEnum)
                    .Select(g => new
                    {
                        Forma = g.Key.HasValue ? g.Key.Value.ToString() : "Sin forma",
                        CantidadVentas = g.Count(),
                        TotalFacturado = g.Sum(v => v.total)
                    })
                    .ToList();

                // Asegurar mostrar todas las formas (incluir 0)
                var todasFormas = Enum.GetValues(typeof(FormaPagoEnum)).Cast<FormaPagoEnum>().Select(f => f.ToString()).ToList();
                var faltantes = todasFormas.Except(agrupado.Select(a => a.Forma))
                    .Select(f => new { Forma = f, CantidadVentas = 0, TotalFacturado = 0m });
                var dataAgregado = agrupado.Concat(faltantes).OrderByDescending(x => x.TotalFacturado).ToList();

                var flp = Controls.Find("flpFormasPago", true).FirstOrDefault() as FlowLayoutPanel;
                if (flp != null)
                {
                    flp.SuspendLayout();
                    flp.Controls.Clear();

                    foreach (var fila in dataAgregado)
                    {
                        var card = CreateFormaPanel(fila.Forma, fila.CantidadVentas, fila.TotalFacturado, flp.ClientSize.Width);
                        flp.Controls.Add(card);
                    }

                    flp.ResumeLayout();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar resumen por forma de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateFormaPanel(string forma, int cantidad, decimal total, int flpWidth)
        {
            // colores y estilos
            Color accent = GetAccentColorForForma(forma);
            Color bg = cantidad == 0 ? Color.FromArgb(45, 45, 45) : Color.FromArgb(30, 30, 30);
            Color textColor = cantidad == 0 ? Color.LightGray : Color.White;

            var panel = new Panel
            {
                Width = Math.Max(240, flpWidth - 25),
                Height = 64,
                Margin = new Padding(6),
                Padding = new Padding(8),
                BackColor = bg,
                Cursor = Cursors.Hand
            };

            // barra de color a la izquierda
            var accentBar = new Panel
            {
                Width = 6,
                Dock = DockStyle.Left,
                BackColor = accent
            };
            panel.Controls.Add(accentBar);

            // contenedor de texto
            var container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                Padding = new Padding(8, 4, 8, 4)
            };
            panel.Controls.Add(container);

            // título (forma)
            var lblTitle = new Label
            {
                AutoSize = false,
                Height = 22,
                Dock = DockStyle.Top,
                Text = forma,
                ForeColor = textColor,
                Font = new Font("Bahnschrift SemiCondensed", 11F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            };
            container.Controls.Add(lblTitle);

            // subtítulo (cantidad y total)
            var lblSub = new Label
            {
                AutoSize = false,
                Height = 20,
                Dock = DockStyle.Bottom,
                Text = $"{cantidad} ventas  —  $ {total:N2}",
                ForeColor = Color.LightGray,
                Font = new Font("Bahnschrift SemiCondensed", 10F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft
            };
            container.Controls.Add(lblSub);

            // efecto hover: aclarar fondo al entrar
            var originalBack = panel.BackColor;
            panel.MouseEnter += (s, e) =>
            {
                panel.BackColor = ControlPaint.Light(originalBack, 0.08f);
            };
            panel.MouseLeave += (s, e) =>
            {
                panel.BackColor = originalBack;
            };

            // también propagar eventos a controles hijos para que el hover funcione al pasar por los labels
            foreach (Control c in panel.Controls)
            {
                c.MouseEnter += (s, e) => panel.BackColor = ControlPaint.Light(originalBack, 0.08f);
                c.MouseLeave += (s, e) => panel.BackColor = originalBack;
            }

            // opcional: al hacer click puedes filtrar la grilla por esa forma de pago
            panel.Click += (s, e) =>
            {
                // ejemplo: setear dtpDesde/dtpHasta o aplicar filtro; aquí simplemente mostramos la forma
                // MessageBox.Show($"Filtrar por: {forma}");
            };

            return panel;
        }

        private Color GetAccentColorForForma(string forma)
        {
            // Mapea nombres comunes de formas a colores. Adapta a tus nombres reales del enum.
            var f = (forma ?? "").ToLowerInvariant();
            if (f.Contains("efectivo")) return Color.FromArgb(40, 167, 69);        // verde
            if (f.Contains("transfer")) return Color.FromArgb(23, 162, 184);      // cyan
            if (f.Contains("debito")) return Color.FromArgb(0, 123, 255);        // azul
            if (f.Contains("credito")) return Color.FromArgb(102, 16, 242);      // morado
            if (f.Contains("mercado") || f.Contains("mp")) return Color.FromArgb(255, 193, 7); // amarillo
            if (f.Contains("ticket") || f.Contains("vale")) return Color.FromArgb(255, 123, 0); // naranja
            // default
            return Color.FromArgb(70, 130, 180); // steelblue
        }
    }
}
