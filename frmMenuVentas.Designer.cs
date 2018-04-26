namespace Procesadora
{
    partial class frmMenuVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuVentas));
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sidemenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdVentaPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdCancelarPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRegistrarPedido = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdModificarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdRegistrarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdGenerarFactura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdVentaGeneral = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.sidemenu.Controls.Add(this.bunifuFlatButton4);
            this.sidemenu.Controls.Add(this.bunifuFlatButton3);
            this.sidemenu.Controls.Add(this.bunifuFlatButton2);
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.cmdVentaPedido);
            this.sidemenu.Controls.Add(this.cmdCancelarPedido);
            this.sidemenu.Controls.Add(this.cmdRegistrarPedido);
            this.sidemenu.Controls.Add(this.cmdModificarCliente);
            this.sidemenu.Controls.Add(this.cmdRegistrarCliente);
            this.sidemenu.Controls.Add(this.cmdGenerarFactura);
            this.sidemenu.Controls.Add(this.cmdVentaGeneral);
            this.InsumosTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelTransition.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Location = new System.Drawing.Point(0, 48);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(264, 763);
            this.sidemenu.TabIndex = 0;
            this.sidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.sidemenu_Paint);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton4.ButtonText = "Stock de productos";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.bunifuFlatButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton4.Iconimage")));
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 65D;
            this.bunifuFlatButton4.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.bunifuFlatButton4.IsTab = true;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(1, 33);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(260, 60);
            this.bunifuFlatButton4.TabIndex = 20;
            this.bunifuFlatButton4.Text = "Stock de productos";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton3.ButtonText = "Lista de clientes";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 65D;
            this.bunifuFlatButton3.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.bunifuFlatButton3.IsTab = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(-2, 693);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(260, 60);
            this.bunifuFlatButton3.TabIndex = 19;
            this.bunifuFlatButton3.Text = "Lista de clientes";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuFlatButton2.ButtonText = "Reporte de ventas";
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(-2, 627);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(260, 60);
            this.bunifuFlatButton2.TabIndex = 18;
            this.bunifuFlatButton2.Text = "Reporte de ventas";
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
            this.bunifuFlatButton1.ButtonText = "Registrar cobro";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(1, 561);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(260, 60);
            this.bunifuFlatButton1.TabIndex = 17;
            this.bunifuFlatButton1.Text = "Registrar cobro";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // cmdVentaPedido
            // 
            this.cmdVentaPedido.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdVentaPedido.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdVentaPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdVentaPedido.BorderRadius = 0;
            this.cmdVentaPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdVentaPedido.ButtonText = "Venta por pedido";
            this.cmdVentaPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdVentaPedido, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdVentaPedido, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdVentaPedido, BunifuAnimatorNS.DecorationType.None);
            this.cmdVentaPedido.DisabledColor = System.Drawing.Color.Gray;
            this.cmdVentaPedido.ForeColor = System.Drawing.Color.White;
            this.cmdVentaPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdVentaPedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdVentaPedido.Iconimage")));
            this.cmdVentaPedido.Iconimage_right = null;
            this.cmdVentaPedido.Iconimage_right_Selected = null;
            this.cmdVentaPedido.Iconimage_Selected = null;
            this.cmdVentaPedido.IconMarginLeft = 0;
            this.cmdVentaPedido.IconMarginRight = 0;
            this.cmdVentaPedido.IconRightVisible = true;
            this.cmdVentaPedido.IconRightZoom = 0D;
            this.cmdVentaPedido.IconVisible = true;
            this.cmdVentaPedido.IconZoom = 65D;
            this.cmdVentaPedido.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdVentaPedido.IsTab = true;
            this.cmdVentaPedido.Location = new System.Drawing.Point(-2, 297);
            this.cmdVentaPedido.Name = "cmdVentaPedido";
            this.cmdVentaPedido.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdVentaPedido.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdVentaPedido.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdVentaPedido.selected = false;
            this.cmdVentaPedido.Size = new System.Drawing.Size(260, 60);
            this.cmdVentaPedido.TabIndex = 16;
            this.cmdVentaPedido.Text = "Venta por pedido";
            this.cmdVentaPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdVentaPedido.Textcolor = System.Drawing.Color.White;
            this.cmdVentaPedido.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentaPedido.Click += new System.EventHandler(this.cmdVentaPedido_Click);
            // 
            // cmdCancelarPedido
            // 
            this.cmdCancelarPedido.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdCancelarPedido.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdCancelarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCancelarPedido.BorderRadius = 0;
            this.cmdCancelarPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdCancelarPedido.ButtonText = "Cancelar pedido";
            this.cmdCancelarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdCancelarPedido, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdCancelarPedido, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdCancelarPedido, BunifuAnimatorNS.DecorationType.None);
            this.cmdCancelarPedido.DisabledColor = System.Drawing.Color.Gray;
            this.cmdCancelarPedido.ForeColor = System.Drawing.Color.White;
            this.cmdCancelarPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdCancelarPedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdCancelarPedido.Iconimage")));
            this.cmdCancelarPedido.Iconimage_right = null;
            this.cmdCancelarPedido.Iconimage_right_Selected = null;
            this.cmdCancelarPedido.Iconimage_Selected = null;
            this.cmdCancelarPedido.IconMarginLeft = 0;
            this.cmdCancelarPedido.IconMarginRight = 0;
            this.cmdCancelarPedido.IconRightVisible = true;
            this.cmdCancelarPedido.IconRightZoom = 0D;
            this.cmdCancelarPedido.IconVisible = true;
            this.cmdCancelarPedido.IconZoom = 65D;
            this.cmdCancelarPedido.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdCancelarPedido.IsTab = true;
            this.cmdCancelarPedido.Location = new System.Drawing.Point(1, 231);
            this.cmdCancelarPedido.Name = "cmdCancelarPedido";
            this.cmdCancelarPedido.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdCancelarPedido.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdCancelarPedido.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdCancelarPedido.selected = false;
            this.cmdCancelarPedido.Size = new System.Drawing.Size(260, 60);
            this.cmdCancelarPedido.TabIndex = 15;
            this.cmdCancelarPedido.Text = "Cancelar pedido";
            this.cmdCancelarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCancelarPedido.Textcolor = System.Drawing.Color.White;
            this.cmdCancelarPedido.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelarPedido.Click += new System.EventHandler(this.cmdCancelarPedido_Click);
            // 
            // cmdRegistrarPedido
            // 
            this.cmdRegistrarPedido.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarPedido.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarPedido.BorderRadius = 0;
            this.cmdRegistrarPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarPedido.ButtonText = "Registrar pedido";
            this.cmdRegistrarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarPedido, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarPedido, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarPedido, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarPedido.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarPedido.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarPedido.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarPedido.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarPedido.Iconimage")));
            this.cmdRegistrarPedido.Iconimage_right = null;
            this.cmdRegistrarPedido.Iconimage_right_Selected = null;
            this.cmdRegistrarPedido.Iconimage_Selected = null;
            this.cmdRegistrarPedido.IconMarginLeft = 0;
            this.cmdRegistrarPedido.IconMarginRight = 0;
            this.cmdRegistrarPedido.IconRightVisible = true;
            this.cmdRegistrarPedido.IconRightZoom = 0D;
            this.cmdRegistrarPedido.IconVisible = true;
            this.cmdRegistrarPedido.IconZoom = 65D;
            this.cmdRegistrarPedido.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRegistrarPedido.IsTab = true;
            this.cmdRegistrarPedido.Location = new System.Drawing.Point(3, 165);
            this.cmdRegistrarPedido.Name = "cmdRegistrarPedido";
            this.cmdRegistrarPedido.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarPedido.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarPedido.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarPedido.selected = false;
            this.cmdRegistrarPedido.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarPedido.TabIndex = 14;
            this.cmdRegistrarPedido.Text = "Registrar pedido";
            this.cmdRegistrarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarPedido.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarPedido.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarPedido.Click += new System.EventHandler(this.cmdRegistrarPedido_Click);
            // 
            // cmdModificarCliente
            // 
            this.cmdModificarCliente.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdModificarCliente.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdModificarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdModificarCliente.BorderRadius = 0;
            this.cmdModificarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdModificarCliente.ButtonText = "Modificar cliente";
            this.cmdModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdModificarCliente, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdModificarCliente, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdModificarCliente, BunifuAnimatorNS.DecorationType.None);
            this.cmdModificarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.cmdModificarCliente.ForeColor = System.Drawing.Color.White;
            this.cmdModificarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdModificarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdModificarCliente.Iconimage")));
            this.cmdModificarCliente.Iconimage_right = null;
            this.cmdModificarCliente.Iconimage_right_Selected = null;
            this.cmdModificarCliente.Iconimage_Selected = null;
            this.cmdModificarCliente.IconMarginLeft = 0;
            this.cmdModificarCliente.IconMarginRight = 0;
            this.cmdModificarCliente.IconRightVisible = true;
            this.cmdModificarCliente.IconRightZoom = 0D;
            this.cmdModificarCliente.IconVisible = true;
            this.cmdModificarCliente.IconZoom = 65D;
            this.cmdModificarCliente.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdModificarCliente.IsTab = true;
            this.cmdModificarCliente.Location = new System.Drawing.Point(3, 495);
            this.cmdModificarCliente.Name = "cmdModificarCliente";
            this.cmdModificarCliente.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdModificarCliente.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdModificarCliente.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdModificarCliente.selected = false;
            this.cmdModificarCliente.Size = new System.Drawing.Size(260, 60);
            this.cmdModificarCliente.TabIndex = 13;
            this.cmdModificarCliente.Text = "Modificar cliente";
            this.cmdModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificarCliente.Textcolor = System.Drawing.Color.White;
            this.cmdModificarCliente.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarCliente.Click += new System.EventHandler(this.cmdModificarCliente_Click);
            // 
            // cmdRegistrarCliente
            // 
            this.cmdRegistrarCliente.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdRegistrarCliente.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRegistrarCliente.BorderRadius = 0;
            this.cmdRegistrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdRegistrarCliente.ButtonText = "Registrar cliente";
            this.cmdRegistrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdRegistrarCliente, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdRegistrarCliente, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdRegistrarCliente, BunifuAnimatorNS.DecorationType.None);
            this.cmdRegistrarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.cmdRegistrarCliente.ForeColor = System.Drawing.Color.White;
            this.cmdRegistrarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdRegistrarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdRegistrarCliente.Iconimage")));
            this.cmdRegistrarCliente.Iconimage_right = null;
            this.cmdRegistrarCliente.Iconimage_right_Selected = null;
            this.cmdRegistrarCliente.Iconimage_Selected = null;
            this.cmdRegistrarCliente.IconMarginLeft = 0;
            this.cmdRegistrarCliente.IconMarginRight = 0;
            this.cmdRegistrarCliente.IconRightVisible = true;
            this.cmdRegistrarCliente.IconRightZoom = 0D;
            this.cmdRegistrarCliente.IconVisible = true;
            this.cmdRegistrarCliente.IconZoom = 65D;
            this.cmdRegistrarCliente.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdRegistrarCliente.IsTab = true;
            this.cmdRegistrarCliente.Location = new System.Drawing.Point(1, 429);
            this.cmdRegistrarCliente.Name = "cmdRegistrarCliente";
            this.cmdRegistrarCliente.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdRegistrarCliente.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdRegistrarCliente.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdRegistrarCliente.selected = false;
            this.cmdRegistrarCliente.Size = new System.Drawing.Size(260, 60);
            this.cmdRegistrarCliente.TabIndex = 12;
            this.cmdRegistrarCliente.Text = "Registrar cliente";
            this.cmdRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdRegistrarCliente.Textcolor = System.Drawing.Color.White;
            this.cmdRegistrarCliente.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarCliente.Click += new System.EventHandler(this.cmdRegistrarCliente_Click);
            // 
            // cmdGenerarFactura
            // 
            this.cmdGenerarFactura.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdGenerarFactura.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdGenerarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdGenerarFactura.BorderRadius = 0;
            this.cmdGenerarFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdGenerarFactura.ButtonText = "Generar factura";
            this.cmdGenerarFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdGenerarFactura, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdGenerarFactura, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdGenerarFactura, BunifuAnimatorNS.DecorationType.None);
            this.cmdGenerarFactura.DisabledColor = System.Drawing.Color.Gray;
            this.cmdGenerarFactura.ForeColor = System.Drawing.Color.White;
            this.cmdGenerarFactura.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdGenerarFactura.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdGenerarFactura.Iconimage")));
            this.cmdGenerarFactura.Iconimage_right = null;
            this.cmdGenerarFactura.Iconimage_right_Selected = null;
            this.cmdGenerarFactura.Iconimage_Selected = null;
            this.cmdGenerarFactura.IconMarginLeft = 0;
            this.cmdGenerarFactura.IconMarginRight = 0;
            this.cmdGenerarFactura.IconRightVisible = true;
            this.cmdGenerarFactura.IconRightZoom = 0D;
            this.cmdGenerarFactura.IconVisible = true;
            this.cmdGenerarFactura.IconZoom = 65D;
            this.cmdGenerarFactura.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdGenerarFactura.IsTab = true;
            this.cmdGenerarFactura.Location = new System.Drawing.Point(3, 363);
            this.cmdGenerarFactura.Name = "cmdGenerarFactura";
            this.cmdGenerarFactura.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdGenerarFactura.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdGenerarFactura.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdGenerarFactura.selected = false;
            this.cmdGenerarFactura.Size = new System.Drawing.Size(260, 60);
            this.cmdGenerarFactura.TabIndex = 11;
            this.cmdGenerarFactura.Text = "Generar factura";
            this.cmdGenerarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGenerarFactura.Textcolor = System.Drawing.Color.White;
            this.cmdGenerarFactura.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGenerarFactura.Click += new System.EventHandler(this.cmdGenerarFactura_Click);
            // 
            // cmdVentaGeneral
            // 
            this.cmdVentaGeneral.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.cmdVentaGeneral.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cmdVentaGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdVentaGeneral.BorderRadius = 0;
            this.cmdVentaGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdVentaGeneral.ButtonText = "    Venta a público en general";
            this.cmdVentaGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelTransition.SetDecoration(this.cmdVentaGeneral, BunifuAnimatorNS.DecorationType.None);
            this.LogoTransition.SetDecoration(this.cmdVentaGeneral, BunifuAnimatorNS.DecorationType.None);
            this.InsumosTransition.SetDecoration(this.cmdVentaGeneral, BunifuAnimatorNS.DecorationType.None);
            this.cmdVentaGeneral.DisabledColor = System.Drawing.Color.Gray;
            this.cmdVentaGeneral.ForeColor = System.Drawing.Color.White;
            this.cmdVentaGeneral.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdVentaGeneral.Iconimage = ((System.Drawing.Image)(resources.GetObject("cmdVentaGeneral.Iconimage")));
            this.cmdVentaGeneral.Iconimage_right = null;
            this.cmdVentaGeneral.Iconimage_right_Selected = null;
            this.cmdVentaGeneral.Iconimage_Selected = null;
            this.cmdVentaGeneral.IconMarginLeft = 0;
            this.cmdVentaGeneral.IconMarginRight = 0;
            this.cmdVentaGeneral.IconRightVisible = true;
            this.cmdVentaGeneral.IconRightZoom = 0D;
            this.cmdVentaGeneral.IconVisible = true;
            this.cmdVentaGeneral.IconZoom = 65D;
            this.cmdVentaGeneral.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.cmdVentaGeneral.IsTab = true;
            this.cmdVentaGeneral.Location = new System.Drawing.Point(3, 99);
            this.cmdVentaGeneral.Name = "cmdVentaGeneral";
            this.cmdVentaGeneral.Normalcolor = System.Drawing.SystemColors.WindowFrame;
            this.cmdVentaGeneral.OnHovercolor = System.Drawing.Color.DimGray;
            this.cmdVentaGeneral.OnHoverTextColor = System.Drawing.Color.Black;
            this.cmdVentaGeneral.selected = false;
            this.cmdVentaGeneral.Size = new System.Drawing.Size(260, 60);
            this.cmdVentaGeneral.TabIndex = 5;
            this.cmdVentaGeneral.Text = "    Venta a público en general";
            this.cmdVentaGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdVentaGeneral.Textcolor = System.Drawing.Color.White;
            this.cmdVentaGeneral.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentaGeneral.Click += new System.EventHandler(this.cmdRegistrarEmpleado_Click);
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
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Ventas";
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
            this.cmdEncargado.Location = new System.Drawing.Point(476, 339);
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
            this.lblPuesto.Location = new System.Drawing.Point(536, 308);
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
            this.label2.Location = new System.Drawing.Point(462, 308);
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
            this.lblNombre.Location = new System.Drawing.Point(552, 283);
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
            this.label1.Location = new System.Drawing.Point(462, 283);
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
            // frmMenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1341, 788);
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
            this.Name = "frmMenuVentas";
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
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition PanelTransition;
        private BunifuAnimatorNS.BunifuTransition LogoTransition;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private BunifuAnimatorNS.BunifuTransition InsumosTransition;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.ErrorProvider validador;
        private Bunifu.Framework.UI.BunifuFlatButton cmdVentaGeneral;
        private Bunifu.Framework.UI.BunifuFlatButton cmdGenerarFactura;
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarCliente;
        private Bunifu.Framework.UI.BunifuFlatButton cmdVentaPedido;
        private Bunifu.Framework.UI.BunifuFlatButton cmdCancelarPedido;
        private Bunifu.Framework.UI.BunifuFlatButton cmdRegistrarPedido;
        private Bunifu.Framework.UI.BunifuFlatButton cmdModificarCliente;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdEncargado;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
    }
}

