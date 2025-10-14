using ControlVentas.Data;
using ControlVentas.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ControlVentas.Views.Gastos
{
    public partial class AgregarGastoView : Form
    {
        private readonly ControlVentaContext _context;
        private readonly Gasto _gasto;

        public AgregarGastoView(ControlVentaContext context, Gasto? gasto = null)
        {
            InitializeComponent();
            _context = context;
            _gasto = gasto ?? new Gasto();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dtpFecha.Value = _gasto.fecha;
            txtDescripcion.Text = _gasto.descripcion;
            txtMonto.Text = _gasto.monto > 0 ? _gasto.monto.ToString("N2") : "";

            // Obtener descripciones únicas de gastos anteriores
            var descripciones = _context.Gastos
                .Where(g => !string.IsNullOrWhiteSpace(g.descripcion))
                .Select(g => g.descripcion)
                .Distinct()
                .ToArray();

            // Configurar autocompletado en el TextBox de descripción
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(descripciones);
            txtDescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDescripcion.AutoCompleteCustomSource = autoComplete;
        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria.");
                return;
            }
            if (!decimal.TryParse(txtMonto.Text, out decimal monto) || monto <= 0)
            {
                MessageBox.Show("El monto debe ser un número mayor a cero.");
                return;
            }

            _gasto.fecha = dtpFecha.Value;
            _gasto.descripcion = txtDescripcion.Text.Trim();
            _gasto.monto = monto;

            if (_gasto.id == 0)
                _context.Gastos.Add(_gasto);

            _context.SaveChanges();
            MessageBox.Show("Gasto guardado correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // cerrar el formulario sin guardar
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
