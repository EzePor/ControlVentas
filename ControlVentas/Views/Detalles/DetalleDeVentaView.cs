using ControlVentas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.Views.Detalles
{
    public partial class DetalleDeVentaView : Form
    {
        private readonly Venta _venta;

        public DetalleDeVentaView(Venta venta)
        {
            InitializeComponent();
            _venta = venta;
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            lblFecha.Text = $"Fecha: {_venta.fecha:dd/MM/yyyy}";
            lblTotal.Text = $"Total: $ {_venta.total:N2}";

            dgvDetalle.Columns.Clear();
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.Columns.Add("Producto", "Producto");
            dgvDetalle.Columns.Add("Cantidad", "Cantidad");
            dgvDetalle.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvDetalle.Columns.Add("Subtotal", "Subtotal");

            foreach (var d in _venta.detalles)
            {
                dgvDetalle.Rows.Add(
                    d.producto?.nombre ?? "-",
                    d.cantidad,
                    d.precioUnitario.ToString("N2"),
                    (d.cantidad * d.precioUnitario).ToString("N2")
                );
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

