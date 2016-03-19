using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButton
{
    
    public partial class Form1 : Form
    {
        private string categoria, dinero;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            categoria = "categoria B";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dinero = "100";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            dinero = "$200";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("es de  "+ categoria +"  gana  "+ dinero);
            label1.Text = "es de  " + categoria + "  gana  " + dinero;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            categoria = "categoria A";
        }
    }
}
