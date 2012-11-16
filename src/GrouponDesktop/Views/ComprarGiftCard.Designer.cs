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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelUsrDestino = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(12, 9);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(55, 21);
            this.labelMonto.TabIndex = 1;
            this.labelMonto.Text = "Monto";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(34, 109);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(140, 21);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre de Usuario";
            // 
            // buttonComprar
            // 
            this.buttonComprar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComprar.Location = new System.Drawing.Point(16, 180);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(176, 36);
            this.buttonComprar.TabIndex = 9;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            // 
            // ComprarGiftCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 227);
            this.Controls.Add(this.buttonComprar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelUsrDestino);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.comboBox1);
            this.Name = "ComprarGiftCard";
            this.Text = "ComprarGiftCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label labelUsrDestino;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonComprar;
    }
}