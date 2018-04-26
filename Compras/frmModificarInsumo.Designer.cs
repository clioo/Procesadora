namespace Procesadora
{
    partial class frmModificarInsumo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtTipoInsumo = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtUMedida = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtCostoPromedio = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtIDInsumo = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbInsumoMod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cbInsumoAlta = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cbInsumoBaja = new System.Windows.Forms.ComboBox();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarInsumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdGuardar);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(21, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 381);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar insumo";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(12, 327);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(100, 30);
            this.cmdGuardar.TabIndex = 13;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtCantidad);
            this.groupBox11.Location = new System.Drawing.Point(184, 108);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(172, 67);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(6, 25);
            this.txtCantidad.MaxLength = 30;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(120, 26);
            this.txtCantidad.TabIndex = 7;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtTipoInsumo);
            this.groupBox10.Location = new System.Drawing.Point(184, 254);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(172, 67);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tipo de Insumo";
            // 
            // txtTipoInsumo
            // 
            this.txtTipoInsumo.Location = new System.Drawing.Point(6, 25);
            this.txtTipoInsumo.MaxLength = 30;
            this.txtTipoInsumo.Name = "txtTipoInsumo";
            this.txtTipoInsumo.ReadOnly = true;
            this.txtTipoInsumo.Size = new System.Drawing.Size(120, 26);
            this.txtTipoInsumo.TabIndex = 7;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtUMedida);
            this.groupBox9.Location = new System.Drawing.Point(184, 181);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(172, 67);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Unidad de medida";
            // 
            // txtUMedida
            // 
            this.txtUMedida.Location = new System.Drawing.Point(6, 25);
            this.txtUMedida.MaxLength = 30;
            this.txtUMedida.Name = "txtUMedida";
            this.txtUMedida.ReadOnly = true;
            this.txtUMedida.Size = new System.Drawing.Size(120, 26);
            this.txtUMedida.TabIndex = 7;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtCostoPromedio);
            this.groupBox8.Location = new System.Drawing.Point(6, 254);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(172, 67);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Costo promedio";
            // 
            // txtCostoPromedio
            // 
            this.txtCostoPromedio.Location = new System.Drawing.Point(6, 25);
            this.txtCostoPromedio.MaxLength = 30;
            this.txtCostoPromedio.Name = "txtCostoPromedio";
            this.txtCostoPromedio.ReadOnly = true;
            this.txtCostoPromedio.Size = new System.Drawing.Size(120, 26);
            this.txtCostoPromedio.TabIndex = 7;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtIDInsumo);
            this.groupBox7.Location = new System.Drawing.Point(184, 25);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(172, 67);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "ID del Insumo";
            // 
            // txtIDInsumo
            // 
            this.txtIDInsumo.Location = new System.Drawing.Point(6, 25);
            this.txtIDInsumo.MaxLength = 30;
            this.txtIDInsumo.Name = "txtIDInsumo";
            this.txtIDInsumo.ReadOnly = true;
            this.txtIDInsumo.Size = new System.Drawing.Size(120, 26);
            this.txtIDInsumo.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtStockMin);
            this.groupBox6.Location = new System.Drawing.Point(6, 181);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(172, 67);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Stock Mínimo";
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(6, 25);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(120, 26);
            this.txtStockMin.TabIndex = 0;
            this.txtStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMin_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNombre);
            this.groupBox5.Location = new System.Drawing.Point(6, 108);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(172, 67);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 25);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 26);
            this.txtNombre.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbInsumoMod);
            this.groupBox4.Location = new System.Drawing.Point(6, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 67);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insumo a modificar:";
            // 
            // cbInsumoMod
            // 
            this.cbInsumoMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsumoMod.FormattingEnabled = true;
            this.cbInsumoMod.Location = new System.Drawing.Point(6, 25);
            this.cbInsumoMod.Name = "cbInsumoMod";
            this.cbInsumoMod.Size = new System.Drawing.Size(130, 26);
            this.cbInsumoMod.TabIndex = 3;
            this.cbInsumoMod.SelectedIndexChanged += new System.EventHandler(this.cbInsumoMod_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAgregar);
            this.groupBox1.Controls.Add(this.cbInsumoAlta);
            this.groupBox1.Location = new System.Drawing.Point(399, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 102);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insumo a dar de alta:";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(6, 62);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(100, 30);
            this.cmdAgregar.TabIndex = 7;
            this.cmdAgregar.Text = "Dar de alta";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cbInsumoAlta
            // 
            this.cbInsumoAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsumoAlta.FormattingEnabled = true;
            this.cbInsumoAlta.Location = new System.Drawing.Point(6, 25);
            this.cbInsumoAlta.Name = "cbInsumoAlta";
            this.cbInsumoAlta.Size = new System.Drawing.Size(130, 26);
            this.cbInsumoAlta.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdEliminar);
            this.groupBox3.Controls.Add(this.cbInsumoBaja);
            this.groupBox3.Location = new System.Drawing.Point(399, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 102);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insumo a dar de baja:";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(6, 62);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(100, 30);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Dar de baja";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cbInsumoBaja
            // 
            this.cbInsumoBaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInsumoBaja.FormattingEnabled = true;
            this.cbInsumoBaja.Location = new System.Drawing.Point(6, 25);
            this.cbInsumoBaja.Name = "cbInsumoBaja";
            this.cbInsumoBaja.Size = new System.Drawing.Size(130, 26);
            this.cbInsumoBaja.TabIndex = 3;
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarInsumosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(576, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarInsumosToolStripMenuItem
            // 
            this.registrarInsumosToolStripMenuItem.Name = "registrarInsumosToolStripMenuItem";
            this.registrarInsumosToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.registrarInsumosToolStripMenuItem.Text = "Registrar Insumos";
            this.registrarInsumosToolStripMenuItem.Click += new System.EventHandler(this.registrarInsumosToolStripMenuItem_Click);
            // 
            // frmModificarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModificarInsumo";
            this.Text = "Modificar Insumos";
            this.Load += new System.EventHandler(this.frmModificarInsumo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtTipoInsumo;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtUMedida;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtCostoPromedio;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtIDInsumo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbInsumoMod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.ComboBox cbInsumoAlta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.ComboBox cbInsumoBaja;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarInsumosToolStripMenuItem;
    }
}