namespace Procesadora
{
    partial class frmRetirarProducto
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
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.IdInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.dtpFechaTransferencia = new System.Windows.Forms.DateTimePicker();
            this.gbFechaTransfer = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.gbDestino.SuspendLayout();
            this.gbFechaTransfer.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.BackgroundImage = global::Procesadora.Properties.Resources.Paloma;
            this.cmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAceptar.Location = new System.Drawing.Point(593, 292);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(66, 58);
            this.cmdAceptar.TabIndex = 16;
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AllowUserToOrderColumns = true;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInsumo,
            this.NombeInsumo,
            this.Cantida,
            this.Presentacion,
            this.stock});
            this.dgvCompra.Location = new System.Drawing.Point(12, 14);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(572, 386);
            this.dgvCompra.TabIndex = 15;
            this.dgvCompra.TabStop = false;
            // 
            // IdInsumo
            // 
            this.IdInsumo.HeaderText = "ID Producto";
            this.IdInsumo.Name = "IdInsumo";
            this.IdInsumo.ReadOnly = true;
            this.IdInsumo.Width = 130;
            // 
            // NombeInsumo
            // 
            this.NombeInsumo.FillWeight = 140F;
            this.NombeInsumo.HeaderText = "Nombre";
            this.NombeInsumo.Name = "NombeInsumo";
            this.NombeInsumo.ReadOnly = true;
            this.NombeInsumo.Width = 160;
            // 
            // Cantida
            // 
            this.Cantida.HeaderText = "Cantidad";
            this.Cantida.Name = "Cantida";
            this.Cantida.ReadOnly = true;
            // 
            // Presentacion
            // 
            this.Presentacion.HeaderText = "Presentación";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            this.Presentacion.Width = 140;
            // 
            // stock
            // 
            this.stock.HeaderText = "stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Concepto:";
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.BackColor = System.Drawing.Color.Red;
            this.lbl_concepto.Location = new System.Drawing.Point(676, 14);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(50, 18);
            this.lbl_concepto.TabIndex = 18;
            this.lbl_concepto.Text = "label2";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(593, 181);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(309, 76);
            this.txtObservaciones.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Observaciones:";
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.lbl_destino);
            this.gbDestino.Location = new System.Drawing.Point(593, 35);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(306, 54);
            this.gbDestino.TabIndex = 21;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Sucursal destino";
            this.gbDestino.Visible = false;
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.BackColor = System.Drawing.Color.Red;
            this.lbl_destino.Location = new System.Drawing.Point(6, 22);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(50, 18);
            this.lbl_destino.TabIndex = 22;
            this.lbl_destino.Text = "label2";
            // 
            // dtpFechaTransferencia
            // 
            this.dtpFechaTransferencia.Location = new System.Drawing.Point(9, 25);
            this.dtpFechaTransferencia.Name = "dtpFechaTransferencia";
            this.dtpFechaTransferencia.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaTransferencia.TabIndex = 22;
            // 
            // gbFechaTransfer
            // 
            this.gbFechaTransfer.Controls.Add(this.dtpFechaTransferencia);
            this.gbFechaTransfer.Location = new System.Drawing.Point(593, 95);
            this.gbFechaTransfer.Name = "gbFechaTransfer";
            this.gbFechaTransfer.Size = new System.Drawing.Size(243, 62);
            this.gbFechaTransfer.TabIndex = 23;
            this.gbFechaTransfer.TabStop = false;
            this.gbFechaTransfer.Text = "Fecha de retiro";
            // 
            // frmRetirarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 412);
            this.Controls.Add(this.gbFechaTransfer);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lbl_concepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.dgvCompra);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRetirarProducto";
            this.Text = "Retirar producto";
            this.Load += new System.EventHandler(this.frmRetirarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.gbFechaTransfer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAceptar;
        public System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.DateTimePicker dtpFechaTransferencia;
        private System.Windows.Forms.GroupBox gbFechaTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}