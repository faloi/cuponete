namespace GrouponDesktop.Views
{
    partial class ModificarProveedor
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
            this.proveedorGroupBox = new System.Windows.Forms.GroupBox();
            this.ciudadProvCombo = new System.Windows.Forms.ComboBox();
            this.contacto = new System.Windows.Forms.TextBox();
            this.contactoProveedorLabel = new System.Windows.Forms.Label();
            this.comboRubro = new System.Windows.Forms.ComboBox();
            this.rubroProveedorLabel = new System.Windows.Forms.Label();
            this.cuit = new System.Windows.Forms.TextBox();
            this.cuitProveedorLabel = new System.Windows.Forms.Label();
            this.ciudadProveedorLabel = new System.Windows.Forms.Label();
            this.codigoPostal = new System.Windows.Forms.TextBox();
            this.cPostalProveedorLabel = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.direccionProveedorLabel = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.telefonoProveedorLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.emailProveedorLabel = new System.Windows.Forms.Label();
            this.razonSocial = new System.Windows.Forms.TextBox();
            this.razonSocialProveedorLabel = new System.Windows.Forms.Label();
            this.usuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.direccionGroupBox = new System.Windows.Forms.GroupBox();
            this.localidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.depto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.piso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.proveedorGroupBox.SuspendLayout();
            this.usuarioGroupBox.SuspendLayout();
            this.direccionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // proveedorGroupBox
            // 
            this.proveedorGroupBox.Controls.Add(this.direccionGroupBox);
            this.proveedorGroupBox.Controls.Add(this.ciudadProvCombo);
            this.proveedorGroupBox.Controls.Add(this.contacto);
            this.proveedorGroupBox.Controls.Add(this.contactoProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.comboRubro);
            this.proveedorGroupBox.Controls.Add(this.rubroProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.cuit);
            this.proveedorGroupBox.Controls.Add(this.cuitProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.ciudadProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.codigoPostal);
            this.proveedorGroupBox.Controls.Add(this.cPostalProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.direccion);
            this.proveedorGroupBox.Controls.Add(this.direccionProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.telefono);
            this.proveedorGroupBox.Controls.Add(this.telefonoProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.email);
            this.proveedorGroupBox.Controls.Add(this.emailProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.razonSocial);
            this.proveedorGroupBox.Controls.Add(this.razonSocialProveedorLabel);
            this.proveedorGroupBox.Location = new System.Drawing.Point(3, 120);
            this.proveedorGroupBox.Name = "proveedorGroupBox";
            this.proveedorGroupBox.Size = new System.Drawing.Size(673, 261);
            this.proveedorGroupBox.TabIndex = 5;
            this.proveedorGroupBox.TabStop = false;
            this.proveedorGroupBox.Text = "Datos Proveedor";
            // 
            // ciudadProvCombo
            // 
            this.ciudadProvCombo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadProvCombo.FormattingEnabled = true;
            this.ciudadProvCombo.Location = new System.Drawing.Point(12, 221);
            this.ciudadProvCombo.Name = "ciudadProvCombo";
            this.ciudadProvCombo.Size = new System.Drawing.Size(155, 25);
            this.ciudadProvCombo.TabIndex = 34;
            // 
            // contactoProveedor
            // 
            this.contacto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacto.Location = new System.Drawing.Point(203, 220);
            this.contacto.Name = "contacto";
            this.contacto.Size = new System.Drawing.Size(158, 25);
            this.contacto.TabIndex = 33;
            // 
            // contactoProveedorLabel
            // 
            this.contactoProveedorLabel.AutoSize = true;
            this.contactoProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactoProveedorLabel.Location = new System.Drawing.Point(200, 197);
            this.contactoProveedorLabel.Name = "contactoProveedorLabel";
            this.contactoProveedorLabel.Size = new System.Drawing.Size(149, 21);
            this.contactoProveedorLabel.TabIndex = 32;
            this.contactoProveedorLabel.Text = "Nombre de contacto";
            // 
            // comboRubro
            // 
            this.comboRubro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRubro.FormattingEnabled = true;
            this.comboRubro.Location = new System.Drawing.Point(461, 39);
            this.comboRubro.Name = "comboRubro";
            this.comboRubro.Size = new System.Drawing.Size(155, 25);
            this.comboRubro.TabIndex = 6;
            // 
            // rubroProveedorLabel
            // 
            this.rubroProveedorLabel.AutoSize = true;
            this.rubroProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubroProveedorLabel.Location = new System.Drawing.Point(457, 15);
            this.rubroProveedorLabel.Name = "rubroProveedorLabel";
            this.rubroProveedorLabel.Size = new System.Drawing.Size(51, 21);
            this.rubroProveedorLabel.TabIndex = 30;
            this.rubroProveedorLabel.Text = "Rubro";
            // 
            // cuitProveedor
            // 
            this.cuit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuit.Location = new System.Drawing.Point(239, 40);
            this.cuit.Name = "cuit";
            this.cuit.Size = new System.Drawing.Size(158, 25);
            this.cuit.TabIndex = 5;
            // 
            // cuitProveedorLabel
            // 
            this.cuitProveedorLabel.AutoSize = true;
            this.cuitProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuitProveedorLabel.Location = new System.Drawing.Point(235, 16);
            this.cuitProveedorLabel.Name = "cuitProveedorLabel";
            this.cuitProveedorLabel.Size = new System.Drawing.Size(42, 21);
            this.cuitProveedorLabel.TabIndex = 28;
            this.cuitProveedorLabel.Text = "CUIT";
            // 
            // ciudadProveedorLabel
            // 
            this.ciudadProveedorLabel.AutoSize = true;
            this.ciudadProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadProveedorLabel.Location = new System.Drawing.Point(9, 197);
            this.ciudadProveedorLabel.Name = "ciudadProveedorLabel";
            this.ciudadProveedorLabel.Size = new System.Drawing.Size(58, 21);
            this.ciudadProveedorLabel.TabIndex = 26;
            this.ciudadProveedorLabel.Text = "Ciudad";
            // 
            // cPostalProveedor
            // 
            this.codigoPostal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoPostal.Location = new System.Drawing.Point(567, 152);
            this.codigoPostal.Name = "codigoPostal";
            this.codigoPostal.Size = new System.Drawing.Size(96, 25);
            this.codigoPostal.TabIndex = 25;
            // 
            // cPostalProveedorLabel
            // 
            this.cPostalProveedorLabel.AutoSize = true;
            this.cPostalProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPostalProveedorLabel.Location = new System.Drawing.Point(564, 129);
            this.cPostalProveedorLabel.Name = "cPostalProveedorLabel";
            this.cPostalProveedorLabel.Size = new System.Drawing.Size(103, 21);
            this.cPostalProveedorLabel.TabIndex = 24;
            this.cPostalProveedorLabel.Text = "Codigo Postal";
            // 
            // direccionProveedor
            // 
            this.direccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(12, 152);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(496, 25);
            this.direccion.TabIndex = 15;
            // 
            // direccionProveedorLabel
            // 
            this.direccionProveedorLabel.AutoSize = true;
            this.direccionProveedorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionProveedorLabel.Location = new System.Drawing.Point(9, 128);
            this.direccionProveedorLabel.Name = "direccionProveedorLabel";
            this.direccionProveedorLabel.Size = new System.Drawing.Size(75, 21);
            this.direccionProveedorLabel.TabIndex = 13;
            this.direccionProveedorLabel.Text = "Direccion";
            // 
            // telefonoProveedor
            // 
            this.telefono.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(239, 85);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(158, 25);
            this.telefono.TabIndex = 12;
            // 
            // telefonoProveedorLabel
            // 
            this.telefonoProveedorLabel.AutoSize = true;
            this.telefonoProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoProveedorLabel.Location = new System.Drawing.Point(235, 63);
            this.telefonoProveedorLabel.Name = "telefonoProveedorLabel";
            this.telefonoProveedorLabel.Size = new System.Drawing.Size(68, 21);
            this.telefonoProveedorLabel.TabIndex = 11;
            this.telefonoProveedorLabel.Text = "Telefono";
            // 
            // emailProveedor
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(13, 87);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(158, 25);
            this.email.TabIndex = 7;
            // 
            // emailProveedorLabel
            // 
            this.emailProveedorLabel.AutoSize = true;
            this.emailProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailProveedorLabel.Location = new System.Drawing.Point(9, 63);
            this.emailProveedorLabel.Name = "emailProveedorLabel";
            this.emailProveedorLabel.Size = new System.Drawing.Size(45, 21);
            this.emailProveedorLabel.TabIndex = 5;
            this.emailProveedorLabel.Text = "Email";
            // 
            // razonSocialProveedor
            // 
            this.razonSocial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razonSocial.Location = new System.Drawing.Point(12, 40);
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Size = new System.Drawing.Size(158, 25);
            this.razonSocial.TabIndex = 4;
            // 
            // razonSocialProveedorLabel
            // 
            this.razonSocialProveedorLabel.AutoSize = true;
            this.razonSocialProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razonSocialProveedorLabel.Location = new System.Drawing.Point(9, 16);
            this.razonSocialProveedorLabel.Name = "razonSocialProveedorLabel";
            this.razonSocialProveedorLabel.Size = new System.Drawing.Size(94, 21);
            this.razonSocialProveedorLabel.TabIndex = 3;
            this.razonSocialProveedorLabel.Text = "Razon Social";
            // 
            // usuarioGroupBox
            // 
            this.usuarioGroupBox.Controls.Add(this.password);
            this.usuarioGroupBox.Controls.Add(this.passwordLabel);
            this.usuarioGroupBox.Controls.Add(this.nombreLabel);
            this.usuarioGroupBox.Controls.Add(this.username);
            this.usuarioGroupBox.Location = new System.Drawing.Point(3, 12);
            this.usuarioGroupBox.Name = "usuarioGroupBox";
            this.usuarioGroupBox.Size = new System.Drawing.Size(673, 86);
            this.usuarioGroupBox.TabIndex = 9;
            this.usuarioGroupBox.TabStop = false;
            this.usuarioGroupBox.Text = "Datos usuario";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(239, 40);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(158, 25);
            this.password.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(235, 19);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 21);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(8, 16);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(119, 21);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre Usuario";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(12, 40);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(157, 25);
            this.username.TabIndex = 1;
            // 
            // guardarButton
            // 
            this.guardarButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarButton.Location = new System.Drawing.Point(159, 397);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(161, 28);
            this.guardarButton.TabIndex = 11;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.Location = new System.Drawing.Point(376, 397);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(161, 28);
            this.limpiarButton.TabIndex = 10;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            this.limpiarButton.Visible = false;
            // 
            // direccionGroupBox
            // 
            this.direccionGroupBox.Controls.Add(this.localidad);
            this.direccionGroupBox.Controls.Add(this.label5);
            this.direccionGroupBox.Controls.Add(this.depto);
            this.direccionGroupBox.Controls.Add(this.label4);
            this.direccionGroupBox.Controls.Add(this.piso);
            this.direccionGroupBox.Controls.Add(this.label3);
            this.direccionGroupBox.Controls.Add(this.numero);
            this.direccionGroupBox.Controls.Add(this.label1);
            this.direccionGroupBox.Controls.Add(this.calle);
            this.direccionGroupBox.Controls.Add(this.label2);
            this.direccionGroupBox.Location = new System.Drawing.Point(9, 119);
            this.direccionGroupBox.Name = "direccionGroupBox";
            this.direccionGroupBox.Size = new System.Drawing.Size(544, 75);
            this.direccionGroupBox.TabIndex = 35;
            this.direccionGroupBox.TabStop = false;
            this.direccionGroupBox.Text = "Direccion";
            // 
            // localidad
            // 
            this.localidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidad.Location = new System.Drawing.Point(406, 38);
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(119, 25);
            this.localidad.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Localidad";
            // 
            // depto
            // 
            this.depto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depto.Location = new System.Drawing.Point(335, 38);
            this.depto.Name = "depto";
            this.depto.Size = new System.Drawing.Size(46, 25);
            this.depto.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Depto";
            // 
            // piso
            // 
            this.piso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piso.Location = new System.Drawing.Point(280, 38);
            this.piso.Name = "piso";
            this.piso.Size = new System.Drawing.Size(33, 25);
            this.piso.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Piso";
            // 
            // numero
            // 
            this.numero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(185, 38);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(73, 25);
            this.numero.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero";
            // 
            // calle
            // 
            this.calle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calle.Location = new System.Drawing.Point(12, 38);
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(158, 25);
            this.calle.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calle";
            // 
            // ModificarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 441);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.usuarioGroupBox);
            this.Controls.Add(this.proveedorGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ModificarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Proveedor";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.proveedorGroupBox.ResumeLayout(false);
            this.proveedorGroupBox.PerformLayout();
            this.usuarioGroupBox.ResumeLayout(false);
            this.usuarioGroupBox.PerformLayout();
            this.direccionGroupBox.ResumeLayout(false);
            this.direccionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox proveedorGroupBox;
        private System.Windows.Forms.TextBox contacto;
        private System.Windows.Forms.Label contactoProveedorLabel;
        private System.Windows.Forms.ComboBox comboRubro;
        private System.Windows.Forms.Label rubroProveedorLabel;
        private System.Windows.Forms.TextBox cuit;
        private System.Windows.Forms.Label cuitProveedorLabel;
        private System.Windows.Forms.Label ciudadProveedorLabel;
        private System.Windows.Forms.TextBox codigoPostal;
        private System.Windows.Forms.Label cPostalProveedorLabel;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label direccionProveedorLabel;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label telefonoProveedorLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label emailProveedorLabel;
        private System.Windows.Forms.TextBox razonSocial;
        private System.Windows.Forms.Label razonSocialProveedorLabel;
        private System.Windows.Forms.GroupBox usuarioGroupBox;
        protected System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nombreLabel;
        protected System.Windows.Forms.TextBox username;
        protected System.Windows.Forms.Button guardarButton;
        protected System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.ComboBox ciudadProvCombo;
        private System.Windows.Forms.GroupBox direccionGroupBox;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox depto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox piso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.Label label2;
    }
}