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
    public partial class lop : Form
    {
        private SqlTransaction transaction;
        //private string max;
        private SqlCommand command;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable data;
        private string tentaikhoan;
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connect);
        public lop()
        {
            InitializeComponent();
        }
        public lop(string n)
        {
            InitializeComponent();
            tentaikhoan = n;
        }

        private void lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyhososinhvienDataSet37.thongtin' table. You can move, or remove it, as needed.
            this.thongtinTableAdapter2.Fill(this.quanlyhososinhvienDataSet37.thongtin);
            LoadLop();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command = new SqlCommand("select*from thongtin", connection);
            //command.Parameters.AddWithValue("@a", tenlop);
            adapter = new SqlDataAdapter(command);
            data = new DataTable();
            adapter.Fill(data);
            datatheolop.DataSource = data;

        }
        private void LoadLop()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            combolop.Items.Clear();
            if (transaction != null) // Kiểm tra nếu có giao dịch đang diễn ra
            {
                cmd.Transaction = transaction; // Gán Transaction nếu cần
            }
            //using (SqlCommand cmd = new SqlCommand("SELECT tenlop FROM lop", connection))
            //{
            // cmd.Parameters.AddWithValue("@hocki", hocki);
            cmd = new SqlCommand("SELECT tenlop FROM lop", connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        combolop.Items.Add(reader.GetString(0));
                    }
                reader.Close();
                }
                
            //}
        }

        private void combolop_SelectedIndexChanged(object sender, EventArgs e)
        {
            data.Clear();
            string tenlop = combolop.Text;
            command = new SqlCommand("select*from thongtin where lop = @a", connection);
            command.Parameters.AddWithValue("@a",tenlop);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Ban co muon thoat khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ketquahoctap kq = new ketquahoctap();
            kq.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doimatkhau d = new doimatkhau(tentaikhoan);
            
            d.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            quanly q = new quanly();
            q.Show();
            this.Hide();
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void ReloadData()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            data.Clear();
            adapter.Fill(data);
            datatheolop.DataSource = data;
        }

        private void checkthem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkthem.Checked) txttenlop.Enabled = true;
            else txttenlop.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            try
            {
                transaction = connection.BeginTransaction();
                SqlCommand cmd = connection.CreateCommand();
                cmd.Transaction = transaction;
                try
                {
                    cmd.CommandText = "insert into lop values ( @b)";
                    //cmd.Parameters.AddWithValue("@a", int.Parse(max) + 1);
                    cmd.Parameters.AddWithValue("@b", txttenlop.Text);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Thêm lớp thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadLop();
            //}
        }
        
    }
}
