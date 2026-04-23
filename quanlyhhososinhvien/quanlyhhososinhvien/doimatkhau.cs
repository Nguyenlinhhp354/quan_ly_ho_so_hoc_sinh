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
    
    public partial class doimatkhau : Form
    {
        string tentaikhoan;
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        public doimatkhau()
        {
            InitializeComponent();
        }
        public doimatkhau(string n)
        {
            
            InitializeComponent();
            tentaikhoan = n;
        }
        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("select matkhau from taikhoan where tentaikhoan = @a", conn);
            cmd.Parameters.AddWithValue("@a", tentaikhoan);
            object matkhau = cmd.ExecuteScalar();
            string matkhaucu = matkhau.ToString();
            
            if (String.IsNullOrEmpty(txtmatkhaucu.Text) || String.IsNullOrEmpty(txtmatkhaumoi.Text) || String.IsNullOrEmpty(txtxacnhan.Text) || string.IsNullOrEmpty(txtxacthuc.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Chưa đầy đủ thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!txtrandom.Text.Equals(txtxacthuc.Text))
            {
                MessageBox.Show("Mã xác thực chưa chính xác", "Chưa đầy đủ thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtrandom.Text = GenerateRandomString(5);
            }
            else if (!matkhau.Equals(txtmatkhaucu.Text))
            {
                MessageBox.Show("Mật khẩu cũ chưa chính xác", "Vui lòng nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmatkhaucu.Focus();
            }
            else if (!txtmatkhaumoi.Text.Equals(txtxacnhan.Text))
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận chưa giống nhau", "Vui lòng nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmatkhaucu.Equals(txtmatkhaumoi.Text))
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu cũ không được trùng nhau", "Vui lòng nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult tb = MessageBox.Show("Xác nhận đổi mật khẩu ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tb == DialogResult.Yes)
                {
                    SqlTransaction transaction = conn.BeginTransaction();
                    SqlCommand cmddoipass = conn.CreateCommand();
                    cmddoipass.Transaction = transaction;
                    try
                    {
                        cmddoipass.CommandText = "update taikhoan set matkhau = @a where tentaikhoan = @b";
                        cmddoipass.Parameters.AddWithValue("@a", txtmatkhaumoi.Text);
                        cmddoipass.Parameters.AddWithValue("@b", tentaikhoan);
                        cmddoipass.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                        transaction.Commit();
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked == true)
            {
                txtmatkhaucu.PasswordChar = '\0';
                txtmatkhaumoi.PasswordChar = '\0';
                txtxacnhan.PasswordChar = '\0';
            }
            else
            {
                txtmatkhaucu.PasswordChar = '*';
                txtmatkhaumoi.PasswordChar = '*';
                txtxacnhan.PasswordChar = '*';
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            quanly q = new quanly(tentaikhoan);
            q.Show();
            this.Close();
        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {
            txtrandom.Text = GenerateRandomString(5);
        }
        private string GenerateRandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string randomString = "";

            for (int i = 0; i < length; i++)
            {
                randomString += chars[random.Next(chars.Length)];
            }

            return randomString;
        }
    }
}
