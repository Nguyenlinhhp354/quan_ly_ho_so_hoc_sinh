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
    public partial class them : Form
    {
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connect);

        public them()
        {
            InitializeComponent();
            
        }

        private void them_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'quanlyhososinhvienDataSet5.hedaotao' table. You can move, or remove it, as needed.
            //this.hedaotaoTableAdapter.Fill(this.quanlyhososinhvienDataSet5.hedaotao);
            //// TODO: This line of code loads data into the 'quanlyhososinhvienDataSet5.lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter1.Fill(this.quanlyhososinhvienDataSet5.lop);
            LoadLop();
            LoadHedaotao();
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand cmdthongtin = connection.CreateCommand();
                SqlCommand cmddiemgpa = connection.CreateCommand();
                cmdthongtin.Transaction = transaction;
                cmddiemgpa.Transaction = transaction;
                try
                {
                    cmdthongtin.CommandText = "insert into thongtin values (@mahocsinh, @tenhocsinh ,@ngaysinh, @gioitinh, @cccd, @sdt, @lop, @hedaotao, @email)";
                    //SqlCommand command = new SqlCommand("insert into thongtin values (@mahocsinh, @tenhocsinh ,@ngaysinh, @gioitinh, @cccd, @sdt, @lop, @hedaotao, @email)", connection);
                    int mahocsinh = int.Parse(txtmahocsinh.Text);
                    cmdthongtin.Parameters.AddWithValue("@mahocsinh", mahocsinh);
                    string tenhocsinh = txthoten.Text;
                    cmdthongtin.Parameters.AddWithValue("@tenhocsinh", tenhocsinh);
                    cmdthongtin.Parameters.AddWithValue("@ngaysinh", datengaysinh.Value.ToString("yyyy/MM/dd"));
                    if (rdnu.Checked) cmdthongtin.Parameters.AddWithValue("@gioitinh", rdnu.Text);
                    else cmdthongtin.Parameters.AddWithValue("@gioitinh", rdnam.Text);
                    cmdthongtin.Parameters.AddWithValue("@cccd", txtcccd.Text);
                    cmdthongtin.Parameters.AddWithValue("@sdt", txtsdt.Text);
                    string lop = combolop.Text;
                    cmdthongtin.Parameters.AddWithValue("@lop", lop);
                    string hedaotao = combohedaotao.Text;
                    cmdthongtin.Parameters.AddWithValue("@hedaotao", hedaotao);
                    string email = ChuyenDoiKhongDau(GetFirstName(tenhocsinh)) + mahocsinh + "@st.vimaru.edu.vn";
                    cmdthongtin.Parameters.AddWithValue("@email", email);
                    cmdthongtin.ExecuteNonQuery();


                    cmddiemgpa.CommandText = "insert into diemgpa values (@a, @b, @c, @d)";
                    //SqlCommand command2 = new SqlCommand("insert into diemgpa values (@a, @b, @c, @d)");
                    cmddiemgpa.Parameters.AddWithValue("@a", mahocsinh);
                    cmddiemgpa.Parameters.AddWithValue("@b", tenhocsinh);
                    cmddiemgpa.Parameters.AddWithValue("@c", lop);
                    string ma = "0";
                    cmddiemgpa.Parameters.AddWithValue("@d", int.Parse(ma));
                    cmddiemgpa.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Thêm học viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    if (txthoten.Text == "" || txtcccd.Text == "" || txtmahocsinh.Text == "" || txtsdt.Text == "" || combolop.Text == "" || (!rdnam.Checked && !rdnu.Checked))
                    {
                        MessageBox.Show("Bạn cần nhập đầy đủ các thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }
        public static string GetFirstName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return string.Empty;
            }
            fullName = fullName.Trim();
                
                string[] parts = fullName.Trim().Split(' ');

            
            return parts[parts.Length - 1];
        }
        static string ChuyenDoiKhongDau(string ten)
        {
            string khongDau = Regex.Replace(ten.Normalize(NormalizationForm.FormD), @"[\u0300-\u036F]", string.Empty);
            return khongDau.ToLower();
        }
        private void butthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Ban co muon thoat khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void LoadHedaotao()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            combohedaotao.Items.Clear();

            using (SqlCommand cmd = new SqlCommand("SELECT tenhedaotao FROM hedaotao", connection))
            {
                // cmd.Parameters.AddWithValue("@hocki", hocki);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        combohedaotao.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
        private void LoadLop()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            combolop.Items.Clear();

            using (SqlCommand cmd = new SqlCommand("SELECT tenlop FROM lop", connection))
            {
                // cmd.Parameters.AddWithValue("@hocki", hocki);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        combolop.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
    }
}

