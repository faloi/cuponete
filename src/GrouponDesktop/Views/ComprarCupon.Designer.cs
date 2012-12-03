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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioFicticio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonComprarCupon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.PrecioFicticio,
            this.PrecioReal});
            this.dataGridView1.Location = new System.Drawing.Point(10, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 194);
            this.dataGridView1.TabIndex = 1;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // PrecioFicticio
            // 
            this.PrecioFicticio.HeaderText = "Precio Ficticio";
            this.PrecioFicticio.Name = "PrecioFicticio";
            // 
            // PrecioReal
            // 
            this.PrecioReal.HeaderText = "Precio Real";
            this.PrecioReal.Name = "PrecioReal";
            // 
            // buttonComprarCupon
            // 
            this.buttonComprarCupon.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComprarCupon.Location = new System.Drawing.Point(192, 249);
            this.buttonComprarCupon.Name = "buttonComprarCupon";
            this.buttonComprarCupon.Size = new System.Drawing.Size(213, 36);
            this.buttonComprarCupon.TabIndex = 2;
            this.buttonComprarCupon.Text = "Comprar Cupón";
            this.buttonComprarCupon.UseVisualStyleBackColor = true;
            // 
            // ComprarCupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 293);
            this.Controls.Add(this.buttonComprarCupon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCuponesDisponibles);
            this.Name = "ComprarCupon";
            this.Text = "ComprarCupon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCuponesDisponibles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioFicticio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioReal;
        private System.Windows.Forms.Button buttonComprarCupon;
    }
}