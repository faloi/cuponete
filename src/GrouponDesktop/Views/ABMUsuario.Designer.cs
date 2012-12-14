namespace GrouponDesktop.Views
{
    partial class ABMUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonBajaRestaurar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonDesbloquear = new System.Windows.Forms.Button();
            this.usuariosDataGrid = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNombreDeUsuario = new System.Windows.Forms.Label();
            this.textBoxNombreDeUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // limpiarButton
            // 
            this.limpiarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.Location = new System.Drawing.Point(355, 24);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(163, 32);
            this.limpiarButton.TabIndex = 18;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(355, 79);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(163, 44);
            this.buttonBuscar.TabIndex = 16;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonBajaRestaurar
            // 
            this.buttonBajaRestaurar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBajaRestaurar.Location = new System.Drawing.Point(405, 398);
            this.buttonBajaRestaurar.Name = "buttonBajaRestaurar";
            this.buttonBajaRestaurar.Size = new System.Drawing.Size(113, 33);
            this.buttonBajaRestaurar.TabIndex = 22;
            this.buttonBajaRestaurar.Text = "Baja / Restaurar";
            this.buttonBajaRestaurar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(201, 398);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(116, 33);
            this.buttonModificar.TabIndex = 21;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonDesbloquear
            // 
            this.buttonDesbloquear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesbloquear.Location = new System.Drawing.Point(16, 399);
            this.buttonDesbloquear.Name = "buttonDesbloquear";
            this.buttonDesbloquear.Size = new System.Drawing.Size(102, 33);
            this.buttonDesbloquear.TabIndex = 19;
            this.buttonDesbloquear.Text = "Desbloquear";
            this.buttonDesbloquear.UseVisualStyleBackColor = true;
            // 
            // usuariosDataGrid
            // 
            this.usuariosDataGrid.AllowUserToAddRows = false;
            this.usuariosDataGrid.AllowUserToDeleteRows = false;
            this.usuariosDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuariosDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usuariosDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuariosDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usuariosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.idRol,
            this.Estado});
            this.usuariosDataGrid.Location = new System.Drawing.Point(16, 143);
            this.usuariosDataGrid.Name = "usuariosDataGrid";
            this.usuariosDataGrid.ReadOnly = true;
            this.usuariosDataGrid.Size = new System.Drawing.Size(502, 234);
            this.usuariosDataGrid.TabIndex = 23;
            // 
            // Username
            // 
            this.Username.HeaderText = "Nombre de Usuario";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // idRol
            // 
            this.idRol.HeaderText = "Rol";
            this.idRol.Name = "idRol";
            this.idRol.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // labelNombreDeUsuario
            // 
            this.labelNombreDeUsuario.AutoSize = true;
            this.labelNombreDeUsuario.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDeUsuario.Location = new System.Drawing.Point(12, 9);
            this.labelNombreDeUsuario.Name = "labelNombreDeUsuario";
            this.labelNombreDeUsuario.Size = new System.Drawing.Size(140, 21);
            this.labelNombreDeUsuario.TabIndex = 12;
            this.labelNombreDeUsuario.Text = "Nombre de Usuario";
            // 
            // textBoxNombreDeUsuario
            // 
            this.textBoxNombreDeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombreDeUsuario.Location = new System.Drawing.Point(16, 32);
            this.textBoxNombreDeUsuario.Name = "textBoxNombreDeUsuario";
            this.textBoxNombreDeUsuario.Size = new System.Drawing.Size(241, 20);
            this.textBoxNombreDeUsuario.TabIndex = 10;
            // 
            // ABMUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 443);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonBajaRestaurar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonDesbloquear);
            this.Controls.Add(this.usuariosDataGrid);
            this.Controls.Add(this.labelNombreDeUsuario);
            this.Controls.Add(this.textBoxNombreDeUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ABMUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonBajaRestaurar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonDesbloquear;
        private System.Windows.Forms.DataGridView usuariosDataGrid;
        private System.Windows.Forms.Label labelNombreDeUsuario;
        private System.Windows.Forms.TextBox textBoxNombreDeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}