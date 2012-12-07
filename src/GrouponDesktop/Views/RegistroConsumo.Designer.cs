namespace GrouponDesktop.Views
{
    partial class RegistroConsumo
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
            this.labelRegistroCupon = new System.Windows.Forms.Label();
            this.labelNroDeCupon = new System.Windows.Forms.Label();
            this.textBoxNroCupon = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRegistroCupon
            // 
            this.labelRegistroCupon.AutoSize = true;
            this.labelRegistroCupon.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroCupon.Location = new System.Drawing.Point(12, 9);
            this.labelRegistroCupon.Name = "labelRegistroCupon";
            this.labelRegistroCupon.Size = new System.Drawing.Size(205, 74);
            this.labelRegistroCupon.TabIndex = 1;
            this.labelRegistroCupon.Text = "Registrar Cupón \r\nConsumido";
            this.labelRegistroCupon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNroDeCupon
            // 
            this.labelNroDeCupon.AutoSize = true;
            this.labelNroDeCupon.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroDeCupon.Location = new System.Drawing.Point(44, 95);
            this.labelNroDeCupon.Name = "labelNroDeCupon";
            this.labelNroDeCupon.Size = new System.Drawing.Size(136, 21);
            this.labelNroDeCupon.TabIndex = 5;
            this.labelNroDeCupon.Text = "Numero de Cupón";
            // 
            // textBoxNroCupon
            // 
            this.textBoxNroCupon.Location = new System.Drawing.Point(9, 119);
            this.textBoxNroCupon.Name = "textBoxNroCupon";
            this.textBoxNroCupon.Size = new System.Drawing.Size(207, 20);
            this.textBoxNroCupon.TabIndex = 1;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.Location = new System.Drawing.Point(9, 161);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(207, 36);
            this.buttonRegistrar.TabIndex = 2;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(58, 221);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 29);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // RegistroConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 262);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.labelNroDeCupon);
            this.Controls.Add(this.textBoxNroCupon);
            this.Controls.Add(this.labelRegistroCupon);
            this.Name = "RegistroConsumo";
            this.Text = "RegistroConsumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegistroCupon;
        private System.Windows.Forms.Label labelNroDeCupon;
        private System.Windows.Forms.TextBox textBoxNroCupon;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}