using ControlVentas.Data;
using ControlVentas.Enums;
using ControlVentas.ExtensionMethods;
using ControlVentas.Interfaces;
using ControlVentas.Models;
using ControlVentas.Services;
using ControlVentas.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas.Views.Productos
{
    public partial class AgregarEditarProductosView : Form
    {
       private readonly ControlVentaContext _controlVentaContext;

        BindingSource listaProductos = new BindingSource();
        BindingSource BindingProductos = new BindingSource();
        List<Producto> ListaProductos = new List<Producto>();
        private Producto producto;
        public AgregarEditarProductosView(ControlVentaContext context)
        {
            InitializeComponent();
            _controlVentaContext = context;
            CargarComboBoxNombreProducto(); // <-- Agrega esta línea
            producto = new Producto();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Gray;
            Padding = new Padding(2);
            CargarComboBoxRubro();
        }

        private void CargarProductos()
        {
            ShowInActivity.Show("Descargando/actualizando la lista de productos");
            var productos = _controlVentaContext.Productos.ToList();
            foreach (var producto in productos)
            {
                producto.precioformateado = producto.precio.ToString("F2");
            }
            listaProductos.DataSource = productos;
            // dgvProductos.OcultarColumnas(new string[] { "precioformateado", "eliminado" });
          //  PersonalizarColumnas();
            ShowInActivity.Hide();
        }

        private void PersonalizarColumnas()
        {
            dgvProductos.Columns["id"].HeaderText = "ID";
            dgvProductos.Columns["nombre"].HeaderText = "NOMBRE";
            dgvProductos.Columns["Rubro"].HeaderText = "RUBRO";
            dgvProductos.Columns["precio"].HeaderText = "PRECIO";


            // Cambiar tipo de letra
            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
                column.HeaderCell.Style.SelectionBackColor = Color.Orange; // Cambia a tu color preferido
            }
        }

        private void CargarComboBoxRubro()
        {
            cboRubro.DataSource = Enum.GetValues(typeof(RubroEnum));
        }

        public AgregarEditarProductosView(Producto producto)
        {
            InitializeComponent();
            _controlVentaContext = new ControlVentaContext();
            this.producto = producto;
            CargarComboBoxNombreProducto();
            CargarComboBoxRubro();
            CargarDatosProductosAEditar();
        }

        private void CargarDatosProductosAEditar()
        {
            // Asegúrate de que el ComboBox está cargado
            CargarComboBoxNombreProducto();

            // Si el nombre existe en la lista, selecciónalo
            int index = cmbNombreProducto.FindStringExact(producto.nombre);
            if (index >= 0)
                cmbNombreProducto.SelectedIndex = index;
            else
                cmbNombreProducto.Text = producto.nombre; // Si es nuevo o modificado

            txtPrecio.Text = producto.precioformateado;
            cboRubro.SelectedItem = producto.Rubro;
        }

        // Validación de los datos ingresados
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(cmbNombreProducto.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("El precio debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        

            if (cboRubro.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un rubro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                producto.nombre = cmbNombreProducto.Text.Trim();
                producto.precioformateado = txtPrecio.Text;
                producto.Rubro = (RubroEnum)cboRubro.SelectedItem;

                // Convertir el precio formateado a decimal antes de guardar
                if (decimal.TryParse(txtPrecio.Text, out decimal precioDecimal))
                {
                    producto.precio = precioDecimal;
                }

                try
                {
                    if (producto.id == 0) // Nuevo producto
                    {
                        ShowInActivity.Show("Agregando producto ...");
                        _controlVentaContext.Productos.Add(producto);
                        _controlVentaContext.SaveChanges();
                        ShowInActivity.Hide();
                        MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Producto existente (editar)
                    {
                        ShowInActivity.Show("Actualizando producto ...");
                        _controlVentaContext.Productos.Update(producto);
                        _controlVentaContext.SaveChanges();
                        ShowInActivity.Hide();
                        MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CargarComboBoxNombreProducto()
        {
            var nombres = _controlVentaContext.Productos
                .Where(p => !p.eliminado)
                .Select(p => p.nombre)
                .ToList() // Trae los nombres a memoria primero
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            cmbNombreProducto.DataSource = nombres;
            cmbNombreProducto.DropDownStyle = ComboBoxStyle.DropDown;
            cmbNombreProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbNombreProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbNombreProducto.SelectedIndex = -1;
        }

        // Evento Paint para dibujar el borde redondeado
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderRadius = 20;  // Radio de redondeo de esquinas
            int borderSize = 4;     // Grosor del borde

            using (GraphicsPath path = new GraphicsPath())
            {
                // Crear un borde con esquinas redondeadas
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(Width - borderRadius - 1, Height - borderRadius - 1, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, Height - borderRadius - 1, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                // Dibujar el borde
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.White, borderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
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
            // Puedes agregar más validaciones aquí
            return true;
        }
    }
}
