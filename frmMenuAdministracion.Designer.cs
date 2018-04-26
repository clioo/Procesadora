namespace Procesadora
{
    partial class frmMenuAdministracion
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdministracion));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LogoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.PanelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.InsumosTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdEncargado = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRegistrarReceta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdBajaSucursal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdModificarSucursal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.cmdRegistrarSucursal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidemenu.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.sidemenu.Controls.Add(this.bunifuFlatButton2);
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.cmdRegistrarReceta);
            this.sidemenu.Controls.Add(this.cmdBajaSucursal);
            this.sidemenu.Controls.Add(this.cmdModificarSucursal);
            this.sidemenu.Controls.Add(this.Logo);
            this.sidemenu.Controls.Add(this.cmdRegistrarSucursal);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Administración";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(678, 221);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 25);
            this.lblNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puesto:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblPuesto, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblPuesto, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.lblPuesto, BunifuAnimatorNS.DecorationType.None);
            this.lblPuesto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(662, 246);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(0, 25);
            this.lblPuesto.TabIndex = 5;
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
            this.cmdEncargado.Location = new System.Drawing.Point(602, 277);
            this.cmdEncargado.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmdEncargado.Name = "cmdEncargado";
            this.cmdEncargado.Size = new System.Drawing.Size(129, 80);
            this.cmdEncargado.TabIndex = 45;
            this.cmdEncargado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdEncargado.Visible = false;
            this.cmdEncargado.Click += new System.EventHandler(this.cmdEncargado_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton2.ButtonText = "Reportes";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 65D;
            this.bunifuFlatButton2.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(-2, 433);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(260, 60);
            this.bunifuFlatButton2.TabIndex = 15;
            this.bunifuFlatButton2.Text = "Reportes";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton1.ButtonText = "Registrar producto";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-2, 367);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(260, 60);
            this.bunifuFlatButton1.TabIndex = 14;
            this.bunifuFlatButton1.Text = "Registrar producto";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // cmdRegistrarReceta
            // 
            this.cmdRegistrarReceta.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarReceta.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarReceta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarReceta.BorderRadius = 0;
            this.cmdRegistrarReceta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarReceta.ButtonText = "Registrar receta";
            this.cmdRegistrarReceta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarReceta, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarReceta, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarReceta, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarReceta.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarReceta.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarReceta.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarReceta.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarReceta.Iconimage")));
            this.cmdRegistrarReceta.Iconimage_right = null;
            this.cmdRegistrarReceta.Iconimage_right_Selected = null;
            this.cmdRegistrarReceta.Iconimage_Selected = null;
            this.cmdRegistrarReceta.IconMarginLeft = 0;
            this.cmdRegistrarReceta.IconMarginRight = 0;
            this.cmdRegistrarReceta.IconRightVisible = true;
            this.cmdRegistrarReceta.IconRightZoom = 0D;
            this.cmdRegistrarReceta.IconVisible = true;
            this.cmdRegistrarReceta.IconZoom = 65D;
            this.cmdRegistrarReceta.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRegistrarReceta.IsTab = true;
            this.cmdRegistrarReceta.Location = new System.Drawing.Point(0, 301);
            this.cmdRegistrarReceta.Name = "cmdRegistrarReceta";
            this.cmdRegistrarReceta.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarReceta.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarReceta.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarReceta.selected = false;
            this.cmdRegistrarReceta.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarReceta.TabIndex = 13;
            this.cmdRegistrarReceta.Text = "Registrar receta";
            this.cmdRegistrarReceta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarReceta.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarReceta.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarReceta.Click += new System.EventHandler(this.cmdRegistrarReceta_Click);
            // 
            // cmdBajaSucursal
            // 
            this.cmdBajaSucursal.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdBajaSucursal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdBajaSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBajaSucursal.BorderRadius = 0;
            this.cmdBajaSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdBajaSucursal.ButtonText = "Baja de sucursal";
            this.cmdBajaSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdBajaSucursal, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdBajaSucursal, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdBajaSucursal, BunifuAnimatorNS.DecorationType.None);
            this.cmdBajaSucursal.DisabledColor = System.Drawing.Color.Gray;
            this.cmdBajaSucursal.ForeColor = System.Drawing.Color.White;
            this.cmdBajaSucursal.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdBajaSucursal.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdBajaSucursal.Iconimage")));
            this.cmdBajaSucursal.Iconimage_right = null;
            this.cmdBajaSucursal.Iconimage_right_Selected = null;
            this.cmdBajaSucursal.Iconimage_Selected = null;
            this.cmdBajaSucursal.IconMarginLeft = 0;
            this.cmdBajaSucursal.IconMarginRight = 0;
            this.cmdBajaSucursal.IconRightVisible = true;
            this.cmdBajaSucursal.IconRightZoom = 0D;
            this.cmdBajaSucursal.IconVisible = true;
            this.cmdBajaSucursal.IconZoom = 65D;
            this.cmdBajaSucursal.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdBajaSucursal.IsTab = true;
            this.cmdBajaSucursal.Location = new System.Drawing.Point(3, 235);
            this.cmdBajaSucursal.Name = "cmdBajaSucursal";
            this.cmdBajaSucursal.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdBajaSucursal.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdBajaSucursal.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdBajaSucursal.selected = false;
            this.cmdBajaSucursal.Size = new System.Drawing.Size(260, 60);
            this.cmdBajaSucursal.TabIndex = 12;
            this.cmdBajaSucursal.Text = "Baja de sucursal";
            this.cmdBajaSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBajaSucursal.Textcolor = System.Drawing.Color.White;
            this.cmdBajaSucursal.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBajaSucursal.Click += new System.EventHandler(this.cmdBajaSucursal_Click);
            // 
            // cmdModificarSucursal
            // 
            this.cmdModificarSucursal.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdModificarSucursal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdModificarSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdModificarSucursal.BorderRadius = 0;
            this.cmdModificarSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdModificarSucursal.ButtonText = "Modificar producto";
            this.cmdModificarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdModificarSucursal, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdModificarSucursal, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdModificarSucursal, BunifuAnimatorNS.DecorationType.None);
            this.cmdModificarSucursal.DisabledColor = System.Drawing.Color.Gray;
            this.cmdModificarSucursal.ForeColor = System.Drawing.Color.White;
            this.cmdModificarSucursal.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdModificarSucursal.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdModificarSucursal.Iconimage")));
            this.cmdModificarSucursal.Iconimage_right = null;
            this.cmdModificarSucursal.Iconimage_right_Selected = null;
            this.cmdModificarSucursal.Iconimage_Selected = null;
            this.cmdModificarSucursal.IconMarginLeft = 0;
            this.cmdModificarSucursal.IconMarginRight = 0;
            this.cmdModificarSucursal.IconRightVisible = true;
            this.cmdModificarSucursal.IconRightZoom = 0D;
            this.cmdModificarSucursal.IconVisible = true;
            this.cmdModificarSucursal.IconZoom = 65D;
            this.cmdModificarSucursal.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdModificarSucursal.IsTab = true;
            this.cmdModificarSucursal.Location = new System.Drawing.Point(3, 169);
            this.cmdModificarSucursal.Name = "cmdModificarSucursal";
            this.cmdModificarSucursal.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdModificarSucursal.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdModificarSucursal.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdModificarSucursal.selected = false;
            this.cmdModificarSucursal.Size = new System.Drawing.Size(260, 60);
            this.cmdModificarSucursal.TabIndex = 11;
            this.cmdModificarSucursal.Text = "Modificar producto";
            this.cmdModificarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificarSucursal.Textcolor = System.Drawing.Color.White;
            this.cmdModificarSucursal.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarSucursal.Click += new System.EventHandler(this.cmdModificarSucursal_Click);
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
            // cmdRegistrarSucursal
            // 
            this.cmdRegistrarSucursal.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarSucursal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarSucursal.BorderRadius = 0;
            this.cmdRegistrarSucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarSucursal.ButtonText = "Registrar sucursal";
            this.cmdRegistrarSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarSucursal, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarSucursal, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarSucursal, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarSucursal.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarSucursal.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarSucursal.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarSucursal.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarSucursal.Iconimage")));
            this.cmdRegistrarSucursal.Iconimage_right = null;
            this.cmdRegistrarSucursal.Iconimage_right_Selected = null;
            this.cmdRegistrarSucursal.Iconimage_Selected = null;
            this.cmdRegistrarSucursal.IconMarginLeft = 0;
            this.cmdRegistrarSucursal.IconMarginRight = 0;
            this.cmdRegistrarSucursal.IconRightVisible = true;
            this.cmdRegistrarSucursal.IconRightZoom = 0D;
            this.cmdRegistrarSucursal.IconVisible = true;
            this.cmdRegistrarSucursal.IconZoom = 65D;
            this.cmdRegistrarSucursal.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRegistrarSucursal.IsTab = true;
            this.cmdRegistrarSucursal.Location = new System.Drawing.Point(1, 103);
            this.cmdRegistrarSucursal.Name = "cmdRegistrarSucursal";
            this.cmdRegistrarSucursal.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarSucursal.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarSucursal.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarSucursal.selected = false;
            this.cmdRegistrarSucursal.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarSucursal.TabIndex = 5;
            this.cmdRegistrarSucursal.Text = "Registrar sucursal";
            this.cmdRegistrarSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarSucursal.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarSucursal.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarSucursal.Click += new System.EventHandler(this.cmdRegistrarSucursal_Click);
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
            // frmMenuAdministracion
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
            this.Name = "frmMenuAdministracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Modificar Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuRRHH_Load);
            this.sidemenu.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarSucursal;
        private Bunifu.Framework.UI.BunifuFlatButton cmdModificarSucursal;
        private Bunifu.Framework.UI.BunifuFlatButton cmdBajaSucursal;
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarReceta;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdEncargado;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}

