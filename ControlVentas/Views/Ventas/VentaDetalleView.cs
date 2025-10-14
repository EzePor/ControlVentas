using ControlVentas.Data;
using ControlVentas.Enums;
using ControlVentas.Models;
using ControlVentas.Views.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControlVentas.Views.Ventas
{
    public partial class VentaDetalleView : Form
    {
        private readonly ControlVentaContext _context;
        private decimal totalVenta = 0;
        private List<string> productosTemporales = new List<string>();

        public VentaDetalleView(ControlVentaContext context)
        {
            InitializeComponent();
            _context = context;
            this.Load += VentaDetalleView_Load;
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDown; // Permite escribir
            cantidadProducto.ValueChanged += cantidadProducto_ValueChanged;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
        }

        private void VentaDetalleView_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void CargarComboBox()
        {
            var productosBase = _context.Productos
                .Where(p => !p.eliminado && p.activo)
                .Select(p => p.nombre)
                .OrderBy(n => n) // <-- orden alfabético
                .ToList();

            var todos = productosBase.Concat(productosTemporales)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(n => n) // <-- orden alfabético también para temporales
                .ToList();

            cmbProducto.DataSource = todos;
            cmbProducto.SelectedIndex = -1;
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDown;
            cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;

            // ComboBox de forma de pago (ya está correcto)
            cmbFormaPago.DataSource = Enum.GetValues(typeof(FormaPagoEnum));
            cmbFormaPago.SelectedItem = FormaPagoEnum.Efectivo;

            // ComboBox de rubro
            comboBoxRubro.DataSource = Enum.GetValues(typeof(RubroEnum));
            comboBoxRubro.SelectedIndex = -1;

            dtpFecha.Value = DateTime.Now;

            configurarGrilla();
        }

        private void configurarGrilla()
        {
            dgvDetalles.Columns.Clear();
            dgvDetalles.Columns.Add("ProductoId", "ProductoId");
            dgvDetalles.Columns["ProductoId"].Visible = false;
            dgvDetalles.Columns.Add("Producto", "Producto");
            dgvDetalles.Columns.Add("Cantidad", "Cantidad");
            dgvDetalles.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvDetalles.Columns.Add("Subtotal", "Subtotal");

            // Columna de botón para eliminar
            var btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "🗑";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvDetalles.Columns.Add(btnEliminar);

            dgvDetalles.CellClick += dgvDetalles_CellClick;
            dgvDetalles.CellPainting += dgvDetalles_CellPainting;
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreProducto = cmbProducto.Text.Trim();
            var producto = _context.Productos.FirstOrDefault(p => p.nombre.ToLower() == nombreProducto.ToLower());
            if (producto != null)
            {
                txtPrecio.Text = producto.precio.ToString("N2");
            }
            else
            {
                txtPrecio.Text = "";
               }
               CalcularSubTotal();
           }

        private void CalcularSubTotal()
        {
            int cantidad = (int)cantidadProducto.Value;
            if (decimal.TryParse(txtPrecio.Text, out decimal precioUnitario) && cantidad > 0)
            {
                txtSubTotal.Text = (cantidad * precioUnitario).ToString("N2");
            }
            else
            {
                txtSubTotal.Text = "";
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = cmbProducto.Text.Trim();
            if (string.IsNullOrEmpty(nombreProducto))
            {
                MessageBox.Show("Ingrese el nombre del producto.");
                return;
            }

            int cantidad = (int)cantidadProducto.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precioUnitario) || precioUnitario <= 0)
            {
                MessageBox.Show("Ingrese un precio válido.");
                return;
            }

            // Buscar si el producto existe en la base
            var producto = _context.Productos.FirstOrDefault(p => p.nombre.ToLower() == nombreProducto.ToLower());
            int productoId = producto?.id ?? 0;

            // Si no existe, crear y guardar el producto
            if (productoId == 0)
            {
                if (comboBoxRubro.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione el rubro para el nuevo producto.");
                    return;
                }

                var nuevoProducto = new Producto
                {
                    nombre = nombreProducto,
                    precio = precioUnitario,
                    Rubro = (RubroEnum)comboBoxRubro.SelectedItem,
                    activo = true,
                    eliminado = false
                };
                _context.Productos.Add(nuevoProducto);
                _context.SaveChanges();
                productoId = nuevoProducto.id;
                producto = nuevoProducto;

                ActualizarComboBoxDataSource(); // <-- Actualiza el ComboBox aquí
            }

            // Agregar a la grilla
            dgvDetalles.Rows.Add(productoId, nombreProducto, cantidad, precioUnitario.ToString("N2"), (cantidad * precioUnitario).ToString("N2"));
            totalVenta += cantidad * precioUnitario;
            lblTotalVenta.Text = $"$ {totalVenta:N2}";
            ActualizarTotalItems();

            cmbProducto.Text = "";
            txtPrecio.Text = "";
            cantidadProducto.Value = 1;
            txtSubTotal.Text = "";
            comboBoxRubro.SelectedIndex = -1;
        }

        private void ActualizarComboBoxDataSource()
        {
            var productosBase = _context.Productos
                .Where(p => !p.eliminado && p.activo)
                .Select(p => p.nombre)
                .ToList();

            var todos = productosBase.Concat(productosTemporales)
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();

            cmbProducto.DataSource = null;
            cmbProducto.DataSource = todos;
            cmbProducto.SelectedIndex = -1;
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto a la venta.");
                return;
            }
            if (cmbFormaPago.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una forma de pago.");
                return;
            }

            Venta venta = new Venta
            {
                fecha = dtpFecha.Value,
                eliminado = false,
                detalles = new List<VentaDetalle>()
            };

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.IsNewRow) continue;

                int productoId = Convert.ToInt32(row.Cells["ProductoId"].Value);
                var producto = _context.Productos.Find(productoId);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);

                // Solo guardar si el producto existe en la base
                if (productoId != 0 && producto != null)
                {
                    var detalle = new VentaDetalle
                    {
                        productoId = productoId,
                        producto = producto,
                        cantidad = cantidad,
                        precioUnitario = precioUnitario,
                        formaPagoEnum = (FormaPagoEnum)cmbFormaPago.SelectedItem,
                        eliminado = false
                    };
                    venta.detalles.Add(detalle);
                }
                // Si el producto no existe, lo creas y lo guardas
                if (productoId == 0)
                {
                    string nombreProducto = row.Cells["Producto"].Value?.ToString() ?? "";
                    var nuevoProducto = new Producto
                    {
                        nombre = nombreProducto,
                        precio = precioUnitario,
                        Rubro = (RubroEnum)comboBoxRubro.SelectedItem,
                        activo = true,
                        eliminado = false
                    };
                    _context.Productos.Add(nuevoProducto);
                    _context.SaveChanges();
                    productoId = nuevoProducto.id;
                    producto = nuevoProducto;

                    var detalle = new VentaDetalle
                    {
                        productoId = productoId,
                        producto = producto,
                        cantidad = cantidad,
                        precioUnitario = precioUnitario,
                        formaPagoEnum = (FormaPagoEnum)cmbFormaPago.SelectedItem,
                        eliminado = false
                    };
                    venta.detalles.Add(detalle);
                }
            }

            if (!ValidarVenta(venta))
            {
                return;
            }

            _context.Ventas.Add(venta);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Aquí podrías registrar el error en un archivo log si lo deseas
            }
            MessageBox.Show("Venta guardada exitosamente ✅");

            // Limpiar formulario
            dgvDetalles.Rows.Clear();
            totalVenta = 0;
            lblTotalVenta.Text = "$ 0.00";
            cmbProducto.SelectedIndex = -1;
            cantidadProducto.Value = 1; // <-- valor por defecto
            txtPrecio.Text = "";
            txtSubTotal.Text = "";
            cmbFormaPago.SelectedItem = FormaPagoEnum.Efectivo; // <-- valor por defecto
            comboBoxRubro.SelectedIndex = -1;
            ActualizarTotalItems();
        }

        private bool ValidarVenta(Venta venta)
        {
            if (venta.detalles == null || !venta.detalles.Any())
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (var detalle in venta.detalles)
            {
                if (detalle.cantidad <= 0 || detalle.precioUnitario <= 0)
                {
                    MessageBox.Show("Cantidad y precio unitario deben ser mayores a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void cantidadProducto_ValueChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void iconBtAgregarProductoNuevo_Click(object sender, EventArgs e)
        {
            var frmAgregarProducto = new AgregarEditarProductosView(_context);
            if (frmAgregarProducto.ShowDialog() == DialogResult.OK)
            {
                // Recargar productos en el combo
                var productosBase = _context.Productos
                    .Where(p => !p.eliminado && p.activo)
                    .Select(p => p.nombre)
                    .ToList();

                var todos = productosBase.Concat(productosTemporales)
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToList();

                cmbProducto.DataSource = null;
                cmbProducto.DataSource = todos;
                cmbProducto.SelectedIndex = -1;
            }
        }

        private void dgvDetalles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDetalles.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                var nombreProducto = dgvDetalles.Rows[e.RowIndex].Cells["Producto"].Value?.ToString();
                var confirm = MessageBox.Show(
                    $"¿Seguro que deseas eliminar '{nombreProducto}' de la venta?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    decimal subtotal = 0;
                    if (decimal.TryParse(dgvDetalles.Rows[e.RowIndex].Cells["Subtotal"].Value?.ToString(), out subtotal))
                    {
                        totalVenta -= subtotal;
                        lblTotalVenta.Text = $"$ {totalVenta:N2}";
                    }
                    dgvDetalles.Rows.RemoveAt(e.RowIndex);
                    ActualizarTotalItems();
                }
            }
        }

        private void dgvDetalles_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvDetalles.Columns[e.ColumnIndex].Name == "Eliminar")
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
                    new Font(dgvDetalles.Font, FontStyle.Bold),
                    textRect,
                    Color.White,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left
                );

                e.Handled = true;
            }
        }

        private void ActualizarTotalItems()
        {
            lblTotalItemsGrilla.Text = $"Total de ítems: {dgvDetalles.Rows.Count}";
        }
    }
}
