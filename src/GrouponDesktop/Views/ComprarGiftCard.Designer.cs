namespace GrouponDesktop.Views
{
    partial class ComprarGiftCard
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
            this.comboBoxMontos = new System.Windows.Forms.ComboBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.labelUsrDestino = new System.Windows.Forms.Label();
            this.textBoxNomUsua = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMontos
            // 
            this.comboBoxMontos.FormattingEnabled = true;
            this.comboBoxMontos.Location = new System.Drawing.Point(16, 33);
            this.comboBoxMontos.Name = "comboBoxMontos";
            this.comboBoxMontos.Size = new System.Drawing.Size(176, 21);
            this.comboBoxMontos.TabIndex = 0;
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(12, 9);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(77, 21);
            this.labelMonto.TabIndex = 1;
            this.labelMonto.Text = "Monto ($)";
            // 
            // buttonComprar
            // 
            this.buttonComprar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComprar.Location = new System.Drawing.Point(16, 180);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(176, 36);
            this.buttonComprar.TabIndex = 2;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            // 
            // labelUsrDestino
            // 
            this.labelUsrDestino.AutoSize = true;
            this.labelUsrDestino.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsrDestino.Location = new System.Drawing.Point(42, 70);
            this.labelUsrDestino.Name = "labelUsrDestino";
            this.labelUsrDestino.Size = new System.Drawing.Size(122, 30);
            this.labelUsrDestino.TabIndex = 2;
            this.labelUsrDestino.Text = "Destinatario";
            // 
            // textBoxNomUsua
            // 
            this.textBoxNomUsua.Location = new System.Drawing.Point(16, 133);
            this.textBoxNomUsua.Name = "textBoxNomUsua";
            this.textBoxNomUsua.Size = new System.Drawing.Size(176, 20);
            this.textBoxNomUsua.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(12, 109);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(140, 21);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre de Usuario";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(50, 242);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 29);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // ComprarGiftCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 283);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxNomUsua);
            this.Controls.Add(this.labelUsrDestino);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.comboBoxMontos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ComprarGiftCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Gift Card";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMontos;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Label labelUsrDestino;
        private System.Windows.Forms.TextBox textBoxNomUsua;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonCancelar;
    }
}