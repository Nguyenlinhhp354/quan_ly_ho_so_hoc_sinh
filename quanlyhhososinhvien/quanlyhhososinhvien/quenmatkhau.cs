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
    public partial class quenmatkhau : Form
    {
        public string matkhau;
        static string connecting = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection connected = new SqlConnection(connecting);
        public quenmatkhau()
        {
            InitializeComponent();
        }

        private void quenmatkhau_Load(object sender, EventArgs e)
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

        private void btnkhoiphuc_Click(object sender, EventArgs e)
        {
            string taikhoan = txttaikhoan.Text;
            string pass = txtmatkhaubimat.Text;
            string xacthuc = txtxacthuc.Text;
            //string rand = txtrandom.Text;
            if (connected.State == ConnectionState.Closed)
            {
                connected.Open();
            }
            SqlCommand command = new SqlCommand("select matkhaubimat from taikhoan where tentaikhoan = @a", connected);
            command.Parameters.AddWithValue("@a", taikhoan);
            object temp = command.ExecuteScalar();
            matkhau = temp.ToString();
            if (String.IsNullOrEmpty(taikhoan) && String.IsNullOrEmpty(pass) && String.IsNullOrEmpty(xacthuc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttaikhoan.Focus();
                txtrandom.Text = GenerateRandomString(5);
            }else if (!xacthuc.Equals(txtrandom.Text))
            {
                MessageBox.Show("Mã xác thực phải giống nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtxacthuc.Focus();
                txtrandom.Text = GenerateRandomString(5);
            }else if (!pass.Equals(matkhau))
            {
                MessageBox.Show("Mật khẩu bí mật chưa chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtxacthuc.Focus();
                txtrandom.Text = GenerateRandomString(5);
            }
            else
            {
                
                    string passmoi = GenerateRandomString(5);
                    //MessageBox.Show("Mật khẩu mới của bạn là: " + passmoi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SqlTransaction transaction = connected.BeginTransaction();
                    SqlCommand cmdupdate = connected.CreateCommand();
                    cmdupdate.Transaction = transaction;
                
                    cmdupdate.CommandText = "update taikhoan set matkhau = @a where tentaikhoan = @b";
                    cmdupdate.Parameters.AddWithValue("@a", passmoi);
                    cmdupdate.Parameters.AddWithValue("@b", taikhoan);
                    
                    cmdupdate.ExecuteNonQuery();
                    MessageBox.Show("Mật khẩu mới của bạn là: " + passmoi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaction.Commit();
            }
        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked == true)
            {
               
                txtmatkhaubimat.PasswordChar = '\0';
            }
            else
            {
                
                txtmatkhaubimat.PasswordChar = '*';
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
