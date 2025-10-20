namespace ControlVentas

{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalView));
            panelMenu = new Panel();
            btnResumenPorDia = new FontAwesome.Sharp.IconButton();
            btnDatosPagos = new FontAwesome.Sharp.IconButton();
            btnEstadisticasVentas = new FontAwesome.Sharp.IconButton();
            btnBalance = new FontAwesome.Sharp.IconButton();
            btnGastos = new FontAwesome.Sharp.IconButton();
            btnResumenVentas = new FontAwesome.Sharp.IconButton();
            iconButtonProductos = new FontAwesome.Sharp.IconButton();
            iconButtonVentaDetalle = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnInicio = new PictureBox();
            panel1 = new Panel();
            panelTituloMenu = new Panel();
            btnCerrarApp = new FontAwesome.Sharp.IconButton();
            labelTituloChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnInicio).BeginInit();
            panelTituloMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(btnResumenPorDia);
            panelMenu.Controls.Add(btnDatosPagos);
            panelMenu.Controls.Add(btnEstadisticasVentas);
            panelMenu.Controls.Add(btnBalance);
            panelMenu.Controls.Add(btnGastos);
            panelMenu.Controls.Add(btnResumenVentas);
            panelMenu.Controls.Add(iconButtonProductos);
            panelMenu.Controls.Add(iconButtonVentaDetalle);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(259, 921);
            panelMenu.TabIndex = 0;
            // 
            // btnResumenPorDia
            // 
            btnResumenPorDia.BackColor = Color.FromArgb(64, 64, 64);
            btnResumenPorDia.Dock = DockStyle.Top;
            btnResumenPorDia.FlatAppearance.BorderSize = 0;
            btnResumenPorDia.FlatStyle = FlatStyle.Flat;
            btnResumenPorDia.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResumenPorDia.ForeColor = Color.White;
            btnResumenPorDia.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            btnResumenPorDia.IconColor = Color.White;
            btnResumenPorDia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResumenPorDia.IconSize = 40;
            btnResumenPorDia.Location = new Point(0, 769);
            btnResumenPorDia.Margin = new Padding(3, 38, 3, 6);
            btnResumenPorDia.Name = "btnResumenPorDia";
            btnResumenPorDia.Padding = new Padding(11, 0, 22, 0);
            btnResumenPorDia.RightToLeft = RightToLeft.No;
            btnResumenPorDia.Size = new Size(259, 88);
            btnResumenPorDia.TabIndex = 8;
            btnResumenPorDia.TabStop = false;
            btnResumenPorDia.Text = "Resumen por día";
            btnResumenPorDia.TextAlign = ContentAlignment.MiddleLeft;
            btnResumenPorDia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResumenPorDia.UseVisualStyleBackColor = false;
            btnResumenPorDia.Click += btnResumenPorDia_Click;
            // 
            // btnDatosPagos
            // 
            btnDatosPagos.BackColor = Color.FromArgb(64, 64, 64);
            btnDatosPagos.Dock = DockStyle.Top;
            btnDatosPagos.FlatAppearance.BorderSize = 0;
            btnDatosPagos.FlatStyle = FlatStyle.Flat;
            btnDatosPagos.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDatosPagos.ForeColor = Color.White;
            btnDatosPagos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnDatosPagos.IconColor = Color.White;
            btnDatosPagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDatosPagos.IconSize = 40;
            btnDatosPagos.Location = new Point(0, 681);
            btnDatosPagos.Margin = new Padding(3, 38, 3, 6);
            btnDatosPagos.Name = "btnDatosPagos";
            btnDatosPagos.Padding = new Padding(11, 0, 22, 0);
            btnDatosPagos.RightToLeft = RightToLeft.No;
            btnDatosPagos.Size = new Size(259, 88);
            btnDatosPagos.TabIndex = 7;
            btnDatosPagos.Text = "Datos Forma de Pago";
            btnDatosPagos.TextAlign = ContentAlignment.MiddleLeft;
            btnDatosPagos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDatosPagos.UseVisualStyleBackColor = false;
            btnDatosPagos.Click += btnDatosPagos_Click;
            // 
            // btnEstadisticasVentas
            // 
            btnEstadisticasVentas.BackColor = Color.FromArgb(64, 64, 64);
            btnEstadisticasVentas.Dock = DockStyle.Top;
            btnEstadisticasVentas.FlatAppearance.BorderSize = 0;
            btnEstadisticasVentas.FlatStyle = FlatStyle.Flat;
            btnEstadisticasVentas.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstadisticasVentas.ForeColor = Color.White;
            btnEstadisticasVentas.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            btnEstadisticasVentas.IconColor = Color.White;
            btnEstadisticasVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEstadisticasVentas.IconSize = 40;
            btnEstadisticasVentas.Location = new Point(0, 593);
            btnEstadisticasVentas.Margin = new Padding(3, 38, 3, 6);
            btnEstadisticasVentas.Name = "btnEstadisticasVentas";
            btnEstadisticasVentas.Padding = new Padding(11, 0, 22, 0);
            btnEstadisticasVentas.RightToLeft = RightToLeft.No;
            btnEstadisticasVentas.Size = new Size(259, 88);
            btnEstadisticasVentas.TabIndex = 6;
            btnEstadisticasVentas.Text = "Estadísticas Ventas";
            btnEstadisticasVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnEstadisticasVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstadisticasVentas.UseVisualStyleBackColor = false;
            btnEstadisticasVentas.Click += btnEstadisticasVentas_Click;
            // 
            // btnBalance
            // 
            btnBalance.BackColor = Color.FromArgb(64, 64, 64);
            btnBalance.Dock = DockStyle.Top;
            btnBalance.FlatAppearance.BorderSize = 0;
            btnBalance.FlatStyle = FlatStyle.Flat;
            btnBalance.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBalance.ForeColor = Color.White;
            btnBalance.IconChar = FontAwesome.Sharp.IconChar.ScaleBalanced;
            btnBalance.IconColor = Color.White;
            btnBalance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBalance.IconSize = 40;
            btnBalance.Location = new Point(0, 505);
            btnBalance.Margin = new Padding(3, 38, 3, 6);
            btnBalance.Name = "btnBalance";
            btnBalance.Padding = new Padding(11, 0, 22, 0);
            btnBalance.RightToLeft = RightToLeft.No;
            btnBalance.Size = new Size(259, 88);
            btnBalance.TabIndex = 5;
            btnBalance.Text = "Balance";
            btnBalance.TextAlign = ContentAlignment.MiddleLeft;
            btnBalance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBalance.UseVisualStyleBackColor = false;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnGastos
            // 
            btnGastos.BackColor = Color.FromArgb(64, 64, 64);
            btnGastos.Dock = DockStyle.Top;
            btnGastos.FlatAppearance.BorderSize = 0;
            btnGastos.FlatStyle = FlatStyle.Flat;
            btnGastos.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGastos.ForeColor = Color.White;
            btnGastos.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            btnGastos.IconColor = Color.White;
            btnGastos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGastos.IconSize = 40;
            btnGastos.Location = new Point(0, 417);
            btnGastos.Margin = new Padding(3, 38, 3, 6);
            btnGastos.Name = "btnGastos";
            btnGastos.Padding = new Padding(11, 0, 22, 0);
            btnGastos.RightToLeft = RightToLeft.No;
            btnGastos.Size = new Size(259, 88);
            btnGastos.TabIndex = 4;
            btnGastos.Text = "Gastos";
            btnGastos.TextAlign = ContentAlignment.MiddleLeft;
            btnGastos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGastos.UseVisualStyleBackColor = false;
            btnGastos.Click += btnGastos_Click;
            // 
            // btnResumenVentas
            // 
            btnResumenVentas.BackColor = Color.FromArgb(64, 64, 64);
            btnResumenVentas.Dock = DockStyle.Top;
            btnResumenVentas.FlatAppearance.BorderSize = 0;
            btnResumenVentas.FlatStyle = FlatStyle.Flat;
            btnResumenVentas.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResumenVentas.ForeColor = Color.White;
            btnResumenVentas.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            btnResumenVentas.IconColor = Color.White;
            btnResumenVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnResumenVentas.IconSize = 40;
            btnResumenVentas.Location = new Point(0, 329);
            btnResumenVentas.Margin = new Padding(3, 38, 3, 6);
            btnResumenVentas.Name = "btnResumenVentas";
            btnResumenVentas.Padding = new Padding(11, 0, 22, 0);
            btnResumenVentas.RightToLeft = RightToLeft.No;
            btnResumenVentas.Size = new Size(259, 88);
            btnResumenVentas.TabIndex = 3;
            btnResumenVentas.Text = "Resumen Ventas";
            btnResumenVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnResumenVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnResumenVentas.UseVisualStyleBackColor = false;
            btnResumenVentas.Click += btnResumenVentas_Click;
            // 
            // iconButtonProductos
            // 
            iconButtonProductos.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonProductos.Dock = DockStyle.Top;
            iconButtonProductos.FlatAppearance.BorderSize = 0;
            iconButtonProductos.FlatStyle = FlatStyle.Flat;
            iconButtonProductos.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonProductos.ForeColor = Color.White;
            iconButtonProductos.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
            iconButtonProductos.IconColor = Color.White;
            iconButtonProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonProductos.IconSize = 40;
            iconButtonProductos.Location = new Point(0, 241);
            iconButtonProductos.Margin = new Padding(3, 38, 3, 6);
            iconButtonProductos.Name = "iconButtonProductos";
            iconButtonProductos.Padding = new Padding(11, 0, 22, 0);
            iconButtonProductos.RightToLeft = RightToLeft.No;
            iconButtonProductos.Size = new Size(259, 88);
            iconButtonProductos.TabIndex = 2;
            iconButtonProductos.Text = "Productos";
            iconButtonProductos.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonProductos.UseVisualStyleBackColor = false;
            iconButtonProductos.Click += iconButtonProductos_Click;
            // 
            // iconButtonVentaDetalle
            // 
            iconButtonVentaDetalle.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonVentaDetalle.Dock = DockStyle.Top;
            iconButtonVentaDetalle.FlatAppearance.BorderSize = 0;
            iconButtonVentaDetalle.FlatStyle = FlatStyle.Flat;
            iconButtonVentaDetalle.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonVentaDetalle.ForeColor = Color.White;
            iconButtonVentaDetalle.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            iconButtonVentaDetalle.IconColor = Color.White;
            iconButtonVentaDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonVentaDetalle.IconSize = 40;
            iconButtonVentaDetalle.Location = new Point(0, 153);
            iconButtonVentaDetalle.Margin = new Padding(3, 38, 3, 6);
            iconButtonVentaDetalle.Name = "iconButtonVentaDetalle";
            iconButtonVentaDetalle.Padding = new Padding(11, 0, 22, 0);
            iconButtonVentaDetalle.RightToLeft = RightToLeft.No;
            iconButtonVentaDetalle.Size = new Size(259, 88);
            iconButtonVentaDetalle.TabIndex = 1;
            iconButtonVentaDetalle.Text = "Venta";
            iconButtonVentaDetalle.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonVentaDetalle.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonVentaDetalle.UseVisualStyleBackColor = false;
            iconButtonVentaDetalle.Click += iconButtonVentaDetalle_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInicio);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 153);
            panel2.TabIndex = 0;
            // 
            // btnInicio
            // 
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.Location = new Point(14, 13);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(238, 121);
            btnInicio.SizeMode = PictureBoxSizeMode.Zoom;
            btnInicio.TabIndex = 0;
            btnInicio.TabStop = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(259, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 921);
            panel1.TabIndex = 1;
            // 
            // panelTituloMenu
            // 
            panelTituloMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelTituloMenu.Controls.Add(btnCerrarApp);
            panelTituloMenu.Controls.Add(labelTituloChildForm);
            panelTituloMenu.Controls.Add(iconCurrentChildForm);
            panelTituloMenu.Dock = DockStyle.Top;
            panelTituloMenu.Location = new Point(269, 0);
            panelTituloMenu.Name = "panelTituloMenu";
            panelTituloMenu.Size = new Size(1188, 88);
            panelTituloMenu.TabIndex = 2;
            // 
            // btnCerrarApp
            // 
            btnCerrarApp.BackColor = Color.FromArgb(64, 64, 64);
            btnCerrarApp.FlatStyle = FlatStyle.Flat;
            btnCerrarApp.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btnCerrarApp.IconColor = Color.White;
            btnCerrarApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrarApp.IconSize = 52;
            btnCerrarApp.Location = new Point(1550, 22);
            btnCerrarApp.Name = "btnCerrarApp";
            btnCerrarApp.Size = new Size(63, 60);
            btnCerrarApp.TabIndex = 2;
            btnCerrarApp.UseVisualStyleBackColor = false;
            btnCerrarApp.Click += btnCerrarApp_Click;
            // 
            // labelTituloChildForm
            // 
            labelTituloChildForm.AutoSize = true;
            labelTituloChildForm.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTituloChildForm.ForeColor = Color.White;
            labelTituloChildForm.Location = new Point(96, 24);
            labelTituloChildForm.Name = "labelTituloChildForm";
            labelTituloChildForm.Size = new Size(85, 36);
            labelTituloChildForm.TabIndex = 1;
            labelTituloChildForm.Text = "INICIO";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(64, 64, 64);
            iconCurrentChildForm.ForeColor = Color.FromArgb(255, 128, 0);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.FromArgb(255, 128, 0);
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 60;
            iconCurrentChildForm.Location = new Point(17, 13);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(72, 60);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(269, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(1188, 10);
            panel3.TabIndex = 3;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.Black;
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(269, 98);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1188, 823);
            panelDesktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(261, 185);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1457, 921);
            Controls.Add(panelDesktop);
            Controls.Add(panel3);
            Controls.Add(panelTituloMenu);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Font = new Font("Bahnschrift SemiBold SemiConden", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTIÓN DE NEGOCIO";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnInicio).EndInit();
            panelTituloMenu.ResumeLayout(false);
            panelTituloMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel2;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonVentaDetalle;
        private FontAwesome.Sharp.IconButton btnResumenPorDia;
        private FontAwesome.Sharp.IconButton btnDatosPagos;
        private FontAwesome.Sharp.IconButton btnEstadisticasVentas;
        private FontAwesome.Sharp.IconButton btnBalance;
        private FontAwesome.Sharp.IconButton btnGastos;
        private FontAwesome.Sharp.IconButton btnResumenVentas;
        private FontAwesome.Sharp.IconButton iconButtonProductos;
        private PictureBox btnInicio;
        private Panel panelTituloMenu;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label labelTituloChildForm;
        private Panel panel3;
        private Panel panelDesktop;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCerrarApp;
    }
}
