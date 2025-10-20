namespace ControlVentas.Views.Productos
{
    partial class ProductosView
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
            BtnBuscarProducto = new FontAwesome.Sharp.IconButton();
            textBoxBuscarProducto = new TextBox();
            dataGridViewProductos = new DataGridView();
            iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            iconButtonEditar = new FontAwesome.Sharp.IconButton();
            comboBoxRubro = new ComboBox();
            btnLimpiarBusqueda = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            comboBoxOrden = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscarProducto
            // 
            BtnBuscarProducto.BackColor = Color.FromArgb(255, 128, 0);
            BtnBuscarProducto.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarProducto.ForeColor = Color.White;
            BtnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscarProducto.IconColor = Color.White;
            BtnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarProducto.IconSize = 25;
            BtnBuscarProducto.Location = new Point(511, 97);
            BtnBuscarProducto.Name = "BtnBuscarProducto";
            BtnBuscarProducto.Size = new Size(126, 46);
            BtnBuscarProducto.TabIndex = 11;
            BtnBuscarProducto.Text = "&Buscar";
            BtnBuscarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscarProducto.UseVisualStyleBackColor = false;
            BtnBuscarProducto.Click += BtnBuscarProducto_Click;
            // 
            // textBoxBuscarProducto
            // 
            textBoxBuscarProducto.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBuscarProducto.Location = new Point(82, 33);
            textBoxBuscarProducto.Name = "textBoxBuscarProducto";
            textBoxBuscarProducto.Size = new Size(1212, 32);
            textBoxBuscarProducto.TabIndex = 10;
            textBoxBuscarProducto.TextChanged += textBoxBuscarProducto_TextChanged;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewProductos.BorderStyle = BorderStyle.None;
            dataGridViewProductos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProductos.Location = new Point(42, 149);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(1630, 665);
            dataGridViewProductos.TabIndex = 8;
            // 
            // iconButtonEliminar
            // 
            iconButtonEliminar.Anchor = AnchorStyles.Bottom;
            iconButtonEliminar.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonEliminar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonEliminar.ForeColor = Color.Red;
            iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButtonEliminar.IconColor = Color.Red;
            iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEliminar.Location = new Point(1471, 825);
            iconButtonEliminar.Name = "iconButtonEliminar";
            iconButtonEliminar.Size = new Size(181, 63);
            iconButtonEliminar.TabIndex = 14;
            iconButtonEliminar.Text = "Eliminar";
            iconButtonEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonEliminar.UseVisualStyleBackColor = false;
            iconButtonEliminar.Click += iconButtonEliminar_Click;
            // 
            // iconButtonAgregar
            // 
            iconButtonAgregar.Anchor = AnchorStyles.Bottom;
            iconButtonAgregar.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonAgregar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonAgregar.ForeColor = Color.FromArgb(0, 192, 0);
            iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonAgregar.IconColor = Color.FromArgb(0, 192, 0);
            iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAgregar.Location = new Point(145, 820);
            iconButtonAgregar.Name = "iconButtonAgregar";
            iconButtonAgregar.Size = new Size(233, 63);
            iconButtonAgregar.TabIndex = 12;
            iconButtonAgregar.Text = "Agregar";
            iconButtonAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonAgregar.UseVisualStyleBackColor = false;
            iconButtonAgregar.Click += iconButtonAgregar_Click;
            // 
            // iconButtonEditar
            // 
            iconButtonEditar.Anchor = AnchorStyles.Bottom;
            iconButtonEditar.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonEditar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonEditar.ForeColor = Color.Blue;
            iconButtonEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButtonEditar.IconColor = Color.Blue;
            iconButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditar.Location = new Point(521, 820);
            iconButtonEditar.Name = "iconButtonEditar";
            iconButtonEditar.Size = new Size(179, 63);
            iconButtonEditar.TabIndex = 15;
            iconButtonEditar.Text = "Editar";
            iconButtonEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonEditar.UseVisualStyleBackColor = false;
            iconButtonEditar.Click += iconButtonEditar_Click;
            // 
            // comboBoxRubro
            // 
            comboBoxRubro.FormattingEnabled = true;
            comboBoxRubro.Location = new Point(91, 103);
            comboBoxRubro.Name = "comboBoxRubro";
            comboBoxRubro.Size = new Size(373, 30);
            comboBoxRubro.TabIndex = 16;
            // 
            // btnLimpiarBusqueda
            // 
            btnLimpiarBusqueda.BackColor = Color.White;
            btnLimpiarBusqueda.ForeColor = Color.FromArgb(192, 0, 0);
            btnLimpiarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Brush;
            btnLimpiarBusqueda.IconColor = Color.FromArgb(192, 0, 0);
            btnLimpiarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarBusqueda.IconSize = 35;
            btnLimpiarBusqueda.Location = new Point(1157, 83);
            btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            btnLimpiarBusqueda.Size = new Size(137, 49);
            btnLimpiarBusqueda.TabIndex = 17;
            btnLimpiarBusqueda.Text = "Limpiar";
            btnLimpiarBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            btnLimpiarBusqueda.Click += btnLimpiarBusqueda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(145, 8);
            label1.Name = "label1";
            label1.Size = new Size(121, 22);
            label1.TabIndex = 18;
            label1.Text = "Filtrar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(124, 78);
            label2.Name = "label2";
            label2.Size = new Size(129, 22);
            label2.TabIndex = 19;
            label2.Text = "Filtrar por Rubro";
            // 
            // comboBoxOrden
            // 
            comboBoxOrden.FormattingEnabled = true;
            comboBoxOrden.Items.AddRange(new object[] { "A-Z", "Z-A" });
            comboBoxOrden.Location = new Point(765, 102);
            comboBoxOrden.Name = "comboBoxOrden";
            comboBoxOrden.Size = new Size(236, 30);
            comboBoxOrden.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(774, 78);
            label3.Name = "label3";
            label3.Size = new Size(132, 22);
            label3.TabIndex = 24;
            label3.Text = "Orden  alfabético:";
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1700, 900);
            Controls.Add(label3);
            Controls.Add(comboBoxOrden);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiarBusqueda);
            Controls.Add(comboBoxRubro);
            Controls.Add(iconButtonEditar);
            Controls.Add(iconButtonEliminar);
            Controls.Add(iconButtonAgregar);
            Controls.Add(BtnBuscarProducto);
            Controls.Add(textBoxBuscarProducto);
            Controls.Add(dataGridViewProductos);
            Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductosView";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBuscarProducto;
        private TextBox textBoxBuscarProducto;
        private DataGridView dataGridViewProductos;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private ComboBox comboBoxRubro;
        private FontAwesome.Sharp.IconButton btnLimpiarBusqueda;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxOrden;
        private Label label3;
    }
}