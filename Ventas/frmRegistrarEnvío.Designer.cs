namespace Procesadora
{
    partial class frmRegistrarEnvío
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
            this.txtnumero_seguimiento = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtempresaPaqueteria = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtp_fechaenvio = new System.Windows.Forms.DateTimePicker();
            this.cmd_Registrar = new System.Windows.Forms.Button();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_id_venta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtID_Empleado = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtcostoEnvio = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnumero_seguimiento);
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 58);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Número de seguimiento";
            // 
            // txtnumero_seguimiento
            // 
            this.txtnumero_seguimiento.Location = new System.Drawing.Point(17, 26);
            this.txtnumero_seguimiento.Name = "txtnumero_seguimiento";
            this.txtnumero_seguimiento.Size = new System.Drawing.Size(153, 26);
            this.txtnumero_seguimiento.TabIndex = 1;
            this.txtnumero_seguimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_IDEncargado_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtempresaPaqueteria);
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 58);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Empresa Paqueteria";
            // 
            // txtempresaPaqueteria
            // 
            this.txtempresaPaqueteria.Location = new System.Drawing.Point(17, 26);
            this.txtempresaPaqueteria.Name = "txtempresaPaqueteria";
            this.txtempresaPaqueteria.Size = new System.Drawing.Size(153, 26);
            this.txtempresaPaqueteria.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtp_fechaenvio);
            this.groupBox5.Location = new System.Drawing.Point(12, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 58);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fecha de envío";
            // 
            // dtp_fechaenvio
            // 
            this.dtp_fechaenvio.CustomFormat = "yyyy-MM-dd";
            this.dtp_fechaenvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechaenvio.Location = new System.Drawing.Point(17, 26);
            this.dtp_fechaenvio.Name = "dtp_fechaenvio";
            this.dtp_fechaenvio.Size = new System.Drawing.Size(153, 26);
            this.dtp_fechaenvio.TabIndex = 8;
            this.dtp_fechaenvio.Value = new System.DateTime(2017, 11, 12, 0, 0, 0, 0);
            // 
            // cmd_Registrar
            // 
            this.cmd_Registrar.Location = new System.Drawing.Point(231, 332);
            this.cmd_Registrar.Name = "cmd_Registrar";
            this.cmd_Registrar.Size = new System.Drawing.Size(213, 58);
            this.cmd_Registrar.TabIndex = 10;
            this.cmd_Registrar.Text = "Registrar";
            this.cmd_Registrar.UseVisualStyleBackColor = true;
            this.cmd_Registrar.Click += new System.EventHandler(this.cmd_Registrar_Click);
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // txt_id_venta
            // 
            this.txt_id_venta.Enabled = false;
            this.txt_id_venta.Location = new System.Drawing.Point(17, 26);
            this.txt_id_venta.Name = "txt_id_venta";
            this.txt_id_venta.Size = new System.Drawing.Size(153, 26);
            this.txt_id_venta.TabIndex = 1;
            this.txt_id_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_txt_id_orden_produccion_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdBuscar);
            this.groupBox1.Controls.Add(this.txt_id_venta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID de la venta";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtID_Empleado);
            this.groupBox4.Location = new System.Drawing.Point(12, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 58);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ID del empleado";
            // 
            // txtID_Empleado
            // 
            this.txtID_Empleado.Enabled = false;
            this.txtID_Empleado.Location = new System.Drawing.Point(17, 26);
            this.txtID_Empleado.Name = "txtID_Empleado";
            this.txtID_Empleado.Size = new System.Drawing.Size(153, 26);
            this.txtID_Empleado.TabIndex = 1;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtcostoEnvio);
            this.groupBox7.Location = new System.Drawing.Point(12, 332);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(213, 58);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Precio del envío";
            // 
            // txtcostoEnvio
            // 
            this.txtcostoEnvio.Location = new System.Drawing.Point(17, 26);
            this.txtcostoEnvio.Name = "txtcostoEnvio";
            this.txtcostoEnvio.Size = new System.Drawing.Size(153, 26);
            this.txtcostoEnvio.TabIndex = 1;
            this.txtcostoEnvio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidadprod_KeyPress);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.txt_id_cliente);
            this.groupBox8.Location = new System.Drawing.Point(231, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(213, 58);
            this.groupBox8.TabIndex = 3;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "ID del cliente";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Procesadora.Properties.Resources.Lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(176, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Enabled = false;
            this.txt_id_cliente.Location = new System.Drawing.Point(17, 26);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(153, 26);
            this.txt_id_cliente.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtcalle);
            this.groupBox9.Location = new System.Drawing.Point(231, 76);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(213, 58);
            this.groupBox9.TabIndex = 5;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Calle";
            // 
            // txtcalle
            // 
            this.txtcalle.Location = new System.Drawing.Point(17, 26);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(153, 26);
            this.txtcalle.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.txtNumero);
            this.groupBox10.Location = new System.Drawing.Point(231, 140);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(213, 58);
            this.groupBox10.TabIndex = 6;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(17, 26);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(153, 26);
            this.txtNumero.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtcp);
            this.groupBox11.Location = new System.Drawing.Point(231, 268);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(213, 58);
            this.groupBox11.TabIndex = 8;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Código postal";
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(17, 26);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(153, 26);
            this.txtcp.TabIndex = 1;
            this.txtcp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcp_KeyPress);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtColonia);
            this.groupBox12.Location = new System.Drawing.Point(231, 204);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(213, 58);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Colonia";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(17, 26);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(153, 26);
            this.txtColonia.TabIndex = 1;
            // 
            // frmRegistrarEnvío
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 423);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cmd_Registrar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegistrarEnvío";
            this.Text = "Registrar envío.";
            this.Load += new System.EventHandler(this.frmRegistrarProduccionDeLote_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnumero_seguimiento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtempresaPaqueteria;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtp_fechaenvio;
        private System.Windows.Forms.Button cmd_Registrar;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txt_id_venta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtID_Empleado;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtcostoEnvio;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtcalle;
    }
}