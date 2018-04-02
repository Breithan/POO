namespace appPractica2
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDiaPed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEsQuinc = new System.Windows.Forms.CheckBox();
            this.chkEsFest = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbApedir = new System.Windows.Forms.GroupBox();
            this.txtVrTot = new System.Windows.Forms.TextBox();
            this.txtCanTot = new System.Windows.Forms.TextBox();
            this.txtCantAdic = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantNorm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.grbApedir.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(152, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cafetería Mi U";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Día";
            // 
            // cmbDiaPed
            // 
            this.cmbDiaPed.FormattingEnabled = true;
            this.cmbDiaPed.Items.AddRange(new object[] {
            "Seleccione un Día",
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.cmbDiaPed.Location = new System.Drawing.Point(228, 112);
            this.cmbDiaPed.Name = "cmbDiaPed";
            this.cmbDiaPed.Size = new System.Drawing.Size(189, 21);
            this.cmbDiaPed.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "¿Es Quincena?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "¿Es Festivo?";
            // 
            // chkEsQuinc
            // 
            this.chkEsQuinc.Location = new System.Drawing.Point(265, 158);
            this.chkEsQuinc.Name = "chkEsQuinc";
            this.chkEsQuinc.Size = new System.Drawing.Size(106, 24);
            this.chkEsQuinc.TabIndex = 5;
            this.chkEsQuinc.UseVisualStyleBackColor = true;
            // 
            // chkEsFest
            // 
            this.chkEsFest.Location = new System.Drawing.Point(265, 195);
            this.chkEsFest.Name = "chkEsFest";
            this.chkEsFest.Size = new System.Drawing.Size(106, 24);
            this.chkEsFest.TabIndex = 6;
            this.chkEsFest.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(69, 242);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 34);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "REALIZAR PEDIDO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbApedir
            // 
            this.grbApedir.BackColor = System.Drawing.Color.Gainsboro;
            this.grbApedir.Controls.Add(this.txtVrTot);
            this.grbApedir.Controls.Add(this.txtCanTot);
            this.grbApedir.Controls.Add(this.txtCantAdic);
            this.grbApedir.Controls.Add(this.label8);
            this.grbApedir.Controls.Add(this.label7);
            this.grbApedir.Controls.Add(this.label6);
            this.grbApedir.Controls.Add(this.txtCantNorm);
            this.grbApedir.Controls.Add(this.label5);
            this.grbApedir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbApedir.Location = new System.Drawing.Point(69, 294);
            this.grbApedir.Name = "grbApedir";
            this.grbApedir.Size = new System.Drawing.Size(348, 210);
            this.grbApedir.TabIndex = 9;
            this.grbApedir.TabStop = false;
            this.grbApedir.Text = "A Pedir";
            // 
            // txtVrTot
            // 
            this.txtVrTot.Location = new System.Drawing.Point(179, 161);
            this.txtVrTot.Name = "txtVrTot";
            this.txtVrTot.ReadOnly = true;
            this.txtVrTot.Size = new System.Drawing.Size(131, 27);
            this.txtVrTot.TabIndex = 17;
            // 
            // txtCanTot
            // 
            this.txtCanTot.Location = new System.Drawing.Point(179, 119);
            this.txtCanTot.Name = "txtCanTot";
            this.txtCanTot.ReadOnly = true;
            this.txtCanTot.Size = new System.Drawing.Size(131, 27);
            this.txtCanTot.TabIndex = 16;
            // 
            // txtCantAdic
            // 
            this.txtCantAdic.Location = new System.Drawing.Point(179, 78);
            this.txtCantAdic.Name = "txtCantAdic";
            this.txtCantAdic.ReadOnly = true;
            this.txtCantAdic.Size = new System.Drawing.Size(131, 27);
            this.txtCantAdic.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vr. A Pagar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cant. Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cant. Adic.:";
            // 
            // txtCantNorm
            // 
            this.txtCantNorm.Location = new System.Drawing.Point(179, 39);
            this.txtCantNorm.Name = "txtCantNorm";
            this.txtCantNorm.ReadOnly = true;
            this.txtCantNorm.Size = new System.Drawing.Size(131, 27);
            this.txtCantNorm.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cant. Normal:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(69, 522);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(348, 83);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(307, 621);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(110, 34);
            this.btnTerminar.TabIndex = 17;
            this.btnTerminar.Text = "TERMINAR";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 663);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grbApedir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.chkEsFest);
            this.Controls.Add(this.chkEsQuinc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDiaPed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedido";
            this.Text = "Práctica #2 - Reglas de Negocio";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.grbApedir.ResumeLayout(false);
            this.grbApedir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDiaPed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkEsQuinc;
        private System.Windows.Forms.CheckBox chkEsFest;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbApedir;
        private System.Windows.Forms.TextBox txtVrTot;
        private System.Windows.Forms.TextBox txtCanTot;
        private System.Windows.Forms.TextBox txtCantAdic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantNorm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTerminar;
    }
}

