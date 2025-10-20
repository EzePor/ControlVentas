using System;
using System.Windows.Forms;
using System.Drawing;
using FontAwesome.Sharp;

using System;
using System.Windows.Forms;
using System.Drawing;
using FontAwesome.Sharp;

namespace ControlVentas.Views.Datos
{
    partial class VentasPorDiaView
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
            btnFiltrar = new IconButton();
            btnAnio = new IconButton();
            btnMes = new IconButton();
            btnSemana = new IconButton();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            dgvPorDia = new DataGridView();
            lblCant = new Panel();
            lblCantidadVentas = new Label();
            panel1 = new Panel();
            lblTotalPeriodo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPorDia).BeginInit();
            lblCant.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.White;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.ForeColor = Color.FromArgb(192, 0, 0);
            btnFiltrar.IconChar = IconChar.Filter;
            btnFiltrar.IconColor = Color.FromArgb(192, 0, 0);
            btnFiltrar.IconFont = IconFont.Solid;
            btnFiltrar.IconSize = 30;
            btnFiltrar.Location = new Point(897, 16);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(122, 53);
            btnFiltrar.TabIndex = 26;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnAnio
            // 
            btnAnio.BackColor = Color.White;
            btnAnio.FlatStyle = FlatStyle.Flat;
            btnAnio.ForeColor = Color.Navy;
            btnAnio.IconChar = IconChar.None;
            btnAnio.IconColor = Color.Black;
            btnAnio.IconFont = IconFont.Auto;
            btnAnio.Location = new Point(564, 91);
            btnAnio.Name = "btnAnio";
            btnAnio.Size = new Size(94, 42);
            btnAnio.TabIndex = 25;
            btnAnio.Text = "Año";
            btnAnio.UseVisualStyleBackColor = false;
            // 
            // btnMes
            // 
            btnMes.BackColor = Color.White;
            btnMes.FlatStyle = FlatStyle.Flat;
            btnMes.ForeColor = Color.Green;
            btnMes.IconChar = IconChar.None;
            btnMes.IconColor = Color.Black;
            btnMes.IconFont = IconFont.Auto;
            btnMes.Location = new Point(338, 91);
            btnMes.Name = "btnMes";
            btnMes.Size = new Size(94, 42);
            btnMes.TabIndex = 24;
            btnMes.Text = "Mes";
            btnMes.UseVisualStyleBackColor = false;
            // 
            // btnSemana
            // 
            btnSemana.BackColor = Color.White;
            btnSemana.FlatStyle = FlatStyle.Flat;
            btnSemana.ForeColor = Color.Olive;
            btnSemana.IconChar = IconChar.None;
            btnSemana.IconColor = Color.Black;
            btnSemana.IconFont = IconFont.Auto;
            btnSemana.Location = new Point(135, 91);
            btnSemana.Name = "btnSemana";
            btnSemana.Size = new Size(94, 42);
            btnSemana.TabIndex = 23;
            btnSemana.Text = "Semana";
            btnSemana.UseVisualStyleBackColor = false;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(475, 24);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(347, 32);
            dtpHasta.TabIndex = 21;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(44, 24);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(369, 32);
            dtpDesde.TabIndex = 20;
            // 
            // dgvPorDia
            // 
            dgvPorDia.AllowUserToAddRows = false;
            dgvPorDia.AllowUserToDeleteRows = false;
            dgvPorDia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPorDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPorDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPorDia.Location = new Point(15, 137);
            dgvPorDia.Name = "dgvPorDia";
            dgvPorDia.ReadOnly = true;
            dgvPorDia.RowHeadersWidth = 51;
            dgvPorDia.Size = new Size(1653, 644);
            dgvPorDia.TabIndex = 27;
            // 
            // lblCant
            // 
            lblCant.Anchor = AnchorStyles.Bottom;
            lblCant.BackColor = Color.FromArgb(128, 128, 255);
            lblCant.Controls.Add(lblCantidadVentas);
            lblCant.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCant.Location = new Point(874, 791);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(430, 100);
            lblCant.TabIndex = 29;
            // 
            // lblCantidadVentas
            // 
            lblCantidadVentas.Anchor = AnchorStyles.Bottom;
            lblCantidadVentas.AutoSize = true;
            lblCantidadVentas.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadVentas.Location = new Point(36, 31);
            lblCantidadVentas.Name = "lblCantidadVentas";
            lblCantidadVentas.Size = new Size(0, 34);
            lblCantidadVentas.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom;
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(lblTotalPeriodo);
            panel1.Location = new Point(373, 784);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 109);
            panel1.TabIndex = 28;
            // 
            // lblTotalPeriodo
            // 
            lblTotalPeriodo.Anchor = AnchorStyles.Bottom;
            lblTotalPeriodo.AutoSize = true;
            lblTotalPeriodo.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPeriodo.Location = new Point(43, 42);
            lblTotalPeriodo.Name = "lblTotalPeriodo";
            lblTotalPeriodo.Size = new Size(0, 36);
            lblTotalPeriodo.TabIndex = 1;
            // 
            // VentasPorDiaView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1700, 900);
            Controls.Add(lblCant);
            Controls.Add(panel1);
            Controls.Add(dgvPorDia);
            Controls.Add(btnFiltrar);
            Controls.Add(btnAnio);
            Controls.Add(btnMes);
            Controls.Add(btnSemana);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "VentasPorDiaView";
            Text = "Ventas Por Día";
            ((System.ComponentModel.ISupportInitialize)dgvPorDia).EndInit();
            lblCant.ResumeLayout(false);
            lblCant.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnAnio;
        private FontAwesome.Sharp.IconButton btnMes;
        private FontAwesome.Sharp.IconButton btnSemana;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private DataGridView dgvPorDia;
        private Panel lblCant;
        private Label lblCantidadVentas;
        private Panel panel1;
        private Label lblTotalPeriodo;
    }
}