namespace GrouponDesktop.Views
{
    partial class DarDeBajaCliente
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelCuponesDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(121, 91);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(98, 29);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.Location = new System.Drawing.Point(17, 91);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(98, 29);
            this.buttonConfirmar.TabIndex = 5;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            // 
            // labelCuponesDisponibles
            // 
            this.labelCuponesDisponibles.AutoSize = true;
            this.labelCuponesDisponibles.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuponesDisponibles.Location = new System.Drawing.Point(12, 9);
            this.labelCuponesDisponibles.Name = "labelCuponesDisponibles";
            this.labelCuponesDisponibles.Size = new System.Drawing.Size(213, 60);
            this.labelCuponesDisponibles.TabIndex = 6;
            this.labelCuponesDisponibles.Text = "Esta seguro de que de\r\ndesea darse de baja?";
            this.labelCuponesDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DarDeBajaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 131);
            this.Controls.Add(this.labelCuponesDisponibles);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.buttonCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DarDeBajaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Darse De Baja";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label labelCuponesDisponibles;
    }
}