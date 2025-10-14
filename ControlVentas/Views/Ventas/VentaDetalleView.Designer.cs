namespace ControlVentas.Views.Ventas
{
    partial class VentaDetalleView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Titulo = new Label();
            dtpFecha = new DateTimePicker();
            cmbProducto = new ComboBox();
            cantidadProducto = new NumericUpDown();
            txtPrecio = new TextBox();
            btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            cmbFormaPago = new ComboBox();
            dgvDetalles = new DataGridView();
            panel1 = new Panel();
            lblTotalItemsGrilla = new Label();
            LabelTotal = new Label();
            lblTotalVenta = new Label();
            btnGuardarVenta = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSubTotal = new TextBox();
            label6 = new Label();
            iconBtAgregarProductoNuevo = new FontAwesome.Sharp.IconButton();
            comboBoxRubro = new ComboBox();
            lblRubro = new Label();
            ((System.ComponentModel.ISupportInitialize)cantidadProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(1302, 9);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(294, 48);
            Titulo.TabIndex = 0;
            Titulo.Text = "Registro de venta";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(226, 89);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(313, 28);
            dtpFecha.TabIndex = 1;
            // 
            // cmbProducto
            // 
            cmbProducto.ForeColor = Color.Black;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(102, 151);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(601, 29);
            cmbProducto.TabIndex = 2;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // cantidadProducto
            // 
            cantidadProducto.Location = new Point(803, 151);
            cantidadProducto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.Size = new Size(85, 28);
            cantidadProducto.TabIndex = 3;
            cantidadProducto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadProducto.ValueChanged += cantidadProducto_ValueChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(911, 152);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(242, 28);
            txtPrecio.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.Blue;
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            btnAgregarProducto.IconColor = Color.White;
            btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProducto.Location = new Point(1421, 133);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(201, 47);
            btnAgregarProducto.TabIndex = 5;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Location = new Point(652, 92);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(279, 29);
            cmbFormaPago.TabIndex = 6;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToAddRows = false;
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalles.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvDetalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDetalles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalles.Location = new Point(101, 207);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.RowHeadersWidth = 51;
            dgvDetalles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalles.Size = new Size(1520, 540);
            dgvDetalles.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(lblTotalItemsGrilla);
            panel1.Controls.Add(LabelTotal);
            panel1.Controls.Add(lblTotalVenta);
            panel1.Location = new Point(261, 769);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 118);
            panel1.TabIndex = 8;
            // 
            // lblTotalItemsGrilla
            // 
            lblTotalItemsGrilla.AutoSize = true;
            lblTotalItemsGrilla.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalItemsGrilla.ForeColor = Color.FromArgb(192, 0, 0);
            lblTotalItemsGrilla.Location = new Point(456, 18);
            lblTotalItemsGrilla.Name = "lblTotalItemsGrilla";
            lblTotalItemsGrilla.Size = new Size(0, 28);
            lblTotalItemsGrilla.TabIndex = 18;
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelTotal.ForeColor = Color.DimGray;
            LabelTotal.Location = new Point(28, 18);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(72, 34);
            LabelTotal.TabIndex = 1;
            LabelTotal.Text = "Total:";
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.AutoSize = true;
            lblTotalVenta.Font = new Font("Bahnschrift SemiCondensed", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVenta.ForeColor = Color.Black;
            lblTotalVenta.Location = new Point(43, 62);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(48, 45);
            lblTotalVenta.TabIndex = 0;
            lblTotalVenta.Text = "$ ";
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.BackColor = Color.FromArgb(255, 128, 0);
            btnGuardarVenta.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarVenta.ForeColor = Color.FromArgb(64, 64, 64);
            btnGuardarVenta.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarVenta.IconColor = Color.Black;
            btnGuardarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarVenta.Location = new Point(1275, 769);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(211, 84);
            btnGuardarVenta.TabIndex = 9;
            btnGuardarVenta.Text = "Guardar Venta";
            btnGuardarVenta.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarVenta.UseVisualStyleBackColor = false;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(236, 65);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 10;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(661, 65);
            label2.Name = "label2";
            label2.Size = new Size(110, 21);
            label2.TabIndex = 11;
            label2.Text = "Forma de Pago";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(117, 127);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 12;
            label3.Text = "Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(805, 127);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 13;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(930, 128);
            label5.Name = "label5";
            label5.Size = new Size(138, 21);
            label5.TabIndex = 14;
            label5.Text = "Precio del producto";
            // 
            // txtSubTotal
            // 
            txtSubTotal.ForeColor = Color.Blue;
            txtSubTotal.Location = new Point(1167, 151);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(245, 28);
            txtSubTotal.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(1217, 127);
            label6.Name = "label6";
            label6.Size = new Size(65, 21);
            label6.TabIndex = 16;
            label6.Text = "SubTotal";
            // 
            // iconBtAgregarProductoNuevo
            // 
            iconBtAgregarProductoNuevo.BackgroundImageLayout = ImageLayout.Center;
            iconBtAgregarProductoNuevo.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconBtAgregarProductoNuevo.ForeColor = Color.Black;
            iconBtAgregarProductoNuevo.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
            iconBtAgregarProductoNuevo.IconColor = Color.Green;
            iconBtAgregarProductoNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtAgregarProductoNuevo.IconSize = 30;
            iconBtAgregarProductoNuevo.Location = new Point(709, 133);
            iconBtAgregarProductoNuevo.Name = "iconBtAgregarProductoNuevo";
            iconBtAgregarProductoNuevo.RightToLeft = RightToLeft.No;
            iconBtAgregarProductoNuevo.Size = new Size(90, 47);
            iconBtAgregarProductoNuevo.TabIndex = 17;
            iconBtAgregarProductoNuevo.Text = "+";
            iconBtAgregarProductoNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtAgregarProductoNuevo.UseVisualStyleBackColor = true;
            iconBtAgregarProductoNuevo.Click += iconBtAgregarProductoNuevo_Click;
            // 
            // comboBoxRubro
            // 
            comboBoxRubro.FormattingEnabled = true;
            comboBoxRubro.Location = new Point(1008, 89);
            comboBoxRubro.Name = "comboBoxRubro";
            comboBoxRubro.Size = new Size(293, 29);
            comboBoxRubro.TabIndex = 18;
            // 
            // lblRubro
            // 
            lblRubro.AutoSize = true;
            lblRubro.ForeColor = Color.White;
            lblRubro.Location = new Point(1020, 62);
            lblRubro.Name = "lblRubro";
            lblRubro.Size = new Size(49, 21);
            lblRubro.TabIndex = 19;
            lblRubro.Text = "Rubro";
            // 
            // VentaDetalleView
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1720, 910);
            Controls.Add(lblRubro);
            Controls.Add(comboBoxRubro);
            Controls.Add(iconBtAgregarProductoNuevo);
            Controls.Add(label6);
            Controls.Add(txtSubTotal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardarVenta);
            Controls.Add(panel1);
            Controls.Add(dgvDetalles);
            Controls.Add(cmbFormaPago);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtPrecio);
            Controls.Add(cantidadProducto);
            Controls.Add(cmbProducto);
            Controls.Add(dtpFecha);
            Controls.Add(Titulo);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentaDetalleView";
            Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)cantidadProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private DateTimePicker dtpFecha;
        private ComboBox cmbProducto;
        private NumericUpDown cantidadProducto;
        private TextBox txtPrecio;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private ComboBox cmbFormaPago;
        private DataGridView dgvDetalles;
        private Panel panel1;
        private Label lblTotalVenta;
        private Label LabelTotal;
        private FontAwesome.Sharp.IconButton btnGuardarVenta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSubTotal;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconBtAgregarProductoNuevo;
        private Label lblTotalItemsGrilla;
        private ComboBox comboBoxRubro;
        private Label lblRubro;
    }
}