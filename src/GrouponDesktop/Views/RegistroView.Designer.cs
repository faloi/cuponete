namespace GrouponDesktop.Views
{
    partial class RegistroView
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.usuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.repitaPassword = new System.Windows.Forms.TextBox();
            this.repitaPasswordLabel = new System.Windows.Forms.Label();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.rolLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.clienteGroupBox = new System.Windows.Forms.GroupBox();
            this.fechaNacCliente = new System.Windows.Forms.DateTimePicker();
            this.ciuPrefClienteBox = new System.Windows.Forms.CheckedListBox();
            this.proveedorGroupBox = new System.Windows.Forms.GroupBox();
            this.contactoProveedor = new System.Windows.Forms.TextBox();
            this.contactoProveedorLabel = new System.Windows.Forms.Label();
            this.comboRubro = new System.Windows.Forms.ComboBox();
            this.rubroProveedorLabel = new System.Windows.Forms.Label();
            this.cuitProveedor = new System.Windows.Forms.TextBox();
            this.cuitProveedorLabel = new System.Windows.Forms.Label();
            this.ciudadProveedor = new System.Windows.Forms.TextBox();
            this.ciudadProveedorLabel = new System.Windows.Forms.Label();
            this.cPostalProveedor = new System.Windows.Forms.TextBox();
            this.cPostalProveedorLabel = new System.Windows.Forms.Label();
            this.localidadProveedor = new System.Windows.Forms.TextBox();
            this.localidadProveedorLabel = new System.Windows.Forms.Label();
            this.dptoDirProveedor = new System.Windows.Forms.TextBox();
            this.dptoDirProveedorLabel = new System.Windows.Forms.Label();
            this.pisoDirProveedor = new System.Windows.Forms.TextBox();
            this.pisoDirProveedorLabel = new System.Windows.Forms.Label();
            this.numeroDirProveedor = new System.Windows.Forms.TextBox();
            this.numeroDirProveedorLabel = new System.Windows.Forms.Label();
            this.calleProveedor = new System.Windows.Forms.TextBox();
            this.calleProveedorLabel = new System.Windows.Forms.Label();
            this.direccionProveedorLabel = new System.Windows.Forms.Label();
            this.telefonoProveedor = new System.Windows.Forms.TextBox();
            this.telefonoProveedorLabel = new System.Windows.Forms.Label();
            this.emailProveedor = new System.Windows.Forms.TextBox();
            this.emailProveedorLabel = new System.Windows.Forms.Label();
            this.razonSocialProveedor = new System.Windows.Forms.TextBox();
            this.razonSocialProveedorLabel = new System.Windows.Forms.Label();
            this.ciuPrefClienteLabel = new System.Windows.Forms.Label();
            this.cpostalCliente = new System.Windows.Forms.TextBox();
            this.cpostalClienteLabel = new System.Windows.Forms.Label();
            this.localidadCliente = new System.Windows.Forms.TextBox();
            this.localidadClienteLabel = new System.Windows.Forms.Label();
            this.dptoDirCliente = new System.Windows.Forms.TextBox();
            this.dptoDirClienteLabel = new System.Windows.Forms.Label();
            this.pisoDirCliente = new System.Windows.Forms.TextBox();
            this.pisoDirClienteLabel = new System.Windows.Forms.Label();
            this.numeroDirCliente = new System.Windows.Forms.TextBox();
            this.numeroDirClienteLabel = new System.Windows.Forms.Label();
            this.calleCliente = new System.Windows.Forms.TextBox();
            this.calleClienteLabel = new System.Windows.Forms.Label();
            this.direccionClienteLabel = new System.Windows.Forms.Label();
            this.telefonoCliente = new System.Windows.Forms.TextBox();
            this.telefonoClienteLabel = new System.Windows.Forms.Label();
            this.emailCliente = new System.Windows.Forms.TextBox();
            this.emailClienteLabel = new System.Windows.Forms.Label();
            this.dniCliente = new System.Windows.Forms.TextBox();
            this.dniLabel = new System.Windows.Forms.Label();
            this.apellidoCliente = new System.Windows.Forms.TextBox();
            this.apellidoClienteLabel = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.nombreClienteLabel = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.usuarioGroupBox.SuspendLayout();
            this.clienteGroupBox.SuspendLayout();
            this.proveedorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(26, 16);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(119, 21);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre Usuario";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(30, 40);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(232, 20);
            this.username.TabIndex = 1;
            // 
            // usuarioGroupBox
            // 
            this.usuarioGroupBox.Controls.Add(this.repitaPassword);
            this.usuarioGroupBox.Controls.Add(this.repitaPasswordLabel);
            this.usuarioGroupBox.Controls.Add(this.comboRol);
            this.usuarioGroupBox.Controls.Add(this.rolLabel);
            this.usuarioGroupBox.Controls.Add(this.password);
            this.usuarioGroupBox.Controls.Add(this.passwordLabel);
            this.usuarioGroupBox.Controls.Add(this.nombreLabel);
            this.usuarioGroupBox.Controls.Add(this.username);
            this.usuarioGroupBox.Location = new System.Drawing.Point(12, 12);
            this.usuarioGroupBox.Name = "usuarioGroupBox";
            this.usuarioGroupBox.Size = new System.Drawing.Size(797, 128);
            this.usuarioGroupBox.TabIndex = 2;
            this.usuarioGroupBox.TabStop = false;
            this.usuarioGroupBox.Text = "Datos usuario";
            // 
            // repitaPassword
            // 
            this.repitaPassword.Location = new System.Drawing.Point(350, 89);
            this.repitaPassword.Name = "repitaPassword";
            this.repitaPassword.Size = new System.Drawing.Size(155, 20);
            this.repitaPassword.TabIndex = 7;
            // 
            // repitaPasswordLabel
            // 
            this.repitaPasswordLabel.AutoSize = true;
            this.repitaPasswordLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repitaPasswordLabel.Location = new System.Drawing.Point(346, 68);
            this.repitaPasswordLabel.Name = "repitaPasswordLabel";
            this.repitaPasswordLabel.Size = new System.Drawing.Size(134, 21);
            this.repitaPasswordLabel.TabIndex = 6;
            this.repitaPasswordLabel.Text = "Repita el password";
            // 
            // comboRol
            // 
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Location = new System.Drawing.Point(350, 39);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(155, 21);
            this.comboRol.TabIndex = 5;
            this.comboRol.SelectedIndexChanged += new System.EventHandler(this.ComboRolSelectedIndexChanged);
            // 
            // rolLabel
            // 
            this.rolLabel.AutoSize = true;
            this.rolLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolLabel.Location = new System.Drawing.Point(346, 16);
            this.rolLabel.Name = "rolLabel";
            this.rolLabel.Size = new System.Drawing.Size(31, 21);
            this.rolLabel.TabIndex = 4;
            this.rolLabel.Text = "Rol";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(30, 89);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(232, 20);
            this.password.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(26, 68);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 21);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // clienteGroupBox
            // 
            this.clienteGroupBox.Controls.Add(this.fechaNacCliente);
            this.clienteGroupBox.Controls.Add(this.ciuPrefClienteBox);
            this.clienteGroupBox.Controls.Add(this.ciuPrefClienteLabel);
            this.clienteGroupBox.Controls.Add(this.cpostalCliente);
            this.clienteGroupBox.Controls.Add(this.cpostalClienteLabel);
            this.clienteGroupBox.Controls.Add(this.localidadCliente);
            this.clienteGroupBox.Controls.Add(this.localidadClienteLabel);
            this.clienteGroupBox.Controls.Add(this.dptoDirCliente);
            this.clienteGroupBox.Controls.Add(this.dptoDirClienteLabel);
            this.clienteGroupBox.Controls.Add(this.pisoDirCliente);
            this.clienteGroupBox.Controls.Add(this.pisoDirClienteLabel);
            this.clienteGroupBox.Controls.Add(this.numeroDirCliente);
            this.clienteGroupBox.Controls.Add(this.numeroDirClienteLabel);
            this.clienteGroupBox.Controls.Add(this.calleCliente);
            this.clienteGroupBox.Controls.Add(this.calleClienteLabel);
            this.clienteGroupBox.Controls.Add(this.direccionClienteLabel);
            this.clienteGroupBox.Controls.Add(this.telefonoCliente);
            this.clienteGroupBox.Controls.Add(this.telefonoClienteLabel);
            this.clienteGroupBox.Controls.Add(this.emailCliente);
            this.clienteGroupBox.Controls.Add(this.emailClienteLabel);
            this.clienteGroupBox.Controls.Add(this.dniCliente);
            this.clienteGroupBox.Controls.Add(this.dniLabel);
            this.clienteGroupBox.Controls.Add(this.apellidoCliente);
            this.clienteGroupBox.Controls.Add(this.apellidoClienteLabel);
            this.clienteGroupBox.Controls.Add(this.nombreCliente);
            this.clienteGroupBox.Controls.Add(this.nombreClienteLabel);
            this.clienteGroupBox.Location = new System.Drawing.Point(12, 146);
            this.clienteGroupBox.Name = "clienteGroupBox";
            this.clienteGroupBox.Size = new System.Drawing.Size(797, 380);
            this.clienteGroupBox.TabIndex = 3;
            this.clienteGroupBox.TabStop = false;
            this.clienteGroupBox.Text = "Datos Cliente";
            // 
            // fechaNacCliente
            // 
            this.fechaNacCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacCliente.Location = new System.Drawing.Point(477, 42);
            this.fechaNacCliente.Name = "fechaNacCliente";
            this.fechaNacCliente.Size = new System.Drawing.Size(200, 20);
            this.fechaNacCliente.TabIndex = 28;
            // 
            // ciuPrefClienteBox
            // 
            this.ciuPrefClienteBox.FormattingEnabled = true;
            this.ciuPrefClienteBox.Location = new System.Drawing.Point(30, 280);
            this.ciuPrefClienteBox.Name = "ciuPrefClienteBox";
            this.ciuPrefClienteBox.Size = new System.Drawing.Size(647, 94);
            this.ciuPrefClienteBox.TabIndex = 27;
            // 
            // proveedorGroupBox
            // 
            this.proveedorGroupBox.Controls.Add(this.contactoProveedor);
            this.proveedorGroupBox.Controls.Add(this.contactoProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.comboRubro);
            this.proveedorGroupBox.Controls.Add(this.rubroProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.cuitProveedor);
            this.proveedorGroupBox.Controls.Add(this.cuitProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.ciudadProveedor);
            this.proveedorGroupBox.Controls.Add(this.ciudadProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.cPostalProveedor);
            this.proveedorGroupBox.Controls.Add(this.cPostalProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.localidadProveedor);
            this.proveedorGroupBox.Controls.Add(this.localidadProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.dptoDirProveedor);
            this.proveedorGroupBox.Controls.Add(this.dptoDirProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.pisoDirProveedor);
            this.proveedorGroupBox.Controls.Add(this.pisoDirProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.numeroDirProveedor);
            this.proveedorGroupBox.Controls.Add(this.numeroDirProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.calleProveedor);
            this.proveedorGroupBox.Controls.Add(this.calleProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.direccionProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.telefonoProveedor);
            this.proveedorGroupBox.Controls.Add(this.telefonoProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.emailProveedor);
            this.proveedorGroupBox.Controls.Add(this.emailProveedorLabel);
            this.proveedorGroupBox.Controls.Add(this.razonSocialProveedor);
            this.proveedorGroupBox.Controls.Add(this.razonSocialProveedorLabel);
            this.proveedorGroupBox.Location = new System.Drawing.Point(6, 146);
            this.proveedorGroupBox.Name = "proveedorGroupBox";
            this.proveedorGroupBox.Size = new System.Drawing.Size(803, 380);
            this.proveedorGroupBox.TabIndex = 4;
            this.proveedorGroupBox.TabStop = false;
            this.proveedorGroupBox.Text = "Datos Proveedor";
            // 
            // contactoProveedor
            // 
            this.contactoProveedor.Location = new System.Drawing.Point(221, 282);
            this.contactoProveedor.Name = "contactoProveedor";
            this.contactoProveedor.Size = new System.Drawing.Size(158, 20);
            this.contactoProveedor.TabIndex = 33;
            // 
            // contactoProveedorLabel
            // 
            this.contactoProveedorLabel.AutoSize = true;
            this.contactoProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactoProveedorLabel.Location = new System.Drawing.Point(218, 259);
            this.contactoProveedorLabel.Name = "contactoProveedorLabel";
            this.contactoProveedorLabel.Size = new System.Drawing.Size(149, 21);
            this.contactoProveedorLabel.TabIndex = 32;
            this.contactoProveedorLabel.Text = "Nombre de contacto";
            // 
            // comboRubro
            // 
            this.comboRubro.FormattingEnabled = true;
            this.comboRubro.Location = new System.Drawing.Point(479, 39);
            this.comboRubro.Name = "comboRubro";
            this.comboRubro.Size = new System.Drawing.Size(155, 21);
            this.comboRubro.TabIndex = 31;
            // 
            // rubroProveedorLabel
            // 
            this.rubroProveedorLabel.AutoSize = true;
            this.rubroProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rubroProveedorLabel.Location = new System.Drawing.Point(475, 15);
            this.rubroProveedorLabel.Name = "rubroProveedorLabel";
            this.rubroProveedorLabel.Size = new System.Drawing.Size(51, 21);
            this.rubroProveedorLabel.TabIndex = 30;
            this.rubroProveedorLabel.Text = "Rubro";
            // 
            // cuitProveedor
            // 
            this.cuitProveedor.Location = new System.Drawing.Point(257, 40);
            this.cuitProveedor.Name = "cuitProveedor";
            this.cuitProveedor.Size = new System.Drawing.Size(158, 20);
            this.cuitProveedor.TabIndex = 29;
            // 
            // cuitProveedorLabel
            // 
            this.cuitProveedorLabel.AutoSize = true;
            this.cuitProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuitProveedorLabel.Location = new System.Drawing.Point(253, 16);
            this.cuitProveedorLabel.Name = "cuitProveedorLabel";
            this.cuitProveedorLabel.Size = new System.Drawing.Size(42, 21);
            this.cuitProveedorLabel.TabIndex = 28;
            this.cuitProveedorLabel.Text = "CUIT";
            // 
            // ciudadProveedor
            // 
            this.ciudadProveedor.Location = new System.Drawing.Point(30, 282);
            this.ciudadProveedor.Name = "ciudadProveedor";
            this.ciudadProveedor.Size = new System.Drawing.Size(158, 20);
            this.ciudadProveedor.TabIndex = 27;
            // 
            // ciudadProveedorLabel
            // 
            this.ciudadProveedorLabel.AutoSize = true;
            this.ciudadProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadProveedorLabel.Location = new System.Drawing.Point(27, 259);
            this.ciudadProveedorLabel.Name = "ciudadProveedorLabel";
            this.ciudadProveedorLabel.Size = new System.Drawing.Size(58, 21);
            this.ciudadProveedorLabel.TabIndex = 26;
            this.ciudadProveedorLabel.Text = "Ciudad";
            // 
            // cPostalProveedor
            // 
            this.cPostalProveedor.Location = new System.Drawing.Point(221, 224);
            this.cPostalProveedor.Name = "cPostalProveedor";
            this.cPostalProveedor.Size = new System.Drawing.Size(96, 20);
            this.cPostalProveedor.TabIndex = 25;
            // 
            // cPostalProveedorLabel
            // 
            this.cPostalProveedorLabel.AutoSize = true;
            this.cPostalProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPostalProveedorLabel.Location = new System.Drawing.Point(218, 201);
            this.cPostalProveedorLabel.Name = "cPostalProveedorLabel";
            this.cPostalProveedorLabel.Size = new System.Drawing.Size(103, 21);
            this.cPostalProveedorLabel.TabIndex = 24;
            this.cPostalProveedorLabel.Text = "Codigo Postal";
            // 
            // localidadProveedor
            // 
            this.localidadProveedor.Location = new System.Drawing.Point(30, 224);
            this.localidadProveedor.Name = "localidadProveedor";
            this.localidadProveedor.Size = new System.Drawing.Size(158, 20);
            this.localidadProveedor.TabIndex = 23;
            // 
            // localidadProveedorLabel
            // 
            this.localidadProveedorLabel.AutoSize = true;
            this.localidadProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadProveedorLabel.Location = new System.Drawing.Point(27, 201);
            this.localidadProveedorLabel.Name = "localidadProveedorLabel";
            this.localidadProveedorLabel.Size = new System.Drawing.Size(73, 21);
            this.localidadProveedorLabel.TabIndex = 22;
            this.localidadProveedorLabel.Text = "Localidad";
            // 
            // dptoDirProveedor
            // 
            this.dptoDirProveedor.Location = new System.Drawing.Point(560, 178);
            this.dptoDirProveedor.Name = "dptoDirProveedor";
            this.dptoDirProveedor.Size = new System.Drawing.Size(74, 20);
            this.dptoDirProveedor.TabIndex = 21;
            // 
            // dptoDirProveedorLabel
            // 
            this.dptoDirProveedorLabel.AutoSize = true;
            this.dptoDirProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptoDirProveedorLabel.Location = new System.Drawing.Point(556, 154);
            this.dptoDirProveedorLabel.Name = "dptoDirProveedorLabel";
            this.dptoDirProveedorLabel.Size = new System.Drawing.Size(48, 21);
            this.dptoDirProveedorLabel.TabIndex = 20;
            this.dptoDirProveedorLabel.Text = "Dpto.";
            // 
            // pisoDirProveedor
            // 
            this.pisoDirProveedor.Location = new System.Drawing.Point(385, 177);
            this.pisoDirProveedor.Name = "pisoDirProveedor";
            this.pisoDirProveedor.Size = new System.Drawing.Size(158, 20);
            this.pisoDirProveedor.TabIndex = 19;
            // 
            // pisoDirProveedorLabel
            // 
            this.pisoDirProveedorLabel.AutoSize = true;
            this.pisoDirProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisoDirProveedorLabel.Location = new System.Drawing.Point(381, 155);
            this.pisoDirProveedorLabel.Name = "pisoDirProveedorLabel";
            this.pisoDirProveedorLabel.Size = new System.Drawing.Size(37, 21);
            this.pisoDirProveedorLabel.TabIndex = 18;
            this.pisoDirProveedorLabel.Text = "Piso";
            // 
            // numeroDirProveedor
            // 
            this.numeroDirProveedor.Location = new System.Drawing.Point(221, 177);
            this.numeroDirProveedor.Name = "numeroDirProveedor";
            this.numeroDirProveedor.Size = new System.Drawing.Size(158, 20);
            this.numeroDirProveedor.TabIndex = 17;
            // 
            // numeroDirProveedorLabel
            // 
            this.numeroDirProveedorLabel.AutoSize = true;
            this.numeroDirProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDirProveedorLabel.Location = new System.Drawing.Point(217, 155);
            this.numeroDirProveedorLabel.Name = "numeroDirProveedorLabel";
            this.numeroDirProveedorLabel.Size = new System.Drawing.Size(65, 21);
            this.numeroDirProveedorLabel.TabIndex = 16;
            this.numeroDirProveedorLabel.Text = "Número";
            // 
            // calleProveedor
            // 
            this.calleProveedor.Location = new System.Drawing.Point(30, 178);
            this.calleProveedor.Name = "calleProveedor";
            this.calleProveedor.Size = new System.Drawing.Size(158, 20);
            this.calleProveedor.TabIndex = 15;
            // 
            // calleProveedorLabel
            // 
            this.calleProveedorLabel.AutoSize = true;
            this.calleProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calleProveedorLabel.Location = new System.Drawing.Point(27, 155);
            this.calleProveedorLabel.Name = "calleProveedorLabel";
            this.calleProveedorLabel.Size = new System.Drawing.Size(42, 21);
            this.calleProveedorLabel.TabIndex = 14;
            this.calleProveedorLabel.Text = "Calle";
            // 
            // direccionProveedorLabel
            // 
            this.direccionProveedorLabel.AutoSize = true;
            this.direccionProveedorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionProveedorLabel.Location = new System.Drawing.Point(27, 122);
            this.direccionProveedorLabel.Name = "direccionProveedorLabel";
            this.direccionProveedorLabel.Size = new System.Drawing.Size(75, 21);
            this.direccionProveedorLabel.TabIndex = 13;
            this.direccionProveedorLabel.Text = "Direccion";
            // 
            // telefonoProveedor
            // 
            this.telefonoProveedor.Location = new System.Drawing.Point(257, 85);
            this.telefonoProveedor.Name = "telefonoProveedor";
            this.telefonoProveedor.Size = new System.Drawing.Size(158, 20);
            this.telefonoProveedor.TabIndex = 12;
            // 
            // telefonoProveedorLabel
            // 
            this.telefonoProveedorLabel.AutoSize = true;
            this.telefonoProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoProveedorLabel.Location = new System.Drawing.Point(253, 63);
            this.telefonoProveedorLabel.Name = "telefonoProveedorLabel";
            this.telefonoProveedorLabel.Size = new System.Drawing.Size(68, 21);
            this.telefonoProveedorLabel.TabIndex = 11;
            this.telefonoProveedorLabel.Text = "Telefono";
            // 
            // emailProveedor
            // 
            this.emailProveedor.Location = new System.Drawing.Point(27, 85);
            this.emailProveedor.Name = "emailProveedor";
            this.emailProveedor.Size = new System.Drawing.Size(158, 20);
            this.emailProveedor.TabIndex = 6;
            // 
            // emailProveedorLabel
            // 
            this.emailProveedorLabel.AutoSize = true;
            this.emailProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailProveedorLabel.Location = new System.Drawing.Point(27, 63);
            this.emailProveedorLabel.Name = "emailProveedorLabel";
            this.emailProveedorLabel.Size = new System.Drawing.Size(45, 21);
            this.emailProveedorLabel.TabIndex = 5;
            this.emailProveedorLabel.Text = "Email";
            // 
            // razonSocialProveedor
            // 
            this.razonSocialProveedor.Location = new System.Drawing.Point(30, 40);
            this.razonSocialProveedor.Name = "razonSocialProveedor";
            this.razonSocialProveedor.Size = new System.Drawing.Size(158, 20);
            this.razonSocialProveedor.TabIndex = 4;
            // 
            // razonSocialProveedorLabel
            // 
            this.razonSocialProveedorLabel.AutoSize = true;
            this.razonSocialProveedorLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.razonSocialProveedorLabel.Location = new System.Drawing.Point(27, 16);
            this.razonSocialProveedorLabel.Name = "razonSocialProveedorLabel";
            this.razonSocialProveedorLabel.Size = new System.Drawing.Size(94, 21);
            this.razonSocialProveedorLabel.TabIndex = 3;
            this.razonSocialProveedorLabel.Text = "Razon Social";
            // 
            // ciuPrefClienteLabel
            // 
            this.ciuPrefClienteLabel.AutoSize = true;
            this.ciuPrefClienteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciuPrefClienteLabel.Location = new System.Drawing.Point(27, 259);
            this.ciuPrefClienteLabel.Name = "ciuPrefClienteLabel";
            this.ciuPrefClienteLabel.Size = new System.Drawing.Size(178, 21);
            this.ciuPrefClienteLabel.TabIndex = 26;
            this.ciuPrefClienteLabel.Text = "Ciudades de Preferencia";
            // 
            // cpostalCliente
            // 
            this.cpostalCliente.Location = new System.Drawing.Point(221, 223);
            this.cpostalCliente.Name = "cpostalCliente";
            this.cpostalCliente.Size = new System.Drawing.Size(96, 20);
            this.cpostalCliente.TabIndex = 25;
            // 
            // cpostalClienteLabel
            // 
            this.cpostalClienteLabel.AutoSize = true;
            this.cpostalClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpostalClienteLabel.Location = new System.Drawing.Point(217, 200);
            this.cpostalClienteLabel.Name = "cpostalClienteLabel";
            this.cpostalClienteLabel.Size = new System.Drawing.Size(103, 21);
            this.cpostalClienteLabel.TabIndex = 24;
            this.cpostalClienteLabel.Text = "Codigo Postal";
            // 
            // localidadCliente
            // 
            this.localidadCliente.Location = new System.Drawing.Point(30, 223);
            this.localidadCliente.Name = "localidadCliente";
            this.localidadCliente.Size = new System.Drawing.Size(158, 20);
            this.localidadCliente.TabIndex = 23;
            // 
            // localidadClienteLabel
            // 
            this.localidadClienteLabel.AutoSize = true;
            this.localidadClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localidadClienteLabel.Location = new System.Drawing.Point(26, 200);
            this.localidadClienteLabel.Name = "localidadClienteLabel";
            this.localidadClienteLabel.Size = new System.Drawing.Size(73, 21);
            this.localidadClienteLabel.TabIndex = 22;
            this.localidadClienteLabel.Text = "Localidad";
            // 
            // dptoDirCliente
            // 
            this.dptoDirCliente.Location = new System.Drawing.Point(560, 177);
            this.dptoDirCliente.Name = "dptoDirCliente";
            this.dptoDirCliente.Size = new System.Drawing.Size(74, 20);
            this.dptoDirCliente.TabIndex = 21;
            // 
            // dptoDirClienteLabel
            // 
            this.dptoDirClienteLabel.AutoSize = true;
            this.dptoDirClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptoDirClienteLabel.Location = new System.Drawing.Point(556, 153);
            this.dptoDirClienteLabel.Name = "dptoDirClienteLabel";
            this.dptoDirClienteLabel.Size = new System.Drawing.Size(48, 21);
            this.dptoDirClienteLabel.TabIndex = 20;
            this.dptoDirClienteLabel.Text = "Dpto.";
            // 
            // pisoDirCliente
            // 
            this.pisoDirCliente.Location = new System.Drawing.Point(385, 177);
            this.pisoDirCliente.Name = "pisoDirCliente";
            this.pisoDirCliente.Size = new System.Drawing.Size(158, 20);
            this.pisoDirCliente.TabIndex = 19;
            // 
            // pisoDirClienteLabel
            // 
            this.pisoDirClienteLabel.AutoSize = true;
            this.pisoDirClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pisoDirClienteLabel.Location = new System.Drawing.Point(381, 153);
            this.pisoDirClienteLabel.Name = "pisoDirClienteLabel";
            this.pisoDirClienteLabel.Size = new System.Drawing.Size(37, 21);
            this.pisoDirClienteLabel.TabIndex = 18;
            this.pisoDirClienteLabel.Text = "Piso";
            // 
            // numeroDirCliente
            // 
            this.numeroDirCliente.Location = new System.Drawing.Point(221, 177);
            this.numeroDirCliente.Name = "numeroDirCliente";
            this.numeroDirCliente.Size = new System.Drawing.Size(158, 20);
            this.numeroDirCliente.TabIndex = 17;
            // 
            // numeroDirClienteLabel
            // 
            this.numeroDirClienteLabel.AutoSize = true;
            this.numeroDirClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDirClienteLabel.Location = new System.Drawing.Point(217, 153);
            this.numeroDirClienteLabel.Name = "numeroDirClienteLabel";
            this.numeroDirClienteLabel.Size = new System.Drawing.Size(65, 21);
            this.numeroDirClienteLabel.TabIndex = 16;
            this.numeroDirClienteLabel.Text = "Número";
            // 
            // calleCliente
            // 
            this.calleCliente.Location = new System.Drawing.Point(30, 177);
            this.calleCliente.Name = "calleCliente";
            this.calleCliente.Size = new System.Drawing.Size(158, 20);
            this.calleCliente.TabIndex = 15;
            // 
            // calleClienteLabel
            // 
            this.calleClienteLabel.AutoSize = true;
            this.calleClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calleClienteLabel.Location = new System.Drawing.Point(27, 155);
            this.calleClienteLabel.Name = "calleClienteLabel";
            this.calleClienteLabel.Size = new System.Drawing.Size(42, 21);
            this.calleClienteLabel.TabIndex = 14;
            this.calleClienteLabel.Text = "Calle";
            // 
            // direccionClienteLabel
            // 
            this.direccionClienteLabel.AutoSize = true;
            this.direccionClienteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionClienteLabel.Location = new System.Drawing.Point(27, 122);
            this.direccionClienteLabel.Name = "direccionClienteLabel";
            this.direccionClienteLabel.Size = new System.Drawing.Size(75, 21);
            this.direccionClienteLabel.TabIndex = 13;
            this.direccionClienteLabel.Text = "Direccion";
            // 
            // telefonoCliente
            // 
            this.telefonoCliente.Location = new System.Drawing.Point(477, 90);
            this.telefonoCliente.Name = "telefonoCliente";
            this.telefonoCliente.Size = new System.Drawing.Size(200, 20);
            this.telefonoCliente.TabIndex = 12;
            // 
            // telefonoClienteLabel
            // 
            this.telefonoClienteLabel.AutoSize = true;
            this.telefonoClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoClienteLabel.Location = new System.Drawing.Point(475, 68);
            this.telefonoClienteLabel.Name = "telefonoClienteLabel";
            this.telefonoClienteLabel.Size = new System.Drawing.Size(68, 21);
            this.telefonoClienteLabel.TabIndex = 11;
            this.telefonoClienteLabel.Text = "Telefono";
            // 
            // emailCliente
            // 
            this.emailCliente.Location = new System.Drawing.Point(257, 90);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(158, 20);
            this.emailCliente.TabIndex = 10;
            // 
            // emailClienteLabel
            // 
            this.emailClienteLabel.AutoSize = true;
            this.emailClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailClienteLabel.Location = new System.Drawing.Point(253, 68);
            this.emailClienteLabel.Name = "emailClienteLabel";
            this.emailClienteLabel.Size = new System.Drawing.Size(45, 21);
            this.emailClienteLabel.TabIndex = 9;
            this.emailClienteLabel.Text = "Email";
            // 
            // dniCliente
            // 
            this.dniCliente.Location = new System.Drawing.Point(30, 90);
            this.dniCliente.Name = "dniCliente";
            this.dniCliente.Size = new System.Drawing.Size(158, 20);
            this.dniCliente.TabIndex = 8;
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniLabel.Location = new System.Drawing.Point(27, 68);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(36, 21);
            this.dniLabel.TabIndex = 7;
            this.dniLabel.Text = "DNI";
            // 
            // apellidoCliente
            // 
            this.apellidoCliente.Location = new System.Drawing.Point(257, 42);
            this.apellidoCliente.Name = "apellidoCliente";
            this.apellidoCliente.Size = new System.Drawing.Size(158, 20);
            this.apellidoCliente.TabIndex = 6;
            // 
            // apellidoClienteLabel
            // 
            this.apellidoClienteLabel.AutoSize = true;
            this.apellidoClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoClienteLabel.Location = new System.Drawing.Point(253, 18);
            this.apellidoClienteLabel.Name = "apellidoClienteLabel";
            this.apellidoClienteLabel.Size = new System.Drawing.Size(64, 21);
            this.apellidoClienteLabel.TabIndex = 5;
            this.apellidoClienteLabel.Text = "Apellido";
            // 
            // nombreCliente
            // 
            this.nombreCliente.Location = new System.Drawing.Point(30, 37);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(158, 20);
            this.nombreCliente.TabIndex = 4;
            // 
            // nombreClienteLabel
            // 
            this.nombreClienteLabel.AutoSize = true;
            this.nombreClienteLabel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClienteLabel.Location = new System.Drawing.Point(27, 18);
            this.nombreClienteLabel.Name = "nombreClienteLabel";
            this.nombreClienteLabel.Size = new System.Drawing.Size(65, 21);
            this.nombreClienteLabel.TabIndex = 3;
            this.nombreClienteLabel.Text = "Nombre";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Location = new System.Drawing.Point(42, 537);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(145, 23);
            this.limpiarButton.TabIndex = 5;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(565, 537);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(124, 23);
            this.guardarButton.TabIndex = 6;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            // 
            // RegistroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 572);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.proveedorGroupBox);
            this.Controls.Add(this.clienteGroupBox);
            this.Controls.Add(this.usuarioGroupBox);
            this.Name = "RegistroView";
            this.usuarioGroupBox.ResumeLayout(false);
            this.usuarioGroupBox.PerformLayout();
            this.clienteGroupBox.ResumeLayout(false);
            this.clienteGroupBox.PerformLayout();
            this.proveedorGroupBox.ResumeLayout(false);
            this.proveedorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.GroupBox usuarioGroupBox;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label rolLabel;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.TextBox repitaPassword;
        private System.Windows.Forms.Label repitaPasswordLabel;
        private System.Windows.Forms.GroupBox clienteGroupBox;
        private System.Windows.Forms.Label nombreClienteLabel;
        private System.Windows.Forms.TextBox emailCliente;
        private System.Windows.Forms.Label emailClienteLabel;
        private System.Windows.Forms.TextBox dniCliente;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.TextBox apellidoCliente;
        private System.Windows.Forms.Label apellidoClienteLabel;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.TextBox telefonoCliente;
        private System.Windows.Forms.Label telefonoClienteLabel;
        private System.Windows.Forms.TextBox dptoDirCliente;
        private System.Windows.Forms.Label dptoDirClienteLabel;
        private System.Windows.Forms.TextBox pisoDirCliente;
        private System.Windows.Forms.Label pisoDirClienteLabel;
        private System.Windows.Forms.TextBox numeroDirCliente;
        private System.Windows.Forms.Label numeroDirClienteLabel;
        private System.Windows.Forms.TextBox calleCliente;
        private System.Windows.Forms.Label calleClienteLabel;
        private System.Windows.Forms.Label direccionClienteLabel;
        private System.Windows.Forms.TextBox cpostalCliente;
        private System.Windows.Forms.Label cpostalClienteLabel;
        private System.Windows.Forms.TextBox localidadCliente;
        private System.Windows.Forms.Label localidadClienteLabel;
        private System.Windows.Forms.CheckedListBox ciuPrefClienteBox;
        private System.Windows.Forms.Label ciuPrefClienteLabel;
        private System.Windows.Forms.TextBox cPostalProveedor;
        private System.Windows.Forms.Label cPostalProveedorLabel;
        private System.Windows.Forms.TextBox localidadProveedor;
        private System.Windows.Forms.Label localidadProveedorLabel;
        private System.Windows.Forms.TextBox dptoDirProveedor;
        private System.Windows.Forms.Label dptoDirProveedorLabel;
        private System.Windows.Forms.TextBox pisoDirProveedor;
        private System.Windows.Forms.Label pisoDirProveedorLabel;
        private System.Windows.Forms.TextBox numeroDirProveedor;
        private System.Windows.Forms.Label numeroDirProveedorLabel;
        private System.Windows.Forms.TextBox calleProveedor;
        private System.Windows.Forms.Label calleProveedorLabel;
        private System.Windows.Forms.Label direccionProveedorLabel;
        private System.Windows.Forms.GroupBox proveedorGroupBox;
        private System.Windows.Forms.TextBox telefonoProveedor;
        private System.Windows.Forms.Label telefonoProveedorLabel;
        private System.Windows.Forms.TextBox emailProveedor;
        private System.Windows.Forms.Label emailProveedorLabel;
        private System.Windows.Forms.TextBox razonSocialProveedor;
        private System.Windows.Forms.Label razonSocialProveedorLabel;
        private System.Windows.Forms.TextBox cuitProveedor;
        private System.Windows.Forms.Label cuitProveedorLabel;
        private System.Windows.Forms.TextBox ciudadProveedor;
        private System.Windows.Forms.Label ciudadProveedorLabel;
        private System.Windows.Forms.TextBox contactoProveedor;
        private System.Windows.Forms.Label contactoProveedorLabel;
        private System.Windows.Forms.ComboBox comboRubro;
        private System.Windows.Forms.Label rubroProveedorLabel;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button guardarButton;
        private System.Windows.Forms.DateTimePicker fechaNacCliente;
    }
}