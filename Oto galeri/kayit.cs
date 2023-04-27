using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oto_galeri
{
    public partial class kayit : UserControl
    {
        public kayit()
        {
            InitializeComponent();
        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_sname.Text != "" && txt_tel.Text != "" && txt_email.Text != "")
            {
                guna2GradientButton1.Enabled = true;
            }
            else if (txt_name.Text == "" || txt_sname.Text == "" || txt_tel.Text == "" || txt_email.Text == "")
            {
                guna2GradientButton1.Enabled = false;
            }
        }

        private void txt_sname_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_sname.Text != "" && txt_tel.Text != "" && txt_email.Text != "")
            {
                guna2GradientButton1.Enabled = true;
            }
            else if (txt_name.Text == "" || txt_sname.Text == "" || txt_tel.Text == "" || txt_email.Text == "")
            {
                guna2GradientButton1.Enabled = false;
            }
        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_sname.Text != "" && txt_tel.Text != "" && txt_email.Text != "")
            {
                guna2GradientButton1.Enabled = true;
            }
            else if (txt_name.Text == "" || txt_sname.Text == "" || txt_tel.Text == "" || txt_email.Text == "")
            {
                guna2GradientButton1.Enabled = false;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_sname.Text != "" && txt_tel.Text != "" && txt_email.Text != "")
            {
                guna2GradientButton1.Enabled = true;
            }
            else if (txt_name.Text == "" || txt_sname.Text == "" || txt_tel.Text == "" || txt_email.Text == "")
            {
                guna2GradientButton1.Enabled = false;
            }
        }

        private void checkbox1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
        }
    }
}
