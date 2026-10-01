namespace calculadora_ejercicio1
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
            this.BtnIng = new System.Windows.Forms.Button();
            this.TextUsr = new System.Windows.Forms.TextBox();
            this.TextClave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnIng
            // 
            this.BtnIng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnIng.Location = new System.Drawing.Point(325, 101);
            this.BtnIng.Name = "BtnIng";
            this.BtnIng.Size = new System.Drawing.Size(75, 23);
            this.BtnIng.TabIndex = 0;
            this.BtnIng.Text = "Ingresar";
            this.BtnIng.UseVisualStyleBackColor = false;
            this.BtnIng.Click += new System.EventHandler(this.BtnIng_Click);
            // 
            // TextUsr
            // 
            this.TextUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.TextUsr.Location = new System.Drawing.Point(205, 156);
            this.TextUsr.Name = "TextUsr";
            this.TextUsr.Size = new System.Drawing.Size(100, 22);
            this.TextUsr.TabIndex = 1;
            this.TextUsr.TextChanged += new System.EventHandler(this.TextUsr_TextChanged);
            // 
            // TextClave
            // 
            this.TextClave.BackColor = System.Drawing.Color.Blue;
            this.TextClave.Location = new System.Drawing.Point(419, 156);
            this.TextClave.Name = "TextClave";
            this.TextClave.Size = new System.Drawing.Size(100, 22);
            this.TextClave.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextClave);
            this.Controls.Add(this.TextUsr);
            this.Controls.Add(this.BtnIng);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnIng;
        private System.Windows.Forms.TextBox TextUsr;
        private System.Windows.Forms.TextBox TextClave;
    }
}

