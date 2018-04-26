namespace Procesadora
{
    partial class frmRegistrarSucursal
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroExt = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdAnadirTel = new System.Windows.Forms.Button();
            this.txtNumeroInt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.cmdRehabilitar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModulos = new System.Windows.Forms.ComboBox();
            this.lbTelefonos = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEncargado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(249, 55);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(100, 30);
            this.cmdVerificar.TabIndex = 4;
            this.cmdVerificar.Text = "Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.cmd_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 20);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 26);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.Enabled = false;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Items.AddRange(new object[] {
            "Recepción",
            "Ventas",
            "Compras",
            "Recursos humanos"});
            this.cbCiudad.Location = new System.Drawing.Point(6, 19);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(142, 26);
            this.cbCiudad.TabIndex = 8;
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(0, 15);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(131, 26);
            this.txtCalle.TabIndex = 16;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Exterior";
            // 
            // txtNumeroExt
            // 
            this.txtNumeroExt.Enabled = false;
            this.txtNumeroExt.Location = new System.Drawing.Point(9, 43);
            this.txtNumeroExt.MaxLength = 4;
            this.txtNumeroExt.Name = "txtNumeroExt";
            this.txtNumeroExt.Size = new System.Drawing.Size(61, 26);
            this.txtNumeroExt.TabIndex = 2;
            this.txtNumeroExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroExt_KeyPress);
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Enabled = false;
            this.txtCodigoPostal.Location = new System.Drawing.Point(6, 25);
            this.txtCodigoPostal.MaxLength = 5;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(61, 26);
            this.txtCodigoPostal.TabIndex = 20;
            this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPostal_KeyPress);
            // 
            // txtColonia
            // 
            this.txtColonia.Enabled = false;
            this.txtColonia.Location = new System.Drawing.Point(6, 25);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(142, 26);
            this.txtColonia.TabIndex = 22;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColonia_KeyPress);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(30, 626);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(100, 30);
            this.cmdRegistrar.TabIndex = 20;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Visible = false;
            this.cmdRegistrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(136, 626);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(100, 30);
            this.cmdCancelar.TabIndex = 22;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(6, 17);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(142, 26);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BeepOnError = true;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(6, 25);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(142, 26);
            this.txtTelefono.TabIndex = 2;
            // 
            // validador
            // 
            this.validador.ContainerControl = this;
            // 
            // cmdAnadirTel
            // 
            this.cmdAnadirTel.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnadirTel.Location = new System.Drawing.Point(130, 73);
            this.cmdAnadirTel.Name = "cmdAnadirTel";
            this.cmdAnadirTel.Size = new System.Drawing.Size(33, 30);
            this.cmdAnadirTel.TabIndex = 6;
            this.cmdAnadirTel.TabStop = false;
            this.cmdAnadirTel.Text = "+";
            this.cmdAnadirTel.UseVisualStyleBackColor = true;
            this.cmdAnadirTel.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNumeroInt
            // 
            this.txtNumeroInt.Enabled = false;
            this.txtNumeroInt.Location = new System.Drawing.Point(82, 43);
            this.txtNumeroInt.MaxLength = 4;
            this.txtNumeroInt.Name = "txtNumeroInt";
            this.txtNumeroInt.Size = new System.Drawing.Size(61, 26);
            this.txtNumeroInt.TabIndex = 4;
            this.txtNumeroInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroInt_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(88, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Interior";
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(12, 56);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(59, 18);
            this.lblTelefonos.TabIndex = 33;
            this.lblTelefonos.Text = "Módulo";
            this.lblTelefonos.Visible = false;
            // 
            // cmdRehabilitar
            // 
            this.cmdRehabilitar.Location = new System.Drawing.Point(249, 55);
            this.cmdRehabilitar.Name = "cmdRehabilitar";
            this.cmdRehabilitar.Size = new System.Drawing.Size(100, 30);
            this.cmdRehabilitar.TabIndex = 34;
            this.cmdRehabilitar.Text = "Rehabilitar";
            this.cmdRehabilitar.UseVisualStyleBackColor = true;
            this.cmdRehabilitar.Visible = false;
            this.cmdRehabilitar.Click += new System.EventHandler(this.cmdRehabilitar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(242, 626);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(100, 30);
            this.cmdLimpiar.TabIndex = 24;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(75, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre sucursal";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbCiudad);
            this.groupBox4.Location = new System.Drawing.Point(75, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(161, 51);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ciudad";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtEmail);
            this.groupBox5.Location = new System.Drawing.Point(75, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 49);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Email";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.cbModulos);
            this.groupBox6.Controls.Add(this.txtTelefono);
            this.groupBox6.Controls.Add(this.cmdAnadirTel);
            this.groupBox6.Controls.Add(this.lblTelefonos);
            this.groupBox6.Controls.Add(this.lbTelefonos);
            this.groupBox6.Location = new System.Drawing.Point(36, 193);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(367, 111);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Teléfono(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Telefonos añadidos";
            this.label1.Visible = false;
            // 
            // cbModulos
            // 
            this.cbModulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModulos.FormattingEnabled = true;
            this.cbModulos.Location = new System.Drawing.Point(6, 77);
            this.cbModulos.Name = "cbModulos";
            this.cbModulos.Size = new System.Drawing.Size(107, 26);
            this.cbModulos.TabIndex = 4;
            // 
            // lbTelefonos
            // 
            this.lbTelefonos.FormattingEnabled = true;
            this.lbTelefonos.ItemHeight = 18;
            this.lbTelefonos.Location = new System.Drawing.Point(185, 32);
            this.lbTelefonos.Name = "lbTelefonos";
            this.lbTelefonos.Size = new System.Drawing.Size(176, 76);
            this.lbTelefonos.TabIndex = 32;
            this.lbTelefonos.TabStop = false;
            this.lbTelefonos.Visible = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtCalle);
            this.groupBox7.Location = new System.Drawing.Point(81, 381);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(148, 50);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Calle";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.txtNumeroExt);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.txtNumeroInt);
            this.groupBox8.Location = new System.Drawing.Point(81, 428);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(168, 74);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Número";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtCodigoPostal);
            this.groupBox9.Location = new System.Drawing.Point(81, 503);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(144, 54);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Código postal";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtColonia);
            this.groupBox10.Location = new System.Drawing.Point(81, 563);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(168, 57);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Colonia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEncargado);
            this.groupBox2.Location = new System.Drawing.Point(81, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 55);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encargado";
            // 
            // cbEncargado
            // 
            this.cbEncargado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncargado.FormattingEnabled = true;
            this.cbEncargado.Items.AddRange(new object[] {
            "Recursos humanos",
            "Recepción",
            "Ventas",
            "Compras",
            "Producción"});
            this.cbEncargado.Location = new System.Drawing.Point(9, 23);
            this.cbEncargado.Name = "cbEncargado";
            this.cbEncargado.Size = new System.Drawing.Size(133, 26);
            this.cbEncargado.TabIndex = 35;
            // 
            // frmRegistrarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdRehabilitar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.cmdVerificar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarSucursal";
            this.Text = "Registrar Sucursal";
            this.Load += new System.EventHandler(this.FrmRegistrarSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumeroExt;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.ErrorProvider validador;
        private System.Windows.Forms.Button cmdAnadirTel;
        private System.Windows.Forms.TextBox txtNumeroInt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.Button cmdRehabilitar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModulos;
        private System.Windows.Forms.ListBox lbTelefonos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbEncargado;

    }
}

