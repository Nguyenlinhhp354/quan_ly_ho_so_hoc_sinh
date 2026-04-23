using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyhososinhvien
{
    public partial class Timkiemthongtin : Form
    {
        public Timkiemthongtin()
        {
            InitializeComponent();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            string query = "SELECT masinhvien, hoten, gioitinh, diachi, sdt, cccd, lop, khoa * FROM THONGTIN WHERE masinhvien = @masinhvien";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@masinhvien", txtma.Text);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show($"Mã Sinh Viên : {reader["masinhvien"]}\n" + $"Họ Tên : {reader["HoTen"]}\n)" + $"Ngày Sinh : {reader["NgaySinh"]}\n)" + $"Giới tính: {reader["GioiTinh"]}\n" + $"Địa chỉ:{reader["DiaChi"]}\n" + $"Số điện thoại : {reader["SDT"]}\n" + $"CCCD :{reader["CCCD"]}\n" + $"Lớp :{reader["Lop"]}\n" + $"Khoa Viện :{reader["KhoaVien"]}\n");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên!");
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show($"Lỗi: {ex1.Message}");
                }
            }
        }
    }
} 

      
