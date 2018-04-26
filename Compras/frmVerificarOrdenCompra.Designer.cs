namespace Procesadora
{
    partial class frmVerificarOrdenCompra
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
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.cmdVerificar = new System.Windows.Forms.Button();
            this.validador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdRegresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBuscar);
            this.groupBox1.Controls.Add(this.txtIdCompra);
            this.groupBox1.Location = new System.Drawing.Point(49, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(308, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresa el ID de la orden de compra";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackgroundImage = global::Procesadora.Properties.Resources.Lupa;
            this.cmdBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBuscar.Location = new System.Drawing.Point(260, 23);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(31, 30);
            this.cmdBuscar.TabIndex = 3;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Location = new System.Drawing.Point(7, 26);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(222, 26);
            this.txtIdCompra.TabIndex = 0;
            this.txtIdCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCompra_KeyPress);
            // 
            // cmdVerificar
            // 
            this.cmdVerificar.Location = new System.Drawing.Point(56, 71);
            this.cmdVerificar.Name = "cmdVerificar";
            this.cmdVerificar.Size = new System.Drawing.Size(100, 40);
            this.cmdVerificar.TabIndex = 1;
            this.cmdVerificar.Text = "Verificar";
            this.cmdVerificar.UseVisualStyleBackColor = true;
            this.cmdVerificar.Click += new System.EventHandler(this.cmdVerificar_Click);
            // 
            // validador
            // 
            this.validador.ContainerControl = this;
            // 
            // cmdRegresar
            // 
            this.cmdRegresar.Location = new System.Drawing.Point(178, 71);
            this.cmdRegresar.Name = "cmdRegresar";
            this.cmdRegresar.Size = new System.Drawing.Size(100, 40);
            this.cmdRegresar.TabIndex = 2;
            this.cmdRegresar.Text = "Regresar";
            this.cmdRegresar.UseVisualStyleBackColor = true;
            this.cmdRegresar.Click += new System.EventHandler(this.cmdRegresar_Click);
            // 
            // frmVerificarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 195);
            this.Controls.Add(this.cmdRegresar);
            this.Controls.Add(this.cmdVerificar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVerificarOrdenCompra";
            this.Text = "Verificar Orden";
            this.Load += new System.EventHandler(this.frmBuscarOrden_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.validador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.Button cmdVerificar;
        private System.Windows.Forms.ErrorProvider validador;
        private System.Windows.Forms.Button cmdRegresar;
        private System.Windows.Forms.Button cmdBuscar;
    }
}