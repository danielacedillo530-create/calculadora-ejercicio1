namespace calculadora_ejercicio1
{
    partial class Form2
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
            this.textBB1 = new System.Windows.Forms.TextBox();
            this.textBB2 = new System.Windows.Forms.TextBox();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnPotencia = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.BtnFactorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBB1
            // 
            this.textBB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBB1.Location = new System.Drawing.Point(324, 90);
            this.textBB1.Name = "textBB1";
            this.textBB1.Size = new System.Drawing.Size(100, 22);
            this.textBB1.TabIndex = 0;
            // 
            // textBB2
            // 
            this.textBB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBB2.Location = new System.Drawing.Point(324, 275);
            this.textBB2.Name = "textBB2";
            this.textBB2.Size = new System.Drawing.Size(100, 22);
            this.textBB2.TabIndex = 1;
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.Yellow;
            this.BtnSuma.Location = new System.Drawing.Point(64, 126);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(75, 23);
            this.BtnSuma.TabIndex = 2;
            this.BtnSuma.Text = "S";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.Lime;
            this.BtnProducto.Location = new System.Drawing.Point(182, 160);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnProducto.TabIndex = 3;
            this.BtnProducto.Text = "M";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // BtnPotencia
            // 
            this.BtnPotencia.BackColor = System.Drawing.Color.Blue;
            this.BtnPotencia.Location = new System.Drawing.Point(324, 186);
            this.BtnPotencia.Name = "BtnPotencia";
            this.BtnPotencia.Size = new System.Drawing.Size(75, 23);
            this.BtnPotencia.TabIndex = 4;
            this.BtnPotencia.Text = "P";
            this.BtnPotencia.UseVisualStyleBackColor = false;
            this.BtnPotencia.Click += new System.EventHandler(this.BtnPotencia_Click);
            // 
            // BtnDivision
            // 
            this.BtnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnDivision.Location = new System.Drawing.Point(466, 160);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(75, 23);
            this.BtnDivision.TabIndex = 5;
            this.BtnDivision.Text = "D";
            this.BtnDivision.UseVisualStyleBackColor = false;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click);
            // 
            // BtnFactorial
            // 
            this.BtnFactorial.BackColor = System.Drawing.Color.Teal;
            this.BtnFactorial.Location = new System.Drawing.Point(558, 126);
            this.BtnFactorial.Name = "BtnFactorial";
            this.BtnFactorial.Size = new System.Drawing.Size(75, 23);
            this.BtnFactorial.TabIndex = 6;
            this.BtnFactorial.Text = "F";
            this.BtnFactorial.UseVisualStyleBackColor = false;
            this.BtnFactorial.Click += new System.EventHandler(this.BtnFactorial_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFactorial);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.BtnPotencia);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.textBB2);
            this.Controls.Add(this.textBB1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBB1;
        private System.Windows.Forms.TextBox textBB2;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnPotencia;
        private System.Windows.Forms.Button BtnDivision;
        private System.Windows.Forms.Button BtnFactorial;
    }
}