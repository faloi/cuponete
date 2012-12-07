namespace GrouponDesktop.Views
{
    partial class PedirDevolucion
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
            this.labelSolicitarDevolucion = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.buttonSolicitar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSolicitarDevolucion
            // 
            this.labelSolicitarDevolucion.AutoSize = true;
            this.labelSolicitarDevolucion.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolicitarDevolucion.Location = new System.Drawing.Point(23, 9);
            this.labelSolicitarDevolucion.Name = "labelSolicitarDevolucion";
            this.labelSolicitarDevolucion.Size = new System.Drawing.Size(238, 37);
            this.labelSolicitarDevolucion.TabIndex = 0;
            this.labelSolicitarDevolucion.Text = "Solicitar Devolución";
            this.labelSolicitarDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(79, 60);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(130, 21);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Código de Cupón";
            this.labelCodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(30, 84);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(231, 20);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // buttonSolicitar
            // 
            this.buttonSolicitar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolicitar.Location = new System.Drawing.Point(30, 119);
            this.buttonSolicitar.Name = "buttonSolicitar";
            this.buttonSolicitar.Size = new System.Drawing.Size(117, 29);
            this.buttonSolicitar.TabIndex = 3;
            this.buttonSolicitar.Text = "Solicitar";
            this.buttonSolicitar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(153, 119);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 29);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // PedirDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSolicitar);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.labelSolicitarDevolucion);
            this.Name = "PedirDevolucion";
            this.Text = "PedirDevolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSolicitarDevolucion;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button buttonSolicitar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}