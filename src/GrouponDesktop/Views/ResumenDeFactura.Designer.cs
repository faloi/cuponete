namespace GrouponDesktop.Views
{
    partial class ResumenDeFactura
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
            this.labelProveedor = new System.Windows.Forms.Label();
            this.numeroFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.montoTotal = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.Location = new System.Drawing.Point(67, 9);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(248, 37);
            this.labelProveedor.TabIndex = 30;
            this.labelProveedor.Text = "Resumen De Factura";
            // 
            // numeroFactura
            // 
            this.numeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeroFactura.Location = new System.Drawing.Point(168, 78);
            this.numeroFactura.Name = "numeroFactura";
            this.numeroFactura.ReadOnly = true;
            this.numeroFactura.Size = new System.Drawing.Size(157, 20);
            this.numeroFactura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "N° Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Monto Total";
            // 
            // montoTotal
            // 
            this.montoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.montoTotal.Location = new System.Drawing.Point(168, 105);
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            this.montoTotal.Size = new System.Drawing.Size(157, 20);
            this.montoTotal.TabIndex = 2;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(129, 166);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(140, 29);
            this.buttonAceptar.TabIndex = 3;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // ResumenDeFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 217);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.montoTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.numeroFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ResumenDeFactura";
            this.Text = "ResumenDeFactura";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.TextBox numeroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox montoTotal;
        private System.Windows.Forms.Button buttonAceptar;
    }
}