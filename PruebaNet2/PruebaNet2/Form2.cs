using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaNet2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int a, b, c, d, f;
        int count;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sumar el total seleccionado.
            
            if (checkBox1.Checked)
            {
                a = 22000;
            }
            else if (checkBox2.Checked)
            {
                b = 12000;
            }
            else if (checkBox3.Checked)
            {
                c = 8000;
            }
            else if (checkBox4.Checked)
            {
                d = 1500;
            }
            else if (checkBox5.Checked)
            {
                f= 5000;
            }
            
            count = a + b + c + d + f;
            textBox1.ReadOnly = true;
            textBox1.Text = count.ToString();
            textBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Total Pedido: "+ count.ToString());
            MessageBox.Show("Gracias por comprar en Pizza Hat"); 
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
