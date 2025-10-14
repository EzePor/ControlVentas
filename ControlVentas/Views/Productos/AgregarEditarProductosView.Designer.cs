namespace ControlVentas.Views.Productos
{
    partial class AgregarEditarProductosView
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
            txtPrecio = new TextBox();
            label8 = new Label();
            label1 = new Label();
            labelNombre = new Label();
            cboRubro = new ComboBox();
            label3 = new Label();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            iconButtonGuardar = new FontAwesome.Sharp.IconButton();
            dgvProductos = new DataGridView();
            cmbNombreProducto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(393, 195);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(742, 32);
            txtPrecio.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(272, 193);
            label8.Name = "label8";
            label8.Size = new Size(63, 24);
            label8.TabIndex = 24;
            label8.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 151);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 20;
            label1.Text = "Rubro:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(261, 105);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(74, 24);
            labelNombre.TabIndex = 18;
            labelNombre.Text = "Nombre:";
            // 
            // cboRubro
            // 
            cboRubro.FormattingEnabled = true;
            cboRubro.Location = new Point(393, 146);
            cboRubro.Name = "cboRubro";
            cboRubro.Size = new Size(742, 29);
            cboRubro.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(510, 37);
            label3.Name = "label3";
            label3.Size = new Size(473, 57);
            label3.TabIndex = 27;
            label3.Text = "Agregar/Editar Producto";
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.BackColor = Color.Gray;
            iconButtonSalir.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonSalir.ForeColor = Color.White;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.Location = new Point(1146, 734);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Padding = new Padding(25, 0, 0, 0);
            iconButtonSalir.Size = new Size(254, 73);
            iconButtonSalir.TabIndex = 29;
            iconButtonSalir.Text = "Salir";
            iconButtonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSalir.UseVisualStyleBackColor = false;
            iconButtonSalir.Click += iconButtonSalir_Click;
            // 
            // iconButtonGuardar
            // 
            iconButtonGuardar.BackColor = Color.Blue;
            iconButtonGuardar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonGuardar.ForeColor = Color.White;
            iconButtonGuardar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonGuardar.IconColor = Color.White;
            iconButtonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonGuardar.Location = new Point(203, 731);
            iconButtonGuardar.Name = "iconButtonGuardar";
            iconButtonGuardar.Padding = new Padding(25, 0, 0, 0);
            iconButtonGuardar.Size = new Size(239, 67);
            iconButtonGuardar.TabIndex = 28;
            iconButtonGuardar.Text = "Guardar";
            iconButtonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonGuardar.UseVisualStyleBackColor = false;
            iconButtonGuardar.Click += iconButtonGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.GridColor = Color.White;
            dgvProductos.Location = new Point(203, 241);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1197, 476);
            dgvProductos.TabIndex = 30;
            // 
            // cmbNombreProducto
            // 
            cmbNombreProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbNombreProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbNombreProducto.FormattingEnabled = true;
            cmbNombreProducto.Location = new Point(400, 100);
            cmbNombreProducto.Name = "cmbNombreProducto";
            cmbNombreProducto.Size = new Size(735, 29);
            cmbNombreProducto.TabIndex = 31;
            // 
            // AgregarEditarProductosView
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1660, 850);
            Controls.Add(cmbNombreProducto);
            Controls.Add(dgvProductos);
            Controls.Add(iconButtonSalir);
            Controls.Add(iconButtonGuardar);
            Controls.Add(label3);
            Controls.Add(cboRubro);
            Controls.Add(txtPrecio);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(labelNombre);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarEditarProductosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarEditarProductosView";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecio;
        private Label label8;
        private Label label1;
        private Label labelNombre;
        private ComboBox cboRubro;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconButton iconButtonGuardar;
        private DataGridView dgvProductos;
        private ComboBox cmbNombreProducto;
    }
}