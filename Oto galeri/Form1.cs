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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbCommand cmd;
        OleDbConnection con;
        OleDbDataReader dr;

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pn_login.Visible = false;
            guna2Transition1.HideSync(pn_login);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pn_login.Visible = true;
            guna2Transition1.ShowSync(pn_login);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            string ad = txt_kullanici.Text;
            string sifre = txt_sifre.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Dbusers.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = " SELECT * FROM users where username1 = '" + txt_kullanici.Text + "' AND password1 = '" + txt_sifre.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
                f2.label1.Text = txt_kullanici.Text;

                    
            }

            else if(txt_kullanici.Text=="admin" && txt_sifre.Text=="1")
            {
                AdminForm a1 = new AdminForm();
                a1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış");
            }
            con.Close();
        }

        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            string username = txt_rusername.Text;
            string password = txt_rpassword.Text;
            string name = txt_rname.Text;
            string email = txt_remail.Text;

            try
            {

                OleDbConnection con = new OleDbConnection();
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Dbusers.accdb");
                OleDbCommand cmd = new OleDbCommand("Insert into users (username1,password1,email1,name1) Values (@username,@password,@email,@name)", con);
                cmd.Parameters.Add(new OleDbParameter("@username", username));
                cmd.Parameters.Add(new OleDbParameter("@password", password));
                cmd.Parameters.Add(new OleDbParameter("@email", email));
                cmd.Parameters.Add(new OleDbParameter("@name", name));
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
                f2.label1.Text = txt_rusername.Text;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_rname_TextChanged(object sender, EventArgs e)
        {
            if (txt_rname.Text != "" && txt_remail.Text != "" && txt_rusername.Text != "" && txt_rpassword.Text != "")
            {
                btn_kaydol.Enabled = true;
            }
            else if (txt_rname.Text == "" || txt_remail.Text == "" || txt_rusername.Text == "" || txt_rpassword.Text == "")
            {
                btn_kaydol.Enabled = false;
            }
        }

        private void txt_remail_TextChanged(object sender, EventArgs e)
        {
            if (txt_rname.Text != "" && txt_remail.Text != "" && txt_rusername.Text != "" && txt_rpassword.Text != "")
            {
                btn_kaydol.Enabled = true;
            }
            else if (txt_rname.Text == "" || txt_remail.Text == "" || txt_rusername.Text == "" || txt_rpassword.Text == "")
            {
                btn_kaydol.Enabled = false;
            }
        }

        private void txt_rusername_TextChanged(object sender, EventArgs e)
        {
            if (txt_rname.Text != "" && txt_remail.Text != "" && txt_rusername.Text != "" && txt_rpassword.Text != "")
            {
                btn_kaydol.Enabled = true;
            }
            else if (txt_rname.Text == "" || txt_remail.Text == "" || txt_rusername.Text == "" || txt_rpassword.Text == "")
            {
                btn_kaydol.Enabled = false;
            }
        }

        private void txt_rpassword_TextChanged(object sender, EventArgs e)
        {
            if (txt_rname.Text != "" && txt_remail.Text != "" && txt_rusername.Text != "" && txt_rpassword.Text != "")
            {
                btn_kaydol.Enabled = true;
            }
            else if (txt_rname.Text == "" || txt_remail.Text == "" || txt_rusername.Text == "" || txt_rpassword.Text == "")
            {
                btn_kaydol.Enabled = false;
            }
        }

        private void guna2GradientButton2_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
