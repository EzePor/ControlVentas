namespace ControlVentas.Views.Gastos
{
    partial class ResumenGastosView
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
            btnAyer = new FontAwesome.Sharp.IconButton();
            dgvGastos = new DataGridView();
            btnAnio = new FontAwesome.Sharp.IconButton();
            btnMes = new FontAwesome.Sharp.IconButton();
            btnSemana = new FontAwesome.Sharp.IconButton();
            btnHoy = new FontAwesome.Sharp.IconButton();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            btnReporte = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            lblTotalGastos = new Label();
            btnAgregarGasto = new FontAwesome.Sharp.IconButton();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvGastos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAyer
            // 
            btnAyer.BackColor = Color.White;
            btnAyer.FlatStyle = FlatStyle.Flat;
            btnAyer.ForeColor = Color.Maroon;
            btnAyer.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAyer.IconColor = Color.Maroon;
            btnAyer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAyer.Location = new Point(104, 90);
            btnAyer.Name = "btnAyer";
            btnAyer.Size = new Size(90, 43);
            btnAyer.TabIndex = 7;
            btnAyer.Text = "Ayer";
            btnAyer.UseVisualStyleBackColor = false;
            btnAyer.Click += btnAyer_Click_1;
            // 
            // dgvGastos
            // 
            dgvGastos.AllowUserToAddRows = false;
            dgvGastos.AllowUserToDeleteRows = false;
            dgvGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGastos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGastos.Location = new Point(49, 139);
            dgvGastos.Name = "dgvGastos";
            dgvGastos.ReadOnly = true;
            dgvGastos.RowHeadersWidth = 51;
            dgvGastos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGastos.Size = new Size(1571, 574);
            dgvGastos.TabIndex = 14;
            // 
            // btnAnio
            // 
            btnAnio.BackColor = Color.White;
            btnAnio.FlatStyle = FlatStyle.Flat;
            btnAnio.ForeColor = Color.FromArgb(0, 0, 192);
            btnAnio.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAnio.IconColor = Color.FromArgb(0, 0, 192);
            btnAnio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnio.Location = new Point(890, 90);
            btnAnio.Name = "btnAnio";
            btnAnio.Size = new Size(94, 43);
            btnAnio.TabIndex = 13;
            btnAnio.Text = "Año";
            btnAnio.UseVisualStyleBackColor = false;
            btnAnio.Click += btnAnio_Click_1;
            // 
            // btnMes
            // 
            btnMes.BackColor = Color.White;
            btnMes.FlatStyle = FlatStyle.Flat;
            btnMes.ForeColor = Color.FromArgb(0, 192, 0);
            btnMes.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMes.IconColor = Color.FromArgb(0, 192, 0);
            btnMes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMes.Location = new Point(673, 90);
            btnMes.Name = "btnMes";
            btnMes.Size = new Size(94, 43);
            btnMes.TabIndex = 12;
            btnMes.Text = "Mes";
            btnMes.UseVisualStyleBackColor = false;
            btnMes.Click += btnMes_Click_1;
            // 
            // btnSemana
            // 
            btnSemana.BackColor = Color.White;
            btnSemana.FlatStyle = FlatStyle.Flat;
            btnSemana.ForeColor = Color.Olive;
            btnSemana.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSemana.IconColor = Color.Olive;
            btnSemana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSemana.Location = new Point(474, 90);
            btnSemana.Name = "btnSemana";
            btnSemana.Size = new Size(94, 43);
            btnSemana.TabIndex = 11;
            btnSemana.Text = "Semana";
            btnSemana.UseVisualStyleBackColor = false;
            btnSemana.Click += btnSemana_Click_1;
            // 
            // btnHoy
            // 
            btnHoy.BackColor = Color.White;
            btnHoy.FlatStyle = FlatStyle.Flat;
            btnHoy.ForeColor = Color.FromArgb(192, 64, 0);
            btnHoy.IconChar = FontAwesome.Sharp.IconChar.None;
            btnHoy.IconColor = Color.FromArgb(192, 64, 0);
            btnHoy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoy.Location = new Point(281, 90);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(94, 43);
            btnHoy.TabIndex = 10;
            btnHoy.Text = "Hoy";
            btnHoy.UseVisualStyleBackColor = false;
            btnHoy.Click += btnHoy_Click_1;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(627, 26);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(342, 32);
            dtpHasta.TabIndex = 9;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(147, 26);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(351, 32);
            dtpDesde.TabIndex = 8;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(0, 192, 0);
            btnReporte.ForeColor = Color.Black;
            btnReporte.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnReporte.IconColor = Color.Black;
            btnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporte.Location = new Point(1467, 749);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(137, 63);
            btnReporte.TabIndex = 16;
            btnReporte.Text = "Reporte";
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(lblTotalGastos);
            panel1.Location = new Point(88, 729);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 109);
            panel1.TabIndex = 15;
            // 
            // lblTotalGastos
            // 
            lblTotalGastos.AutoSize = true;
            lblTotalGastos.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalGastos.ForeColor = Color.Black;
            lblTotalGastos.Location = new Point(59, 35);
            lblTotalGastos.Name = "lblTotalGastos";
            lblTotalGastos.Size = new Size(0, 36);
            lblTotalGastos.TabIndex = 1;
            // 
            // btnAgregarGasto
            // 
            btnAgregarGasto.BackColor = Color.Blue;
            btnAgregarGasto.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarGasto.ForeColor = Color.White;
            btnAgregarGasto.IconChar = FontAwesome.Sharp.IconChar.SquareArrowUpRight;
            btnAgregarGasto.IconColor = Color.White;
            btnAgregarGasto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarGasto.Location = new Point(833, 764);
            btnAgregarGasto.Name = "btnAgregarGasto";
            btnAgregarGasto.Size = new Size(217, 55);
            btnAgregarGasto.TabIndex = 17;
            btnAgregarGasto.Text = "Agregar gasto";
            btnAgregarGasto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarGasto.UseVisualStyleBackColor = false;
            btnAgregarGasto.Click += btnAgregarGasto_Click_1;
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
            btnFiltrar.Location = new Point(1071, 17);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(132, 41);
            btnFiltrar.TabIndex = 18;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click_1;
            // 
            // ResumenGastosView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1660, 860);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAgregarGasto);
            Controls.Add(btnReporte);
            Controls.Add(panel1);
            Controls.Add(btnAyer);
            Controls.Add(dgvGastos);
            Controls.Add(btnAnio);
            Controls.Add(btnMes);
            Controls.Add(btnSemana);
            Controls.Add(btnHoy);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ResumenGastosView";
            Text = "Resumen de gastos";
            ((System.ComponentModel.ISupportInitialize)dgvGastos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAyer;
        private DataGridView dgvGastos;
        private FontAwesome.Sharp.IconButton btnAnio;
        private FontAwesome.Sharp.IconButton btnMes;
        private FontAwesome.Sharp.IconButton btnSemana;
        private FontAwesome.Sharp.IconButton btnHoy;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private FontAwesome.Sharp.IconButton btnReporte;
        private Panel panel1;
        private Label lblTotalGastos;
        private FontAwesome.Sharp.IconButton btnAgregarGasto;
        private FontAwesome.Sharp.IconButton btnFiltrar;
    }
}