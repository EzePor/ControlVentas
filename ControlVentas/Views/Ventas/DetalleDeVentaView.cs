using ControlVentas.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ControlVentas.Views.Ventas
{
    public partial class DetalleDeVentaView : Form
    {
        private readonly Venta _venta;

        public DetalleDeVentaView(Venta venta)
        {
            InitializeComponent();
            _venta = venta;
            CargarDatosVenta();
        }

        private void CargarDatosVenta()
        {
            lblFecha.Text = $"Fecha: {_venta.fecha:dd/MM/yyyy}";
            lblTotal.Text = $"Total: $ {_venta.total:N2}";
            lblFormaPago.Text = $"Forma de pago: {_venta.detalles.FirstOrDefault()?.formaPagoEnum.ToString() ?? "-"}";

            dgvDetalleVenta.Columns.Clear();
            dgvDetalleVenta.AutoGenerateColumns = false;
            dgvDetalleVenta.Columns.Add("Producto", "Producto");
            dgvDetalleVenta.Columns.Add("Cantidad", "Cantidad");
            dgvDetalleVenta.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvDetalleVenta.Columns.Add("Subtotal", "Subtotal");

            foreach (var d in _venta.detalles)
            {
                dgvDetalleVenta.Rows.Add(
                    d.producto?.nombre ?? "-",
                    d.cantidad,
                    d.precioUnitario.ToString("N2"),
                    (d.cantidad * d.precioUnitario).ToString("N2")
                );
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
