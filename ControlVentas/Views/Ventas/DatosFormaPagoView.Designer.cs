namespace ControlVentas.Views.Ventas
{
    partial class DatosFormaPagoView
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
            dgvVentas = new DataGridView();
            btnAnio = new FontAwesome.Sharp.IconButton();
            btnMes = new FontAwesome.Sharp.IconButton();
            btnSemana = new FontAwesome.Sharp.IconButton();
            btnHoy = new FontAwesome.Sharp.IconButton();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            lblCant = new Panel();
            lblCantidadVentas = new Label();
            panel1 = new Panel();
            lblTotalPeriodo = new Label();
            flpFormasPago = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            lblCant.SuspendLayout();
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
            btnFiltrar.Location = new Point(889, 16);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(122, 53);
            btnFiltrar.TabIndex = 18;
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
            btnAyer.Location = new Point(85, 91);
            btnAyer.Name = "btnAyer";
            btnAyer.Size = new Size(90, 42);
            btnAyer.TabIndex = 10;
            btnAyer.Text = "Ayer";
            btnAyer.UseVisualStyleBackColor = false;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvVentas.Location = new Point(20, 153);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(1025, 545);
            dgvVentas.TabIndex = 17;
            // 
            // btnAnio
            // 
            btnAnio.BackColor = Color.White;
            btnAnio.FlatStyle = FlatStyle.Flat;
            btnAnio.ForeColor = Color.Navy;
            btnAnio.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAnio.IconColor = Color.Black;
            btnAnio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnio.Location = new Point(877, 91);
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
            btnMes.Location = new Point(651, 91);
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
            btnSemana.Location = new Point(448, 91);
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
            btnHoy.Location = new Point(260, 91);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(94, 42);
            btnHoy.TabIndex = 13;
            btnHoy.Text = "Hoy";
            btnHoy.UseVisualStyleBackColor = false;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(467, 24);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(347, 32);
            dtpHasta.TabIndex = 12;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(36, 24);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(369, 32);
            dtpDesde.TabIndex = 11;
            // 
            // lblCant
            // 
            lblCant.Anchor = AnchorStyles.Bottom;
            lblCant.BackColor = Color.FromArgb(128, 128, 255);
            lblCant.Controls.Add(lblCantidadVentas);
            lblCant.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCant.Location = new Point(687, 706);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(388, 100);
            lblCant.TabIndex = 21;
            // 
            // lblCantidadVentas
            // 
            lblCantidadVentas.Anchor = AnchorStyles.Bottom;
            lblCantidadVentas.AutoSize = true;
            lblCantidadVentas.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadVentas.Location = new Point(35, 31);
            lblCantidadVentas.Name = "lblCantidadVentas";
            lblCantidadVentas.Size = new Size(0, 34);
            lblCantidadVentas.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(lblTotalPeriodo);
            panel1.Location = new Point(186, 700);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 109);
            panel1.TabIndex = 19;
            // 
            // lblTotalPeriodo
            // 
            lblTotalPeriodo.Anchor = AnchorStyles.Bottom;
            lblTotalPeriodo.AutoSize = true;
            lblTotalPeriodo.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPeriodo.Location = new Point(29, 42);
            lblTotalPeriodo.Name = "lblTotalPeriodo";
            lblTotalPeriodo.Size = new Size(0, 36);
            lblTotalPeriodo.TabIndex = 1;
            // 
            // flpFormasPago
            // 
            flpFormasPago.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpFormasPago.BackColor = Color.FromArgb(128, 128, 255);
            flpFormasPago.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpFormasPago.ForeColor = Color.Black;
            flpFormasPago.Location = new Point(1064, 153);
            flpFormasPago.Name = "flpFormasPago";
            flpFormasPago.Size = new Size(554, 545);
            flpFormasPago.TabIndex = 22;
            // 
            // DatosFormaPagoView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1642, 813);
            Controls.Add(flpFormasPago);
            Controls.Add(lblCant);
            Controls.Add(panel1);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAyer);
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
            Name = "DatosFormaPagoView";
            Text = "Datos FormaPago";
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            lblCant.ResumeLayout(false);
            lblCant.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnAyer;
        private DataGridView dgvVentas;
        private FontAwesome.Sharp.IconButton btnAnio;
        private FontAwesome.Sharp.IconButton btnMes;
        private FontAwesome.Sharp.IconButton btnSemana;
        private FontAwesome.Sharp.IconButton btnHoy;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Panel lblCant;
        private Label lblCantidadVentas;
        private Panel panel1;
        private Label lblTotalPeriodo;
        private FlowLayoutPanel flpFormasPago;
    }
}