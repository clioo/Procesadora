namespace Procesadora
{
    partial class frmMenuCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuCompras));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdCompraMobiliario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRegistrarPago = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdGenerarOrdenCompra = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdCancelarOrdenCompra = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdModificarProveedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRegistrarCompra = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRegistrarProveedor = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sidemenu.SuspendLayout();
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
            this.sidemenu.Controls.Add(this.bunifuFlatButton2);
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.cmdCompraMobiliario);
            this.sidemenu.Controls.Add(this.cmdRegistrarPago);
            this.sidemenu.Controls.Add(this.cmdGenerarOrdenCompra);
            this.sidemenu.Controls.Add(this.cmdCancelarOrdenCompra);
            this.sidemenu.Controls.Add(this.cmdModificarProveedor);
            this.sidemenu.Controls.Add(this.cmdRegistrarCompra);
            this.sidemenu.Controls.Add(this.cmdRegistrarProveedor);
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
            this.bunifuFlatButton1.ButtonText = "Registrar nuevo insumo";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(2, 204);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(260, 60);
            this.bunifuFlatButton1.TabIndex = 16;
            this.bunifuFlatButton1.Text = "Registrar nuevo insumo";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // cmdCompraMobiliario
            // 
            this.cmdCompraMobiliario.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdCompraMobiliario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdCompraMobiliario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCompraMobiliario.BorderRadius = 0;
            this.cmdCompraMobiliario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdCompraMobiliario.ButtonText = "Registrar Compra de mobiliario";
            this.cmdCompraMobiliario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdCompraMobiliario, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdCompraMobiliario, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdCompraMobiliario, BunifuAnimatorNS.DecorationType.None);
            this.cmdCompraMobiliario.DisabledColor = System.Drawing.Color.Gray;
            this.cmdCompraMobiliario.ForeColor = System.Drawing.Color.White;
            this.cmdCompraMobiliario.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdCompraMobiliario.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdCompraMobiliario.Iconimage")));
            this.cmdCompraMobiliario.Iconimage_right = null;
            this.cmdCompraMobiliario.Iconimage_right_Selected = null;
            this.cmdCompraMobiliario.Iconimage_Selected = null;
            this.cmdCompraMobiliario.IconMarginLeft = 0;
            this.cmdCompraMobiliario.IconMarginRight = 0;
            this.cmdCompraMobiliario.IconRightVisible = true;
            this.cmdCompraMobiliario.IconRightZoom = 0D;
            this.cmdCompraMobiliario.IconVisible = true;
            this.cmdCompraMobiliario.IconZoom = 65D;
            this.cmdCompraMobiliario.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdCompraMobiliario.IsTab = true;
            this.cmdCompraMobiliario.Location = new System.Drawing.Point(-2, 72);
            this.cmdCompraMobiliario.Name = "cmdCompraMobiliario";
            this.cmdCompraMobiliario.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdCompraMobiliario.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdCompraMobiliario.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdCompraMobiliario.selected = false;
            this.cmdCompraMobiliario.Size = new System.Drawing.Size(260, 60);
            this.cmdCompraMobiliario.TabIndex = 15;
            this.cmdCompraMobiliario.Text = "Registrar Compra de mobiliario";
            this.cmdCompraMobiliario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCompraMobiliario.Textcolor = System.Drawing.Color.White;
            this.cmdCompraMobiliario.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCompraMobiliario.Click += new System.EventHandler(this.cmdCompraMobiliario_Click);
            // 
            // cmdRegistrarPago
            // 
            this.cmdRegistrarPago.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarPago.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarPago.BorderRadius = 0;
            this.cmdRegistrarPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarPago.ButtonText = "Registrar pago";
            this.cmdRegistrarPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarPago, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarPago, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarPago, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarPago.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarPago.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarPago.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarPago.Iconimage")));
            this.cmdRegistrarPago.Iconimage_right = null;
            this.cmdRegistrarPago.Iconimage_right_Selected = null;
            this.cmdRegistrarPago.Iconimage_Selected = null;
            this.cmdRegistrarPago.IconMarginLeft = 0;
            this.cmdRegistrarPago.IconMarginRight = 0;
            this.cmdRegistrarPago.IconRightVisible = true;
            this.cmdRegistrarPago.IconRightZoom = 0D;
            this.cmdRegistrarPago.IconVisible = true;
            this.cmdRegistrarPago.IconZoom = 65D;
            this.cmdRegistrarPago.IsTab = true;
            this.cmdRegistrarPago.Location = new System.Drawing.Point(1, 336);
            this.cmdRegistrarPago.Name = "cmdRegistrarPago";
            this.cmdRegistrarPago.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarPago.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarPago.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarPago.selected = false;
            this.cmdRegistrarPago.Size = new System.Drawing.Size(262, 60);
            this.cmdRegistrarPago.TabIndex = 13;
            this.cmdRegistrarPago.Text = "Registrar pago";
            this.cmdRegistrarPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarPago.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarPago.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarPago.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // cmdGenerarOrdenCompra
            // 
            this.cmdGenerarOrdenCompra.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdGenerarOrdenCompra.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdGenerarOrdenCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGenerarOrdenCompra.BorderRadius = 0;
            this.cmdGenerarOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdGenerarOrdenCompra.ButtonText = "Generar Orden de compra";
            this.cmdGenerarOrdenCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdGenerarOrdenCompra, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdGenerarOrdenCompra, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdGenerarOrdenCompra, BunifuAnimatorNS.DecorationType.None);
            this.cmdGenerarOrdenCompra.DisabledColor = System.Drawing.Color.Gray;
            this.cmdGenerarOrdenCompra.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdGenerarOrdenCompra.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdGenerarOrdenCompra.Iconimage")));
            this.cmdGenerarOrdenCompra.Iconimage_right = null;
            this.cmdGenerarOrdenCompra.Iconimage_right_Selected = null;
            this.cmdGenerarOrdenCompra.Iconimage_Selected = null;
            this.cmdGenerarOrdenCompra.IconMarginLeft = 0;
            this.cmdGenerarOrdenCompra.IconMarginRight = 0;
            this.cmdGenerarOrdenCompra.IconRightVisible = true;
            this.cmdGenerarOrdenCompra.IconRightZoom = 0D;
            this.cmdGenerarOrdenCompra.IconVisible = true;
            this.cmdGenerarOrdenCompra.IconZoom = 65D;
            this.cmdGenerarOrdenCompra.IsTab = true;
            this.cmdGenerarOrdenCompra.Location = new System.Drawing.Point(3, 402);
            this.cmdGenerarOrdenCompra.Name = "cmdGenerarOrdenCompra";
            this.cmdGenerarOrdenCompra.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdGenerarOrdenCompra.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdGenerarOrdenCompra.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdGenerarOrdenCompra.selected = false;
            this.cmdGenerarOrdenCompra.Size = new System.Drawing.Size(260, 60);
            this.cmdGenerarOrdenCompra.TabIndex = 12;
            this.cmdGenerarOrdenCompra.Text = "Generar Orden de compra";
            this.cmdGenerarOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGenerarOrdenCompra.Textcolor = System.Drawing.Color.White;
            this.cmdGenerarOrdenCompra.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerarOrdenCompra.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // cmdCancelarOrdenCompra
            // 
            this.cmdCancelarOrdenCompra.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdCancelarOrdenCompra.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdCancelarOrdenCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCancelarOrdenCompra.BorderRadius = 0;
            this.cmdCancelarOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdCancelarOrdenCompra.ButtonText = "Cancelar orden de compra";
            this.cmdCancelarOrdenCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdCancelarOrdenCompra, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdCancelarOrdenCompra, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdCancelarOrdenCompra, BunifuAnimatorNS.DecorationType.None);
            this.cmdCancelarOrdenCompra.DisabledColor = System.Drawing.Color.Gray;
            this.cmdCancelarOrdenCompra.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdCancelarOrdenCompra.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdCancelarOrdenCompra.Iconimage")));
            this.cmdCancelarOrdenCompra.Iconimage_right = null;
            this.cmdCancelarOrdenCompra.Iconimage_right_Selected = null;
            this.cmdCancelarOrdenCompra.Iconimage_Selected = null;
            this.cmdCancelarOrdenCompra.IconMarginLeft = 0;
            this.cmdCancelarOrdenCompra.IconMarginRight = 0;
            this.cmdCancelarOrdenCompra.IconRightVisible = true;
            this.cmdCancelarOrdenCompra.IconRightZoom = 0D;
            this.cmdCancelarOrdenCompra.IconVisible = true;
            this.cmdCancelarOrdenCompra.IconZoom = 65D;
            this.cmdCancelarOrdenCompra.IsTab = true;
            this.cmdCancelarOrdenCompra.Location = new System.Drawing.Point(0, 468);
            this.cmdCancelarOrdenCompra.Name = "cmdCancelarOrdenCompra";
            this.cmdCancelarOrdenCompra.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdCancelarOrdenCompra.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdCancelarOrdenCompra.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdCancelarOrdenCompra.selected = false;
            this.cmdCancelarOrdenCompra.Size = new System.Drawing.Size(262, 60);
            this.cmdCancelarOrdenCompra.TabIndex = 11;
            this.cmdCancelarOrdenCompra.Text = "Cancelar orden de compra";
            this.cmdCancelarOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelarOrdenCompra.Textcolor = System.Drawing.Color.White;
            this.cmdCancelarOrdenCompra.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelarOrdenCompra.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // cmdModificarProveedor
            // 
            this.cmdModificarProveedor.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdModificarProveedor.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdModificarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdModificarProveedor.BorderRadius = 0;
            this.cmdModificarProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdModificarProveedor.ButtonText = "Modificar proveedor";
            this.cmdModificarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdModificarProveedor, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdModificarProveedor, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdModificarProveedor, BunifuAnimatorNS.DecorationType.None);
            this.cmdModificarProveedor.DisabledColor = System.Drawing.Color.Gray;
            this.cmdModificarProveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdModificarProveedor.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdModificarProveedor.Iconimage")));
            this.cmdModificarProveedor.Iconimage_right = null;
            this.cmdModificarProveedor.Iconimage_right_Selected = null;
            this.cmdModificarProveedor.Iconimage_Selected = null;
            this.cmdModificarProveedor.IconMarginLeft = 0;
            this.cmdModificarProveedor.IconMarginRight = 0;
            this.cmdModificarProveedor.IconRightVisible = true;
            this.cmdModificarProveedor.IconRightZoom = 0D;
            this.cmdModificarProveedor.IconVisible = true;
            this.cmdModificarProveedor.IconZoom = 65D;
            this.cmdModificarProveedor.IsTab = true;
            this.cmdModificarProveedor.Location = new System.Drawing.Point(2, 270);
            this.cmdModificarProveedor.Name = "cmdModificarProveedor";
            this.cmdModificarProveedor.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdModificarProveedor.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdModificarProveedor.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdModificarProveedor.selected = false;
            this.cmdModificarProveedor.Size = new System.Drawing.Size(260, 60);
            this.cmdModificarProveedor.TabIndex = 7;
            this.cmdModificarProveedor.Text = "Modificar proveedor";
            this.cmdModificarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificarProveedor.Textcolor = System.Drawing.Color.White;
            this.cmdModificarProveedor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarProveedor.Click += new System.EventHandler(this.tabRegistrarDescuento_Click);
            // 
            // cmdRegistrarCompra
            // 
            this.cmdRegistrarCompra.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarCompra.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarCompra.BorderRadius = 0;
            this.cmdRegistrarCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarCompra.ButtonText = "Registrar Compra";
            this.cmdRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarCompra, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarCompra, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarCompra, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarCompra.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarCompra.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarCompra.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarCompra.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarCompra.Iconimage")));
            this.cmdRegistrarCompra.Iconimage_right = null;
            this.cmdRegistrarCompra.Iconimage_right_Selected = null;
            this.cmdRegistrarCompra.Iconimage_Selected = null;
            this.cmdRegistrarCompra.IconMarginLeft = 0;
            this.cmdRegistrarCompra.IconMarginRight = 0;
            this.cmdRegistrarCompra.IconRightVisible = true;
            this.cmdRegistrarCompra.IconRightZoom = 0D;
            this.cmdRegistrarCompra.IconVisible = true;
            this.cmdRegistrarCompra.IconZoom = 65D;
            this.cmdRegistrarCompra.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRegistrarCompra.IsTab = true;
            this.cmdRegistrarCompra.Location = new System.Drawing.Point(1, 6);
            this.cmdRegistrarCompra.Name = "cmdRegistrarCompra";
            this.cmdRegistrarCompra.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarCompra.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarCompra.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarCompra.selected = false;
            this.cmdRegistrarCompra.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarCompra.TabIndex = 4;
            this.cmdRegistrarCompra.Text = "Registrar Compra";
            this.cmdRegistrarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarCompra.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarCompra.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarCompra.Click += new System.EventHandler(this.tabRegEmpleado_Click);
            // 
            // cmdRegistrarProveedor
            // 
            this.cmdRegistrarProveedor.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarProveedor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarProveedor.BorderRadius = 0;
            this.cmdRegistrarProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarProveedor.ButtonText = "Regisrar Proveedor";
            this.cmdRegistrarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarProveedor, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarProveedor, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarProveedor, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarProveedor.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarProveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarProveedor.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarProveedor.Iconimage")));
            this.cmdRegistrarProveedor.Iconimage_right = null;
            this.cmdRegistrarProveedor.Iconimage_right_Selected = null;
            this.cmdRegistrarProveedor.Iconimage_Selected = null;
            this.cmdRegistrarProveedor.IconMarginLeft = 0;
            this.cmdRegistrarProveedor.IconMarginRight = 0;
            this.cmdRegistrarProveedor.IconRightVisible = true;
            this.cmdRegistrarProveedor.IconRightZoom = 20D;
            this.cmdRegistrarProveedor.IconVisible = true;
            this.cmdRegistrarProveedor.IconZoom = 65D;
            this.cmdRegistrarProveedor.IsTab = true;
            this.cmdRegistrarProveedor.Location = new System.Drawing.Point(3, 138);
            this.cmdRegistrarProveedor.Name = "cmdRegistrarProveedor";
            this.cmdRegistrarProveedor.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarProveedor.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarProveedor.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarProveedor.selected = true;
            this.cmdRegistrarProveedor.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarProveedor.TabIndex = 2;
            this.cmdRegistrarProveedor.Text = "Regisrar Proveedor";
            this.cmdRegistrarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarProveedor.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarProveedor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarProveedor.Click += new System.EventHandler(this.tabRegistrarBonificacion_Click);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(200, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Recursos Humanos RRHH";
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
            this.cmdEncargado.Location = new System.Drawing.Point(404, 265);
            this.cmdEncargado.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmdEncargado.Name = "cmdEncargado";
            this.cmdEncargado.Size = new System.Drawing.Size(129, 80);
            this.cmdEncargado.TabIndex = 55;
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
            this.lblPuesto.Location = new System.Drawing.Point(464, 234);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(0, 25);
            this.lblPuesto.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Puesto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.PanelTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.lblNombre, BunifuAnimatorNS.DecorationType.None);
            this.lblNombre.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(480, 209);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 25);
            this.lblNombre.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 51;
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
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton2.ButtonText = "Reporte de compras";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
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
            this.bunifuFlatButton2.IsTab = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(-1, 534);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(262, 60);
            this.bunifuFlatButton2.TabIndex = 17;
            this.bunifuFlatButton2.Text = "Reporte de compras";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click_1);
            // 
            // frmMenuCompras
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
            this.Name = "frmMenuCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Modificar Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuRRHH_Load);
            this.sidemenu.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarProveedor;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarCompra;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private Bunifu.Framework.UI.BunifuFlatButton cmdModificarProveedor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private BunifuAnimatorNS.BunifuTransition InsumosTransition;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuFlatButton cmdCancelarOrdenCompra;
        private System.Windows.Forms.ErrorProvider validador;
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarPago;
        private Bunifu.Framework.UI.BunifuFlatButton cmdGenerarOrdenCompra;
        private Bunifu.Framework.UI.BunifuFlatButton cmdCompraMobiliario;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdEncargado;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}

