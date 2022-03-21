namespace Empresa_vehiculos
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
            this.textplaca = new System.Windows.Forms.TextBox();
            this.textmarca = new System.Windows.Forms.TextBox();
            this.textmodelo = new System.Windows.Forms.TextBox();
            this.textcolor = new System.Windows.Forms.TextBox();
            this.textpreciok = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonIngreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textplaca
            // 
            this.textplaca.Location = new System.Drawing.Point(134, 26);
            this.textplaca.Name = "textplaca";
            this.textplaca.Size = new System.Drawing.Size(100, 20);
            this.textplaca.TabIndex = 0;
            // 
            // textmarca
            // 
            this.textmarca.Location = new System.Drawing.Point(134, 53);
            this.textmarca.Name = "textmarca";
            this.textmarca.Size = new System.Drawing.Size(100, 20);
            this.textmarca.TabIndex = 1;
            // 
            // textmodelo
            // 
            this.textmodelo.Location = new System.Drawing.Point(134, 80);
            this.textmodelo.Name = "textmodelo";
            this.textmodelo.Size = new System.Drawing.Size(100, 20);
            this.textmodelo.TabIndex = 2;
            // 
            // textcolor
            // 
            this.textcolor.Location = new System.Drawing.Point(134, 107);
            this.textcolor.Name = "textcolor";
            this.textcolor.Size = new System.Drawing.Size(100, 20);
            this.textcolor.TabIndex = 3;
            // 
            // textpreciok
            // 
            this.textpreciok.Location = new System.Drawing.Point(134, 134);
            this.textpreciok.Name = "textpreciok";
            this.textpreciok.Size = new System.Drawing.Size(100, 20);
            this.textpreciok.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio x Kilometro";
            // 
            // ButtonIngreso
            // 
            this.ButtonIngreso.Location = new System.Drawing.Point(134, 169);
            this.ButtonIngreso.Name = "ButtonIngreso";
            this.ButtonIngreso.Size = new System.Drawing.Size(100, 25);
            this.ButtonIngreso.TabIndex = 10;
            this.ButtonIngreso.Text = "Ingresar";
            this.ButtonIngreso.UseVisualStyleBackColor = true;
            this.ButtonIngreso.Click += new System.EventHandler(this.ButtonIngreso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpreciok);
            this.Controls.Add(this.textcolor);
            this.Controls.Add(this.textmodelo);
            this.Controls.Add(this.textmarca);
            this.Controls.Add(this.textplaca);
            this.Name = "Form1";
            this.Text = "Form Vehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textplaca;
        private System.Windows.Forms.TextBox textmarca;
        private System.Windows.Forms.TextBox textmodelo;
        private System.Windows.Forms.TextBox textcolor;
        private System.Windows.Forms.TextBox textpreciok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonIngreso;
    }
}

