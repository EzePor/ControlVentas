namespace ControlVentas.Views.Ventas
{
    partial class ResumenVentasView
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
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnHoy = new FontAwesome.Sharp.IconButton();
            btnSemana = new FontAwesome.Sharp.IconButton();
            btnMes = new FontAwesome.Sharp.IconButton();
            btnAnio = new FontAwesome.Sharp.IconButton();
            dgvVentas = new DataGridView();
            panel1 = new Panel();
            lblTotalPeriodo = new Label();
            btnReporte = new FontAwesome.Sharp.IconButton();
            btnAyer = new FontAwesome.Sharp.IconButton();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            lblCant = new Panel();
            lblCantidadVentas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            panel1.SuspendLayout();
            lblCant.SuspendLayout();
            SuspendLayout();
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(125, 25);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(369, 32);
            dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(556, 25);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(347, 32);
            dtpHasta.TabIndex = 1;
            // 
            // btnHoy
            // 
            btnHoy.BackColor = Color.White;
            btnHoy.FlatStyle = FlatStyle.Flat;
            btnHoy.ForeColor = Color.FromArgb(192, 64, 0);
            btnHoy.IconChar = FontAwesome.Sharp.IconChar.None;
            btnHoy.IconColor = Color.Black;
            btnHoy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoy.Location = new Point(265, 101);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(94, 42);
            btnHoy.TabIndex = 2;
            btnHoy.Text = "Hoy";
            btnHoy.UseVisualStyleBackColor = false;
            btnHoy.Click += btnHoy_Click;
            // 
            // btnSemana
            // 
            btnSemana.BackColor = Color.White;
            btnSemana.FlatStyle = FlatStyle.Flat;
            btnSemana.ForeColor = Color.Olive;
            btnSemana.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSemana.IconColor = Color.Black;
            btnSemana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSemana.Location = new Point(453, 101);
            btnSemana.Name = "btnSemana";
            btnSemana.Size = new Size(94, 42);
            btnSemana.TabIndex = 3;
            btnSemana.Text = "Semana";
            btnSemana.UseVisualStyleBackColor = false;
            btnSemana.Click += btnSemana_Click;
            // 
            // btnMes
            // 
            btnMes.BackColor = Color.White;
            btnMes.FlatStyle = FlatStyle.Flat;
            btnMes.ForeColor = Color.Green;
            btnMes.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMes.IconColor = Color.Black;
            btnMes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMes.Location = new Point(656, 101);
            btnMes.Name = "btnMes";
            btnMes.Size = new Size(94, 42);
            btnMes.TabIndex = 4;
            btnMes.Text = "Mes";
            btnMes.UseVisualStyleBackColor = false;
            btnMes.Click += btnMes_Click;
            // 
            // btnAnio
            // 
            btnAnio.BackColor = Color.White;
            btnAnio.FlatStyle = FlatStyle.Flat;
            btnAnio.ForeColor = Color.Navy;
            btnAnio.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAnio.IconColor = Color.Black;
            btnAnio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnio.Location = new Point(882, 101);
            btnAnio.Name = "btnAnio";
            btnAnio.Size = new Size(94, 42);
            btnAnio.TabIndex = 5;
            btnAnio.Text = "Año";
            btnAnio.UseVisualStyleBackColor = false;
            btnAnio.Click += btnAnio_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.Location = new Point(41, 163);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(1571, 574);
            dgvVentas.TabIndex = 6;
            dgvVentas.CellClick += dgvVentas_CellClick;
            dgvVentas.CellPainting += dgvVentas_CellPainting;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(lblTotalPeriodo);
            panel1.Location = new Point(52, 743);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 109);
            panel1.TabIndex = 7;
            // 
            // lblTotalPeriodo
            // 
            lblTotalPeriodo.AutoSize = true;
            lblTotalPeriodo.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPeriodo.Location = new Point(73, 33);
            lblTotalPeriodo.Name = "lblTotalPeriodo";
            lblTotalPeriodo.Size = new Size(0, 36);
            lblTotalPeriodo.TabIndex = 1;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(0, 192, 0);
            btnReporte.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnReporte.IconColor = Color.Black;
            btnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporte.Location = new Point(1431, 763);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(137, 63);
            btnReporte.TabIndex = 8;
            btnReporte.Text = "Reporte";
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // btnAyer
            // 
            btnAyer.BackColor = Color.White;
            btnAyer.FlatStyle = FlatStyle.Flat;
            btnAyer.ForeColor = Color.FromArgb(192, 0, 0);
            btnAyer.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAyer.IconColor = Color.Black;
            btnAyer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAyer.Location = new Point(90, 101);
            btnAyer.Name = "btnAyer";
            btnAyer.Size = new Size(90, 42);
            btnAyer.TabIndex = 0;
            btnAyer.Text = "Ayer";
            btnAyer.UseVisualStyleBackColor = false;
            btnAyer.Click += btnAyer_Click;
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
            btnFiltrar.Location = new Point(979, 27);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(122, 37);
            btnFiltrar.TabIndex = 9;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click_1;
            // 
            // lblCant
            // 
            lblCant.BackColor = Color.FromArgb(128, 128, 255);
            lblCant.Controls.Add(lblCantidadVentas);
            lblCant.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCant.Location = new Point(553, 750);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(320, 100);
            lblCant.TabIndex = 10;
            // 
            // lblCantidadVentas
            // 
            lblCantidadVentas.AutoSize = true;
            lblCantidadVentas.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadVentas.Location = new Point(16, 31);
            lblCantidadVentas.Name = "lblCantidadVentas";
            lblCantidadVentas.Size = new Size(0, 34);
            lblCantidadVentas.TabIndex = 1;
            // 
            // ResumenVentasView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1660, 860);
            Controls.Add(lblCant);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAyer);
            Controls.Add(btnReporte);
            Controls.Add(panel1);
            Controls.Add(dgvVentas);
            Controls.Add(btnAnio);
            Controls.Add(btnMes);
            Controls.Add(btnSemana);
            Controls.Add(btnHoy);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ResumenVentasView";
            Text = "Resumen Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            lblCant.ResumeLayout(false);
            lblCant.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private FontAwesome.Sharp.IconButton btnHoy;
        private FontAwesome.Sharp.IconButton btnSemana;
        private FontAwesome.Sharp.IconButton btnMes;
        private FontAwesome.Sharp.IconButton btnAnio;
        private DataGridView dgvVentas;
        private Panel panel1;
        private Label lblTotalPeriodo;
        private FontAwesome.Sharp.IconButton btnReporte;
        private FontAwesome.Sharp.IconButton btnAyer;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private Panel lblCant;
        private Label lblCantidadVentas;
    }
}