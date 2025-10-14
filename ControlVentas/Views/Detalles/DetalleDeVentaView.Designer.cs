namespace ControlVentas.Views.Detalles
{
    partial class DetalleDeVentaView
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
            lblFecha = new Label();
            lblTotal = new Label();
            dgvDetalle = new DataGridView();
            btnCerrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(110, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(60, 24);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(1088, 812);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 24);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total:";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.BackgroundColor = Color.FromArgb(192, 192, 255);
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.GridColor = Color.FromArgb(192, 192, 255);
            dgvDetalle.Location = new Point(56, 48);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(1561, 745);
            dgvDetalle.TabIndex = 2;
            // 
            // btnCerrar
            // 
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCerrar.IconColor = Color.Black;
            btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCerrar.Location = new Point(1481, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // DetalleDeVentaView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1660, 860);
            Controls.Add(btnCerrar);
            Controls.Add(dgvDetalle);
            Controls.Add(lblTotal);
            Controls.Add(lblFecha);
            Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DetalleDeVentaView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetallebDe Venta";
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblTotal;
        private DataGridView dgvDetalle;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}