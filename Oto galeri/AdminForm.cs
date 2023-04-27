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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        int indexRow;


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Dbusers.accdb");
        OleDbCommand cmd = new OleDbCommand();

        private void AdminForm_Load(object sender, EventArgs e)
        {
            kullanicilar();
            kayitlar();
        }

        private void kullanicilar()
        {
            try
            {
                con.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select * from users", con);
                DataSet dshafiza = new DataSet();
                listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void kayitlar()
        {
            try
            {
                con.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select * from kayitlar", con);
                DataSet dshafiza = new DataSet();
                listele.Fill(dshafiza);
                dataGridView2.DataSource = dshafiza.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            guna2GradientButton2.FillColor = Color.Indigo;
            guna2GradientButton2.FillColor2 = Color.DeepPink;
            guna2Panel3.Visible = false;
            guna2Panel2.Visible = true;
            guna2GradientButton1.FillColor = Color.Silver;
            guna2GradientButton1.FillColor2 = Color.Silver;
            guna2TextBox1.Clear();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            guna2GradientButton1.FillColor = Color.Indigo;
            guna2GradientButton1.FillColor2 = Color.DeepPink;
            guna2Panel3.Visible = true;
            guna2Panel2.Visible = false;
            guna2GradientButton2.FillColor = Color.Silver;
            guna2GradientButton2.FillColor2 = Color.Silver;
            guna2TextBox2.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2Button2.Visible == false)
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (guna2Button3.Visible == false)
            {
                guna2Button3.Visible = true;
            }
            else
            {
                guna2Button3.Visible = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbDataAdapter arama = new OleDbDataAdapter("select * from users  where username1='" + guna2TextBox1.Text + "'", con);
                DataSet dshafiza = new DataSet();
                arama.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                con.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                con.Close();
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(rowIndex);
        }

        private void AdminForm_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;
        }

        private void guna2Panel3_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;
        }

        private void guna2Panel2_Click(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbDataAdapter arama = new OleDbDataAdapter("select * from kayitlar  where ad='" + guna2TextBox2.Text + "'", con);
                DataSet dshafiza = new DataSet();
                arama.Fill(dshafiza);
                dataGridView2.DataSource = dshafiza.Tables[0];
                con.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                con.Close();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[indexRow];
            guna2TextBox3.Text = row.Cells[6].Value.ToString();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            DataGridViewRow newDataRow = dataGridView2.Rows[indexRow];
            newDataRow.Cells[6].Value = guna2TextBox3.Text;
        }
    }
}
