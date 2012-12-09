namespace GrouponDesktop.Views
{
    partial class FacturarProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.labelDesde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodigoCupon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonFacturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.Location = new System.Drawing.Point(12, 9);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(79, 21);
            this.labelProveedor.TabIndex = 28;
            this.labelProveedor.Text = "Proveedor";
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProveedor.Location = new System.Drawing.Point(16, 33);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(299, 20);
            this.textBoxProveedor.TabIndex = 27;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(334, 22);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(112, 36);
            this.buttonBuscar.TabIndex = 29;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(247, 90);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHasta.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Hasta";
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(16, 91);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 30;
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesde.Location = new System.Drawing.Point(12, 66);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(52, 21);
            this.labelDesde.TabIndex = 32;
            this.labelDesde.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cupones a Facturar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCupon,
            this.FechaCanje,
            this.Monto});
            this.dataGridView1.Location = new System.Drawing.Point(16, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 190);
            this.dataGridView1.TabIndex = 35;
            // 
            // CodigoCupon
            // 
            this.CodigoCupon.HeaderText = "Código Cupón";
            this.CodigoCupon.Name = "CodigoCupon";
            // 
            // FechaCanje
            // 
            this.FechaCanje.HeaderText = "Fecha de Canje";
            this.FechaCanje.Name = "FechaCanje";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(158, 392);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(140, 29);
            this.buttonCancelar.TabIndex = 37;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonFacturar
            // 
            this.buttonFacturar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacturar.Location = new System.Drawing.Point(121, 345);
            this.buttonFacturar.Name = "buttonFacturar";
            this.buttonFacturar.Size = new System.Drawing.Size(213, 36);
            this.buttonFacturar.TabIndex = 36;
            this.buttonFacturar.Text = "Facturar";
            this.buttonFacturar.UseVisualStyleBackColor = true;
            // 
            // FacturarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 432);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonFacturar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.textBoxProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FacturarProveedor";
            this.Text = "Facturar a Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label labelDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonFacturar;
    }
}