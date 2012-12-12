namespace GrouponDesktop.Views
{
    partial class ComprarCupon
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
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFicticio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonComprarCupon = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuponDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCuponesDisponibles
            // 
            this.labelCuponesDisponibles.AutoSize = true;
            this.labelCuponesDisponibles.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCuponesDisponibles.Location = new System.Drawing.Point(174, 9);
            this.labelCuponesDisponibles.Name = "labelCuponesDisponibles";
            this.labelCuponesDisponibles.Size = new System.Drawing.Size(252, 37);
            this.labelCuponesDisponibles.TabIndex = 0;
            this.labelCuponesDisponibles.Text = "Cupones Disponibles";
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
            this.Descripcion,
            this.PrecioFicticio,
            this.PrecioReal});
            this.cuponDataGrid.Location = new System.Drawing.Point(10, 49);
            this.cuponDataGrid.Name = "cuponDataGrid";
            this.cuponDataGrid.ReadOnly = true;
            this.cuponDataGrid.Size = new System.Drawing.Size(572, 194);
            this.cuponDataGrid.TabIndex = 1;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioFicticio
            // 
            this.PrecioFicticio.HeaderText = "Precio Ficticio";
            this.PrecioFicticio.Name = "PrecioFicticio";
            this.PrecioFicticio.ReadOnly = true;
            // 
            // PrecioReal
            // 
            this.PrecioReal.HeaderText = "Precio Real";
            this.PrecioReal.Name = "PrecioReal";
            this.PrecioReal.ReadOnly = true;
            // 
            // buttonComprarCupon
            // 
            this.buttonComprarCupon.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComprarCupon.Location = new System.Drawing.Point(192, 249);
            this.buttonComprarCupon.Name = "buttonComprarCupon";
            this.buttonComprarCupon.Size = new System.Drawing.Size(213, 36);
            this.buttonComprarCupon.TabIndex = 2;
            this.buttonComprarCupon.Text = "Comprar Cupón";
            this.buttonComprarCupon.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(246, 304);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 29);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // ComprarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 345);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonComprarCupon);
            this.Controls.Add(this.cuponDataGrid);
            this.Controls.Add(this.labelCuponesDisponibles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ComprarCupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Cupon";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuponDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCuponesDisponibles;
        private System.Windows.Forms.DataGridView cuponDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFicticio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioReal;
        private System.Windows.Forms.Button buttonComprarCupon;
        private System.Windows.Forms.Button buttonCancelar;
    }
}