namespace appTaller1Ejercicio1
{
    partial class Form1
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
            this.txbTemperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbTempC = new System.Windows.Forms.RadioButton();
            this.rdbTempF = new System.Windows.Forms.RadioButton();
            this.rdbTempK = new System.Windows.Forms.RadioButton();
            this.rdbTempR = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblTempC = new System.Windows.Forms.Label();
            this.lblTempF = new System.Windows.Forms.Label();
            this.lblTempK = new System.Windows.Forms.Label();
            this.lblTempR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTemperatura.Location = new System.Drawing.Point(116, 61);
            this.txbTemperatura.Margin = new System.Windows.Forms.Padding(2);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.Size = new System.Drawing.Size(170, 27);
            this.txbTemperatura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convertidor de Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperatura:";
            // 
            // rdbTempC
            // 
            this.rdbTempC.AutoSize = true;
            this.rdbTempC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTempC.Location = new System.Drawing.Point(116, 93);
            this.rdbTempC.Name = "rdbTempC";
            this.rdbTempC.Size = new System.Drawing.Size(42, 21);
            this.rdbTempC.TabIndex = 4;
            this.rdbTempC.Text = "Cº";
            this.rdbTempC.UseVisualStyleBackColor = true;
            // 
            // rdbTempF
            // 
            this.rdbTempF.AutoSize = true;
            this.rdbTempF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTempF.Location = new System.Drawing.Point(164, 93);
            this.rdbTempF.Name = "rdbTempF";
            this.rdbTempF.Size = new System.Drawing.Size(37, 21);
            this.rdbTempF.TabIndex = 5;
            this.rdbTempF.Text = "Fº";
            this.rdbTempF.UseVisualStyleBackColor = true;
            // 
            // rdbTempK
            // 
            this.rdbTempK.AutoSize = true;
            this.rdbTempK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTempK.Location = new System.Drawing.Point(207, 93);
            this.rdbTempK.Name = "rdbTempK";
            this.rdbTempK.Size = new System.Drawing.Size(39, 21);
            this.rdbTempK.TabIndex = 6;
            this.rdbTempK.Text = "Kº";
            this.rdbTempK.UseVisualStyleBackColor = true;
            // 
            // rdbTempR
            // 
            this.rdbTempR.AutoSize = true;
            this.rdbTempR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTempR.Location = new System.Drawing.Point(252, 93);
            this.rdbTempR.Name = "rdbTempR";
            this.rdbTempR.Size = new System.Drawing.Size(39, 21);
            this.rdbTempR.TabIndex = 7;
            this.rdbTempR.Text = "Rº";
            this.rdbTempR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dada en:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(15, 119);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(271, 56);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "Convertir temperatura";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblTempC
            // 
            this.lblTempC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTempC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempC.Location = new System.Drawing.Point(15, 177);
            this.lblTempC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempC.Name = "lblTempC";
            this.lblTempC.Size = new System.Drawing.Size(271, 27);
            this.lblTempC.TabIndex = 12;
            // 
            // lblTempF
            // 
            this.lblTempF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTempF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempF.Location = new System.Drawing.Point(15, 204);
            this.lblTempF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempF.Name = "lblTempF";
            this.lblTempF.Size = new System.Drawing.Size(271, 27);
            this.lblTempF.TabIndex = 13;
            // 
            // lblTempK
            // 
            this.lblTempK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTempK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempK.Location = new System.Drawing.Point(15, 231);
            this.lblTempK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempK.Name = "lblTempK";
            this.lblTempK.Size = new System.Drawing.Size(271, 27);
            this.lblTempK.TabIndex = 14;
            // 
            // lblTempR
            // 
            this.lblTempR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTempR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempR.Location = new System.Drawing.Point(15, 255);
            this.lblTempR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempR.Name = "lblTempR";
            this.lblTempR.Size = new System.Drawing.Size(271, 27);
            this.lblTempR.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 291);
            this.Controls.Add(this.lblTempR);
            this.Controls.Add(this.lblTempK);
            this.Controls.Add(this.lblTempF);
            this.Controls.Add(this.lblTempC);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbTempR);
            this.Controls.Add(this.rdbTempK);
            this.Controls.Add(this.rdbTempF);
            this.Controls.Add(this.rdbTempC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTemperatura);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbTempC;
        private System.Windows.Forms.RadioButton rdbTempF;
        private System.Windows.Forms.RadioButton rdbTempK;
        private System.Windows.Forms.RadioButton rdbTempR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblTempC;
        private System.Windows.Forms.Label lblTempF;
        private System.Windows.Forms.Label lblTempK;
        private System.Windows.Forms.Label lblTempR;
    }
}

