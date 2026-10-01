using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_ejercicio1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBB1.Text);
            int Num2 = int.Parse(textBB2.Text);
            int suma = Num1 + Num2;
            MessageBox.Show("El Resultado de la Suma es " + suma);

        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(textBB1.Text);
            int Num2 = int.Parse(textBB2.Text);
            int Producto = Num1 * Num2; 
            MessageBox.Show("El resultado del Producto es" + Producto);

        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBB1.Text);
            int n2 = int.Parse(textBB2.Text);
            int n3 = 1;
            int potencia = 1;

            while (n3 != n2)
            {
                potencia = potencia * n1;
                n3 = n3 + 1;
            }
            MessageBox.Show("El Resultado de la potencia  es " + potencia);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(textBB1.Text);
            float Num2 = float.Parse(textBB2.Text);

            if (Num2 < 0) 
            {
                float division = Num1 / Num2; 
                MessageBox.Show("El resultado es " + division);

            }
            else 
            {
                MessageBox.Show("La Division es indefinida "); 
            }//

        }

        private void BtnFactorial_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBB1.Text);
            int j = 1;
            
            for (int i = 0; i == num1; i++)
            {
                j = j * i;
                {
                    MessageBox.Show("el resultado es " + j);
                }
            }
        }

    }
}
