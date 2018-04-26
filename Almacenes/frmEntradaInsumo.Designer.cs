namespace Procesadora
{
    partial class frmEntradaInsumo
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
            this.gbFechaTransfer = new System.Windows.Forms.GroupBox();
            this.dtpFechaTransferencia = new System.Windows.Forms.DateTimePicker();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.IdInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFechaTransfer.SuspendLayout();
            this.gbDestino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFechaTransfer
            // 
            this.gbFechaTransfer.Controls.Add(this.dtpFechaTransferencia);
            this.gbFechaTransfer.Location = new System.Drawing.Point(593, 93);
            this.gbFechaTransfer.Name = "gbFechaTransfer";
            this.gbFechaTransfer.Size = new System.Drawing.Size(243, 62);
            this.gbFechaTransfer.TabIndex = 37;
            this.gbFechaTransfer.TabStop = false;
            this.gbFechaTransfer.Text = "Fecha de ingreso";
            // 
            // dtpFechaTransferencia
            // 
            this.dtpFechaTransferencia.Location = new System.Drawing.Point(9, 25);
            this.dtpFechaTransferencia.Name = "dtpFechaTransferencia";
            this.dtpFechaTransferencia.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaTransferencia.TabIndex = 22;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.lbl_destino);
            this.gbDestino.Location = new System.Drawing.Point(593, 33);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(306, 54);
            this.gbDestino.TabIndex = 36;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Proveedor";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(593, 179);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(309, 76);
            this.txtObservaciones.TabIndex = 34;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.BackgroundImage = global::Procesadora.Properties.Resources.Paloma;
            this.cmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAceptar.Location = new System.Drawing.Point(593, 290);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(66, 58);
            this.cmdAceptar.TabIndex = 33;
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click_1);
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
            this.Presentacion});
            this.dgvCompra.Location = new System.Drawing.Point(12, 12);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(572, 386);
            this.dgvCompra.TabIndex = 32;
            this.dgvCompra.TabStop = false;
            // 
            // IdInsumo
            // 
            this.IdInsumo.HeaderText = "ID Insumo";
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
            // frmEntradaInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 511);
            this.Controls.Add(this.gbFechaTransfer);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.dgvCompra);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEntradaInsumo";
            this.Load += new System.EventHandler(this.frmRetirarProducto_Load);
            this.gbFechaTransfer.ResumeLayout(false);
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFechaTransfer;
        private System.Windows.Forms.DateTimePicker dtpFechaTransferencia;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button cmdAceptar;
        public System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
    }
}