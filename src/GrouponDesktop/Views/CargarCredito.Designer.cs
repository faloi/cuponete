namespace GrouponDesktop.Views
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
            this.labelMonto = new System.Windows.Forms.Label();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMonto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Location = new System.Drawing.Point(16, 33);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(242, 21);
            this.comboBoxFormaPago.TabIndex = 0;
            this.comboBoxFormaPago.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormaPago_SelectedIndexChanged);
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
            this.textBoxNroTarjeta.Location = new System.Drawing.Point(10, 40);
            this.textBoxNroTarjeta.MaxLength = 15;
            this.textBoxNroTarjeta.Name = "textBoxNroTarjeta";
            this.textBoxNroTarjeta.Size = new System.Drawing.Size(224, 20);
            this.textBoxNroTarjeta.TabIndex = 1;
            this.textBoxNroTarjeta.TextChanged += new System.EventHandler(this.textBoxNroTarjeta_TextChanged);
            // 
            // labelNroDeTarjeta
            // 
            this.labelNroDeTarjeta.AutoSize = true;
            this.labelNroDeTarjeta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroDeTarjeta.Location = new System.Drawing.Point(6, 16);
            this.labelNroDeTarjeta.Name = "labelNroDeTarjeta";
            this.labelNroDeTarjeta.Size = new System.Drawing.Size(135, 21);
            this.labelNroDeTarjeta.TabIndex = 3;
            this.labelNroDeTarjeta.Text = "Numero de Tarjeta";
            // 
            // textBoxCodDeSeg
            // 
            this.textBoxCodDeSeg.Location = new System.Drawing.Point(10, 92);
            this.textBoxCodDeSeg.MaxLength = 3;
            this.textBoxCodDeSeg.Name = "textBoxCodDeSeg";
            this.textBoxCodDeSeg.Size = new System.Drawing.Size(69, 20);
            this.textBoxCodDeSeg.TabIndex = 2;
            // 
            // labelCodDeSeg
            // 
            this.labelCodDeSeg.AutoSize = true;
            this.labelCodDeSeg.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodDeSeg.Location = new System.Drawing.Point(6, 68);
            this.labelCodDeSeg.Name = "labelCodDeSeg";
            this.labelCodDeSeg.Size = new System.Drawing.Size(152, 21);
            this.labelCodDeSeg.TabIndex = 5;
            this.labelCodDeSeg.Text = "Codigo de Seguridad";
            // 
            // labelFechaVto
            // 
            this.labelFechaVto.AutoSize = true;
            this.labelFechaVto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaVto.Location = new System.Drawing.Point(6, 125);
            this.labelFechaVto.Name = "labelFechaVto";
            this.labelFechaVto.Size = new System.Drawing.Size(236, 21);
            this.labelFechaVto.TabIndex = 6;
            this.labelFechaVto.Text = "Fecha de Vencimiento (mm/aaaa)";
            // 
            // textBoxFechaVto
            // 
            this.textBoxFechaVto.Location = new System.Drawing.Point(10, 149);
            this.textBoxFechaVto.MaxLength = 7;
            this.textBoxFechaVto.Name = "textBoxFechaVto";
            this.textBoxFechaVto.Size = new System.Drawing.Size(224, 20);
            this.textBoxFechaVto.TabIndex = 3;
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(12, 260);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(77, 21);
            this.labelMonto.TabIndex = 9;
            this.labelMonto.Text = "Monto ($)";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.Location = new System.Drawing.Point(16, 318);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(242, 36);
            this.buttonCargar.TabIndex = 5;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(80, 369);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 29);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNroDeTarjeta);
            this.groupBox1.Controls.Add(this.textBoxNroTarjeta);
            this.groupBox1.Controls.Add(this.textBoxCodDeSeg);
            this.groupBox1.Controls.Add(this.labelCodDeSeg);
            this.groupBox1.Controls.Add(this.labelFechaVto);
            this.groupBox1.Controls.Add(this.textBoxFechaVto);
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 191);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Tarjeta";
            // 
            // comboBoxMonto
            // 
            this.comboBoxMonto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonto.FormattingEnabled = true;
            this.comboBoxMonto.Location = new System.Drawing.Point(16, 284);
            this.comboBoxMonto.Name = "comboBoxMonto";
            this.comboBoxMonto.Size = new System.Drawing.Size(242, 21);
            this.comboBoxMonto.TabIndex = 12;
            // 
            // CargarCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 410);
            this.Controls.Add(this.comboBoxMonto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelFormaDePago);
            this.Controls.Add(this.comboBoxFormaPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CargarCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Credito";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMonto;
    }
}