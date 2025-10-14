namespace ControlVentas.Views.Datos
{
    partial class EstadisticasVentasView
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
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            btnAyer = new FontAwesome.Sharp.IconButton();
            btnAnio = new FontAwesome.Sharp.IconButton();
            btnMes = new FontAwesome.Sharp.IconButton();
            btnSemana = new FontAwesome.Sharp.IconButton();
            btnHoy = new FontAwesome.Sharp.IconButton();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            cmbRubro = new ComboBox();
            dgvEstadisticas = new DataGridView();
            lblProductoMasVendido = new Label();
            lblTotalProductos = new Label();
            lblTotalFacturado = new Label();
            lblRubroMasVendido = new Label();
            panel1 = new Panel();
            lblFotografia = new Label();
            btnVerPorRubro = new FontAwesome.Sharp.IconButton();
            btnVerPorProducto = new FontAwesome.Sharp.IconButton();
            chkIncluirFotografia = new CheckBox();
            label1 = new Label();
            btnExportarExcel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.White;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.ForeColor = Color.FromArgb(192, 0, 0);
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            btnFiltrar.IconColor = Color.FromArgb(192, 0, 0);
            btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnFiltrar.IconSize = 30;
            btnFiltrar.Location = new Point(923, 26);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(122, 37);
            btnFiltrar.TabIndex = 17;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnAyer
            // 
            btnAyer.BackColor = Color.White;
            btnAyer.FlatStyle = FlatStyle.Flat;
            btnAyer.ForeColor = Color.FromArgb(192, 0, 0);
            btnAyer.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAyer.IconColor = Color.Black;
            btnAyer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAyer.Location = new Point(34, 100);
            btnAyer.Name = "btnAyer";
            btnAyer.Size = new Size(90, 42);
            btnAyer.TabIndex = 10;
            btnAyer.Text = "Ayer";
            btnAyer.UseVisualStyleBackColor = false;
            // 
            // btnAnio
            // 
            btnAnio.BackColor = Color.White;
            btnAnio.FlatStyle = FlatStyle.Flat;
            btnAnio.ForeColor = Color.Navy;
            btnAnio.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAnio.IconColor = Color.Black;
            btnAnio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnio.Location = new Point(826, 100);
            btnAnio.Name = "btnAnio";
            btnAnio.Size = new Size(94, 42);
            btnAnio.TabIndex = 16;
            btnAnio.Text = "Año";
            btnAnio.UseVisualStyleBackColor = false;
            // 
            // btnMes
            // 
            btnMes.BackColor = Color.White;
            btnMes.FlatStyle = FlatStyle.Flat;
            btnMes.ForeColor = Color.Green;
            btnMes.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMes.IconColor = Color.Black;
            btnMes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMes.Location = new Point(600, 100);
            btnMes.Name = "btnMes";
            btnMes.Size = new Size(94, 42);
            btnMes.TabIndex = 15;
            btnMes.Text = "Mes";
            btnMes.UseVisualStyleBackColor = false;
            // 
            // btnSemana
            // 
            btnSemana.BackColor = Color.White;
            btnSemana.FlatStyle = FlatStyle.Flat;
            btnSemana.ForeColor = Color.Olive;
            btnSemana.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSemana.IconColor = Color.Black;
            btnSemana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSemana.Location = new Point(397, 100);
            btnSemana.Name = "btnSemana";
            btnSemana.Size = new Size(94, 42);
            btnSemana.TabIndex = 14;
            btnSemana.Text = "Semana";
            btnSemana.UseVisualStyleBackColor = false;
            // 
            // btnHoy
            // 
            btnHoy.BackColor = Color.White;
            btnHoy.FlatStyle = FlatStyle.Flat;
            btnHoy.ForeColor = Color.FromArgb(192, 64, 0);
            btnHoy.IconChar = FontAwesome.Sharp.IconChar.None;
            btnHoy.IconColor = Color.Black;
            btnHoy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoy.Location = new Point(209, 100);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(94, 42);
            btnHoy.TabIndex = 13;
            btnHoy.Text = "Hoy";
            btnHoy.UseVisualStyleBackColor = false;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(500, 24);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(347, 32);
            dtpHasta.TabIndex = 12;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(69, 24);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(369, 32);
            dtpDesde.TabIndex = 11;
            // 
            // cmbRubro
            // 
            cmbRubro.FormattingEnabled = true;
            cmbRubro.Location = new Point(1007, 110);
            cmbRubro.Name = "cmbRubro";
            cmbRubro.Size = new Size(246, 32);
            cmbRubro.TabIndex = 18;
            // 
            // dgvEstadisticas
            // 
            dgvEstadisticas.AllowUserToAddRows = false;
            dgvEstadisticas.AllowUserToDeleteRows = false;
            dgvEstadisticas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstadisticas.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEstadisticas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEstadisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEstadisticas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEstadisticas.Location = new Point(25, 154);
            dgvEstadisticas.Name = "dgvEstadisticas";
            dgvEstadisticas.ReadOnly = true;
            dgvEstadisticas.RowHeadersWidth = 51;
            dgvEstadisticas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstadisticas.Size = new Size(1650, 627);
            dgvEstadisticas.TabIndex = 19;
            // 
            // lblProductoMasVendido
            // 
            lblProductoMasVendido.AutoSize = true;
            lblProductoMasVendido.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            lblProductoMasVendido.ForeColor = Color.White;
            lblProductoMasVendido.Location = new Point(88, 13);
            lblProductoMasVendido.Name = "lblProductoMasVendido";
            lblProductoMasVendido.Size = new Size(0, 28);
            lblProductoMasVendido.TabIndex = 20;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            lblTotalProductos.ForeColor = Color.White;
            lblTotalProductos.Location = new Point(774, 52);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(0, 28);
            lblTotalProductos.TabIndex = 21;
            // 
            // lblTotalFacturado
            // 
            lblTotalFacturado.AutoSize = true;
            lblTotalFacturado.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalFacturado.ForeColor = Color.White;
            lblTotalFacturado.Location = new Point(1265, 44);
            lblTotalFacturado.Name = "lblTotalFacturado";
            lblTotalFacturado.Size = new Size(0, 36);
            lblTotalFacturado.TabIndex = 22;
            // 
            // lblRubroMasVendido
            // 
            lblRubroMasVendido.AutoSize = true;
            lblRubroMasVendido.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            lblRubroMasVendido.ForeColor = Color.White;
            lblRubroMasVendido.Location = new Point(89, 56);
            lblRubroMasVendido.Name = "lblRubroMasVendido";
            lblRubroMasVendido.Size = new Size(0, 28);
            lblRubroMasVendido.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 192);
            panel1.Controls.Add(lblFotografia);
            panel1.Controls.Add(lblRubroMasVendido);
            panel1.Controls.Add(lblTotalFacturado);
            panel1.Controls.Add(lblTotalProductos);
            panel1.Controls.Add(lblProductoMasVendido);
            panel1.Location = new Point(12, 787);
            panel1.Name = "panel1";
            panel1.Size = new Size(1676, 125);
            panel1.TabIndex = 24;
            // 
            // lblFotografia
            // 
            lblFotografia.AutoSize = true;
            lblFotografia.Font = new Font("Bahnschrift SemiCondensed", 13.8F);
            lblFotografia.ForeColor = Color.White;
            lblFotografia.Location = new Point(773, 14);
            lblFotografia.Name = "lblFotografia";
            lblFotografia.Size = new Size(0, 28);
            lblFotografia.TabIndex = 24;
            // 
            // btnVerPorRubro
            // 
            btnVerPorRubro.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnVerPorRubro.IconColor = Color.Black;
            btnVerPorRubro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerPorRubro.Location = new Point(1308, 85);
            btnVerPorRubro.Name = "btnVerPorRubro";
            btnVerPorRubro.Size = new Size(138, 57);
            btnVerPorRubro.TabIndex = 25;
            btnVerPorRubro.Text = "Ver por Rubro";
            btnVerPorRubro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerPorRubro.UseVisualStyleBackColor = true;
            btnVerPorRubro.Click += btnVerPorRubro_Click;
            // 
            // btnVerPorProducto
            // 
            btnVerPorProducto.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
            btnVerPorProducto.IconColor = Color.Black;
            btnVerPorProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerPorProducto.Location = new Point(1478, 85);
            btnVerPorProducto.Name = "btnVerPorProducto";
            btnVerPorProducto.Size = new Size(138, 57);
            btnVerPorProducto.TabIndex = 26;
            btnVerPorProducto.Text = "Ver por Producto";
            btnVerPorProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerPorProducto.UseVisualStyleBackColor = true;
            btnVerPorProducto.Click += btnVerPorProducto_Click;
            // 
            // chkIncluirFotografia
            // 
            chkIncluirFotografia.AutoSize = true;
            chkIncluirFotografia.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkIncluirFotografia.ForeColor = Color.White;
            chkIncluirFotografia.Location = new Point(1139, 35);
            chkIncluirFotografia.Name = "chkIncluirFotografia";
            chkIncluirFotografia.Size = new Size(251, 28);
            chkIncluirFotografia.TabIndex = 50;
            chkIncluirFotografia.Text = "Incluir Fotografía en la grilla";
            chkIncluirFotografia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1034, 83);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 51;
            label1.Text = "Rubros";
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = Color.FromArgb(0, 192, 0);
            btnExportarExcel.ForeColor = Color.White;
            btnExportarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnExportarExcel.IconColor = Color.White;
            btnExportarExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExportarExcel.Location = new Point(1453, 12);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new Size(176, 67);
            btnExportarExcel.TabIndex = 52;
            btnExportarExcel.Text = "Guargar Excel";
            btnExportarExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportarExcel.UseVisualStyleBackColor = false;
            btnExportarExcel.Click += btnExportarExcel_Click;
            // 
            // EstadisticasVentasView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1700, 920);
            Controls.Add(btnExportarExcel);
            Controls.Add(label1);
            Controls.Add(chkIncluirFotografia);
            Controls.Add(btnVerPorProducto);
            Controls.Add(btnVerPorRubro);
            Controls.Add(panel1);
            Controls.Add(dgvEstadisticas);
            Controls.Add(cmbRubro);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAyer);
            Controls.Add(btnAnio);
            Controls.Add(btnMes);
            Controls.Add(btnSemana);
            Controls.Add(btnHoy);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EstadisticasVentasView";
            Text = "Estadísticas";
            ((System.ComponentModel.ISupportInitialize)dgvEstadisticas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnAyer;
        private FontAwesome.Sharp.IconButton btnAnio;
        private FontAwesome.Sharp.IconButton btnMes;
        private FontAwesome.Sharp.IconButton btnSemana;
        private FontAwesome.Sharp.IconButton btnHoy;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private ComboBox cmbRubro;
        private DataGridView dgvEstadisticas;
        private Label lblProductoMasVendido;
        private Label lblTotalProductos;
        private Label lblTotalFacturado;
        private Label lblRubroMasVendido;
        private Panel panel1;
        private Label lblFotografia;
        private FontAwesome.Sharp.IconButton btnVerPorRubro;
        private FontAwesome.Sharp.IconButton btnVerPorProducto;
        private CheckBox chkIncluirFotografia;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnExportarExcel;
       
    }
}