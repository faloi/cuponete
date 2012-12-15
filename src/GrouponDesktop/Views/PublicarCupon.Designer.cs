namespace GrouponDesktop.Views
{
    partial class PublicarCupon
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
            this.labelCuponesDisponibles = new System.Windows.Forms.Label();
            this.cuponDataGrid = new System.Windows.Forms.DataGridView();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonPublicar = new System.Windows.Forms.Button();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.fecActual = new System.Windows.Forms.DateTimePicker();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.limpiarButton = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuponDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCuponesDisponibles
            // 
            this.labelCuponesDisponibles.AutoSize = true;
            this.labelCuponesDisponibles.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuponesDisponibles.Location = new System.Drawing.Point(271, 9);
            this.labelCuponesDisponibles.Name = "labelCuponesDisponibles";
            this.labelCuponesDisponibles.Size = new System.Drawing.Size(189, 37);
            this.labelCuponesDisponibles.TabIndex = 1;
            this.labelCuponesDisponibles.Text = "Publicar Cupón";
            this.labelCuponesDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cuponDataGrid
            // 
            this.cuponDataGrid.AllowUserToAddRows = false;
            this.cuponDataGrid.AllowUserToDeleteRows = false;
            this.cuponDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cuponDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cuponDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.cuponDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cuponDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proveedor,
            this.Descripcion,
            this.PrecioReal,
            this.Cantidad});
            this.cuponDataGrid.Location = new System.Drawing.Point(10, 167);
            this.cuponDataGrid.Name = "cuponDataGrid";
            this.cuponDataGrid.ReadOnly = true;
            this.cuponDataGrid.Size = new System.Drawing.Size(699, 225);
            this.cuponDataGrid.TabIndex = 4;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioReal
            // 
            this.PrecioReal.HeaderText = "Precio Real";
            this.PrecioReal.Name = "PrecioReal";
            this.PrecioReal.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(293, 452);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(140, 29);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Volver";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonPublicar
            // 
            this.buttonPublicar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPublicar.Location = new System.Drawing.Point(258, 398);
            this.buttonPublicar.Name = "buttonPublicar";
            this.buttonPublicar.Size = new System.Drawing.Size(213, 36);
            this.buttonPublicar.TabIndex = 5;
            this.buttonPublicar.Text = "Publicar";
            this.buttonPublicar.UseVisualStyleBackColor = true;
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(465, 84);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxProveedor.TabIndex = 1;
            // 
            // fecActual
            // 
            this.fecActual.Enabled = false;
            this.fecActual.Location = new System.Drawing.Point(10, 84);
            this.fecActual.Name = "fecActual";
            this.fecActual.Size = new System.Drawing.Size(207, 20);
            this.fecActual.TabIndex = 0;
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.Location = new System.Drawing.Point(461, 60);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(79, 21);
            this.labelProveedor.TabIndex = 32;
            this.labelProveedor.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Fecha actual";
            // 
            // limpiarButton
            // 
            this.limpiarButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarButton.Location = new System.Drawing.Point(367, 125);
            this.limpiarButton.Name = "limpiarButton";
            this.limpiarButton.Size = new System.Drawing.Size(207, 36);
            this.limpiarButton.TabIndex = 3;
            this.limpiarButton.Text = "Limpiar";
            this.limpiarButton.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(154, 125);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(207, 36);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Descripcion";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(235, 84);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(210, 20);
            this.descripcionTextBox.TabIndex = 36;
            // 
            // PublicarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 505);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limpiarButton);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.fecActual);
            this.Controls.Add(this.comboBoxProveedor);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonPublicar);
            this.Controls.Add(this.cuponDataGrid);
            this.Controls.Add(this.labelCuponesDisponibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PublicarCupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicar Cupon";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuponDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCuponesDisponibles;
        private System.Windows.Forms.DataGridView cuponDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonPublicar;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private System.Windows.Forms.DateTimePicker fecActual;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpiarButton;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descripcionTextBox;
    }
}