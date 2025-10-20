namespace ControlVentas.Views.Detalles
{
    partial class BalanceView
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
            dgvBalance = new DataGridView();
            btnAnio = new FontAwesome.Sharp.IconButton();
            btnMes = new FontAwesome.Sharp.IconButton();
            btnSemana = new FontAwesome.Sharp.IconButton();
            btnHoy = new FontAwesome.Sharp.IconButton();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            panel1 = new Panel();
            lblTotalVentas = new Label();
            panel2 = new Panel();
            lblTotalGastos = new Label();
            panel3 = new Panel();
            lblResultado = new Label();
            btnVerVentas = new FontAwesome.Sharp.IconButton();
            btnVerGastos = new FontAwesome.Sharp.IconButton();
            btnVerTodo = new FontAwesome.Sharp.IconButton();
            btnReporte = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            btnFiltrar.Location = new Point(982, 17);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(132, 54);
            btnFiltrar.TabIndex = 18;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnAyer
            // 
            btnAyer.BackColor = Color.White;
            btnAyer.FlatStyle = FlatStyle.Flat;
            btnAyer.ForeColor = Color.FromArgb(192, 64, 0);
            btnAyer.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAyer.IconColor = Color.FromArgb(192, 64, 0);
            btnAyer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAyer.Location = new Point(99, 87);
            btnAyer.Name = "btnAyer";
            btnAyer.Size = new Size(90, 43);
            btnAyer.TabIndex = 10;
            btnAyer.Text = "Ayer";
            btnAyer.UseVisualStyleBackColor = false;
            btnAyer.Click += btnAyer_Click;
            // 
            // dgvBalance
            // 
            dgvBalance.AllowUserToAddRows = false;
            dgvBalance.AllowUserToDeleteRows = false;
            dgvBalance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBalance.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBalance.Location = new Point(44, 136);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.ReadOnly = true;
            dgvBalance.RowHeadersWidth = 51;
            dgvBalance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBalance.Size = new Size(1571, 574);
            dgvBalance.TabIndex = 17;
            dgvBalance.CellMouseEnter += dgvBalance_CellMouseEnter;
            dgvBalance.CellPainting += dgvBalance_CellPainting;
            // 
            // btnAnio
            // 
            btnAnio.BackColor = Color.White;
            btnAnio.FlatStyle = FlatStyle.Flat;
            btnAnio.ForeColor = Color.Teal;
            btnAnio.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAnio.IconColor = Color.Teal;
            btnAnio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnio.Location = new Point(885, 87);
            btnAnio.Name = "btnAnio";
            btnAnio.Size = new Size(98, 43);
            btnAnio.TabIndex = 16;
            btnAnio.Text = "Año";
            btnAnio.UseVisualStyleBackColor = false;
            btnAnio.Click += btnAnio_Click;
            // 
            // btnMes
            // 
            btnMes.BackColor = Color.White;
            btnMes.FlatStyle = FlatStyle.Flat;
            btnMes.ForeColor = Color.FromArgb(0, 192, 0);
            btnMes.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMes.IconColor = Color.FromArgb(0, 192, 0);
            btnMes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMes.Location = new Point(674, 87);
            btnMes.Name = "btnMes";
            btnMes.Size = new Size(94, 43);
            btnMes.TabIndex = 15;
            btnMes.Text = "Mes";
            btnMes.UseVisualStyleBackColor = false;
            btnMes.Click += btnMes_Click;
            // 
            // btnSemana
            // 
            btnSemana.BackColor = Color.White;
            btnSemana.FlatStyle = FlatStyle.Flat;
            btnSemana.ForeColor = Color.Olive;
            btnSemana.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSemana.IconColor = Color.Olive;
            btnSemana.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSemana.Location = new Point(477, 87);
            btnSemana.Name = "btnSemana";
            btnSemana.Size = new Size(94, 43);
            btnSemana.TabIndex = 14;
            btnSemana.Text = "Semana";
            btnSemana.UseVisualStyleBackColor = false;
            btnSemana.Click += btnSemana_Click;
            // 
            // btnHoy
            // 
            btnHoy.BackColor = Color.White;
            btnHoy.FlatStyle = FlatStyle.Flat;
            btnHoy.ForeColor = Color.FromArgb(128, 64, 0);
            btnHoy.IconChar = FontAwesome.Sharp.IconChar.None;
            btnHoy.IconColor = Color.FromArgb(128, 64, 0);
            btnHoy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoy.Location = new Point(282, 87);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(94, 43);
            btnHoy.TabIndex = 13;
            btnHoy.Text = "Hoy";
            btnHoy.UseVisualStyleBackColor = false;
            btnHoy.Click += btnHoy_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(559, 23);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(347, 32);
            dtpHasta.TabIndex = 12;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(142, 23);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(369, 32);
            dtpDesde.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(lblTotalVentas);
            panel1.Location = new Point(44, 730);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 109);
            panel1.TabIndex = 19;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVentas.Location = new Point(51, 38);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(0, 36);
            lblTotalVentas.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(lblTotalGastos);
            panel2.Location = new Point(525, 730);
            panel2.Name = "panel2";
            panel2.Size = new Size(473, 109);
            panel2.TabIndex = 20;
            // 
            // lblTotalGastos
            // 
            lblTotalGastos.Anchor = AnchorStyles.Bottom;
            lblTotalGastos.AutoSize = true;
            lblTotalGastos.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalGastos.Location = new Point(56, 36);
            lblTotalGastos.Name = "lblTotalGastos";
            lblTotalGastos.Size = new Size(0, 36);
            lblTotalGastos.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            panel3.Controls.Add(lblResultado);
            panel3.Location = new Point(1006, 730);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 109);
            panel3.TabIndex = 21;
            // 
            // lblResultado
            // 
            lblResultado.Anchor = AnchorStyles.Bottom;
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(49, 36);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 36);
            lblResultado.TabIndex = 1;
            // 
            // btnVerVentas
            // 
            btnVerVentas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerVentas.BackColor = Color.White;
            btnVerVentas.FlatStyle = FlatStyle.Flat;
            btnVerVentas.ForeColor = Color.FromArgb(0, 192, 0);
            btnVerVentas.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            btnVerVentas.IconColor = Color.FromArgb(0, 192, 0);
            btnVerVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerVentas.IconSize = 30;
            btnVerVentas.Location = new Point(1192, 83);
            btnVerVentas.Name = "btnVerVentas";
            btnVerVentas.Size = new Size(135, 43);
            btnVerVentas.TabIndex = 22;
            btnVerVentas.Text = "ver Ventas";
            btnVerVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerVentas.UseVisualStyleBackColor = false;
            // 
            // btnVerGastos
            // 
            btnVerGastos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerGastos.BackColor = Color.White;
            btnVerGastos.FlatStyle = FlatStyle.Flat;
            btnVerGastos.ForeColor = Color.Red;
            btnVerGastos.IconChar = FontAwesome.Sharp.IconChar.SquareCaretLeft;
            btnVerGastos.IconColor = Color.Red;
            btnVerGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerGastos.IconSize = 30;
            btnVerGastos.Location = new Point(1333, 83);
            btnVerGastos.Name = "btnVerGastos";
            btnVerGastos.Size = new Size(135, 43);
            btnVerGastos.TabIndex = 23;
            btnVerGastos.Text = "ver Gastos";
            btnVerGastos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerGastos.UseVisualStyleBackColor = false;
            // 
            // btnVerTodo
            // 
            btnVerTodo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerTodo.BackColor = Color.White;
            btnVerTodo.FlatStyle = FlatStyle.Flat;
            btnVerTodo.ForeColor = Color.Blue;
            btnVerTodo.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnVerTodo.IconColor = Color.Blue;
            btnVerTodo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerTodo.IconSize = 30;
            btnVerTodo.Location = new Point(1474, 83);
            btnVerTodo.Name = "btnVerTodo";
            btnVerTodo.Size = new Size(135, 43);
            btnVerTodo.TabIndex = 24;
            btnVerTodo.Text = "ver Todo";
            btnVerTodo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerTodo.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            btnReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReporte.BackColor = Color.FromArgb(0, 192, 0);
            btnReporte.ForeColor = Color.Black;
            btnReporte.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            btnReporte.IconColor = Color.Black;
            btnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReporte.Location = new Point(1421, 12);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(135, 65);
            btnReporte.TabIndex = 25;
            btnReporte.Text = "Reporte";
            btnReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // BalanceView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1660, 860);
            Controls.Add(btnReporte);
            Controls.Add(btnVerTodo);
            Controls.Add(btnVerGastos);
            Controls.Add(btnVerVentas);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAyer);
            Controls.Add(dgvBalance);
            Controls.Add(btnAnio);
            Controls.Add(btnMes);
            Controls.Add(btnSemana);
            Controls.Add(btnHoy);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BalanceView";
            Text = "Balance";
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnAyer;
        private DataGridView dgvBalance;
        private FontAwesome.Sharp.IconButton btnAnio;
        private FontAwesome.Sharp.IconButton btnMes;
        private FontAwesome.Sharp.IconButton btnSemana;
        private FontAwesome.Sharp.IconButton btnHoy;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Panel panel1;
        private Label lblTotalVentas;
        private Panel panel2;
        private Label lblTotalGastos;
        private Panel panel3;
        private Label lblResultado;
        private FontAwesome.Sharp.IconButton btnVerVentas;
        private FontAwesome.Sharp.IconButton btnVerGastos;
        private FontAwesome.Sharp.IconButton btnVerTodo;
        private FontAwesome.Sharp.IconButton btnReporte;

    }
}