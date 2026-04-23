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
    public partial class suadiem : Form
    {
        private SqlTransaction transaction;
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        DataRow row;
        public suadiem()
        {
            InitializeComponent();
        }
        public suadiem(DataRow row1)
        {
            InitializeComponent();
            row = row1;
        }
        private void suadiem_Load(object sender, EventArgs e)
        {
            txthocki.Text = row[3].ToString();
            txtmonhoc.Text = row[2].ToString();
            txtx1.Text = row[4].ToString();
            txtx2.Text = row[5].ToString();
            txty.Text = row[6].ToString();
            txtz.Text = row[7].ToString();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            transaction = conn.BeginTransaction();
            SqlCommand command = conn.CreateCommand();
            command.Transaction = transaction;

            try
            {
                command.CommandText = "update ketquahoctap set diemx1 = @a, diemx2 = @b, diemy = @c, diemz = @d where mahocsinh = @mahocsinh and hocki = @hocki and tenmonhoc = @tenmonhoc";
                float diemx1 = float.Parse(txtx1.Text);
                float diemx2 = float.Parse(txtx2.Text);
                float diemy = float.Parse(txty.Text);
                command.Parameters.AddWithValue("@a", txtx1.Text);
                command.Parameters.AddWithValue("@b", txtx2.Text);
                command.Parameters.AddWithValue("@c", txty.Text);
                command.Parameters.AddWithValue("@mahocsinh", row[0].ToString());
                command.Parameters.AddWithValue("@hocki", int.Parse(txthocki.Text));
                command.Parameters.AddWithValue("@tenmonhoc", txtmonhoc.Text);
                if (diemx1 > 10 || diemx1 < 0 || diemx2 > 10 || diemx2 < 0 || diemy > 10 || diemy < 0)
                {
                    MessageBox.Show("Điểm nhập vào chưa hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtx1.Focus();
                }
                else if (diemx1 < 4 || diemx2 < 4)
                {
                    String diemz = "MTC";
                    command.Parameters.AddWithValue("@d", diemz);
                }
                else if (diemy < 4)
                {
                    String diemz = "FALSE";
                    command.Parameters.AddWithValue("@d", diemz);
                }
                else
                {
                    float diemz = (((diemx1 + diemx2) / 2) + diemy) / 2;
                    command.Parameters.AddWithValue("@d", diemz.ToString());
                }
                command.ExecuteNonQuery();
                transaction.Commit();
                this.Close();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
