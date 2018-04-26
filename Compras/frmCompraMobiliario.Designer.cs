namespace Procesadora
{
    partial class frmCompraMobiliario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBuscarMobiliario = new System.Windows.Forms.Button();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdBuscarCompra = new System.Windows.Forms.Button();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBuscarMobiliario);
            this.groupBox1.Controls.Add(this.txtInsumo);
            this.groupBox1.Location = new System.Drawing.Point(48, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(171, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mobiliario";
            // 
            // cmdBuscarMobiliario
            // 
            this.cmdBuscarMobiliario.BackgroundImage = global::Procesadora.Properties.Resources.Lupa;
            this.cmdBuscarMobiliario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscarMobiliario.Location = new System.Drawing.Point(130, 22);
            this.cmdBuscarMobiliario.Name = "cmdBuscarMobiliario";
            this.cmdBuscarMobiliario.Size = new System.Drawing.Size(34, 32);
            this.cmdBuscarMobiliario.TabIndex = 1;
            this.cmdBuscarMobiliario.UseVisualStyleBackColor = true;
            this.cmdBuscarMobiliario.Click += new System.EventHandler(this.cmdBuscarMobiliario_Click);
            // 
            // txtInsumo
            // 
            this.txtInsumo.Enabled = false;
            this.txtInsumo.Location = new System.Drawing.Point(7, 26);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(100, 26);
            this.txtInsumo.TabIndex = 0;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdBuscarCompra);
            this.groupBox2.Controls.Add(this.txtIdCompra);
            this.groupBox2.Location = new System.Drawing.Point(48, 74);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(171, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compra";
            // 
            // cmdBuscarCompra
            // 
            this.cmdBuscarCompra.BackgroundImage = global::Procesadora.Properties.Resources.Lupa;
            this.cmdBuscarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscarCompra.Location = new System.Drawing.Point(130, 22);
            this.cmdBuscarCompra.Name = "cmdBuscarCompra";
            this.cmdBuscarCompra.Size = new System.Drawing.Size(34, 32);
            this.cmdBuscarCompra.TabIndex = 1;
            this.cmdBuscarCompra.UseVisualStyleBackColor = true;
            this.cmdBuscarCompra.Click += new System.EventHandler(this.cmdBuscarCompra_Click);
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Enabled = false;
            this.txtIdCompra.Location = new System.Drawing.Point(7, 26);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(100, 26);
            this.txtIdCompra.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSucursal);
            this.groupBox3.Location = new System.Drawing.Point(48, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 61);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sucursal";
            // 
            // cbSucursal
            // 
            this.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(7, 25);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(133, 26);
            this.cbSucursal.TabIndex = 0;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(34, 207);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(100, 30);
            this.cmdGuardar.TabIndex = 4;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCompraMobiliario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCompraMobiliario";
            this.Text = "Compra de mobiliario";
            this.Load += new System.EventHandler(this.frmCompraMobiliario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBuscarMobiliario;
        private System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdBuscarCompra;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbSucursal;
    }
}