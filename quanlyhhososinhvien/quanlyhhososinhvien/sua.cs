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

    public partial class sua : Form
    {
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connect);
        private DataRow selectedRow, row1;
        private int key;
        public sua(DataRow row)
        {
            
            InitializeComponent();
            selectedRow = row1 = row;
            key = Convert.ToInt32(row1[0]);
            txtmasinhvien.Text = selectedRow[0].ToString();
            txttensinhvien.Text = selectedRow[1].ToString();
            datengaysinh.Value = Convert.ToDateTime(selectedRow[2]);
            txtgioitinh.Text = selectedRow[3].ToString();
            txtcccd.Text = selectedRow[4].ToString();
            txtsdt.Text = selectedRow[5].ToString();
            combolop.Text = selectedRow[6].ToString();
            combohedaotao.Text = selectedRow[7].ToString();
            LoadLop();
            LoadHedaotao();
        }
        
        private void sua_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'quanlyhososinhvienDataSet2.hedaotao' table. You can move, or remove it, as needed.
            //this.hedaotaoTableAdapter.Fill(this.quanlyhososinhvienDataSet2.hedaotao);
            //// TODO: This line of code loads data into the 'quanlyhososinhvienDataSet15.lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter.Fill(this.quanlyhososinhvienDataSet15.lop);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn chắc chắn lưu dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
            {
                selectedRow[0] = txtmasinhvien.Text;
                selectedRow[1] = txttensinhvien.Text;
                selectedRow[2] = datengaysinh.Value;
                selectedRow[3] = txtgioitinh.Text;
                selectedRow[4] = txtcccd.Text;
                selectedRow[5] = txtsdt.Text;
                selectedRow[6] = combolop.Text;
                selectedRow[7] = combohedaotao.Text;
                UpdateDatabase(selectedRow);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn chắc chắn muon thoat ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void UpdateDatabase(DataRow row)
        {
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }
                
                string query = "UPDATE thongtin SET mahocsinh = @Column1, tenhocsinh = @Column2, ngaysinh = @Column3, gioitinh = @Column4, cccd = @Column5, sdt = @Column6, lop = @Column7, tenhedaotao = @Column8, email = @Column9 WHERE mahocsinh = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                
                    command.Parameters.AddWithValue("@Column1", row[0]);
                    command.Parameters.AddWithValue("@Column2", row[1]);
                    command.Parameters.AddWithValue("@Column3", row[2]);
                    command.Parameters.AddWithValue("@Column4", row[3]);
                    command.Parameters.AddWithValue("@Column5", row[4]);
                    command.Parameters.AddWithValue("@Column6", row[5]);
                    command.Parameters.AddWithValue("@Column7", row[6]);
                    command.Parameters.AddWithValue("@Column8", row[7]);
                    string email = ChuyenDoiKhongDau(GetFirstName(txttensinhvien.Text)) + int.Parse(txtmasinhvien.Text) + "@st.vimaru.edu.vn";
                    command.Parameters.AddWithValue("@Column9", email);
                    command.Parameters.AddWithValue("@ID", key);
                    command.ExecuteNonQuery();
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
    }
}
