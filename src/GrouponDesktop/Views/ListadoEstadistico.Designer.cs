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
            this.labelEstadisticasSemestrales = new System.Windows.Forms.Label();
            this.comboBoxSemestre = new System.Windows.Forms.ComboBox();
            this.labelSemestre = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.textBoxAno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoListado = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEstadisticasSemestrales
            // 
            this.labelEstadisticasSemestrales.AutoSize = true;
            this.labelEstadisticasSemestrales.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadisticasSemestrales.Location = new System.Drawing.Point(107, 9);
            this.labelEstadisticasSemestrales.Name = "labelEstadisticasSemestrales";
            this.labelEstadisticasSemestrales.Size = new System.Drawing.Size(282, 37);
            this.labelEstadisticasSemestrales.TabIndex = 2;
            this.labelEstadisticasSemestrales.Text = "Estadisticas Semestrales";
            this.labelEstadisticasSemestrales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSemestre
            // 
            this.comboBoxSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestre.FormattingEnabled = true;
            this.comboBoxSemestre.Location = new System.Drawing.Point(19, 136);
            this.comboBoxSemestre.Name = "comboBoxSemestre";
            this.comboBoxSemestre.Size = new System.Drawing.Size(130, 21);
            this.comboBoxSemestre.TabIndex = 1;
            // 
            // labelSemestre
            // 
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSemestre.Location = new System.Drawing.Point(15, 112);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(71, 21);
            this.labelSemestre.TabIndex = 29;
            this.labelSemestre.Text = "Semestre";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAno.Location = new System.Drawing.Point(165, 112);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(38, 21);
            this.labelAno.TabIndex = 30;
            this.labelAno.Text = "Año";
            // 
            // textBoxAno
            // 
            this.textBoxAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAno.Location = new System.Drawing.Point(169, 137);
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
            this.comboBoxTipoListado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoListado.FormattingEnabled = true;
            this.comboBoxTipoListado.Location = new System.Drawing.Point(19, 82);
            this.comboBoxTipoListado.Name = "comboBoxTipoListado";
            this.comboBoxTipoListado.Size = new System.Drawing.Size(456, 21);
            this.comboBoxTipoListado.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(19, 184);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(456, 262);
            this.dataGridView.TabIndex = 36;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(169, 457);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(159, 29);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Volver";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(316, 130);
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
            this.ClientSize = new System.Drawing.Size(497, 493);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.dataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConsultar;
    }
}