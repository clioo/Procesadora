namespace Procesadora
{
    partial class frmBuscarCompraCredito
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.grpVALOR = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.grpFECHA = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdRegresar = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.grpVALOR.SuspendLayout();
            this.grpFECHA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBuscarPor);
            this.groupBox1.Location = new System.Drawing.Point(10, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(145, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Location = new System.Drawing.Point(7, 26);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(121, 26);
            this.cbBuscarPor.TabIndex = 0;
            this.cbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.cbBuscarPor_SelectedIndexChanged);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.AllowUserToOrderColumns = true;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(10, 146);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.Size = new System.Drawing.Size(449, 197);
            this.dgvCompras.TabIndex = 1;
            // 
            // grpVALOR
            // 
            this.grpVALOR.Controls.Add(this.txtValor);
            this.grpVALOR.Location = new System.Drawing.Point(163, 65);
            this.grpVALOR.Margin = new System.Windows.Forms.Padding(4);
            this.grpVALOR.Name = "grpVALOR";
            this.grpVALOR.Padding = new System.Windows.Forms.Padding(4);
            this.grpVALOR.Size = new System.Drawing.Size(145, 52);
            this.grpVALOR.TabIndex = 1;
            this.grpVALOR.TabStop = false;
            this.grpVALOR.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(7, 19);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(117, 26);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // grpFECHA
            // 
            this.grpFECHA.Controls.Add(this.dtpHasta);
            this.grpFECHA.Controls.Add(this.label2);
            this.grpFECHA.Controls.Add(this.dtpDesde);
            this.grpFECHA.Controls.Add(this.label1);
            this.grpFECHA.Location = new System.Drawing.Point(145, 13);
            this.grpFECHA.Margin = new System.Windows.Forms.Padding(4);
            this.grpFECHA.Name = "grpFECHA";
            this.grpFECHA.Padding = new System.Windows.Forms.Padding(4);
            this.grpFECHA.Size = new System.Drawing.Size(292, 126);
            this.grpFECHA.TabIndex = 2;
            this.grpFECHA.TabStop = false;
            this.grpFECHA.Text = "Fecha";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(10, 94);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 26);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(10, 44);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 26);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // cmdRegresar
            // 
            this.cmdRegresar.Location = new System.Drawing.Point(359, 360);
            this.cmdRegresar.Name = "cmdRegresar";
            this.cmdRegresar.Size = new System.Drawing.Size(100, 30);
            this.cmdRegresar.TabIndex = 3;
            this.cmdRegresar.Text = "Regresar";
            this.cmdRegresar.UseVisualStyleBackColor = true;
            this.cmdRegresar.Click += new System.EventHandler(this.cmdRegresar_Click);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(253, 360);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(100, 30);
            this.cmdAceptar.TabIndex = 4;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // frmBuscarCompraCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 413);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.cmdRegresar);
            this.Controls.Add(this.grpFECHA);
            this.Controls.Add(this.grpVALOR);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscarCompraCredito";
            this.Text = "Buscar compra a crédito";
            this.Load += new System.EventHandler(this.frmBuscarCompra_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.grpVALOR.ResumeLayout(false);
            this.grpVALOR.PerformLayout();
            this.grpFECHA.ResumeLayout(false);
            this.grpFECHA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.GroupBox grpVALOR;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox grpFECHA;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdRegresar;
        private System.Windows.Forms.Button cmdAceptar;
    }
}