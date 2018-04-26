namespace Procesadora
{
    partial class frmVentaGeneral
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
            this.components = new System.ComponentModel.Container();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmdBuscarCliente = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtIdInsumo = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdReducir = new System.Windows.Forms.Button();
            this.cmdAumentar = new System.Windows.Forms.Button();
            this.cmdCancelarVenta = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(686, 510);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 35);
            this.txtTotal.TabIndex = 158;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaSolicitud);
            this.groupBox2.Location = new System.Drawing.Point(792, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 58);
            this.groupBox2.TabIndex = 156;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha de compra";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(13, 25);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(288, 26);
            this.dtpFechaSolicitud.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.cmdBuscarCliente);
            this.groupBox1.Location = new System.Drawing.Point(792, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 58);
            this.groupBox1.TabIndex = 155;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID del cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(7, 26);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(148, 26);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTicket_KeyPress);
            // 
            // cmdBuscarCliente
            // 
            this.cmdBuscarCliente.BackgroundImage = global::Procesadora.Properties.Resources.Lupa;
            this.cmdBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscarCliente.Location = new System.Drawing.Point(176, 22);
            this.cmdBuscarCliente.Name = "cmdBuscarCliente";
            this.cmdBuscarCliente.Size = new System.Drawing.Size(31, 30);
            this.cmdBuscarCliente.TabIndex = 1;
            this.cmdBuscarCliente.UseVisualStyleBackColor = true;
            this.cmdBuscarCliente.Click += new System.EventHandler(this.cmdBuscarCliente_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(356, 35);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(100, 30);
            this.cmdAgregar.TabIndex = 148;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // dgvCompra
            // 
            this.dgvCompra.AllowUserToAddRows = false;
            this.dgvCompra.AllowUserToDeleteRows = false;
            this.dgvCompra.AllowUserToOrderColumns = true;
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.NombeInsumo,
            this.Presentacion,
            this.Cantidad,
            this.Precio,
            this.subtotal});
            this.dgvCompra.Location = new System.Drawing.Point(12, 76);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(774, 428);
            this.dgvCompra.TabIndex = 151;
            this.dgvCompra.TabStop = false;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 130;
            // 
            // NombeInsumo
            // 
            this.NombeInsumo.FillWeight = 140F;
            this.NombeInsumo.HeaderText = "Nombre";
            this.NombeInsumo.Name = "NombeInsumo";
            this.NombeInsumo.ReadOnly = true;
            this.NombeInsumo.Width = 160;
            // 
            // Presentacion
            // 
            this.Presentacion.HeaderText = "Presentacion";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 140;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Location = new System.Drawing.Point(231, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 58);
            this.groupBox3.TabIndex = 147;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(7, 26);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(96, 26);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtIdInsumo);
            this.groupBox8.Controls.Add(this.cmdBuscar);
            this.groupBox8.Location = new System.Drawing.Point(12, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(213, 58);
            this.groupBox8.TabIndex = 146;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ID del producto";
            // 
            // txtIdInsumo
            // 
            this.txtIdInsumo.Location = new System.Drawing.Point(7, 26);
            this.txtIdInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdInsumo.Name = "txtIdInsumo";
            this.txtIdInsumo.Size = new System.Drawing.Size(148, 26);
            this.txtIdInsumo.TabIndex = 0;
            this.txtIdInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_insumo_KeyPress);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackgroundImage = global::Procesadora.Properties.Resources.Lupa;
            this.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscar.Location = new System.Drawing.Point(176, 22);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(31, 30);
            this.cmdBuscar.TabIndex = 1;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackgroundImage = global::Procesadora.Properties.Resources.Cruz;
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdEliminar.Location = new System.Drawing.Point(145, 510);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(61, 59);
            this.cmdEliminar.TabIndex = 154;
            this.cmdEliminar.TabStop = false;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdReducir
            // 
            this.cmdReducir.BackgroundImage = global::Procesadora.Properties.Resources.Menos;
            this.cmdReducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdReducir.Location = new System.Drawing.Point(78, 510);
            this.cmdReducir.Name = "cmdReducir";
            this.cmdReducir.Size = new System.Drawing.Size(61, 59);
            this.cmdReducir.TabIndex = 153;
            this.cmdReducir.TabStop = false;
            this.cmdReducir.UseVisualStyleBackColor = true;
            this.cmdReducir.Click += new System.EventHandler(this.cmdReducir_Click);
            // 
            // cmdAumentar
            // 
            this.cmdAumentar.BackgroundImage = global::Procesadora.Properties.Resources.Mas;
            this.cmdAumentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAumentar.Location = new System.Drawing.Point(11, 512);
            this.cmdAumentar.Name = "cmdAumentar";
            this.cmdAumentar.Size = new System.Drawing.Size(61, 54);
            this.cmdAumentar.TabIndex = 152;
            this.cmdAumentar.TabStop = false;
            this.cmdAumentar.UseVisualStyleBackColor = true;
            this.cmdAumentar.Click += new System.EventHandler(this.cmdAumentar_Click);
            // 
            // cmdCancelarVenta
            // 
            this.cmdCancelarVenta.BackgroundImage = global::Procesadora.Properties.Resources.Cancelar;
            this.cmdCancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCancelarVenta.Location = new System.Drawing.Point(871, 444);
            this.cmdCancelarVenta.Name = "cmdCancelarVenta";
            this.cmdCancelarVenta.Size = new System.Drawing.Size(66, 60);
            this.cmdCancelarVenta.TabIndex = 150;
            this.cmdCancelarVenta.TabStop = false;
            this.cmdCancelarVenta.UseVisualStyleBackColor = true;
            this.cmdCancelarVenta.Click += new System.EventHandler(this.cmdCancelarVenta_Click);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.BackgroundImage = global::Procesadora.Properties.Resources.Paloma;
            this.cmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAceptar.Location = new System.Drawing.Point(799, 446);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(66, 58);
            this.cmdAceptar.TabIndex = 149;
            this.cmdAceptar.TabStop = false;
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // validador
            // 
            this.validador.ContainerControl = this;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbTipoPago);
            this.groupBox5.Location = new System.Drawing.Point(792, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(149, 58);
            this.groupBox5.TabIndex = 159;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tipo de pago";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Crédito",
            "Cheque"});
            this.cbTipoPago.Location = new System.Drawing.Point(6, 25);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(120, 26);
            this.cbTipoPago.TabIndex = 0;
            // 
            // frmVentaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 572);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdReducir);
            this.Controls.Add(this.cmdAumentar);
            this.Controls.Add(this.cmdCancelarVenta);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox8);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVentaGeneral";
            this.Text = "Venta general";
            this.Load += new System.EventHandler(this.frmVentaGeneral_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button cmdBuscarCliente;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdReducir;
        private System.Windows.Forms.Button cmdAumentar;
        private System.Windows.Forms.Button cmdCancelarVenta;
        private System.Windows.Forms.Button cmdAceptar;
        public System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.TextBox txtIdInsumo;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.ErrorProvider validador;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.ComboBox cbTipoPago;
    }
}