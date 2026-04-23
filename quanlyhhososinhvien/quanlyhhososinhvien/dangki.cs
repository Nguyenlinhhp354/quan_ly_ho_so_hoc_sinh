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
using System.Text.RegularExpressions;

namespace quanlyhhososinhvien
{
    public partial class dangki : Form
    {
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);

        public dangki()
        {
            InitializeComponent();
        }

        private void btndangki_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                 conn.Open();
            }
            try
            {
                if (string.IsNullOrEmpty(txttaikhoan.Text) || string.IsNullOrEmpty(txtmatkhau.Text) || string.IsNullOrEmpty(txtmatkhau2.Text) || string.IsNullOrEmpty(txtmatkhaubimat.Text))
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin tài khoản!", "Lỗi đăng kí", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttaikhoan.Focus();
                }
                if (Regex.IsMatch(txttaikhoan.Text, @"^\d{8}$"))
                {
                    MessageBox.Show("Tên tài khoản không hợp lệ!", "Lỗi đăng kí", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttaikhoan.Focus();
                }
                if (Regex.IsMatch(txtmatkhau.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).+$"))
                {
                    MessageBox.Show("Mật khẩu không hợp lệ!", "Lỗi đăg kí", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmatkhau.Focus();
                }
                if (txtmatkhau.Text != txtmatkhau2.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng nhau!", "Lỗi đăng kí", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmatkhau.Focus();
                }
                if (Regex.IsMatch(txtmatkhaubimat.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\W).+$"))
                {
                    MessageBox.Show("Mật khẩu bí mật không hợp lệ!", "Lỗi đăg kí", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmatkhaubimat.Focus();
                }
                string taikhoan = txttaikhoan.Text;
                string matkhau = txtmatkhau.Text;
                string matkhaubimat = txtmatkhaubimat.Text;
                SqlCommand cmd = new SqlCommand("insert into taikhoan values (@tentaikhoan, @matkhau, @matkhaubimat)", conn);
                cmd.Parameters.AddWithValue("@tentaikhoan", taikhoan);
                cmd.Parameters.AddWithValue("@matkhau", matkhau);
                cmd.Parameters.AddWithValue("@matkhaubimat", matkhaubimat);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đăng kí tài khoản thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăg kí", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void checkmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmatkhau.Checked == true)
            {
                txtmatkhau.PasswordChar = '\0';
                txtmatkhau2.PasswordChar = '\0';
                txtmatkhaubimat.PasswordChar = '\0';
            }
            else
            {
                txtmatkhau.PasswordChar = '*';
                txtmatkhau2.PasswordChar = '*';
                txtmatkhaubimat.PasswordChar = '*';
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Ban co muon thoat khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dangki_Load(object sender, EventArgs e)
        {

        }
    }
}
