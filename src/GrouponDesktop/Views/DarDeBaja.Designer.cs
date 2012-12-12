namespace GrouponDesktop.Views
{
    partial class DarDeBaja
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
            this.groupBoxDarDeBaja = new System.Windows.Forms.GroupBox();
            this.groupBoxHabilitarDeshabilitar = new System.Windows.Forms.GroupBox();
            this.labelFormaDePago = new System.Windows.Forms.Label();
            this.comboBoxAccion = new System.Windows.Forms.ComboBox();
            this.labelNroDeTarjeta = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar2 = new System.Windows.Forms.Button();
            this.buttonConfirmarAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxDarDeBaja.SuspendLayout();
            this.groupBoxHabilitarDeshabilitar.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(115, 98);
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
            this.buttonConfirmar.Location = new System.Drawing.Point(11, 98);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(98, 29);
            this.buttonConfirmar.TabIndex = 5;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // labelCuponesDisponibles
            // 
            this.labelCuponesDisponibles.AutoSize = true;
            this.labelCuponesDisponibles.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuponesDisponibles.Location = new System.Drawing.Point(6, 16);
            this.labelCuponesDisponibles.Name = "labelCuponesDisponibles";
            this.labelCuponesDisponibles.Size = new System.Drawing.Size(213, 60);
            this.labelCuponesDisponibles.TabIndex = 6;
            this.labelCuponesDisponibles.Text = "Esta seguro de que de\r\ndesea darse de baja?";
            this.labelCuponesDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxDarDeBaja
            // 
            this.groupBoxDarDeBaja.Controls.Add(this.labelCuponesDisponibles);
            this.groupBoxDarDeBaja.Controls.Add(this.buttonCancelar);
            this.groupBoxDarDeBaja.Controls.Add(this.buttonConfirmar);
            this.groupBoxDarDeBaja.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDarDeBaja.Name = "groupBoxDarDeBaja";
            this.groupBoxDarDeBaja.Size = new System.Drawing.Size(226, 146);
            this.groupBoxDarDeBaja.TabIndex = 7;
            this.groupBoxDarDeBaja.TabStop = false;
            this.groupBoxDarDeBaja.Text = "Dar de Baja";
            // 
            // groupBoxHabilitarDeshabilitar
            // 
            this.groupBoxHabilitarDeshabilitar.Controls.Add(this.labelFormaDePago);
            this.groupBoxHabilitarDeshabilitar.Controls.Add(this.comboBoxAccion);
            this.groupBoxHabilitarDeshabilitar.Controls.Add(this.labelNroDeTarjeta);
            this.groupBoxHabilitarDeshabilitar.Controls.Add(this.textBoxUsername);
            this.groupBoxHabilitarDeshabilitar.Controls.Add(this.label1);
            this.groupBoxHabilitarDeshabilitar.Controls.Add(this.buttonCancelar2);
            this.groupBoxHabilitarDeshabilitar.Controls.Add(this.buttonConfirmarAdmin);
            this.groupBoxHabilitarDeshabilitar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHabilitarDeshabilitar.Name = "groupBoxHabilitarDeshabilitar";
            this.groupBoxHabilitarDeshabilitar.Size = new System.Drawing.Size(226, 192);
            this.groupBoxHabilitarDeshabilitar.TabIndex = 8;
            this.groupBoxHabilitarDeshabilitar.TabStop = false;
            this.groupBoxHabilitarDeshabilitar.Text = "Habilitar / Deshabilitar";
            // 
            // labelFormaDePago
            // 
            this.labelFormaDePago.AutoSize = true;
            this.labelFormaDePago.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormaDePago.Location = new System.Drawing.Point(7, 93);
            this.labelFormaDePago.Name = "labelFormaDePago";
            this.labelFormaDePago.Size = new System.Drawing.Size(55, 21);
            this.labelFormaDePago.TabIndex = 10;
            this.labelFormaDePago.Text = "Accion";
            // 
            // comboBoxAccion
            // 
            this.comboBoxAccion.FormattingEnabled = true;
            this.comboBoxAccion.Items.AddRange(new object[] {
            "Habilitar",
            "Deshabilitar"});
            this.comboBoxAccion.Location = new System.Drawing.Point(11, 117);
            this.comboBoxAccion.Name = "comboBoxAccion";
            this.comboBoxAccion.Size = new System.Drawing.Size(202, 21);
            this.comboBoxAccion.TabIndex = 9;
            // 
            // labelNroDeTarjeta
            // 
            this.labelNroDeTarjeta.AutoSize = true;
            this.labelNroDeTarjeta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNroDeTarjeta.Location = new System.Drawing.Point(7, 46);
            this.labelNroDeTarjeta.Name = "labelNroDeTarjeta";
            this.labelNroDeTarjeta.Size = new System.Drawing.Size(140, 21);
            this.labelNroDeTarjeta.TabIndex = 8;
            this.labelNroDeTarjeta.Text = "Nombre de Usuario";
            // 
            // textBoxUsername
            // 
            this.errorProvider.SetIconAlignment(this.textBoxUsername, System.Windows.Forms.ErrorIconAlignment.BottomRight);
            this.textBoxUsername.Location = new System.Drawing.Point(11, 70);
            this.textBoxUsername.MaxLength = 15;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(202, 20);
            this.textBoxUsername.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Habilitar / Deshabilitar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar2
            // 
            this.buttonCancelar2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar2.Location = new System.Drawing.Point(115, 157);
            this.buttonCancelar2.Name = "buttonCancelar2";
            this.buttonCancelar2.Size = new System.Drawing.Size(98, 29);
            this.buttonCancelar2.TabIndex = 4;
            this.buttonCancelar2.Text = "Cancelar";
            this.buttonCancelar2.UseVisualStyleBackColor = true;
            this.buttonCancelar2.Click += new System.EventHandler(this.buttonCancelar2_Click);
            // 
            // buttonConfirmarAdmin
            // 
            this.buttonConfirmarAdmin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarAdmin.Location = new System.Drawing.Point(11, 157);
            this.buttonConfirmarAdmin.Name = "buttonConfirmarAdmin";
            this.buttonConfirmarAdmin.Size = new System.Drawing.Size(98, 29);
            this.buttonConfirmarAdmin.TabIndex = 5;
            this.buttonConfirmarAdmin.Text = "Confirmar";
            this.buttonConfirmarAdmin.UseVisualStyleBackColor = true;
            this.buttonConfirmarAdmin.Click += new System.EventHandler(this.buttonConfirmarAdmin_Click);
            // 
            // DarDeBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 215);
            this.Controls.Add(this.groupBoxHabilitarDeshabilitar);
            this.Controls.Add(this.groupBoxDarDeBaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DarDeBaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Darse De Baja";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxDarDeBaja.ResumeLayout(false);
            this.groupBoxDarDeBaja.PerformLayout();
            this.groupBoxHabilitarDeshabilitar.ResumeLayout(false);
            this.groupBoxHabilitarDeshabilitar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label labelCuponesDisponibles;
        private System.Windows.Forms.GroupBox groupBoxDarDeBaja;
        private System.Windows.Forms.GroupBox groupBoxHabilitarDeshabilitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelar2;
        private System.Windows.Forms.Button buttonConfirmarAdmin;
        private System.Windows.Forms.Label labelNroDeTarjeta;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelFormaDePago;
        private System.Windows.Forms.ComboBox comboBoxAccion;
    }
}