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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_sname.Text != "" && txt_tel.Text != "" && txt_email.Text != "")
            {
                btn_gonder.Enabled = true;
            }
            else if (txt_name.Text == "" || txt_sname.Text == "" || txt_tel.Text == "" || txt_email.Text == "")
            {
                btn_gonder.Enabled = false;
            }
        }

        private void txt_sname_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_sname.Text != "" && txt_tel.Text != "" && txt_email.Text != "")
            {
                btn_gonder.Enabled = true;
            }
            else if (txt_name.Text == "" || txt_sname.Text == "" || txt_tel.Text == "" || txt_email.Text == "")
            {
                btn_gonder.Enabled = false;
            }
        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_sname.Text != "" && txt_tel.Text != "" && txt_email.Text != "")
            {
                btn_gonder.Enabled = true;
            }
            else if (txt_name.Text == "" || txt_sname.Text == "" || txt_tel.Text == "" || txt_email.Text == "")
            {
                btn_gonder.Enabled = false;
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text != "" && txt_sname.Text != "" && txt_tel.Text != "" && txt_email.Text != "")
            {
                btn_gonder.Enabled = true;
            }
            else if (txt_name.Text == "" || txt_sname.Text == "" || txt_tel.Text == "" || txt_email.Text == "")
            {
                btn_gonder.Enabled = false;
            }
        }

        private void checkbox1_Click(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void guna2Panel2_MouseEnter(object sender, EventArgs e)
        {
            if (btn1.Visible == false)
            {
                btn1.Visible = true;
            }
        }

        private void guna2Panel2_MouseLeave(object sender, EventArgs e)
        {
            btn1.Visible = false;
        }

        private void guna2PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            btn1.Visible = true;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            btn1.Visible = true;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            btn1.Visible = true;
        }

        private void guna2PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btn1.Visible = false;
        }

        private void guna2Panel4_MouseEnter(object sender, EventArgs e)
        {
            btn2.Visible = true;
        }

        private void guna2Panel4_MouseLeave(object sender, EventArgs e)
        {
            btn2.Visible = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            btn2.Visible = true;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            btn2.Visible = true;
        }

        private void guna2PictureBox4_MouseEnter(object sender, EventArgs e)
        {
            btn2.Visible = true;
        }

        private void guna2PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            btn2.Visible = false;
        }

        private void guna2Panel7_MouseEnter(object sender, EventArgs e)
        {
            btn3.Visible = true;
        }

        private void guna2Panel7_MouseLeave(object sender, EventArgs e)
        {
            btn3.Visible = false;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            btn3.Visible = true;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            btn3.Visible = true;
        }

        private void guna2PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            btn4.Visible = true;
        }

        private void guna2PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            btn4.Visible = false;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            btn4.Visible = true;
        }

        private void guna2Panel3_MouseEnter(object sender, EventArgs e)
        {
            btn4.Visible = true;
        }

        private void guna2Panel3_MouseLeave(object sender, EventArgs e)
        {
            btn4.Visible = false;
        }

        private void guna2Panel6_MouseEnter(object sender, EventArgs e)
        {
            btn5.Visible = true;
        }

        private void guna2Panel6_MouseLeave(object sender, EventArgs e)
        {
            btn5.Visible = false;
        }

        private void guna2PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            btn5.Visible = true;
        }

        private void guna2PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            btn5.Visible = false;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            btn5.Visible = true;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            btn5.Visible = true;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            btn4.Visible = true;
        }

        private void guna2PictureBox7_MouseEnter(object sender, EventArgs e)
        {
            btn6.Visible = true;
        }

        private void guna2PictureBox7_MouseLeave(object sender, EventArgs e)
        {
            btn6.Visible = false;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            btn6.Visible = true;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            btn6.Visible = true;
        }

        private void guna2Panel5_MouseEnter(object sender, EventArgs e)
        {
            btn6.Visible = true;
        }

        private void guna2Panel5_MouseLeave(object sender, EventArgs e)
        {
            btn6.Visible = false;
        }

        private void guna2PictureBox6_MouseEnter(object sender, EventArgs e)
        {
            btn3.Visible = true;
        }

        private void guna2PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            btn3.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            kayit2.Visible = true;
            kayit.Visible = false;
            txt_email.Clear();
            txt_name.Clear();
            txt_sname.Clear();
            txt_tel.Clear();
            guna2Panel1.Enabled = true;
            guna2Panel2.Enabled = true;
            guna2Panel3.Enabled = true;
            guna2Panel4.Enabled = true;
            guna2Panel5.Enabled = true;
            guna2Panel6.Enabled = true;
            guna2Panel7.Enabled = true;
            guna2Button1.Enabled = true;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            kayit.Visible = true;
            lbl_model.Text = label6.Text;
            lbl_fiyat.Text = label8.Text;
            guna2Panel1.Enabled = false;
            guna2Panel2.Enabled = false;
            guna2Panel3.Enabled = false;
            guna2Panel4.Enabled = false;
            guna2Panel5.Enabled = false;
            guna2Panel6.Enabled = false;
            guna2Panel7.Enabled = false;
            guna2Button1.Enabled = false;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            kayit.Visible = true;
            lbl_model.Text = label1.Text;
            lbl_fiyat.Text = label11.Text;
            guna2Panel1.Enabled = false;
            guna2Panel2.Enabled = false;
            guna2Panel3.Enabled = false;
            guna2Panel4.Enabled = false;
            guna2Panel5.Enabled = false;
            guna2Panel6.Enabled = false;
            guna2Panel7.Enabled = false;
            guna2Button1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            kayit.Visible = true;
            lbl_model.Text = label3.Text;
            lbl_fiyat.Text = label10.Text;
            guna2Panel1.Enabled = false;
            guna2Panel2.Enabled = false;
            guna2Panel3.Enabled = false;
            guna2Panel4.Enabled = false;
            guna2Panel5.Enabled = false;
            guna2Panel6.Enabled = false;
            guna2Panel7.Enabled = false;
            guna2Button1.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            kayit.Visible = true;
            lbl_model.Text = label5.Text;
            lbl_fiyat.Text = label9.Text;
            guna2Panel1.Enabled = false;
            guna2Panel2.Enabled = false;
            guna2Panel3.Enabled = false;
            guna2Panel4.Enabled = false;
            guna2Panel5.Enabled = false;
            guna2Panel6.Enabled = false;
            guna2Panel7.Enabled = false;
            guna2Button1.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            kayit.Visible = true;
            lbl_model.Text = label2.Text;
            lbl_fiyat.Text = label7.Text;
            guna2Panel1.Enabled = false;
            guna2Panel2.Enabled = false;
            guna2Panel3.Enabled = false;
            guna2Panel4.Enabled = false;
            guna2Panel5.Enabled = false;
            guna2Panel6.Enabled = false;
            guna2Panel7.Enabled = false;
            guna2Button1.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            kayit.Visible = true;
            lbl_model.Text = label4.Text;
            lbl_fiyat.Text = label12.Text;
            guna2Panel1.Enabled = false;
            guna2Panel2.Enabled = false;
            guna2Panel3.Enabled = false;
            guna2Panel4.Enabled = false;
            guna2Panel5.Enabled = false;
            guna2Panel6.Enabled = false;
            guna2Panel7.Enabled = false;
            guna2Button1.Enabled = false;
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            if (checkbox1.Checked == false)
            {
                label17.Visible = true;
            }

            else
            {
                Form2 f2 = new Form2();
                kayit2.Visible = false;
                kayit3.Visible = true;

                string name = txt_name.Text;
                string sname = txt_sname.Text;
                string tel = txt_tel.Text;
                string email = txt_email.Text;
                string marka = lbl_marka.Text;
                string model = lbl_model.Text;
                string fiyat = lbl_fiyat.Text;

                try
                {

                    OleDbConnection con = new OleDbConnection();
                    con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Dbusers.accdb");
                    OleDbCommand cmd = new OleDbCommand("Insert into kayitlar (ad,soyad,tel_numara,email,marka,model,fiyat) Values (@ad,@soyad,@tel,@email,@marka,@model,fiyat)", con);
                    cmd.Parameters.Add(new OleDbParameter("@ad", name));
                    cmd.Parameters.Add(new OleDbParameter("@soyad", sname));
                    cmd.Parameters.Add(new OleDbParameter("@tel", tel));
                    cmd.Parameters.Add(new OleDbParameter("@email", email));
                    cmd.Parameters.Add(new OleDbParameter("@marka", marka));
                    cmd.Parameters.Add(new OleDbParameter("@model", model));
                    cmd.Parameters.Add(new OleDbParameter("@fiyat", fiyat));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
