using ControlVentas.ExtensionMethods;
using ControlVentas.Models;
using ControlVentas.Utils;
using ControlVentas.Views.Productos;
using ControlVentas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlVentas.Data;
using ControlVentas.Enums;

namespace ControlVentas.Views.Productos
{
    public partial class ProductosView : Form
    {
        private readonly ControlVentaContext _context;

        BindingSource listaProductos = new BindingSource();

      

        public ProductosView(ControlVentaContext context)
        {
            InitializeComponent();
            _context = context;
            comboBoxRubro.DataSource = Enum.GetValues(typeof(RubroEnum));
            comboBoxRubro.SelectedIndex = -1; // Para que no seleccione ninguno al inicio
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando la lista de productos");
            var productos = _context.Productos.Where(p => !p.eliminado);

            // Ordenar según selección
            if (comboBoxOrden.SelectedItem?.ToString() == "Z-A")
                productos = productos.OrderByDescending(p => p.nombre);
            else
                productos = productos.OrderBy(p => p.nombre);

            var productosList = productos.ToList();
            foreach (var producto in productosList)
            {
                producto.precioformateado = producto.precio.ToString("F2");
            }
            listaProductos.DataSource = productosList;
            dataGridViewProductos.DataSource = listaProductos;
            dataGridViewProductos.OcultarColumnas(new string[] { "precioformateado", "eliminado" });

            dataGridViewProductos.Columns["id"].Visible = false;
            dataGridViewProductos.Columns["precioformateado"].Visible = false;
            dataGridViewProductos.Columns["eliminado"].Visible = false;
            dataGridViewProductos.Columns["activo"].Visible = false;

            ShowInActivity.Hide();
            PersonalizarColumnas();
        }

        // PERSONALIZAR TÍTULOS DE COLUMNAS
        private void PersonalizarColumnas()
        {
            if (dataGridViewProductos.Columns.Contains("id"))
                dataGridViewProductos.Columns["id"].HeaderText = "ID";
            // Personalizar encabezados de columnas
            if (dataGridViewProductos.Columns.Contains("nombre"))
                dataGridViewProductos.Columns["nombre"].HeaderText = "Nombre";
            if (dataGridViewProductos.Columns.Contains("Rubro"))
                dataGridViewProductos.Columns["Rubro"].HeaderText = "Rubro";
            if (dataGridViewProductos.Columns.Contains("precio"))
                dataGridViewProductos.Columns["precio"].HeaderText = "Precio";

            // Cambiar tipo de letra
            foreach (DataGridViewColumn column in dataGridViewProductos.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
                column.HeaderCell.Style.SelectionBackColor = Color.Orange; // Cambia a tu color preferido
            }
        }



        private void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarProductosView agregarEditarProductosView = new AgregarEditarProductosView(_context);
            agregarEditarProductosView.ShowDialog();
            CargarGrilla();
        }



        private void iconButtonEditar_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductos.Current;
            AgregarEditarProductosView agregarEditarProductosView = new AgregarEditarProductosView(producto);
            agregarEditarProductosView.ShowDialog();
            CargarGrilla();
        }

        private void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow == null) return;

            var prod = dataGridViewProductos.CurrentRow.DataBoundItem as Producto;
            if (prod == null) return;

            var confirm = MessageBox.Show(
                $"¿Seguro que querés eliminar '{prod.nombre}'?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _context.Productos.Remove(prod);
                _context.SaveChanges();
                CargarGrilla();
            }
        }

        private void textBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            BtnBuscarProducto.PerformClick();
        }

        private async void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscarProducto.Text.Trim().ToLower();
            var productos = await Task.Run(() => _context.Productos.Where(p => !p.eliminado).ToList());

            // Filtrar por nombre y rubro
            RubroEnum? rubroSeleccionado = comboBoxRubro.SelectedItem as RubroEnum?;
            var productosFiltrados = productos.Where(p =>
                (string.IsNullOrEmpty(textoBusqueda) || p.nombre.ToLower().Contains(textoBusqueda)) &&
                (!rubroSeleccionado.HasValue || p.Rubro == rubroSeleccionado.Value)
            ).ToList();

            foreach (var producto in productosFiltrados)
            {
                producto.precioformateado = producto.precio.ToString("F2");
            }

            listaProductos.DataSource = productosFiltrados;
            dataGridViewProductos.DataSource = listaProductos;
            dataGridViewProductos.OcultarColumnas(new string[] { "precioformateado", "eliminado" });
            PersonalizarColumnas();
        }

        private void comboBoxRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnBuscarProducto.PerformClick();
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            textBoxBuscarProducto.Text = "";
            comboBoxRubro.SelectedIndex = -1;
            CargarGrilla(); // Recarga la grilla con todos los productos
        }

        private bool ValidarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.nombre))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (producto.precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Enum.IsDefined(typeof(RubroEnum), producto.Rubro))
            {
                MessageBox.Show("Debe seleccionar un rubro válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ValidarEliminarProducto(Producto producto)
        {
            if (producto == null)
            {
                MessageBox.Show("No se ha seleccionado ningún producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

       
    }
}
