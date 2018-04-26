namespace Procesadora
{
    partial class frmReportesCompras
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
            this.gbfecha = new System.Windows.Forms.GroupBox();
            this.dtp_prod = new System.Windows.Forms.DateTimePicker();
            this.gbValor = new System.Windows.Forms.GroupBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbfecha.SuspendLayout();
            this.gbValor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbfecha
            // 
            this.gbfecha.Controls.Add(this.dtp_prod);
            this.gbfecha.Location = new System.Drawing.Point(176, 12);
            this.gbfecha.Name = "gbfecha";
            this.gbfecha.Size = new System.Drawing.Size(173, 64);
            this.gbfecha.TabIndex = 12;
            this.gbfecha.TabStop = false;
            this.gbfecha.Text = "Fecha";
            this.gbfecha.Visible = false;
            // 
            // dtp_prod
            // 
            this.dtp_prod.CustomFormat = "dd/MM/yyyy";
            this.dtp_prod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_prod.Location = new System.Drawing.Point(6, 25);
            this.dtp_prod.Name = "dtp_prod";
            this.dtp_prod.Size = new System.Drawing.Size(126, 26);
            this.dtp_prod.TabIndex = 9;
            this.dtp_prod.Value = new System.DateTime(2017, 11, 12, 0, 0, 0, 0);
            this.dtp_prod.ValueChanged += new System.EventHandler(this.dtp_prod_ValueChanged);
            // 
            // gbValor
            // 
            this.gbValor.Controls.Add(this.cmdBuscar);
            this.gbValor.Controls.Add(this.txt_valor);
            this.gbValor.Location = new System.Drawing.Point(176, 12);
            this.gbValor.Name = "gbValor";
            this.gbValor.Size = new System.Drawing.Size(173, 64);
            this.gbValor.TabIndex = 11;
            this.gbValor.TabStop = false;
            this.gbValor.Text = "Valor:";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackgroundImage = global::Procesadora.Properties.Resources.Lupa;
            this.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscar.Location = new System.Drawing.Point(133, 22);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(31, 30);
            this.cmdBuscar.TabIndex = 4;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txt_valor
            // 
            this.txt_valor.Enabled = false;
            this.txt_valor.Location = new System.Drawing.Point(6, 25);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(121, 26);
            this.txt_valor.TabIndex = 3;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 82);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(675, 266);
            this.dgv.TabIndex = 10;
            this.dgv.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 64);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // frmReportesCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 362);
            this.Controls.Add(this.gbfecha);
            this.Controls.Add(this.gbValor);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportesCompras";
            this.Text = "Reportes de compras";
            this.Load += new System.EventHandler(this.frmReportesCompras_Load);
            this.gbfecha.ResumeLayout(false);
            this.gbValor.ResumeLayout(false);
            this.gbValor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfecha;
        private System.Windows.Forms.DateTimePicker dtp_prod;
        private System.Windows.Forms.GroupBox gbValor;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}