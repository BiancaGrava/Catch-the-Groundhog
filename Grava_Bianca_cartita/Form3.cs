using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grava_Bianca_cartita
{
    public partial class Form3 : Form
    {
        public Form3()
        { 
            InitializeComponent();
            double a,b,c,r;
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Enabled = false;
            a = scor.pr;
            b = scor.ne;
                c = a + b;
                r = (a / c)*100;
                textBox1.Text = Convert.ToString(r) + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
