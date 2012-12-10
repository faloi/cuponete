namespace GrouponDesktop.Views
{
    partial class ABMProveedor
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
            this.buttonBajaRestaurar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonNuevoProveedor = new System.Windows.Forms.Button();
            this.proveedoresDataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCuit = new System.Windows.Forms.TextBox();
            this.textBoxRazonSocial = new System.Windows.Forms.TextBox();
            this.labelRazonSocial = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelCUIT = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.limpiarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBajaRestaurar
            // 
            this.buttonBajaRestaurar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBajaRestaurar.Location = new System.Drawing.Point(438, 400);
            this.buttonBajaRestaurar.Name = "buttonBajaRestaurar";
            this.buttonBajaRestaurar.Size = new System.Drawing.Size(147, 33);
            this.buttonBajaRestaurar.TabIndex = 7;
            this.buttonBajaRestaurar.Text = "Baja / Restaurar";
            this.buttonBajaRestaurar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(227, 400);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(147, 33);
            this.buttonModificar.TabIndex = 6;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevoProveedor
            // 
            this.buttonNuevoProveedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoProveedor.Location = new System.Drawing.Point(17, 400);
            this.buttonNuevoProveedor.Name = "buttonNuevoProveedor";
            this.buttonNuevoProveedor.Size = new System.Drawing.Size(147, 33);
            this.buttonNuevoProveedor.TabIndex = 5;
            this.buttonNuevoProveedor.Text = "Nuevo Proveedor";
            this.buttonNuevoProveedor.UseVisualStyleBackColor = true;
            // 
            // proveedoresDataGrid
            // 
            this.proveedoresDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.proveedoresDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.proveedoresDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.proveedoresDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.proveedoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedoresDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRazonSocial,
            this.ColumnCUIT,
            this.ColumnEmail});
            this.proveedoresDataGrid.Location = new System.Drawing.Point(17, 144);
            this.proveedoresDataGrid.Name = "proveedoresDataGrid";
            this.proveedoresDataGrid.Size = new System.Drawing.Size(568, 234);
            this.proveedoresDataGrid.TabIndex = 8;
            // 
            // ColumnRazonSocial
            // 
            this.ColumnRazonSocial.HeaderText = "Razon Social";
            this.ColumnRazonSocial.Name = "ColumnRazonSocial";
            // 
            // ColumnCUIT
            // 
            this.ColumnCUIT.HeaderText = "CUIT";
            this.ColumnCUIT.Name = "ColumnCUIT";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // textBoxCuit
            // 
            this.textBoxCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCuit.Location = new System.Drawing.Point(17, 96);
            this.textBoxCuit.Name = "textBoxCuit";
            this.textBoxCuit.Size = new System.Drawing.Size(158, 20);
            this.textBoxCuit.TabIndex = 1;
            // 
            // textBoxRazonSocial
            // 
            this.textBoxRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRazonSocial.Location = new System.Drawing.Point(17, 35);
            this.textBoxRazonSocial.Name = "textBoxRazonSocial";
            this.textBoxRazonSocial.Size = new System.Drawing.Size(337, 20);
            this.textBoxRazonSocial.TabIndex = 0;
            // 
            // labelRazonSocial
            // 
            this.labelRazonSocial.AutoSize = true;
            this.labelRazonSocial.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRazonSocial.Location = new System.Drawing.Point(13, 11);
            this.labelRazonSocial.Name = "labelRazonSocial";
            this.labelRazonSocial.Size = new System.Drawing.Size(94, 21);
            this.labelRazonSocial.TabIndex = 26;
            this.labelRazonSocial.Text = "Razon Social";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new System.Drawing.Point(196, 96);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(158, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // labelCUIT
            // 
            this.labelCUIT.AutoSize = true;
            this.labelCUIT.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCUIT.Location = new System.Drawing.Point(13, 72);
            this.labelCUIT.Name = "labelCUIT";
            this.labelCUIT.Size = new System.Drawing.Size(42, 21);
            this.labelCUIT.TabIndex = 28;
            this.labelCUIT.Text = "CUIT";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(192, 72);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 21);
            this.labelEmail.TabIndex = 29;
            this.labelEmail.Text = "Email";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(422, 72);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(163, 44);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // limpiarButton
            // 
            this.limpiarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.Location = new System.Drawing.Point(422, 30);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(163, 25);
            this.limpiarButton.TabIndex = 4;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // ABMProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 453);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCUIT);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelRazonSocial);
            this.Controls.Add(this.buttonBajaRestaurar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonNuevoProveedor);
            this.Controls.Add(this.proveedoresDataGrid);
            this.Controls.Add(this.textBoxCuit);
            this.Controls.Add(this.textBoxRazonSocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ABMProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBajaRestaurar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonNuevoProveedor;
        private System.Windows.Forms.DataGridView proveedoresDataGrid;
        private System.Windows.Forms.TextBox textBoxCuit;
        private System.Windows.Forms.TextBox textBoxRazonSocial;
        private System.Windows.Forms.Label labelRazonSocial;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelCUIT;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button limpiarButton;
    }
}