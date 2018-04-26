namespace Procesadora
{
    partial class FrmModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarProducto));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmdModificar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdLimpiar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmdCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.cbPresentacion = new System.Windows.Forms.ComboBox();
            this.cmdModificarReceta = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripción: ";
            // 
            // validador
            // 
            this.validador.ContainerControl = this;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(123, 104);
            this.txtPrecio.MaxLength = 4;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(65, 29);
            this.txtPrecio.TabIndex = 19;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(65, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 21);
            this.label12.TabIndex = 31;
            this.label12.Text = "Precio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 21);
            this.label13.TabIndex = 36;
            this.label13.Text = "Presentación:";
            // 
            // cmdModificar
            // 
            this.cmdModificar.ActiveBorderThickness = 1;
            this.cmdModificar.ActiveCornerRadius = 20;
            this.cmdModificar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cmdModificar.ActiveForecolor = System.Drawing.Color.Gray;
            this.cmdModificar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cmdModificar.BackColor = System.Drawing.Color.Gray;
            this.cmdModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdModificar.BackgroundImage")));
            this.cmdModificar.ButtonText = "Modificar";
            this.cmdModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdModificar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.ForeColor = System.Drawing.Color.White;
            this.cmdModificar.IdleBorderThickness = 1;
            this.cmdModificar.IdleCornerRadius = 20;
            this.cmdModificar.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.cmdModificar.IdleForecolor = System.Drawing.Color.White;
            this.cmdModificar.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.cmdModificar.Location = new System.Drawing.Point(18, 241);
            this.cmdModificar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(91, 48);
            this.cmdModificar.TabIndex = 44;
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdModificar.Click += new System.EventHandler(this.cmdAgregarReceta_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.ActiveBorderThickness = 1;
            this.cmdLimpiar.ActiveCornerRadius = 20;
            this.cmdLimpiar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cmdLimpiar.ActiveForecolor = System.Drawing.Color.Gray;
            this.cmdLimpiar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cmdLimpiar.BackColor = System.Drawing.Color.Gray;
            this.cmdLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdLimpiar.BackgroundImage")));
            this.cmdLimpiar.ButtonText = "Limpiar";
            this.cmdLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLimpiar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.ForeColor = System.Drawing.Color.White;
            this.cmdLimpiar.IdleBorderThickness = 1;
            this.cmdLimpiar.IdleCornerRadius = 20;
            this.cmdLimpiar.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.cmdLimpiar.IdleForecolor = System.Drawing.Color.White;
            this.cmdLimpiar.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.cmdLimpiar.Location = new System.Drawing.Point(212, 241);
            this.cmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(98, 48);
            this.cmdLimpiar.TabIndex = 45;
            this.cmdLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click_1);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.ActiveBorderThickness = 1;
            this.cmdCancelar.ActiveCornerRadius = 20;
            this.cmdCancelar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cmdCancelar.ActiveForecolor = System.Drawing.Color.Gray;
            this.cmdCancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cmdCancelar.BackColor = System.Drawing.Color.Gray;
            this.cmdCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.BackgroundImage")));
            this.cmdCancelar.ButtonText = "Cancelar";
            this.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.ForeColor = System.Drawing.Color.White;
            this.cmdCancelar.IdleBorderThickness = 1;
            this.cmdCancelar.IdleCornerRadius = 20;
            this.cmdCancelar.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.cmdCancelar.IdleForecolor = System.Drawing.Color.White;
            this.cmdCancelar.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.cmdCancelar.Location = new System.Drawing.Point(316, 241);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(91, 48);
            this.cmdCancelar.TabIndex = 46;
            this.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Stock Mínimo:";
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(123, 139);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(65, 29);
            this.txtStockMin.TabIndex = 48;
            this.txtStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMin_KeyPress);
            // 
            // cbNombre
            // 
            this.cbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(123, 37);
            this.cbNombre.MaxLength = 50;
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(127, 29);
            this.cbNombre.TabIndex = 49;
            this.cbNombre.SelectedValueChanged += new System.EventHandler(this.cbNombre_SelectedValueChanged);
            // 
            // cbPresentacion
            // 
            this.cbPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPresentacion.FormattingEnabled = true;
            this.cbPresentacion.Location = new System.Drawing.Point(123, 72);
            this.cbPresentacion.MaxLength = 50;
            this.cbPresentacion.Name = "cbPresentacion";
            this.cbPresentacion.Size = new System.Drawing.Size(127, 29);
            this.cbPresentacion.TabIndex = 54;
            this.cbPresentacion.SelectedValueChanged += new System.EventHandler(this.cbPresentacion_SelectedValueChanged);
            // 
            // cmdModificarReceta
            // 
            this.cmdModificarReceta.ActiveBorderThickness = 1;
            this.cmdModificarReceta.ActiveCornerRadius = 20;
            this.cmdModificarReceta.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cmdModificarReceta.ActiveForecolor = System.Drawing.Color.Gray;
            this.cmdModificarReceta.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cmdModificarReceta.BackColor = System.Drawing.Color.Gray;
            this.cmdModificarReceta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdModificarReceta.BackgroundImage")));
            this.cmdModificarReceta.ButtonText = "Modificar Receta";
            this.cmdModificarReceta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdModificarReceta.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarReceta.ForeColor = System.Drawing.Color.White;
            this.cmdModificarReceta.IdleBorderThickness = 1;
            this.cmdModificarReceta.IdleCornerRadius = 20;
            this.cmdModificarReceta.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.cmdModificarReceta.IdleForecolor = System.Drawing.Color.White;
            this.cmdModificarReceta.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.cmdModificarReceta.Location = new System.Drawing.Point(115, 241);
            this.cmdModificarReceta.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.cmdModificarReceta.Name = "cmdModificarReceta";
            this.cmdModificarReceta.Size = new System.Drawing.Size(91, 48);
            this.cmdModificarReceta.TabIndex = 55;
            this.cmdModificarReceta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdModificarReceta.Click += new System.EventHandler(this.cmdModificarReceta_Click);
            // 
            // FrmModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(646, 291);
            this.Controls.Add(this.cmdModificarReceta);
            this.Controls.Add(this.cbPresentacion);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.txtStockMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmModificarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.FrmRegistrarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider validador;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdLimpiar;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdModificar;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.ComboBox cbPresentacion;
        private Bunifu.Framework.UI.BunifuThinButton2 cmdModificarReceta;

    }
}

