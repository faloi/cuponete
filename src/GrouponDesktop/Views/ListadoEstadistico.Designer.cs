namespace GrouponDesktop.Views
{
    partial class ListadoEstadistico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelEstadisticasSemestrales = new System.Windows.Forms.Label();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.labelSemestre = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoListado = new System.Windows.Forms.ComboBox();
            this.dataGridViewCuponesDevueltos = new System.Windows.Forms.DataGridView();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeCuponesDevueltos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewGifcardAcreditadas = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiftcardAcreditadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.model)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuponesDevueltos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGifcardAcreditadas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEstadisticasSemestrales
            // 
            this.labelEstadisticasSemestrales.AutoSize = true;
            this.labelEstadisticasSemestrales.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadisticasSemestrales.Location = new System.Drawing.Point(8, 9);
            this.labelEstadisticasSemestrales.Name = "labelEstadisticasSemestrales";
            this.labelEstadisticasSemestrales.Size = new System.Drawing.Size(282, 37);
            this.labelEstadisticasSemestrales.TabIndex = 2;
            this.labelEstadisticasSemestrales.Text = "Estadisticas Semestrales";
            this.labelEstadisticasSemestrales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Location = new System.Drawing.Point(19, 144);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(67, 21);
            this.comboBoxSemestre.TabIndex = 1;
            // 
            // labelSemestre
            // 
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemestre.Location = new System.Drawing.Point(15, 120);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(71, 21);
            this.labelSemestre.TabIndex = 29;
            this.labelSemestre.Text = "Semestre";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.Location = new System.Drawing.Point(200, 120);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(38, 21);
            this.labelAno.TabIndex = 30;
            this.labelAno.Text = "Año";
            // 
            // textBoxAno
            // 
            this.textBoxAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAno.Location = new System.Drawing.Point(204, 145);
            this.textBoxAno.Name = "textBoxAno";
            this.textBoxAno.Size = new System.Drawing.Size(67, 20);
            this.textBoxAno.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tipo de Listado (Top 5)";
            // 
            // comboBoxTipoListado
            // 
            this.comboBoxTipoListado.FormattingEnabled = true;
            this.comboBoxTipoListado.Location = new System.Drawing.Point(19, 82);
            this.comboBoxTipoListado.Name = "comboBoxTipoListado";
            this.comboBoxTipoListado.Size = new System.Drawing.Size(252, 21);
            this.comboBoxTipoListado.TabIndex = 0;
            this.comboBoxTipoListado.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoListado_SelectedIndexChanged);
            // 
            // dataGridViewCuponesDevueltos
            // 
            this.dataGridViewCuponesDevueltos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCuponesDevueltos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCuponesDevueltos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCuponesDevueltos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuponesDevueltos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proveedor,
            this.PorcentajeCuponesDevueltos});
            this.dataGridViewCuponesDevueltos.Location = new System.Drawing.Point(19, 223);
            this.dataGridViewCuponesDevueltos.Name = "dataGridViewCuponesDevueltos";
            this.dataGridViewCuponesDevueltos.Size = new System.Drawing.Size(252, 223);
            this.dataGridViewCuponesDevueltos.TabIndex = 36;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // PorcentajeCuponesDevueltos
            // 
            this.PorcentajeCuponesDevueltos.HeaderText = "% de Cupones Devueltos";
            this.PorcentajeCuponesDevueltos.Name = "PorcentajeCuponesDevueltos";
            // 
            // dataGridViewGifcardAcreditadas
            // 
            this.dataGridViewGifcardAcreditadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGifcardAcreditadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGifcardAcreditadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGifcardAcreditadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGifcardAcreditadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.GiftcardAcreditadas});
            this.dataGridViewGifcardAcreditadas.Location = new System.Drawing.Point(19, 223);
            this.dataGridViewGifcardAcreditadas.Name = "dataGridViewGifcardAcreditadas";
            this.dataGridViewGifcardAcreditadas.Size = new System.Drawing.Size(252, 223);
            this.dataGridViewGifcardAcreditadas.TabIndex = 37;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // GiftcardAcreditadas
            // 
            this.GiftcardAcreditadas.HeaderText = "Giftcard Acreditadas";
            this.GiftcardAcreditadas.Name = "GiftcardAcreditadas";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(64, 452);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(159, 29);
            this.buttonCancelar.TabIndex = 4;
            this.buttonCancelar.Text = "Volver";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(64, 178);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(159, 29);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 493);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridViewGifcardAcreditadas);
            this.Controls.Add(this.dataGridViewCuponesDevueltos);
            this.Controls.Add(this.comboBoxTipoListado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAno);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelSemestre);
            this.Controls.Add(this.comboBoxSemestre);
            this.Controls.Add(this.labelEstadisticasSemestrales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ListadoEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Estadistico";
            ((System.ComponentModel.ISupportInitialize)(this.model)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuponesDevueltos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGifcardAcreditadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEstadisticasSemestrales;
        private System.Windows.Forms.ComboBox comboBoxSemestre;
        private System.Windows.Forms.Label labelSemestre;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.TextBox textBoxAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoListado;
        private System.Windows.Forms.DataGridView dataGridViewCuponesDevueltos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeCuponesDevueltos;
        private System.Windows.Forms.DataGridView dataGridViewGifcardAcreditadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiftcardAcreditadas;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConsultar;
    }
}