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
    public partial class Form1 : Form
    {
        PictureBox[] pb;
        int nrc,nrv=-1,prinse=0,ratate=0;
        public Form1()
        {
            InitializeComponent();
            pb = new PictureBox[5];//am 4 pictureboxuri
            int i;
            pb[1] = pictureBox1;
            pb[2] = pictureBox2;
            pb[3] = pictureBox3;
            pb[4] = pictureBox4;
            for (i = 1; i <= 4; i++)
            {
                pb[i].Click += new System.EventHandler(clic_imagine);
            }
            pb[1].Enabled = false;
            pb[2].Enabled = false;
            pb[3].Enabled = false;
            pb[4].Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;
        }

        private void clic_imagine(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 4; i++)
                if (sender == pb[i])
                {
                    if (nrc == i)
                        prinse++;
                    else
                        ratate++;
                }

            label1.Text = "cartite vanate: " + prinse;
            label2.Text = "cartite ratate: " + ratate;
            scor.pr = prinse;
            scor.ne =  ratate;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button4.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;

            pb[1].Enabled = false;
            pb[2].Enabled = false;
            pb[3].Enabled = false;
            pb[4].Enabled = false;

            if (prinse == 0 && ratate == 0)
            {
                Form4 f = new Form4();
                f.Show();
            }
            else
            {
                Form3 f = new Form3();
                f.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
            prinse = 0;
            ratate = 0;
            label1.Text = "cartite vanate: " + prinse;
            label2.Text = "cartite ratate: " + ratate;
            pb[1].Image = Properties.Resources.anthill1;
            pb[2].Image = Properties.Resources.anthill1;
            pb[3].Image = Properties.Resources.anthill1;
            pb[4].Image = Properties.Resources.anthill1;
            pb[1].Enabled = true;
            pb[2].Enabled = true;
            pb[3].Enabled = true;
            pb[4].Enabled = true;
            button4.Enabled = false;
            button3.Enabled = true;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pb[1].Enabled = true;
            pb[2].Enabled = true;
            pb[3].Enabled = true;
            pb[4].Enabled = true;
            button3.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            nrc = r.Next(1, 5);//cartita vizibila
            switch(nrc)
            {
                case 1:
                    pb[1].Image = Properties.Resources.mole9;
                    break;
                case 2:
                    pb[2].Image = Properties.Resources.mole9;
                    break;
                case 3:
                    pb[3].Image = Properties.Resources.mole9;
                    break;
                case 4:
                    pb[4].Image = Properties.Resources.mole9;
                    break;

            }
            switch (nrv)
            {
                case 1:
                    pb[1].Image = Properties.Resources.anthill1;
                    break;
                case 2:
                    pb[2].Image = Properties.Resources.anthill1;
                    break;
                case 3:
                    pb[3].Image = Properties.Resources.anthill1;
                    break;
                case 4:
                    pb[4].Image = Properties.Resources.anthill1;
                    break;

            }
            nrv = nrc;

            if (prinse == 10)
            {
                Form2 f = new Form2();
                f.Show();
                timer1.Stop();
                pb[1].Enabled = false;
                pb[2].Enabled = false;
                pb[3].Enabled = false;
                pb[4].Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
            }
        }
    }
}
