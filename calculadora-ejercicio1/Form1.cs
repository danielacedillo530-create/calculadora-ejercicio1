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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIng_Click(object sender, EventArgs e)
        {
            if (TextUsr.Text == "Dostin" && TextClave.Text == "25")
            {
                this.Hide();
             
            }
            else
            {
                MessageBox.Show("sus datos son Invalidos porfavor intente de nuevo");

            }

        }

        private void TextUsr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
