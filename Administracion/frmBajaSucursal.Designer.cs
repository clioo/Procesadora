namespace Procesadora
{
    partial class frmBajaSucursal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cmdCambiar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSucursal);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(175, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sucursal";
            // 
            // cbSucursal
            // 
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(7, 26);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(143, 26);
            this.cbSucursal.TabIndex = 0;
            // 
            // validador
            // 
            this.validador.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEstado);
            this.groupBox2.Location = new System.Drawing.Point(13, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(175, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.cbEstado.Location = new System.Drawing.Point(7, 26);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(143, 26);
            this.cbEstado.TabIndex = 0;
            // 
            // cmdCambiar
            // 
            this.cmdCambiar.Location = new System.Drawing.Point(20, 146);
            this.cmdCambiar.Name = "cmdCambiar";
            this.cmdCambiar.Size = new System.Drawing.Size(100, 30);
            this.cmdCambiar.TabIndex = 2;
            this.cmdCambiar.Text = "Cambiar";
            this.cmdCambiar.UseVisualStyleBackColor = true;
            this.cmdCambiar.Click += new System.EventHandler(this.cmdCambiar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(126, 146);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(100, 30);
            this.cmdCancelar.TabIndex = 3;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucursalesToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(248, 24);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarSucursalToolStripMenuItem,
            this.modificarSucursalToolStripMenuItem});
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            // 
            // registrarSucursalToolStripMenuItem
            // 
            this.registrarSucursalToolStripMenuItem.Name = "registrarSucursalToolStripMenuItem";
            this.registrarSucursalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.registrarSucursalToolStripMenuItem.Text = "Registrar Sucursal";
            this.registrarSucursalToolStripMenuItem.Click += new System.EventHandler(this.registrarSucursalToolStripMenuItem_Click);
            // 
            // modificarSucursalToolStripMenuItem
            // 
            this.modificarSucursalToolStripMenuItem.Name = "modificarSucursalToolStripMenuItem";
            this.modificarSucursalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modificarSucursalToolStripMenuItem.Text = "Modificar Sucursal";
            this.modificarSucursalToolStripMenuItem.Visible = false;
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEmpleadoToolStripMenuItem,
            this.modificarEmpleadosToolStripMenuItem,
            this.modificarContraseñaToolStripMenuItem});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // modificarEmpleadosToolStripMenuItem
            // 
            this.modificarEmpleadosToolStripMenuItem.Name = "modificarEmpleadosToolStripMenuItem";
            this.modificarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modificarEmpleadosToolStripMenuItem.Text = "Modificar Empleados";
            this.modificarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.modificarEmpleadosToolStripMenuItem_Click);
            // 
            // modificarContraseñaToolStripMenuItem
            // 
            this.modificarContraseñaToolStripMenuItem.Name = "modificarContraseñaToolStripMenuItem";
            this.modificarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modificarContraseñaToolStripMenuItem.Text = "Modificar Contraseña";
            this.modificarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.modificarContraseñaToolStripMenuItem_Click);
            // 
            // registrarEmpleadoToolStripMenuItem
            // 
            this.registrarEmpleadoToolStripMenuItem.Name = "registrarEmpleadoToolStripMenuItem";
            this.registrarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.registrarEmpleadoToolStripMenuItem.Text = "Registrar Empleado";
            this.registrarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registrarEmpleadoToolStripMenuItem_Click);
            // 
            // frmBajaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 200);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdCambiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBajaSucursal";
            this.Text = "Baja a sucursal";
            this.Load += new System.EventHandler(this.frmBajaSucursal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.ErrorProvider validador;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdCambiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarContraseñaToolStripMenuItem;
    }
}

