using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Oto_galeri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(guna2Button2.Visible==false)
            {
                guna2Button2.Visible = true;
            }
            else
            {
                guna2Button2.Visible = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Form5 f5 = new Form5();
            f5.Show();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
        }
    }
}
