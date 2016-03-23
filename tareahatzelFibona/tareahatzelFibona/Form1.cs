using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tareahatzelFibona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad;
            cantidad = Convert.ToInt32(textBox1.Text);
            int i, a=1, b=1, c=0;
            listBox1.Items.Add(a);
            listBox1.Items.Add(b);
            for (i = 3; i <= cantidad; i ++)
            {
                c = a + b;
                listBox1.Items.Add(c);
                a = b;
                b = c;

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
