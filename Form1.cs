using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EJERCICIO20_PEDIDOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Salir?", "¿Desea Salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox7.Text);
            if (numero < 5)
            {
                textBox7.Text = Convert.ToString(numero + 1);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox8.Text);
            if (numero < 5)
            {
                textBox8.Text = Convert.ToString(numero + 1);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox9.Text);
            if (numero < 5)
            {
                textBox9.Text = Convert.ToString(numero + 1);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox10.Text);
            if (numero < 5)
            {
                textBox10.Text = Convert.ToString(numero + 1);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox11.Text);
            if (numero < 5)
            {
                textBox11.Text = Convert.ToString(numero + 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox12.Text);
            if (numero < 5)
            {
                textBox12.Text = Convert.ToString(numero + 1);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox13.Text);
            if (numero < 5)
            {
                textBox13.Text = Convert.ToString(numero + 1);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox14.Text);
            if (numero < 5)
            {
                textBox14.Text = Convert.ToString(numero + 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox7.Text);
            if (numero > 0)
            {
                textBox7.Text = Convert.ToString(numero - 1);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox8.Text);
            if (numero > 0)
            {
                textBox8.Text = Convert.ToString(numero - 1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox9.Text);
            if (numero > 0)
            {
                textBox9.Text = Convert.ToString(numero - 1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox10.Text);
            if (numero > 0)
            {
                textBox10.Text = Convert.ToString(numero - 1);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox11.Text);
            if (numero > 0)
            {
                textBox11.Text = Convert.ToString(numero - 1);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox12.Text);
            if (numero > 0)
            {
                textBox12.Text = Convert.ToString(numero - 1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox13.Text);
            if (numero > 0)
            {
                textBox13.Text = Convert.ToString(numero - 1);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int numero = Int32.Parse(textBox14.Text);
            if (numero > 0)
            {
                textBox14.Text = Convert.ToString(numero - 1);
            }
        }
    }
}