namespace Procesadora
{
    partial class frmRetirarInsumo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.idprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Almacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFechaTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFechaTransfer
            // 
            this.gbFechaTransfer.Controls.Add(this.dtpFechaTransferencia);
            this.gbFechaTransfer.Location = new System.Drawing.Point(667, 12);
            this.gbFechaTransfer.Name = "gbFechaTransfer";
            this.gbFechaTransfer.Size = new System.Drawing.Size(243, 62);
            this.gbFechaTransfer.TabIndex = 31;
            this.gbFechaTransfer.TabStop = false;
            this.gbFechaTransfer.Text = "Fecha de retiro";
            // 
            // dtpFechaTransferencia
            // 
            this.dtpFechaTransferencia.Location = new System.Drawing.Point(9, 25);
            this.dtpFechaTransferencia.Name = "dtpFechaTransferencia";
            this.dtpFechaTransferencia.Size = new System.Drawing.Size(200, 26);
            this.dtpFechaTransferencia.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(667, 98);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(309, 76);
            this.txtObservaciones.TabIndex = 28;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.BackgroundImage = global::Procesadora.Properties.Resources.Paloma;
            this.cmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAceptar.Location = new System.Drawing.Point(667, 209);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(66, 58);
            this.cmdAceptar.TabIndex = 25;
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
            this.idprod,
            this.nombreprod,
            this.Cantidad,
            this.unidadmedida,
            this.Almacen,
            this.stock});
            this.dgvCompra.Location = new System.Drawing.Point(12, 12);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(649, 316);
            this.dgvCompra.TabIndex = 32;
            // 
            // idprod
            // 
            this.idprod.HeaderText = "ID insumo";
            this.idprod.Name = "idprod";
            this.idprod.ReadOnly = true;
            // 
            // nombreprod
            // 
            this.nombreprod.HeaderText = "Nombre";
            this.nombreprod.Name = "nombreprod";
            this.nombreprod.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // unidadmedida
            // 
            this.unidadmedida.HeaderText = "Unidad medida";
            this.unidadmedida.Name = "unidadmedida";
            this.unidadmedida.ReadOnly = true;
            // 
            // Almacen
            // 
            this.Almacen.HeaderText = "Almacén";
            this.Almacen.Name = "Almacen";
            this.Almacen.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // frmRetirarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 411);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.gbFechaTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.cmdAceptar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRetirarInsumo";
            this.Text = "Retirar insumo";
            this.Load += new System.EventHandler(this.frmRetirarInsumo_Load);
            this.gbFechaTransfer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFechaTransfer;
        private System.Windows.Forms.DateTimePicker dtpFechaTransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}