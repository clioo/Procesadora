﻿namespace Procesadora
{
    partial class frmBuscarInsumo
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
            this.dgvInsumo = new System.Windows.Forms.DataGridView();
            this.cmdRegresar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBuscarPor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmdAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInsumo
            // 
            this.dgvInsumo.AllowUserToAddRows = false;
            this.dgvInsumo.AllowUserToDeleteRows = false;
            this.dgvInsumo.AllowUserToOrderColumns = true;
            this.dgvInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsumo.Location = new System.Drawing.Point(12, 66);
            this.dgvInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInsumo.Name = "dgvInsumo";
            this.dgvInsumo.ReadOnly = true;
            this.dgvInsumo.Size = new System.Drawing.Size(386, 332);
            this.dgvInsumo.TabIndex = 0;
            this.dgvInsumo.TabStop = false;
            // 
            // cmdRegresar
            // 
            this.cmdRegresar.Location = new System.Drawing.Point(298, 405);
            this.cmdRegresar.Name = "cmdRegresar";
            this.cmdRegresar.Size = new System.Drawing.Size(100, 30);
            this.cmdRegresar.TabIndex = 8;
            this.cmdRegresar.Text = "Regresar";
            this.cmdRegresar.UseVisualStyleBackColor = true;
            this.cmdRegresar.Click += new System.EventHandler(this.cmdRegresar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBuscarPor);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por";
            // 
            // cbBuscarPor
            // 
            this.cbBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuscarPor.FormattingEnabled = true;
            this.cbBuscarPor.Location = new System.Drawing.Point(6, 24);
            this.cbBuscarPor.Name = "cbBuscarPor";
            this.cbBuscarPor.Size = new System.Drawing.Size(165, 26);
            this.cbBuscarPor.TabIndex = 0;
            this.cbBuscarPor.SelectedIndexChanged += new System.EventHandler(this.cbBuscarPor_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Location = new System.Drawing.Point(210, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(134, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(7, 26);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 26);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(192, 405);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(100, 30);
            this.cmdAceptar.TabIndex = 6;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // frmBuscarInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 440);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdRegresar);
            this.Controls.Add(this.dgvInsumo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBuscarInsumo";
            this.Text = "Buscar insumo";
            this.Load += new System.EventHandler(this.frmBuscarInsumo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsumo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInsumo;
        private System.Windows.Forms.Button cmdRegresar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbBuscarPor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button cmdAceptar;
    }
}