namespace appPractica1
{
    partial class frmLiquidacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantHtrab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVrHora = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.lblSalNeto = new System.Windows.Forms.Label();
            this.lblAuxTte = new System.Windows.Forms.Label();
            this.lblVrRete = new System.Windows.Forms.Label();
            this.lblVrHExt = new System.Windows.Forms.Label();
            this.lblCantHExt = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(214, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCantHtrab
            // 
            this.txtCantHtrab.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantHtrab.Location = new System.Drawing.Point(214, 112);
            this.txtCantHtrab.Name = "txtCantHtrab";
            this.txtCantHtrab.Size = new System.Drawing.Size(150, 23);
            this.txtCantHtrab.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mis Cacharros S.A.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 82);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cant. Hora Trab. :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vr. Hora:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVrHora
            // 
            this.txtVrHora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVrHora.Location = new System.Drawing.Point(214, 141);
            this.txtVrHora.Name = "txtVrHora";
            this.txtVrHora.Size = new System.Drawing.Size(150, 23);
            this.txtVrHora.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(58, 203);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 50);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidar.Location = new System.Drawing.Point(214, 203);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(150, 50);
            this.btnLiquidar.TabIndex = 8;
            this.btnLiquidar.Text = "Liquidar";
            this.btnLiquidar.UseVisualStyleBackColor = true;
            this.btnLiquidar.Click += new System.EventHandler(this.btnLiquidar_Click);
            // 
            // grbApagar
            // 
            this.grbApagar.BackColor = System.Drawing.Color.LightGray;
            this.grbApagar.Controls.Add(this.lblSalNeto);
            this.grbApagar.Controls.Add(this.lblAuxTte);
            this.grbApagar.Controls.Add(this.lblVrRete);
            this.grbApagar.Controls.Add(this.lblVrHExt);
            this.grbApagar.Controls.Add(this.lblCantHExt);
            this.grbApagar.Controls.Add(this.lblSalBruto);
            this.grbApagar.Controls.Add(this.label5);
            this.grbApagar.Controls.Add(this.label10);
            this.grbApagar.Controls.Add(this.label9);
            this.grbApagar.Controls.Add(this.label8);
            this.grbApagar.Controls.Add(this.label7);
            this.grbApagar.Controls.Add(this.label6);
            this.grbApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbApagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApagar.Location = new System.Drawing.Point(58, 278);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(306, 203);
            this.grbApagar.TabIndex = 9;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "A Pagar";
            this.grbApagar.Visible = false;
            // 
            // lblSalNeto
            // 
            this.lblSalNeto.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSalNeto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalNeto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalNeto.Location = new System.Drawing.Point(150, 170);
            this.lblSalNeto.Name = "lblSalNeto";
            this.lblSalNeto.Size = new System.Drawing.Size(150, 21);
            this.lblSalNeto.TabIndex = 27;
            this.lblSalNeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuxTte
            // 
            this.lblAuxTte.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAuxTte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAuxTte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuxTte.Location = new System.Drawing.Point(150, 142);
            this.lblAuxTte.Name = "lblAuxTte";
            this.lblAuxTte.Size = new System.Drawing.Size(150, 21);
            this.lblAuxTte.TabIndex = 26;
            this.lblAuxTte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVrRete
            // 
            this.lblVrRete.BackColor = System.Drawing.Color.Gainsboro;
            this.lblVrRete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVrRete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrRete.Location = new System.Drawing.Point(150, 113);
            this.lblVrRete.Name = "lblVrRete";
            this.lblVrRete.Size = new System.Drawing.Size(150, 21);
            this.lblVrRete.TabIndex = 25;
            this.lblVrRete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVrHExt
            // 
            this.lblVrHExt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblVrHExt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVrHExt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrHExt.Location = new System.Drawing.Point(150, 84);
            this.lblVrHExt.Name = "lblVrHExt";
            this.lblVrHExt.Size = new System.Drawing.Size(150, 21);
            this.lblVrHExt.TabIndex = 24;
            this.lblVrHExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantHExt
            // 
            this.lblCantHExt.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCantHExt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantHExt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantHExt.Location = new System.Drawing.Point(150, 55);
            this.lblCantHExt.Name = "lblCantHExt";
            this.lblCantHExt.Size = new System.Drawing.Size(150, 21);
            this.lblCantHExt.TabIndex = 23;
            this.lblCantHExt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.BackColor = System.Drawing.Color.Gainsboro;
            this.lblSalBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalBruto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBruto.Location = new System.Drawing.Point(150, 26);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(150, 21);
            this.lblSalBruto.TabIndex = 22;
            this.lblSalBruto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Salario Bruto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Salario Neto:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Vr. Aux. Tte.:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vr. Retención:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vr. H. Extra:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cant. H. Extra:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(208, 487);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(150, 50);
            this.btnTerminar.TabIndex = 10;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // frmLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(422, 541);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtVrHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantHtrab);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmLiquidacion";
            this.Text = "Practica #1";
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantHtrab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVrHora;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnLiquidar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSalNeto;
        private System.Windows.Forms.Label lblAuxTte;
        private System.Windows.Forms.Label lblVrRete;
        private System.Windows.Forms.Label lblVrHExt;
        private System.Windows.Forms.Label lblCantHExt;
        private System.Windows.Forms.Label lblSalBruto;
    }
}

