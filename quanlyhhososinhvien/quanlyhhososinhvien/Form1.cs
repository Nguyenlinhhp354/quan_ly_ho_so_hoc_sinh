using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlyhhososinhvien
{
    
    public partial class Form1 : Form
    {
        string tentaikhoan;
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txttaikhoan.Text;
            string matkhau = txtmatkhau.Text;
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //string ktra = "select matkhau from taikhoan where taikhoan = '@a'";
            //SqlCommand cmd = new SqlCommand(ktra, conn);
            //cmd.Parameters.AddWithValue("@a", txttaikhoan);
            //object pass = cmd.ExecuteScalar();
            if (AuthenticateUser(taikhoan,matkhau))
            {
                tentaikhoan = taikhoan;
                quanly q = new quanly(tentaikhoan);
                //q.FormClosed += new FormClosedEventHandler(QuanLy_FormClosed);
                q.Show();
                this.Hide();

            }else
            {
                MessageBox.Show("Sai thong tin tai khoan mat khau", "Thu lai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmatkhau.ResetText();
                txttaikhoan.Focus();
            }
        }
        
        public string getusername()
        {
            return tentaikhoan;
        }
        //public bool kiemtradangnhap̣̣̣̣̣(string taikhoan, string matkhau)
        //{
        //    if (taikhoan == this.tentaikhoan && matkhau == this.matkhau)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM taikhoan WHERE tentaikhoan = @Username AND matkhau = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 1;
                }
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtmatkhau.PasswordChar = '\0';
            }
            else
            {
                txtmatkhau.PasswordChar = '*';
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            dangki dk = new dangki();
            dk.FormClosed += new FormClosedEventHandler(DangKi_FormClosed);
            dk.Show();
            this.Hide();
        }
        private void DangKi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show() ;
        }

        private void linkquenpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            quenmatkhau q = new quenmatkhau();
            q.Show();
            this.Hide();
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
