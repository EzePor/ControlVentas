namespace ControlVentas.Views.Gastos
{
    partial class AgregarGastoView
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
            dtpFecha = new DateTimePicker();
            txtDescripcion = new TextBox();
            txtMonto = new TextBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(394, 92);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(544, 32);
            dtpFecha.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(394, 188);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(544, 32);
            txtDescripcion.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(394, 281);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(544, 32);
            txtMonto.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(255, 128, 0);
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(398, 364);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(178, 66);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar gasto";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            btnSalir.IconColor = Color.White;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(785, 364);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(153, 66);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtMonto);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(dtpFecha);
            panel1.Location = new Point(69, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 579);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(448, 61);
            label1.Name = "label1";
            label1.Size = new Size(56, 24);
            label1.TabIndex = 5;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(438, 161);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 6;
            label2.Text = "Descripción";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(445, 247);
            label3.Name = "label3";
            label3.Size = new Size(57, 24);
            label3.TabIndex = 7;
            label3.Text = "Monto";
            // 
            // AgregarGastoView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1660, 860);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarGastoView";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "agregarGastoView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFecha;
        private TextBox txtDescripcion;
        private TextBox txtMonto;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}