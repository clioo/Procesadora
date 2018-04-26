namespace Procesadora
{
    partial class frmOrdenRetirarInsumos
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdReducir = new System.Windows.Forms.Button();
            this.cmdAumentar = new System.Windows.Forms.Button();
            this.cmdCancelarVenta = new System.Windows.Forms.Button();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.IdInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombeInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtIdInsumo = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaRequerida = new System.Windows.Forms.DateTimePicker();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDescripcion);
            this.groupBox4.Location = new System.Drawing.Point(493, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 116);
            this.groupBox4.TabIndex = 145;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Observaciones";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 25);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 85);
            this.txtDescripcion.TabIndex = 0;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(356, 35);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(100, 30);
            this.cmdAgregar.TabIndex = 144;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.BackgroundImage = global::Procesadora.Properties.Resources.Cruz;
            this.cmdEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdEliminar.Location = new System.Drawing.Point(145, 325);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(61, 59);
            this.cmdEliminar.TabIndex = 153;
            this.cmdEliminar.TabStop = false;
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdReducir
            // 
            this.cmdReducir.BackgroundImage = global::Procesadora.Properties.Resources.Menos;
            this.cmdReducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdReducir.Location = new System.Drawing.Point(78, 325);
            this.cmdReducir.Name = "cmdReducir";
            this.cmdReducir.Size = new System.Drawing.Size(61, 59);
            this.cmdReducir.TabIndex = 152;
            this.cmdReducir.TabStop = false;
            this.cmdReducir.UseVisualStyleBackColor = true;
            this.cmdReducir.Click += new System.EventHandler(this.cmdReducir_Click);
            // 
            // cmdAumentar
            // 
            this.cmdAumentar.BackgroundImage = global::Procesadora.Properties.Resources.Mas;
            this.cmdAumentar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAumentar.Location = new System.Drawing.Point(11, 327);
            this.cmdAumentar.Name = "cmdAumentar";
            this.cmdAumentar.Size = new System.Drawing.Size(61, 54);
            this.cmdAumentar.TabIndex = 151;
            this.cmdAumentar.TabStop = false;
            this.cmdAumentar.UseVisualStyleBackColor = true;
            this.cmdAumentar.Click += new System.EventHandler(this.cmdAumentar_Click);
            // 
            // cmdCancelarVenta
            // 
            this.cmdCancelarVenta.BackgroundImage = global::Procesadora.Properties.Resources.Cancelar;
            this.cmdCancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCancelarVenta.Location = new System.Drawing.Point(565, 204);
            this.cmdCancelarVenta.Name = "cmdCancelarVenta";
            this.cmdCancelarVenta.Size = new System.Drawing.Size(66, 60);
            this.cmdCancelarVenta.TabIndex = 149;
            this.cmdCancelarVenta.TabStop = false;
            this.cmdCancelarVenta.UseVisualStyleBackColor = true;
            this.cmdCancelarVenta.Click += new System.EventHandler(this.cmdCancelarVenta_Click);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.BackgroundImage = global::Procesadora.Properties.Resources.Paloma;
            this.cmdAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAceptar.Location = new System.Drawing.Point(493, 204);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(66, 58);
            this.cmdAceptar.TabIndex = 148;
            this.cmdAceptar.TabStop = false;
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
            this.Cantidad});
            this.dgvCompra.Location = new System.Drawing.Point(12, 76);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.ReadOnly = true;
            this.dgvCompra.Size = new System.Drawing.Size(475, 243);
            this.dgvCompra.TabIndex = 150;
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 140;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Location = new System.Drawing.Point(231, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 58);
            this.groupBox3.TabIndex = 143;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(7, 26);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(96, 25);
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
            this.groupBox8.TabIndex = 142;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ID del insumo";
            // 
            // txtIdInsumo
            // 
            this.txtIdInsumo.Location = new System.Drawing.Point(7, 26);
            this.txtIdInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdInsumo.Name = "txtIdInsumo";
            this.txtIdInsumo.Size = new System.Drawing.Size(148, 25);
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
            // validador
            // 
            this.validador.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaRequerida);
            this.groupBox1.Location = new System.Drawing.Point(493, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 64);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha requerida";
            // 
            // dtpFechaRequerida
            // 
            this.dtpFechaRequerida.Location = new System.Drawing.Point(6, 24);
            this.dtpFechaRequerida.Name = "dtpFechaRequerida";
            this.dtpFechaRequerida.Size = new System.Drawing.Size(200, 25);
            this.dtpFechaRequerida.TabIndex = 0;
            // 
            // frmOrdenRetirarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdReducir);
            this.Controls.Add(this.cmdAumentar);
            this.Controls.Add(this.cmdCancelarVenta);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.dgvCompra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox8);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOrdenRetirarInsumos";
            this.Text = "Orden retirar insump";
            this.Load += new System.EventHandler(this.frmOrdenRetirarInsumos_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdReducir;
        private System.Windows.Forms.Button cmdAumentar;
        private System.Windows.Forms.Button cmdCancelarVenta;
        private System.Windows.Forms.Button cmdAceptar;
        public System.Windows.Forms.DataGridView dgvCompra;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.TextBox txtIdInsumo;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.ErrorProvider validador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombeInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaRequerida;

    }
}