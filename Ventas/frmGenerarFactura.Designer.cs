namespace Procesadora
{
    partial class frmGenerarFactura
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
            this.txt_IDVenta = new System.Windows.Forms.TextBox();
            this.cmd_guardar = new System.Windows.Forms.Button();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cmdBuscarCliente = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_IDVenta);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 58);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket de venta(ID)";
            // 
            // txt_IDVenta
            // 
            this.txt_IDVenta.Location = new System.Drawing.Point(17, 26);
            this.txt_IDVenta.Name = "txt_IDVenta";
            this.txt_IDVenta.Size = new System.Drawing.Size(153, 26);
            this.txt_IDVenta.TabIndex = 1;
            this.txt_IDVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDVenta_KeyPress);
            // 
            // cmd_guardar
            // 
            this.cmd_guardar.Location = new System.Drawing.Point(231, 61);
            this.cmd_guardar.Name = "cmd_guardar";
            this.cmd_guardar.Size = new System.Drawing.Size(100, 30);
            this.cmd_guardar.TabIndex = 12;
            this.cmd_guardar.Text = "Generar";
            this.cmd_guardar.UseVisualStyleBackColor = true;
            this.cmd_guardar.Visible = false;
            this.cmd_guardar.Click += new System.EventHandler(this.cmd_guardar_Click);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(231, 25);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(100, 30);
            this.cmdVerificar.TabIndex = 40;
            this.cmdVerificar.Text = "Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cmdBuscarCliente);
            this.gbCliente.Controls.Add(this.txtCliente);
            this.gbCliente.Location = new System.Drawing.Point(12, 76);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(213, 65);
            this.gbCliente.TabIndex = 41;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            this.gbCliente.Visible = false;
            // 
            // cmdBuscarCliente
            // 
            this.cmdBuscarCliente.BackgroundImage = global::Procesadora.Properties.Resources.Lupa;
            this.cmdBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscarCliente.Location = new System.Drawing.Point(176, 21);
            this.cmdBuscarCliente.Name = "cmdBuscarCliente";
            this.cmdBuscarCliente.Size = new System.Drawing.Size(31, 30);
            this.cmdBuscarCliente.TabIndex = 2;
            this.cmdBuscarCliente.UseVisualStyleBackColor = true;
            this.cmdBuscarCliente.Click += new System.EventHandler(this.cmdBuscarCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(17, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(153, 26);
            this.txtCliente.TabIndex = 2;
            // 
            // frmGenerarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 413);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.cmdVerificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd_guardar);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGenerarFactura";
            this.Text = "Generar factura";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_IDVenta;
        private System.Windows.Forms.Button cmd_guardar;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button cmdBuscarCliente;
        private System.Windows.Forms.TextBox txtCliente;
    }
}