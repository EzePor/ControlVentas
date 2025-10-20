using ControlVentas.Data;
using ControlVentas.Views.Datos;
using ControlVentas.Views.Detalles;
using ControlVentas.Views.Gastos;
using ControlVentas.Views.Productos;
using ControlVentas.Views.Ventas;
using FontAwesome.Sharp;



namespace ControlVentas
{

    public partial class MenuPrincipalView : Form
    {
        private readonly ControlVentaContext _context = new ControlVentaContext();

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MenuPrincipalView()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 80);
            panelMenu.Controls.Add(leftBorderBtn);

            // Mostrar el menú principal
            this.Load += MenuPrincipalView_Load;


        }

        private void MenuPrincipalView_Load(object? sender, EventArgs e)
        {
            // Abrir el formulario de iniciar sesión al iniciar

        }


        //Estructura de colores
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(10, 209, 241);
            public static Color color7 = Color.FromArgb(241, 133, 10);
            public static Color color8 = Color.FromArgb(10, 241, 133);
        }

        // Métodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                // Desactivar botón
                DisableButton();

                // Botón
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(64, 64, 64);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Limpiar controles anteriores en el panel (opcional)
            panelDesktop.Controls.Clear();

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTituloChildForm.Text = childForm.Text;
        }

        private void iconButtonClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            labelTituloChildForm.Text = "Clientes";
            // OpenChildForm(new VentaDetalle());
        }

        private void iconButtonProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            labelTituloChildForm.Text = "Productos";
            OpenChildForm(new ProductosView(_context));
        }

        private void iconButtonImpresiones_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            labelTituloChildForm.Text = "Impresiones";
            // OpenChildForm(new ImpresionesView());
        }

        private void iconButtonModoPago_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            labelTituloChildForm.Text = "Modos de Pago";
            // OpenChildForm(new ModosPagosView());
        }

        private void iconButtonCrearPedido_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            labelTituloChildForm.Text = "Crear Pedido";
            // OpenChildForm(new CrearPedidosView());
        }

        private void iconButtonPedidosFiltrados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            labelTituloChildForm.Text = "Pedidos Filtrados";
            // OpenChildForm(new PedidosFiltradosView());
        }

        private void iconButtonResumenPedidos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            labelTituloChildForm.Text = "Resumen de Pedidos";
            // OpenChildForm(newProductosViews());
        }

        private void iconButtonPedidosCompletados_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            labelTituloChildForm.Text = "Pedidos Completados";
            //  OpenChildForm(new PedidosCompletadosView());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.DarkOrange;
            labelTituloChildForm.Text = "Inicio";
            // OpenChildForm(new InicioView());
        }

        private void btnCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonVentaDetalle_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            labelTituloChildForm.Text = "Venta";
            OpenChildForm(new VentaDetalleView(new ControlVentaContext()));
        }

        private void btnResumenVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            labelTituloChildForm.Text = "Resúmenes de Venta";
            OpenChildForm(new ResumenVentasView(new ControlVentaContext()));
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            labelTituloChildForm.Text = "Resúmenes de Gastos";
            OpenChildForm(new ResumenGastosView(new ControlVentaContext()));
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            labelTituloChildForm.Text = "Balance";
            OpenChildForm(new BalanceView(new ControlVentaContext()));
        }

        private void btnEstadisticasVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            labelTituloChildForm.Text = "Estadísticas de Ventas";
            OpenChildForm(new EstadisticasVentasView(new ControlVentaContext()));
        }

        private void btnDatosPagos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            labelTituloChildForm.Text = "Datos de Pagos";
            OpenChildForm(new DatosFormaPagoView(new ControlVentaContext()));
        }

        private void btnResumenPorDia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            labelTituloChildForm.Text = "Ventas por Día";
            OpenChildForm(new VentasPorDiaView(new ControlVentaContext()));
        }
    }
}
