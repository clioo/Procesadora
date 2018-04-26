namespace Procesadora
{
    partial class frmRegistrarOrdenProduccion
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
            this.txt_idproducto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_cantidadprod = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtp_prod = new System.Windows.Forms.DateTimePicker();
            this.cmd_Registrar = new System.Windows.Forms.Button();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBuscar);
            this.groupBox1.Controls.Add(this.txt_idproducto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID del producto";
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
            // txt_idproducto
            // 
            this.txt_idproducto.Location = new System.Drawing.Point(17, 26);
            this.txt_idproducto.Name = "txt_idproducto";
            this.txt_idproducto.Size = new System.Drawing.Size(153, 26);
            this.txt_idproducto.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_cantidadprod);
            this.groupBox3.Location = new System.Drawing.Point(12, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 58);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad a producir";
            // 
            // txt_cantidadprod
            // 
            this.txt_cantidadprod.Location = new System.Drawing.Point(17, 26);
            this.txt_cantidadprod.Name = "txt_cantidadprod";
            this.txt_cantidadprod.Size = new System.Drawing.Size(153, 26);
            this.txt_cantidadprod.TabIndex = 5;
            this.txt_cantidadprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidadprod_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtp_prod);
            this.groupBox5.Location = new System.Drawing.Point(12, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 58);
            this.groupBox5.TabIndex = 8;
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
            this.dtp_prod.Value = new System.DateTime(2017, 12, 1, 0, 0, 0, 0);
            // 
            // cmd_Registrar
            // 
            this.cmd_Registrar.Location = new System.Drawing.Point(12, 204);
            this.cmd_Registrar.Name = "cmd_Registrar";
            this.cmd_Registrar.Size = new System.Drawing.Size(213, 58);
            this.cmd_Registrar.TabIndex = 11;
            this.cmd_Registrar.Text = "Registrar";
            this.cmd_Registrar.UseVisualStyleBackColor = true;
            this.cmd_Registrar.Click += new System.EventHandler(this.cmd_Registrar_Click);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // frmRegistrarOrdenProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 279);
            this.Controls.Add(this.cmd_Registrar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarOrdenProduccion";
            this.Text = "Registrar orden de producción";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txt_idproducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_cantidadprod;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtp_prod;
        private System.Windows.Forms.Button cmd_Registrar;
        private System.Windows.Forms.ErrorProvider ep1;
    }
}