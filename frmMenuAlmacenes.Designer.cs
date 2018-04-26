namespace Procesadora
{
    partial class frmMenuAlmacenes
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
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAlmacenes));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.cmdRegistrarEntradaProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRegistrarRetiroProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRetirarInsumo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdEntradaInsumos = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.sidemenu.Controls.Add(this.cmdRegistrarEntradaProducto);
            this.sidemenu.Controls.Add(this.cmdRegistrarRetiroProducto);
            this.sidemenu.Controls.Add(this.cmdRetirarInsumo);
            this.sidemenu.Controls.Add(this.cmdEntradaInsumos);
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
            // cmdRegistrarEntradaProducto
            // 
            this.cmdRegistrarEntradaProducto.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarEntradaProducto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarEntradaProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarEntradaProducto.BorderRadius = 0;
            this.cmdRegistrarEntradaProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarEntradaProducto.ButtonText = "Registrar entrada de producto";
            this.cmdRegistrarEntradaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarEntradaProducto, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarEntradaProducto, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarEntradaProducto, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarEntradaProducto.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarEntradaProducto.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarEntradaProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarEntradaProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarEntradaProducto.Iconimage")));
            this.cmdRegistrarEntradaProducto.Iconimage_right = null;
            this.cmdRegistrarEntradaProducto.Iconimage_right_Selected = null;
            this.cmdRegistrarEntradaProducto.Iconimage_Selected = null;
            this.cmdRegistrarEntradaProducto.IconMarginLeft = 0;
            this.cmdRegistrarEntradaProducto.IconMarginRight = 0;
            this.cmdRegistrarEntradaProducto.IconRightVisible = true;
            this.cmdRegistrarEntradaProducto.IconRightZoom = 0D;
            this.cmdRegistrarEntradaProducto.IconVisible = true;
            this.cmdRegistrarEntradaProducto.IconZoom = 65D;
            this.cmdRegistrarEntradaProducto.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRegistrarEntradaProducto.IsTab = true;
            this.cmdRegistrarEntradaProducto.Location = new System.Drawing.Point(0, 219);
            this.cmdRegistrarEntradaProducto.Name = "cmdRegistrarEntradaProducto";
            this.cmdRegistrarEntradaProducto.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarEntradaProducto.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarEntradaProducto.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarEntradaProducto.selected = false;
            this.cmdRegistrarEntradaProducto.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarEntradaProducto.TabIndex = 16;
            this.cmdRegistrarEntradaProducto.Text = "Registrar entrada de producto";
            this.cmdRegistrarEntradaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarEntradaProducto.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarEntradaProducto.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarEntradaProducto.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // cmdRegistrarRetiroProducto
            // 
            this.cmdRegistrarRetiroProducto.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarRetiroProducto.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarRetiroProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarRetiroProducto.BorderRadius = 0;
            this.cmdRegistrarRetiroProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarRetiroProducto.ButtonText = "Registrar retiro de producto";
            this.cmdRegistrarRetiroProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarRetiroProducto, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarRetiroProducto, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarRetiroProducto, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarRetiroProducto.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarRetiroProducto.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarRetiroProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarRetiroProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarRetiroProducto.Iconimage")));
            this.cmdRegistrarRetiroProducto.Iconimage_right = null;
            this.cmdRegistrarRetiroProducto.Iconimage_right_Selected = null;
            this.cmdRegistrarRetiroProducto.Iconimage_Selected = null;
            this.cmdRegistrarRetiroProducto.IconMarginLeft = 0;
            this.cmdRegistrarRetiroProducto.IconMarginRight = 0;
            this.cmdRegistrarRetiroProducto.IconRightVisible = true;
            this.cmdRegistrarRetiroProducto.IconRightZoom = 0D;
            this.cmdRegistrarRetiroProducto.IconVisible = true;
            this.cmdRegistrarRetiroProducto.IconZoom = 65D;
            this.cmdRegistrarRetiroProducto.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRegistrarRetiroProducto.IsTab = true;
            this.cmdRegistrarRetiroProducto.Location = new System.Drawing.Point(3, 153);
            this.cmdRegistrarRetiroProducto.Name = "cmdRegistrarRetiroProducto";
            this.cmdRegistrarRetiroProducto.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarRetiroProducto.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarRetiroProducto.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarRetiroProducto.selected = false;
            this.cmdRegistrarRetiroProducto.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarRetiroProducto.TabIndex = 15;
            this.cmdRegistrarRetiroProducto.Text = "Registrar retiro de producto";
            this.cmdRegistrarRetiroProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarRetiroProducto.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarRetiroProducto.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarRetiroProducto.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // cmdRetirarInsumo
            // 
            this.cmdRetirarInsumo.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRetirarInsumo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRetirarInsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRetirarInsumo.BorderRadius = 0;
            this.cmdRetirarInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRetirarInsumo.ButtonText = "Registrar retiro de insumo";
            this.cmdRetirarInsumo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRetirarInsumo, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRetirarInsumo, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRetirarInsumo, BunifuAnimatorNS.DecorationType.None);
            this.cmdRetirarInsumo.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRetirarInsumo.ForeColor = System.Drawing.Color.White;
            this.cmdRetirarInsumo.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRetirarInsumo.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRetirarInsumo.Iconimage")));
            this.cmdRetirarInsumo.Iconimage_right = null;
            this.cmdRetirarInsumo.Iconimage_right_Selected = null;
            this.cmdRetirarInsumo.Iconimage_Selected = null;
            this.cmdRetirarInsumo.IconMarginLeft = 0;
            this.cmdRetirarInsumo.IconMarginRight = 0;
            this.cmdRetirarInsumo.IconRightVisible = true;
            this.cmdRetirarInsumo.IconRightZoom = 0D;
            this.cmdRetirarInsumo.IconVisible = true;
            this.cmdRetirarInsumo.IconZoom = 65D;
            this.cmdRetirarInsumo.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRetirarInsumo.IsTab = true;
            this.cmdRetirarInsumo.Location = new System.Drawing.Point(-2, 351);
            this.cmdRetirarInsumo.Name = "cmdRetirarInsumo";
            this.cmdRetirarInsumo.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRetirarInsumo.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRetirarInsumo.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRetirarInsumo.selected = false;
            this.cmdRetirarInsumo.Size = new System.Drawing.Size(260, 60);
            this.cmdRetirarInsumo.TabIndex = 12;
            this.cmdRetirarInsumo.Text = "Registrar retiro de insumo";
            this.cmdRetirarInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRetirarInsumo.Textcolor = System.Drawing.Color.White;
            this.cmdRetirarInsumo.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRetirarInsumo.Click += new System.EventHandler(this.cmdRetirarInsumo_Click);
            // 
            // cmdEntradaInsumos
            // 
            this.cmdEntradaInsumos.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdEntradaInsumos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdEntradaInsumos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdEntradaInsumos.BorderRadius = 0;
            this.cmdEntradaInsumos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdEntradaInsumos.ButtonText = "Entrada de insumos";
            this.cmdEntradaInsumos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdEntradaInsumos, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdEntradaInsumos, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdEntradaInsumos, BunifuAnimatorNS.DecorationType.None);
            this.cmdEntradaInsumos.DisabledColor = System.Drawing.Color.Gray;
            this.cmdEntradaInsumos.ForeColor = System.Drawing.Color.White;
            this.cmdEntradaInsumos.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdEntradaInsumos.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdEntradaInsumos.Iconimage")));
            this.cmdEntradaInsumos.Iconimage_right = null;
            this.cmdEntradaInsumos.Iconimage_right_Selected = null;
            this.cmdEntradaInsumos.Iconimage_Selected = null;
            this.cmdEntradaInsumos.IconMarginLeft = 0;
            this.cmdEntradaInsumos.IconMarginRight = 0;
            this.cmdEntradaInsumos.IconRightVisible = true;
            this.cmdEntradaInsumos.IconRightZoom = 0D;
            this.cmdEntradaInsumos.IconVisible = true;
            this.cmdEntradaInsumos.IconZoom = 65D;
            this.cmdEntradaInsumos.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdEntradaInsumos.IsTab = true;
            this.cmdEntradaInsumos.Location = new System.Drawing.Point(-2, 285);
            this.cmdEntradaInsumos.Name = "cmdEntradaInsumos";
            this.cmdEntradaInsumos.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdEntradaInsumos.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdEntradaInsumos.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdEntradaInsumos.selected = false;
            this.cmdEntradaInsumos.Size = new System.Drawing.Size(260, 60);
            this.cmdEntradaInsumos.TabIndex = 13;
            this.cmdEntradaInsumos.Text = "Entrada de insumos";
            this.cmdEntradaInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEntradaInsumos.Textcolor = System.Drawing.Color.White;
            this.cmdEntradaInsumos.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntradaInsumos.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
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
            this.bunifuCustomLabel1.Text = "Almacenes";
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
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(30);
            animation5.RotateCoeff = 0.5F;
            animation5.RotateLimit = 0.2F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.LogoTransition.DefaultAnimation = animation5;
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
            this.cmdEncargado.Location = new System.Drawing.Point(524, 327);
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
            this.lblPuesto.Location = new System.Drawing.Point(584, 296);
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
            this.label2.Location = new System.Drawing.Point(510, 296);
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
            this.lblNombre.Location = new System.Drawing.Point(600, 271);
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
            this.label1.Location = new System.Drawing.Point(510, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nombre:";
            // 
            // PanelTransition
            // 
            this.PanelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.PanelTransition.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 20;
            animation6.Padding = new System.Windows.Forms.Padding(30);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.PanelTransition.DefaultAnimation = animation6;
            // 
            // InsumosTransition
            // 
            this.InsumosTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.InsumosTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.InsumosTransition.DefaultAnimation = animation4;
            // 
            // validador
            // 
            this.validador.ContainerControl = this;
            // 
            // frmMenuAlmacenes
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
            this.Name = "frmMenuAlmacenes";
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
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarEntradaProducto;
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarRetiroProducto;
        private Bunifu.Framework.UI.BunifuFlatButton cmdEntradaInsumos;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdEncargado;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton cmdRetirarInsumo;
    }
}

