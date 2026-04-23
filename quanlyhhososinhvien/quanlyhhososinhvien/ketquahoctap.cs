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
    public partial class ketquahoctap : Form
    {
        public string ma;
        private DataTable data;
        private SqlDataAdapter adapter;
        //int index;
        public string tentaikhoan;
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        public ketquahoctap()
        {
            InitializeComponent();
        }
        public ketquahoctap(string n)
        {
            tentaikhoan = n;
            InitializeComponent();
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Ban co muon thoat khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ketquahoctap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyhososinhvienDataSet21.diemgpa' table. You can move, or remove it, as needed.
            this.diemgpaTableAdapter7.Fill(this.quanlyhososinhvienDataSet21.diemgpa);
            
            
           

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            data = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM diemgpa", conn);
            adapter.Fill(data);
            datadiemgpa.DataSource = data;

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            quanly q = new quanly();
            q.Show();
            this.Hide();

        }

        private void datadiemgpa_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (datadiemgpa.SelectedRows.Count > 0)
                {
                    DataRow selectedRow = ((DataRowView)datadiemgpa.SelectedRows[0].DataBoundItem).Row;
                    //textBox1.Text = selectedRow[0].ToString();
                    hocki h = new hocki(selectedRow);
                    h.Owner = this;
                    h.FormClosed += new FormClosedEventHandler(HocKi_FormClosed);
                    h.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ReLoad()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            data.Clear();
            adapter.Fill(data);
            datadiemgpa.DataSource = data;
        }
        private void HocKi_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datadiemgpa.SelectedCells.Count > 0)
            {
                // Lấy index của hàng được chọn
                int selectedRowIndex = datadiemgpa.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datadiemgpa.Rows[selectedRowIndex];
                ma = datadiemgpa.Rows[selectedRowIndex].Cells[0].Value.ToString();
                int index = int.Parse(ma);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu điểm của học sinh này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connect))
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        SqlTransaction transaction = conn.BeginTransaction();
                        SqlCommand cmdthongtin = conn.CreateCommand();
                        SqlCommand cmddiemgpa = conn.CreateCommand();
                        cmdthongtin.Transaction = transaction;
                        cmddiemgpa.Transaction = transaction;
                        try
                        {
                            //SqlCommand cmddiemgpa = new SqlCommand("DELETE FROM diemgpa WHERE mahocsinh = @a", conn, transaction);
                            cmddiemgpa.CommandText = "delete from ketquahoctap where mahocsinh = @a";
                            cmddiemgpa.Parameters.AddWithValue("@a", index);
                            cmddiemgpa.ExecuteNonQuery();

                            cmdthongtin.CommandText = "update diemgpa set diemgpa = 0 where mahocsinh = @a";
                            cmdthongtin.Parameters.AddWithValue("@a", index);
                            cmdthongtin.ExecuteNonQuery();


                            //SqlCommand xoa = new SqlCommand("delete from thongtin where mahocsinh = @a", conn);
                            //xoa.Parameters.AddWithValue("@a", index);
                            //xoa.ExecuteNonQuery();
                            transaction.Commit();
                            ReLoad();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReLoad();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doimatkhau d = new doimatkhau(tentaikhoan);
            //d.FormClosed += new FormClosedEventHandler(DoiMatKhau_FormClosed);
            d.Show();
            this.Hide();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lop l = new lop(tentaikhoan);
            l.Show();
            this.Hide();
        }

        private void datadiemgpa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
