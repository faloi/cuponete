﻿namespace GrouponDesktop.Views
{
    partial class CargarCredito
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
            this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.labelFormaDePago = new System.Windows.Forms.Label();
            this.textBoxNroTarjeta = new System.Windows.Forms.TextBox();
            this.labelNroDeTarjeta = new System.Windows.Forms.Label();
            this.textBoxCodDeSeg = new System.Windows.Forms.TextBox();
            this.labelCodDeSeg = new System.Windows.Forms.Label();
            this.labelFechaVto = new System.Windows.Forms.Label();
            this.textBoxFechaVto = new System.Windows.Forms.TextBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Location = new System.Drawing.Point(16, 33);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(207, 21);
            this.comboBoxFormaPago.TabIndex = 0;
            // 
            // labelFormaDePago
            // 
            this.labelFormaDePago.AutoSize = true;
            this.labelFormaDePago.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormaDePago.Location = new System.Drawing.Point(12, 9);
            this.labelFormaDePago.Name = "labelFormaDePago";
            this.labelFormaDePago.Size = new System.Drawing.Size(112, 21);
            this.labelFormaDePago.TabIndex = 1;
            this.labelFormaDePago.Text = "Forma de Pago";
            // 
            // textBoxNroTarjeta
            // 
            this.textBoxNroTarjeta.Location = new System.Drawing.Point(16, 87);
            this.textBoxNroTarjeta.Name = "textBoxNroTarjeta";
            this.textBoxNroTarjeta.Size = new System.Drawing.Size(207, 20);
            this.textBoxNroTarjeta.TabIndex = 2;
            // 
            // labelNroDeTarjeta
            // 
            this.labelNroDeTarjeta.AutoSize = true;
            this.labelNroDeTarjeta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroDeTarjeta.Location = new System.Drawing.Point(12, 63);
            this.labelNroDeTarjeta.Name = "labelNroDeTarjeta";
            this.labelNroDeTarjeta.Size = new System.Drawing.Size(135, 21);
            this.labelNroDeTarjeta.TabIndex = 3;
            this.labelNroDeTarjeta.Text = "Numero de Tarjeta";
            // 
            // textBoxCodDeSeg
            // 
            this.textBoxCodDeSeg.Location = new System.Drawing.Point(16, 139);
            this.textBoxCodDeSeg.Name = "textBoxCodDeSeg";
            this.textBoxCodDeSeg.Size = new System.Drawing.Size(69, 20);
            this.textBoxCodDeSeg.TabIndex = 4;
            // 
            // labelCodDeSeg
            // 
            this.labelCodDeSeg.AutoSize = true;
            this.labelCodDeSeg.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodDeSeg.Location = new System.Drawing.Point(12, 115);
            this.labelCodDeSeg.Name = "labelCodDeSeg";
            this.labelCodDeSeg.Size = new System.Drawing.Size(152, 21);
            this.labelCodDeSeg.TabIndex = 5;
            this.labelCodDeSeg.Text = "Codigo de Seguridad";
            // 
            // labelFechaVto
            // 
            this.labelFechaVto.AutoSize = true;
            this.labelFechaVto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaVto.Location = new System.Drawing.Point(12, 172);
            this.labelFechaVto.Name = "labelFechaVto";
            this.labelFechaVto.Size = new System.Drawing.Size(158, 21);
            this.labelFechaVto.TabIndex = 6;
            this.labelFechaVto.Text = "Fecha de Vencimiento";
            // 
            // textBoxFechaVto
            // 
            this.textBoxFechaVto.Location = new System.Drawing.Point(16, 196);
            this.textBoxFechaVto.Name = "textBoxFechaVto";
            this.textBoxFechaVto.Size = new System.Drawing.Size(207, 20);
            this.textBoxFechaVto.TabIndex = 7;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(16, 252);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(207, 20);
            this.textBoxMonto.TabIndex = 8;
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(12, 228);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(55, 21);
            this.labelMonto.TabIndex = 9;
            this.labelMonto.Text = "Monto";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.Location = new System.Drawing.Point(16, 286);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(207, 36);
            this.buttonCargar.TabIndex = 10;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            // 
            // CargarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 334);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.textBoxMonto);
            this.Controls.Add(this.textBoxFechaVto);
            this.Controls.Add(this.labelFechaVto);
            this.Controls.Add(this.labelCodDeSeg);
            this.Controls.Add(this.textBoxCodDeSeg);
            this.Controls.Add(this.labelNroDeTarjeta);
            this.Controls.Add(this.textBoxNroTarjeta);
            this.Controls.Add(this.labelFormaDePago);
            this.Controls.Add(this.comboBoxFormaPago);
            this.Name = "CargarCredito";
            this.Text = "CargarCredito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFormaPago;
        private System.Windows.Forms.Label labelFormaDePago;
        private System.Windows.Forms.TextBox textBoxNroTarjeta;
        private System.Windows.Forms.Label labelNroDeTarjeta;
        private System.Windows.Forms.TextBox textBoxCodDeSeg;
        private System.Windows.Forms.Label labelCodDeSeg;
        private System.Windows.Forms.Label labelFechaVto;
        private System.Windows.Forms.TextBox textBoxFechaVto;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Button buttonCargar;
    }
}