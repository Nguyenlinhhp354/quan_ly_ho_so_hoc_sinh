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
    
    public partial class diem : Form
    {
        private SqlTransaction transaction;
        private SqlCommand command;
        public int hocki;
        DataRow row;
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connect);
        public diem()
        {
            InitializeComponent();
        }
        public diem(DataRow dataRow)
        {
            InitializeComponent();
            row = dataRow;
        }
        private void diem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyhososinhvienDataSet32.hocki' table. You can move, or remove it, as needed.
            this.hockiTableAdapter4.Fill(this.quanlyhososinhvienDataSet32.hocki);

            LoadMonHoc(1.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hocki = int.Parse(comboBox1.Text);
            LoadMonHoc(comboBox1.Text);
        }
        private void LoadMonHoc(string h)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            comboBox2.Items.Clear();
            if (!int.TryParse(h, out hocki))
            {
                MessageBox.Show("Học kì không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //hocki = int.Parse(h);
            using (SqlCommand cmd = new SqlCommand("SELECT tenmonhoc FROM monhoc WHERE hocki = @hocki", connection))
            {
                cmd.Parameters.AddWithValue("@hocki", hocki);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox1.Text) || !string.IsNullOrEmpty(comboBox2.Text) || !string.IsNullOrEmpty(txtx1.Text) || !string.IsNullOrEmpty(txtx2.Text) || !string.IsNullOrEmpty(txty.Text))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                try
                {
                    string tenmonhoc = comboBox2.Text;
                    command = new SqlCommand("select count(*) from ketquahoctap where mahocsinh = @a and hocki = @b and tenmonhoc = @c", connection);
                    command.Parameters.AddWithValue("@a", int.Parse(row[0].ToString()));
                    command.Parameters.AddWithValue("@b", int.Parse(comboBox1.Text));
                    command.Parameters.AddWithValue("@c", comboBox2.Text);
                    object ob = command.ExecuteScalar();
                    int count = int.Parse(ob.ToString());
                    if (count > 0)
                    {
                        MessageBox.Show("Dữ liệu đã tồn tại vui lòng sửa thay vì thêm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        transaction = connection.BeginTransaction();
                        SqlCommand cmd1 = connection.CreateCommand();
                        cmd1.Transaction = transaction;
                        try
                        {
                            
                            cmd1.CommandText = "insert into ketquahoctap values (@mahocsinh, @tenhocsinh, @tenmonhoc, @hocki, @diemx1, @diemx2, @diemy, @diemz)";
                            cmd1.Parameters.AddWithValue("@mahocsinh", int.Parse(row[0].ToString()));
                            cmd1.Parameters.AddWithValue("@tenhocsinh", row[1].ToString());
                            cmd1.Parameters.AddWithValue("@tenmonhoc", comboBox2.Text);
                            cmd1.Parameters.AddWithValue("@hocki", comboBox1.Text);
                            float diemx1 = float.Parse(txtx1.Text);
                            cmd1.Parameters.AddWithValue("@diemx1", diemx1);
                            float diemx2 = float.Parse(txtx2.Text);
                            cmd1.Parameters.AddWithValue("@diemx2", diemx2);
                            float diemy = float.Parse(txty.Text);
                            cmd1.Parameters.AddWithValue("@diemy", diemy);
                            if (diemx1 >10 || diemx1 <0 || diemx2 >10 || diemx2<0 || diemy > 10 || diemy<0)
                            {
                                MessageBox.Show("Điểm nhập vào chưa hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtx1.Focus();
                            }
                            else if (diemx1 < 4 || diemx2 < 4)
                            {
                                String diemz = "MTC";
                                cmd1.Parameters.AddWithValue("@diemz", diemz);
                            }
                            else if (diemy < 4)
                            {
                                String diemz = "FALSE";
                                cmd1.Parameters.AddWithValue("@diemz", diemz);
                            }
                            else
                            {
                                float diemz = (((diemx1 + diemx2) / 2) + diemy) / 2;
                                cmd1.Parameters.AddWithValue("@diemz", diemz.ToString());
                            }
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Thêm điểm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            transaction.Commit();
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
