namespace Procesadora
{
    partial class frmRegistrarProduccionDeLote
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_cantidadprod = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_reprec = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtp_prod = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtp_cad = new System.Windows.Forms.DateTimePicker();
            this.cmd_Registrar = new System.Windows.Forms.Button();
            this.dgv_receta = new System.Windows.Forms.DataGridView();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarOrdenDeProducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_id_orden_produccion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdRegresar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_cantidadprod);
            this.groupBox3.Location = new System.Drawing.Point(12, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 58);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad producida";
            // 
            // txt_cantidadprod
            // 
            this.txt_cantidadprod.Location = new System.Drawing.Point(17, 26);
            this.txt_cantidadprod.Name = "txt_cantidadprod";
            this.txt_cantidadprod.Size = new System.Drawing.Size(153, 26);
            this.txt_cantidadprod.TabIndex = 5;
            this.txt_cantidadprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidadprod_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_reprec);
            this.groupBox4.Location = new System.Drawing.Point(12, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 58);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Porciones de receta utilizada";
            // 
            // txt_reprec
            // 
            this.txt_reprec.Location = new System.Drawing.Point(17, 26);
            this.txt_reprec.Name = "txt_reprec";
            this.txt_reprec.Size = new System.Drawing.Size(153, 26);
            this.txt_reprec.TabIndex = 5;
            this.txt_reprec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtp_prod);
            this.groupBox5.Location = new System.Drawing.Point(12, 223);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 58);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fecha de producción";
            // 
            // dtp_prod
            // 
            this.dtp_prod.CustomFormat = "yyyy-MM-dd";
            this.dtp_prod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_prod.Location = new System.Drawing.Point(17, 26);
            this.dtp_prod.Name = "dtp_prod";
            this.dtp_prod.Size = new System.Drawing.Size(153, 26);
            this.dtp_prod.TabIndex = 8;
            this.dtp_prod.Value = new System.DateTime(2017, 11, 12, 0, 0, 0, 0);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtp_cad);
            this.groupBox6.Location = new System.Drawing.Point(12, 287);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 58);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fecha de caducidad";
            // 
            // dtp_cad
            // 
            this.dtp_cad.CustomFormat = "yyyy-MM-dd";
            this.dtp_cad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_cad.Location = new System.Drawing.Point(17, 26);
            this.dtp_cad.Name = "dtp_cad";
            this.dtp_cad.Size = new System.Drawing.Size(153, 26);
            this.dtp_cad.TabIndex = 8;
            this.dtp_cad.Value = new System.DateTime(2017, 11, 12, 0, 0, 0, 0);
            // 
            // cmd_Registrar
            // 
            this.cmd_Registrar.Location = new System.Drawing.Point(12, 351);
            this.cmd_Registrar.Name = "cmd_Registrar";
            this.cmd_Registrar.Size = new System.Drawing.Size(100, 30);
            this.cmd_Registrar.TabIndex = 10;
            this.cmd_Registrar.Text = "Registrar";
            this.cmd_Registrar.UseVisualStyleBackColor = true;
            this.cmd_Registrar.Click += new System.EventHandler(this.cmd_Registrar_Click);
            // 
            // dgv_receta
            // 
            this.dgv_receta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receta.Location = new System.Drawing.Point(261, 31);
            this.dgv_receta.Name = "dgv_receta";
            this.dgv_receta.Size = new System.Drawing.Size(339, 442);
            this.dgv_receta.TabIndex = 11;
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produccionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produccionToolStripMenuItem
            // 
            this.produccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historialDeProduccionToolStripMenuItem,
            this.registrarOrdenDeProducciónToolStripMenuItem});
            this.produccionToolStripMenuItem.Name = "produccionToolStripMenuItem";
            this.produccionToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.produccionToolStripMenuItem.Text = "Produccion";
            // 
            // historialDeProduccionToolStripMenuItem
            // 
            this.historialDeProduccionToolStripMenuItem.Name = "historialDeProduccionToolStripMenuItem";
            this.historialDeProduccionToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.historialDeProduccionToolStripMenuItem.Text = "Historial de produccion";
            this.historialDeProduccionToolStripMenuItem.Click += new System.EventHandler(this.historialDeProduccionToolStripMenuItem_Click);
            // 
            // registrarOrdenDeProducciónToolStripMenuItem
            // 
            this.registrarOrdenDeProducciónToolStripMenuItem.Name = "registrarOrdenDeProducciónToolStripMenuItem";
            this.registrarOrdenDeProducciónToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.registrarOrdenDeProducciónToolStripMenuItem.Text = "Registrar Orden de Producción";
            this.registrarOrdenDeProducciónToolStripMenuItem.Click += new System.EventHandler(this.registrarOrdenDeProducciónToolStripMenuItem_Click);
            // 
            // txt_id_orden_produccion
            // 
            this.txt_id_orden_produccion.Location = new System.Drawing.Point(17, 26);
            this.txt_id_orden_produccion.Name = "txt_id_orden_produccion";
            this.txt_id_orden_produccion.Size = new System.Drawing.Size(153, 26);
            this.txt_id_orden_produccion.TabIndex = 1;
            this.txt_id_orden_produccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_txt_id_orden_produccion_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBuscar);
            this.groupBox1.Controls.Add(this.txt_id_orden_produccion);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID de orden de producción";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackgroundImage = global::Procesadora.Properties.Resources.Lupa;
            this.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscar.Location = new System.Drawing.Point(176, 22);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(31, 30);
            this.cmdBuscar.TabIndex = 1;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdRegresar
            // 
            this.cmdRegresar.Location = new System.Drawing.Point(125, 351);
            this.cmdRegresar.Name = "cmdRegresar";
            this.cmdRegresar.Size = new System.Drawing.Size(100, 30);
            this.cmdRegresar.TabIndex = 13;
            this.cmdRegresar.Text = "Regresar";
            this.cmdRegresar.UseVisualStyleBackColor = true;
            this.cmdRegresar.Click += new System.EventHandler(this.cmdRegresar_Click);
            // 
            // frmRegistrarProduccionDeLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 487);
            this.Controls.Add(this.cmdRegresar);
            this.Controls.Add(this.dgv_receta);
            this.Controls.Add(this.cmd_Registrar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarProduccionDeLote";
            this.Text = "Registrar producción de lote.";
            this.Load += new System.EventHandler(this.frmRegistrarProduccionDeLote_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_cantidadprod;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_reprec;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtp_prod;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtp_cad;
        private System.Windows.Forms.Button cmd_Registrar;
        private System.Windows.Forms.DataGridView dgv_receta;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeProduccionToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txt_id_orden_produccion;
        private System.Windows.Forms.ToolStripMenuItem registrarOrdenDeProducciónToolStripMenuItem;
        private System.Windows.Forms.Button cmdRegresar;
    }
}