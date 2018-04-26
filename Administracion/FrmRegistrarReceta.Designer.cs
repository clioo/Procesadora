namespace Procesadora
{
    partial class FrmRegistrarReceta
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistrarReceta));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbInsumo = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmdRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmd_Eliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmd_Agregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Producto";
            // 
            // dgvReceta
            // 
            this.dgvReceta.AllowUserToAddRows = false;
            this.dgvReceta.AllowUserToDeleteRows = false;
            this.dgvReceta.AllowUserToOrderColumns = true;
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Insumo,
            this.Cantidad,
            this.ID_Insumo});
            this.dgvReceta.Location = new System.Drawing.Point(57, 43);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.ReadOnly = true;
            this.dgvReceta.Size = new System.Drawing.Size(446, 150);
            this.dgvReceta.TabIndex = 1;
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Insumo";
            this.Insumo.Name = "Insumo";
            this.Insumo.ReadOnly = true;
            this.Insumo.Width = 280;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 120;
            // 
            // ID_Insumo
            // 
            this.ID_Insumo.HeaderText = "IDInsumo";
            this.ID_Insumo.Name = "ID_Insumo";
            this.ID_Insumo.ReadOnly = true;
            this.ID_Insumo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Insumo:";
            // 
            // cbInsumo
            // 
            this.cbInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsumo.FormattingEnabled = true;
            this.cbInsumo.Location = new System.Drawing.Point(120, 258);
            this.cbInsumo.Name = "cbInsumo";
            this.cbInsumo.Size = new System.Drawing.Size(121, 21);
            this.cbInsumo.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(120, 217);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(121, 20);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.ActiveBorderThickness = 1;
            this.cmdRegistrar.ActiveCornerRadius = 20;
            this.cmdRegistrar.ActiveFillColor = System.Drawing.Color.DarkGreen;
            this.cmdRegistrar.ActiveForecolor = System.Drawing.Color.White;
            this.cmdRegistrar.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.cmdRegistrar.BackColor = System.Drawing.Color.Gray;
            this.cmdRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrar.BackgroundImage")));
            this.cmdRegistrar.ButtonText = "Registrar";
            this.cmdRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegistrar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmdRegistrar.IdleBorderThickness = 1;
            this.cmdRegistrar.IdleCornerRadius = 20;
            this.cmdRegistrar.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.cmdRegistrar.IdleForecolor = System.Drawing.Color.White;
            this.cmdRegistrar.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.cmdRegistrar.Location = new System.Drawing.Point(26, 308);
            this.cmdRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(119, 41);
            this.cmdRegistrar.TabIndex = 6;
            this.cmdRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdRegistrar.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.Gray;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Limpiar";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(153, 308);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(119, 41);
            this.bunifuThinButton23.TabIndex = 8;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click_1);
            // 
            // cmd_Eliminar
            // 
            this.cmd_Eliminar.ActiveBorderThickness = 1;
            this.cmd_Eliminar.ActiveCornerRadius = 20;
            this.cmd_Eliminar.ActiveFillColor = System.Drawing.Color.DarkGreen;
            this.cmd_Eliminar.ActiveForecolor = System.Drawing.Color.White;
            this.cmd_Eliminar.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.cmd_Eliminar.BackColor = System.Drawing.Color.Gray;
            this.cmd_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Eliminar.BackgroundImage")));
            this.cmd_Eliminar.ButtonText = "Eliminar";
            this.cmd_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Eliminar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Eliminar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmd_Eliminar.IdleBorderThickness = 1;
            this.cmd_Eliminar.IdleCornerRadius = 20;
            this.cmd_Eliminar.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.cmd_Eliminar.IdleForecolor = System.Drawing.Color.White;
            this.cmd_Eliminar.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.cmd_Eliminar.Location = new System.Drawing.Point(375, 217);
            this.cmd_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_Eliminar.Name = "cmd_Eliminar";
            this.cmd_Eliminar.Size = new System.Drawing.Size(119, 41);
            this.cmd_Eliminar.TabIndex = 10;
            this.cmd_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmd_Eliminar.Click += new System.EventHandler(this.cmd_Eliminar_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // cmd_Agregar
            // 
            this.cmd_Agregar.ActiveBorderThickness = 1;
            this.cmd_Agregar.ActiveCornerRadius = 20;
            this.cmd_Agregar.ActiveFillColor = System.Drawing.Color.DarkGreen;
            this.cmd_Agregar.ActiveForecolor = System.Drawing.Color.White;
            this.cmd_Agregar.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.cmd_Agregar.BackColor = System.Drawing.Color.Gray;
            this.cmd_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmd_Agregar.BackgroundImage")));
            this.cmd_Agregar.ButtonText = "Agregar";
            this.cmd_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_Agregar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Agregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmd_Agregar.IdleBorderThickness = 1;
            this.cmd_Agregar.IdleCornerRadius = 20;
            this.cmd_Agregar.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.cmd_Agregar.IdleForecolor = System.Drawing.Color.White;
            this.cmd_Agregar.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.cmd_Agregar.Location = new System.Drawing.Point(248, 217);
            this.cmd_Agregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmd_Agregar.Name = "cmd_Agregar";
            this.cmd_Agregar.Size = new System.Drawing.Size(119, 41);
            this.cmd_Agregar.TabIndex = 9;
            this.cmd_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmd_Agregar.Click += new System.EventHandler(this.cmd_Agregar_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DarkGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Regresar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(280, 308);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(119, 41);
            this.bunifuThinButton21.TabIndex = 11;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // FrmRegistrarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(593, 363);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.cmd_Eliminar);
            this.Controls.Add(this.cmd_Agregar);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbInsumo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarReceta";
            this.Text = "Registrar receta";
            this.Load += new System.EventHandler(this.FrmRegistrarReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbInsumo;
        private System.Windows.Forms.TextBox txtCantidad;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdRegistrar;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        public System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 cmd_Eliminar;
        private System.Windows.Forms.ErrorProvider ep;
        private Bunifu.Framework.UI.BunifuThinButton2 cmd_Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Insumo;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}

