namespace Procesadora
{
    partial class FrmRegistrarEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCURP = new System.Windows.Forms.MaskedTextBox();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmdRehabilitar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mskRFC = new System.Windows.Forms.MaskedTextBox();
            this.mskNSS = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.mskNumeroCuenta = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdAnadirTel = new System.Windows.Forms.Button();
            this.lbTelefonos = new System.Windows.Forms.ListBox();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.cbIdPuesto = new System.Windows.Forms.ComboBox();
            this.dtpVigencia = new System.Windows.Forms.DateTimePicker();
            this.grpVigencia = new System.Windows.Forms.GroupBox();
            this.txtLicencia = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.grpVigencia.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURP";
            // 
            // txtCURP
            // 
            this.txtCURP.BeepOnError = true;
            this.txtCURP.Location = new System.Drawing.Point(60, 46);
            this.txtCURP.Mask = "LLLL000000LLLLLL00";
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(142, 26);
            this.txtCURP.TabIndex = 0;
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(208, 43);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(100, 30);
            this.cmdVerificar.TabIndex = 1;
            this.cmdVerificar.Text = "Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.cmd_Click);
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.Enabled = false;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Items.AddRange(new object[] {
            "prueba"});
            this.cbCiudad.Location = new System.Drawing.Point(188, 308);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(142, 26);
            this.cbCiudad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ciudad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Salario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nombre ";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(188, 116);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 26);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Enabled = false;
            this.txtCalle.Location = new System.Drawing.Point(185, 401);
            this.txtCalle.MaxLength = 35;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(146, 26);
            this.txtCalle.TabIndex = 12;
            this.txtCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalle_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Calle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "RFC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Codigo postal";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Enabled = false;
            this.txtCodigoPostal.Location = new System.Drawing.Point(187, 337);
            this.txtCodigoPostal.MaxLength = 5;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(92, 26);
            this.txtCodigoPostal.TabIndex = 10;
            this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPostal_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(117, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Colonia";
            // 
            // txtColonia
            // 
            this.txtColonia.Enabled = false;
            this.txtColonia.Location = new System.Drawing.Point(185, 369);
            this.txtColonia.MaxLength = 35;
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(142, 26);
            this.txtColonia.TabIndex = 11;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColonia_KeyPress);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Location = new System.Drawing.Point(493, 577);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(100, 30);
            this.cmdRegistrar.TabIndex = 25;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Visible = false;
            this.cmdRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(705, 577);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(100, 30);
            this.cmdCancelar.TabIndex = 27;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Enabled = false;
            this.txtSalario.Location = new System.Drawing.Point(496, 119);
            this.txtSalario.MaxLength = 8;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(83, 26);
            this.txtSalario.TabIndex = 20;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // validador
            // 
            this.validador.ContainerControl = this;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(185, 433);
            this.txtNumero.MaxLength = 4;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(61, 26);
            this.txtNumero.TabIndex = 13;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(112, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Número:";
            // 
            // cmdRehabilitar
            // 
            this.cmdRehabilitar.Location = new System.Drawing.Point(599, 577);
            this.cmdRehabilitar.Name = "cmdRehabilitar";
            this.cmdRehabilitar.Size = new System.Drawing.Size(100, 30);
            this.cmdRehabilitar.TabIndex = 26;
            this.cmdRehabilitar.Text = "Rehabilitar";
            this.cmdRehabilitar.UseVisualStyleBackColor = true;
            this.cmdRehabilitar.Visible = false;
            this.cmdRehabilitar.Click += new System.EventHandler(this.cmdRehabilitar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(811, 577);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(100, 30);
            this.cmdLimpiar.TabIndex = 28;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(57, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 18);
            this.label13.TabIndex = 36;
            this.label13.Text = "Apellido Paterno";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 18);
            this.label14.TabIndex = 37;
            this.label14.Text = "Apellido Materno";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Enabled = false;
            this.txtApellidoP.Location = new System.Drawing.Point(187, 148);
            this.txtApellidoP.MaxLength = 25;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(142, 26);
            this.txtApellidoP.TabIndex = 4;
            this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoP_KeyPress);
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Enabled = false;
            this.txtApellidoM.Location = new System.Drawing.Point(187, 180);
            this.txtApellidoM.MaxLength = 25;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(142, 26);
            this.txtApellidoM.TabIndex = 5;
            this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoM_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(419, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 18);
            this.label15.TabIndex = 40;
            this.label15.Text = "Sucursal";
            // 
            // mskRFC
            // 
            this.mskRFC.BeepOnError = true;
            this.mskRFC.Location = new System.Drawing.Point(187, 246);
            this.mskRFC.Mask = "LLL?000000AAA";
            this.mskRFC.Name = "mskRFC";
            this.mskRFC.Size = new System.Drawing.Size(142, 26);
            this.mskRFC.TabIndex = 7;
            // 
            // mskNSS
            // 
            this.mskNSS.BeepOnError = true;
            this.mskNSS.Location = new System.Drawing.Point(188, 278);
            this.mskNSS.Mask = "00000000000";
            this.mskNSS.Name = "mskNSS";
            this.mskNSS.Size = new System.Drawing.Size(142, 26);
            this.mskNSS.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(141, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 18);
            this.label16.TabIndex = 44;
            this.label16.Text = "NSS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(125, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 18);
            this.label17.TabIndex = 45;
            this.label17.Text = "Puesto";
            // 
            // mskNumeroCuenta
            // 
            this.mskNumeroCuenta.BeepOnError = true;
            this.mskNumeroCuenta.Location = new System.Drawing.Point(496, 157);
            this.mskNumeroCuenta.Mask = "0000-0000-0000-0000";
            this.mskNumeroCuenta.Name = "mskNumeroCuenta";
            this.mskNumeroCuenta.Size = new System.Drawing.Size(171, 26);
            this.mskNumeroCuenta.TabIndex = 21;
            this.mskNumeroCuenta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(348, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 18);
            this.label20.TabIndex = 51;
            this.label20.Text = "Número de Cuenta:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(434, 200);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 18);
            this.label21.TabIndex = 52;
            this.label21.Text = "Banco:";
            // 
            // txtBanco
            // 
            this.txtBanco.Enabled = false;
            this.txtBanco.Location = new System.Drawing.Point(496, 194);
            this.txtBanco.MaxLength = 50;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(108, 26);
            this.txtBanco.TabIndex = 22;
            this.txtBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanco_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(420, 237);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 18);
            this.label23.TabIndex = 55;
            this.label23.Text = "Licencia:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(188, 84);
            this.txtContraseña.MaxLength = 8;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(143, 26);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 18);
            this.label6.TabIndex = 59;
            this.label6.Text = "Contraseña:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(185, 465);
            this.txtTelefono.Mask = "(999)000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(112, 26);
            this.txtTelefono.TabIndex = 14;
            this.txtTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 61;
            this.label2.Text = "Teléfono:";
            // 
            // cmdAnadirTel
            // 
            this.cmdAnadirTel.Location = new System.Drawing.Point(115, 465);
            this.cmdAnadirTel.Name = "cmdAnadirTel";
            this.cmdAnadirTel.Size = new System.Drawing.Size(64, 28);
            this.cmdAnadirTel.TabIndex = 15;
            this.cmdAnadirTel.Text = "Añadir";
            this.cmdAnadirTel.UseVisualStyleBackColor = true;
            this.cmdAnadirTel.Click += new System.EventHandler(this.cmdAnadirTel_Click);
            // 
            // lbTelefonos
            // 
            this.lbTelefonos.FormattingEnabled = true;
            this.lbTelefonos.ItemHeight = 18;
            this.lbTelefonos.Location = new System.Drawing.Point(303, 465);
            this.lbTelefonos.Name = "lbTelefonos";
            this.lbTelefonos.Size = new System.Drawing.Size(144, 22);
            this.lbTelefonos.TabIndex = 16;
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(300, 441);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(147, 18);
            this.lblTelefonos.TabIndex = 64;
            this.lblTelefonos.Text = "Teléfonos añadidos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 18);
            this.label11.TabIndex = 65;
            this.label11.Text = "Turno";
            // 
            // cbTurno
            // 
            this.cbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurno.Enabled = false;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "prueba"});
            this.cbTurno.Location = new System.Drawing.Point(496, 270);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(142, 26);
            this.cbTurno.TabIndex = 24;
            // 
            // cbSucursal
            // 
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.Enabled = false;
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Items.AddRange(new object[] {
            "prueba"});
            this.cbSucursal.Location = new System.Drawing.Point(496, 92);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(142, 26);
            this.cbSucursal.TabIndex = 66;
            // 
            // cbIdPuesto
            // 
            this.cbIdPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdPuesto.Enabled = false;
            this.cbIdPuesto.FormattingEnabled = true;
            this.cbIdPuesto.Items.AddRange(new object[] {
            "prueba"});
            this.cbIdPuesto.Location = new System.Drawing.Point(187, 214);
            this.cbIdPuesto.Name = "cbIdPuesto";
            this.cbIdPuesto.Size = new System.Drawing.Size(142, 26);
            this.cbIdPuesto.TabIndex = 67;
            // 
            // dtpVigencia
            // 
            this.dtpVigencia.Location = new System.Drawing.Point(6, 25);
            this.dtpVigencia.Name = "dtpVigencia";
            this.dtpVigencia.Size = new System.Drawing.Size(200, 26);
            this.dtpVigencia.TabIndex = 69;
            // 
            // grpVigencia
            // 
            this.grpVigencia.Controls.Add(this.dtpVigencia);
            this.grpVigencia.Location = new System.Drawing.Point(621, 207);
            this.grpVigencia.Name = "grpVigencia";
            this.grpVigencia.Size = new System.Drawing.Size(225, 57);
            this.grpVigencia.TabIndex = 70;
            this.grpVigencia.TabStop = false;
            this.grpVigencia.Text = "Vigencia";
            this.grpVigencia.Visible = false;
            // 
            // txtLicencia
            // 
            this.txtLicencia.Location = new System.Drawing.Point(496, 232);
            this.txtLicencia.Mask = "L000000000";
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(108, 26);
            this.txtLicencia.TabIndex = 71;
            this.txtLicencia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLicencia_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucursalesToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarSucursalToolStripMenuItem,
            this.modificarSucursalToolStripMenuItem,
            this.darDeBajaSucursalToolStripMenuItem});
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            // 
            // registrarSucursalToolStripMenuItem
            // 
            this.registrarSucursalToolStripMenuItem.Name = "registrarSucursalToolStripMenuItem";
            this.registrarSucursalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarSucursalToolStripMenuItem.Text = "Registrar Sucursal";
            this.registrarSucursalToolStripMenuItem.Click += new System.EventHandler(this.registrarSucursalToolStripMenuItem_Click);
            // 
            // modificarSucursalToolStripMenuItem
            // 
            this.modificarSucursalToolStripMenuItem.Name = "modificarSucursalToolStripMenuItem";
            this.modificarSucursalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarSucursalToolStripMenuItem.Text = "Modificar Sucursal";
            this.modificarSucursalToolStripMenuItem.Visible = false;
            this.modificarSucursalToolStripMenuItem.Click += new System.EventHandler(this.modificarSucursalToolStripMenuItem_Click);
            // 
            // darDeBajaSucursalToolStripMenuItem
            // 
            this.darDeBajaSucursalToolStripMenuItem.Name = "darDeBajaSucursalToolStripMenuItem";
            this.darDeBajaSucursalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darDeBajaSucursalToolStripMenuItem.Text = "Dar de baja Sucursal";
            this.darDeBajaSucursalToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaSucursalToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            // FrmRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 619);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.grpVigencia);
            this.Controls.Add(this.cbIdPuesto);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.lblTelefonos);
            this.Controls.Add(this.lbTelefonos);
            this.Controls.Add(this.cmdAnadirTel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.mskNumeroCuenta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.mskNSS);
            this.Controls.Add(this.mskRFC);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtApellidoM);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdRehabilitar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.cmdVerificar);
            this.Controls.Add(this.txtCURP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrarEmpleado";
            this.Text = "Registrar Empleado";
            this.Load += new System.EventHandler(this.FrmRegistrarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.grpVigencia.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCURP;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ErrorProvider validador;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cmdRehabilitar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox mskNumeroCuenta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mskNSS;
        private System.Windows.Forms.MaskedTextBox mskRFC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button cmdAnadirTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.ListBox lbTelefonos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbTurno;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.ComboBox cbIdPuesto;
        private System.Windows.Forms.GroupBox grpVigencia;
        private System.Windows.Forms.DateTimePicker dtpVigencia;
        private System.Windows.Forms.MaskedTextBox txtLicencia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarContraseñaToolStripMenuItem;

    }
}

