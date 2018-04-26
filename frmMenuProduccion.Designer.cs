namespace Procesadora
{
    partial class frmMenuProduccion
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuProduccion));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdOrdenRetirarInsumo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdCalidad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdHistorialProduccion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRegistrarProduccion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRegistrarEmpleado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdEncargado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.InsumosTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sidemenu
            // 
            this.sidemenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidemenu.BackColor = System.Drawing.Color.DimGray;
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.cmdOrdenRetirarInsumo);
            this.sidemenu.Controls.Add(this.cmdCalidad);
            this.sidemenu.Controls.Add(this.cmdHistorialProduccion);
            this.sidemenu.Controls.Add(this.cmdRegistrarProduccion);
            this.sidemenu.Controls.Add(this.cmdRegistrarEmpleado);
            this.sidemenu.Controls.Add(this.Logo);
            this.sidemenu.Controls.Add(this.BtnMenu);
            this.InsumosTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Location = new System.Drawing.Point(0, 42);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(261, 637);
            this.sidemenu.TabIndex = 0;
            this.sidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.sidemenu_Paint);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "Notificar Mobiliario defectuoso";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 65D;
            this.bunifuFlatButton1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-2, 430);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(260, 60);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "Notificar Mobiliario defectuoso";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // cmdOrdenRetirarInsumo
            // 
            this.cmdOrdenRetirarInsumo.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdOrdenRetirarInsumo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdOrdenRetirarInsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdOrdenRetirarInsumo.BorderRadius = 0;
            this.cmdOrdenRetirarInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdOrdenRetirarInsumo.ButtonText = "Generar orden de retirar insumo";
            this.cmdOrdenRetirarInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdOrdenRetirarInsumo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdOrdenRetirarInsumo, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdOrdenRetirarInsumo, BunifuAnimatorNS.DecorationType.None);
            this.cmdOrdenRetirarInsumo.DisabledColor = System.Drawing.Color.Gray;
            this.cmdOrdenRetirarInsumo.ForeColor = System.Drawing.Color.White;
            this.cmdOrdenRetirarInsumo.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdOrdenRetirarInsumo.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdOrdenRetirarInsumo.Iconimage")));
            this.cmdOrdenRetirarInsumo.Iconimage_right = null;
            this.cmdOrdenRetirarInsumo.Iconimage_right_Selected = null;
            this.cmdOrdenRetirarInsumo.Iconimage_Selected = null;
            this.cmdOrdenRetirarInsumo.IconMarginLeft = 0;
            this.cmdOrdenRetirarInsumo.IconMarginRight = 0;
            this.cmdOrdenRetirarInsumo.IconRightVisible = true;
            this.cmdOrdenRetirarInsumo.IconRightZoom = 0D;
            this.cmdOrdenRetirarInsumo.IconVisible = true;
            this.cmdOrdenRetirarInsumo.IconZoom = 65D;
            this.cmdOrdenRetirarInsumo.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdOrdenRetirarInsumo.IsTab = true;
            this.cmdOrdenRetirarInsumo.Location = new System.Drawing.Point(1, 298);
            this.cmdOrdenRetirarInsumo.Name = "cmdOrdenRetirarInsumo";
            this.cmdOrdenRetirarInsumo.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdOrdenRetirarInsumo.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdOrdenRetirarInsumo.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdOrdenRetirarInsumo.selected = false;
            this.cmdOrdenRetirarInsumo.Size = new System.Drawing.Size(260, 60);
            this.cmdOrdenRetirarInsumo.TabIndex = 12;
            this.cmdOrdenRetirarInsumo.Text = "Generar orden de retirar insumo";
            this.cmdOrdenRetirarInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOrdenRetirarInsumo.Textcolor = System.Drawing.Color.White;
            this.cmdOrdenRetirarInsumo.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrdenRetirarInsumo.Click += new System.EventHandler(this.cmdOrdenRetirarInsumo_Click);
            // 
            // cmdCalidad
            // 
            this.cmdCalidad.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdCalidad.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdCalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCalidad.BorderRadius = 0;
            this.cmdCalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdCalidad.ButtonText = "Confirmar calidad de lote";
            this.cmdCalidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdCalidad, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdCalidad, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdCalidad, BunifuAnimatorNS.DecorationType.None);
            this.cmdCalidad.DisabledColor = System.Drawing.Color.Gray;
            this.cmdCalidad.ForeColor = System.Drawing.Color.White;
            this.cmdCalidad.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdCalidad.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdCalidad.Iconimage")));
            this.cmdCalidad.Iconimage_right = null;
            this.cmdCalidad.Iconimage_right_Selected = null;
            this.cmdCalidad.Iconimage_Selected = null;
            this.cmdCalidad.IconMarginLeft = 0;
            this.cmdCalidad.IconMarginRight = 0;
            this.cmdCalidad.IconRightVisible = true;
            this.cmdCalidad.IconRightZoom = 0D;
            this.cmdCalidad.IconVisible = true;
            this.cmdCalidad.IconZoom = 65D;
            this.cmdCalidad.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdCalidad.IsTab = true;
            this.cmdCalidad.Location = new System.Drawing.Point(3, 364);
            this.cmdCalidad.Name = "cmdCalidad";
            this.cmdCalidad.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdCalidad.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdCalidad.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdCalidad.selected = false;
            this.cmdCalidad.Size = new System.Drawing.Size(260, 60);
            this.cmdCalidad.TabIndex = 14;
            this.cmdCalidad.Text = "Confirmar calidad de lote";
            this.cmdCalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCalidad.Textcolor = System.Drawing.Color.White;
            this.cmdCalidad.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalidad.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // cmdHistorialProduccion
            // 
            this.cmdHistorialProduccion.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdHistorialProduccion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdHistorialProduccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdHistorialProduccion.BorderRadius = 0;
            this.cmdHistorialProduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdHistorialProduccion.ButtonText = "Historial de produccion";
            this.cmdHistorialProduccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdHistorialProduccion, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdHistorialProduccion, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdHistorialProduccion, BunifuAnimatorNS.DecorationType.None);
            this.cmdHistorialProduccion.DisabledColor = System.Drawing.Color.Gray;
            this.cmdHistorialProduccion.ForeColor = System.Drawing.Color.White;
            this.cmdHistorialProduccion.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdHistorialProduccion.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdHistorialProduccion.Iconimage")));
            this.cmdHistorialProduccion.Iconimage_right = null;
            this.cmdHistorialProduccion.Iconimage_right_Selected = null;
            this.cmdHistorialProduccion.Iconimage_Selected = null;
            this.cmdHistorialProduccion.IconMarginLeft = 0;
            this.cmdHistorialProduccion.IconMarginRight = 0;
            this.cmdHistorialProduccion.IconRightVisible = true;
            this.cmdHistorialProduccion.IconRightZoom = 0D;
            this.cmdHistorialProduccion.IconVisible = true;
            this.cmdHistorialProduccion.IconZoom = 65D;
            this.cmdHistorialProduccion.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdHistorialProduccion.IsTab = true;
            this.cmdHistorialProduccion.Location = new System.Drawing.Point(1, 232);
            this.cmdHistorialProduccion.Name = "cmdHistorialProduccion";
            this.cmdHistorialProduccion.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdHistorialProduccion.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdHistorialProduccion.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdHistorialProduccion.selected = false;
            this.cmdHistorialProduccion.Size = new System.Drawing.Size(260, 60);
            this.cmdHistorialProduccion.TabIndex = 13;
            this.cmdHistorialProduccion.Text = "Historial de produccion";
            this.cmdHistorialProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdHistorialProduccion.Textcolor = System.Drawing.Color.White;
            this.cmdHistorialProduccion.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHistorialProduccion.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // cmdRegistrarProduccion
            // 
            this.cmdRegistrarProduccion.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarProduccion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarProduccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarProduccion.BorderRadius = 0;
            this.cmdRegistrarProduccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarProduccion.ButtonText = "Registrar produccion";
            this.cmdRegistrarProduccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarProduccion, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarProduccion, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarProduccion, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarProduccion.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarProduccion.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarProduccion.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarProduccion.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarProduccion.Iconimage")));
            this.cmdRegistrarProduccion.Iconimage_right = null;
            this.cmdRegistrarProduccion.Iconimage_right_Selected = null;
            this.cmdRegistrarProduccion.Iconimage_Selected = null;
            this.cmdRegistrarProduccion.IconMarginLeft = 0;
            this.cmdRegistrarProduccion.IconMarginRight = 0;
            this.cmdRegistrarProduccion.IconRightVisible = true;
            this.cmdRegistrarProduccion.IconRightZoom = 0D;
            this.cmdRegistrarProduccion.IconVisible = true;
            this.cmdRegistrarProduccion.IconZoom = 65D;
            this.cmdRegistrarProduccion.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRegistrarProduccion.IsTab = true;
            this.cmdRegistrarProduccion.Location = new System.Drawing.Point(1, 166);
            this.cmdRegistrarProduccion.Name = "cmdRegistrarProduccion";
            this.cmdRegistrarProduccion.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarProduccion.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarProduccion.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarProduccion.selected = false;
            this.cmdRegistrarProduccion.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarProduccion.TabIndex = 12;
            this.cmdRegistrarProduccion.Text = "Registrar produccion";
            this.cmdRegistrarProduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarProduccion.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarProduccion.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarProduccion.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // cmdRegistrarEmpleado
            // 
            this.cmdRegistrarEmpleado.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarEmpleado.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarEmpleado.BorderRadius = 0;
            this.cmdRegistrarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarEmpleado.ButtonText = "Orden de producción";
            this.cmdRegistrarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarEmpleado, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarEmpleado.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarEmpleado.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarEmpleado.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarEmpleado.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarEmpleado.Iconimage")));
            this.cmdRegistrarEmpleado.Iconimage_right = null;
            this.cmdRegistrarEmpleado.Iconimage_right_Selected = null;
            this.cmdRegistrarEmpleado.Iconimage_Selected = null;
            this.cmdRegistrarEmpleado.IconMarginLeft = 0;
            this.cmdRegistrarEmpleado.IconMarginRight = 0;
            this.cmdRegistrarEmpleado.IconRightVisible = true;
            this.cmdRegistrarEmpleado.IconRightZoom = 0D;
            this.cmdRegistrarEmpleado.IconVisible = true;
            this.cmdRegistrarEmpleado.IconZoom = 65D;
            this.cmdRegistrarEmpleado.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRegistrarEmpleado.IsTab = true;
            this.cmdRegistrarEmpleado.Location = new System.Drawing.Point(1, 100);
            this.cmdRegistrarEmpleado.Name = "cmdRegistrarEmpleado";
            this.cmdRegistrarEmpleado.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarEmpleado.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarEmpleado.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarEmpleado.selected = false;
            this.cmdRegistrarEmpleado.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarEmpleado.TabIndex = 11;
            this.cmdRegistrarEmpleado.Text = "Orden de producción";
            this.cmdRegistrarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarEmpleado.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarEmpleado.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarEmpleado.Click += new System.EventHandler(this.cmdRegistrarEmpleado_Click);
            // 
            // Logo
            // 
            this.InsumosTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Location = new System.Drawing.Point(65, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(89, 75);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMenu.BackColor = System.Drawing.Color.DimGray;
            this.PanelTransition.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.BtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageActive = null;
            this.BtnMenu.Location = new System.Drawing.Point(216, 6);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(42, 37);
            this.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMenu.TabIndex = 0;
            this.BtnMenu.TabStop = false;
            this.BtnMenu.Zoom = 10;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Header.Controls.Add(this.bunifuThinButton22);
            this.Header.Controls.Add(this.bunifuImageButton2);
            this.Header.Controls.Add(this.pictureBox2);
            this.Header.Controls.Add(this.bunifuCustomLabel1);
            this.InsumosTransition.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1341, 42);
            this.Header.TabIndex = 1;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Salir";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsumosTransition.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.bunifuThinButton22, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton22.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 30;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(1152, 0);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(135, 42);
            this.bunifuThinButton22.TabIndex = 10;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelTransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1308, 9);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(21, 20);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox2
            // 
            this.InsumosTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(43, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(98, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Produccion";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LogoTransition
            // 
            this.LogoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0.5F;
            animation2.RotateLimit = 0.2F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation2;
            // 
            // contextMenuStrip1
            // 
            this.LogoTransition.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cmdEncargado
            // 
            this.cmdEncargado.ActiveBorderThickness = 1;
            this.cmdEncargado.ActiveCornerRadius = 20;
            this.cmdEncargado.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cmdEncargado.ActiveForecolor = System.Drawing.Color.Gray;
            this.cmdEncargado.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cmdEncargado.BackColor = System.Drawing.Color.Gray;
            this.cmdEncargado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdEncargado.BackgroundImage")));
            this.cmdEncargado.ButtonText = "Menu de encargado";
            this.cmdEncargado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsumosTransition.SetDecoration(this.cmdEncargado, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdEncargado, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.cmdEncargado, BunifuAnimatorNS.DecorationType.None);
            this.cmdEncargado.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEncargado.ForeColor = System.Drawing.Color.White;
            this.cmdEncargado.IdleBorderThickness = 1;
            this.cmdEncargado.IdleCornerRadius = 20;
            this.cmdEncargado.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.cmdEncargado.IdleForecolor = System.Drawing.Color.White;
            this.cmdEncargado.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.cmdEncargado.Location = new System.Drawing.Point(433, 320);
            this.cmdEncargado.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmdEncargado.Name = "cmdEncargado";
            this.cmdEncargado.Size = new System.Drawing.Size(129, 80);
            this.cmdEncargado.TabIndex = 50;
            this.cmdEncargado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdEncargado.Visible = false;
            this.cmdEncargado.Click += new System.EventHandler(this.cmdEncargado_Click);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblPuesto, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblPuesto, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.lblPuesto, BunifuAnimatorNS.DecorationType.None);
            this.lblPuesto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(493, 289);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(0, 25);
            this.lblPuesto.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Puesto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(509, 264);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 25);
            this.lblNombre.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nombre:";
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.PanelTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation3;
            // 
            // InsumosTransition
            // 
            this.InsumosTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.InsumosTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.InsumosTransition.DefaultAnimation = animation1;
            // 
            // validador
            // 
            this.validador.ContainerControl = this;
            // 
            // frmMenuProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1341, 681);
            this.Controls.Add(this.cmdEncargado);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.Header);
            this.PanelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Modificar Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuRRHH_Load);
            this.sidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuImageButton BtnMenu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private BunifuAnimatorNS.BunifuTransition InsumosTransition;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ErrorProvider validador;
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarEmpleado;
        private Bunifu.Framework.UI.BunifuFlatButton cmdHistorialProduccion;
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarProduccion;
        private Bunifu.Framework.UI.BunifuFlatButton cmdCalidad;
        private Bunifu.Framework.UI.BunifuFlatButton cmdOrdenRetirarInsumo;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdEncargado;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

