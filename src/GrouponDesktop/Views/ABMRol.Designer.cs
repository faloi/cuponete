namespace GrouponDesktop.Views
{
    partial class ABMRol
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
            this.buttonNuevoRol = new System.Windows.Forms.Button();
            this.rolesDataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelRol = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.nombreRol = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBajaRestaurar
            // 
            this.buttonBajaRestaurar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBajaRestaurar.Location = new System.Drawing.Point(323, 345);
            this.buttonBajaRestaurar.Name = "buttonBajaRestaurar";
            this.buttonBajaRestaurar.Size = new System.Drawing.Size(124, 37);
            this.buttonBajaRestaurar.TabIndex = 5;
            this.buttonBajaRestaurar.Text = "Baja / Restaurar";
            this.buttonBajaRestaurar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(168, 345);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(124, 37);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevoRol
            // 
            this.buttonNuevoRol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoRol.Location = new System.Drawing.Point(16, 345);
            this.buttonNuevoRol.Name = "buttonNuevoRol";
            this.buttonNuevoRol.Size = new System.Drawing.Size(124, 37);
            this.buttonNuevoRol.TabIndex = 3;
            this.buttonNuevoRol.Text = "Nuevo Rol";
            this.buttonNuevoRol.UseVisualStyleBackColor = true;
            // 
            // rolesDataGrid
            // 
            this.rolesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.rolesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rolesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRol});
            this.rolesDataGrid.Location = new System.Drawing.Point(16, 114);
            this.rolesDataGrid.Name = "rolesDataGrid";
            this.rolesDataGrid.Size = new System.Drawing.Size(431, 209);
            this.rolesDataGrid.TabIndex = 6;
            // 
            // ColumnRol
            // 
            this.ColumnRol.HeaderText = "Rol";
            this.ColumnRol.Name = "ColumnRol";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(286, 67);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(161, 41);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(12, 16);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(31, 21);
            this.labelRol.TabIndex = 27;
            this.labelRol.Text = "Rol";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(286, 12);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(161, 31);
            this.buttonLimpiar.TabIndex = 2;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // nombreRol
            // 
            this.nombreRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreRol.Location = new System.Drawing.Point(49, 16);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(184, 20);
            this.nombreRol.TabIndex = 0;
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 399);
            this.Controls.Add(this.nombreRol);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.buttonBajaRestaurar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonNuevoRol);
            this.Controls.Add(this.rolesDataGrid);
            this.Controls.Add(this.buttonBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ABMRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Rol";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBajaRestaurar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonNuevoRol;
        private System.Windows.Forms.DataGridView rolesDataGrid;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRol;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox nombreRol;
    }
}