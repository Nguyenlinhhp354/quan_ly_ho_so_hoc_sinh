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
   


    public partial class quanly : Form
    {
        string tentaikhoan;
        private string ma;
        private SqlDataAdapter adapter;
        //private SqlDataAdapter adapter1;
        private DataTable data;
        //private DataTable data1;
        public string loc;
        public SqlCommand cmd1;
        //private DataRow selectedRow ;
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        public quanly()
        {
            InitializeComponent();
            
    
            //dataviewquanly.MouseDown += new MouseEventHandler(dataviewquanly_MouseDown);
        }
        public quanly(string n)
        {
            InitializeComponent();
            tentaikhoan = n;
            
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

        private void quanly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyhososinhvienDataSet14.thongtin' table. You can move, or remove it, as needed.
            this.thongtinTableAdapter6.Fill(this.quanlyhososinhvienDataSet14.thongtin);
            

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            data = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM thongtin", conn);
            adapter.Fill(data);
            dataviewquanly.DataSource = data;
            
        }
        private void dataviewquanly_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataviewquanly.SelectedRows.Count > 0)
                {
                    DataRow selectedRow = ((DataRowView)dataviewquanly.SelectedRows[0].DataBoundItem).Row;
                    sua s = new sua(selectedRow);
                    s.Owner = this;
                    s.FormClosed += new FormClosedEventHandler(Sua_FormClosed);
                    s.ShowDialog();
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Them_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            them t = new them();
            t.Owner = this;
            t.FormClosed += new FormClosedEventHandler(Them_FormClosed);
            t.ShowDialog();
            
        }
        
        public void setloc(string n)
        {
            loc = n;
        }
        
        private void ReloadData()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            data.Clear();
            adapter.Fill(data);
            dataviewquanly.DataSource = data;
        }
        private void Sua_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReloadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            
            if (dataviewquanly.SelectedCells.Count > 0)
            {
                // Lấy index của hàng được chọn
                int selectedRowIndex = dataviewquanly.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataviewquanly.Rows[selectedRowIndex];
                ma = dataviewquanly.Rows[selectedRowIndex].Cells[0].Value.ToString();
                int index = int.Parse(ma);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
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
                            cmddiemgpa.CommandText = "delete from diemgpa where mahocsinh = @a";
                            cmddiemgpa.Parameters.AddWithValue("@a", index);
                            cmddiemgpa.ExecuteNonQuery();

                            cmdthongtin.CommandText = "delete from thongtin where mahocsinh = @a";
                            cmdthongtin.Parameters.AddWithValue("@a", index);
                            cmdthongtin.ExecuteNonQuery();


                            //SqlCommand xoa = new SqlCommand("delete from thongtin where mahocsinh = @a", conn);
                            //xoa.Parameters.AddWithValue("@a", index);
                            //xoa.ExecuteNonQuery();
                            transaction.Commit();
                            ReloadData();
                        }
                        catch(Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btntim_Click(object sender, EventArgs e)
        {
            timkiem t = new timkiem();
            t.Owner = this;
            t.FormClosed += new FormClosedEventHandler(Timkiem_FormClosed);
            t.ShowDialog();
            //setloc(n(t));
            //loc = t.n;
            //data = t.table();
        }
        public void setcommand(SqlCommand c)
        {
            cmd1 = c;
        }
        private void Timkiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            //textBox1.Text = loc;
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                //SqlCommand cmd = new SqlCommand(loc, conn); // Thiết lập câu lệnh SQL cho SqlCommand
                adapter = new SqlDataAdapter(cmd1);   // Thực thi lệnh và sử dụng SqlDataReader

                data.Clear();
                adapter.Fill(data);                           // Nạp dữ liệu từ SqlDataReader vào DataTable
                dataviewquanly.DataSource = data ;            // Gán DataTable cho DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string n(timkiem a)
        {
            return a.n;
        }

        private void btnhienthitatca_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }


            data = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM thongtin", conn);
            adapter.Fill(data);
            dataviewquanly.DataSource = data;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.thongtinTableAdapter.FillBy(this.quanlyhososinhvienDataSet.thongtin);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void combosapxep_SelectedIndexChanged(object sender, EventArgs e)
        {
            int luachon = combosapxep.SelectedIndex;
            if (luachon == 0)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }


                data = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM thongtin order by mahocsinh", conn);
                adapter.Fill(data);
                dataviewquanly.DataSource = data;
            }
            if (luachon == 1)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }


                data = new DataTable();
                adapter = new SqlDataAdapter("SELECT * FROM thongtin order by tenhocsinh", conn);
                adapter.Fill(data);
                dataviewquanly.DataSource = data;
            }
        }
        private void LoadData(string query)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand(query, conn); // Thiết lập câu lệnh SQL cho SqlCommand
                SqlDataReader reader = cmd.ExecuteReader();   // Thực thi lệnh và sử dụng SqlDataReader

                data = new DataTable();
                data.Load(reader);                           // Nạp dữ liệu từ SqlDataReader vào DataTable
                dataviewquanly.DataSource = data;            // Gán DataTable cho DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        //private void dataviewquanly_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Right)
        //    {
        //        var hitTestInfo = ((DataGridView)sender).HitTest(e.X, e.Y);
        //        if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
        //        {
        //            ((DataGridView)sender).CurrentCell = ((DataGridView)sender).Rows[hitTestInfo.RowIndex].Cells[hitTestInfo.ColumnIndex];
        //            ((DataGridView)sender).Rows[hitTestInfo.RowIndex].Selected = true;
        //        }
        //    }
        //}
        private void contextMenuStrip5_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void xoáToolStripMenuItem1_MouseClick(object sender, MouseEventArgs e)
        {
        }
        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataviewquanly_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void contextMenuStrip5_Opening(object sender, CancelEventArgs e)
        {

        }

        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ketquahoctap kq = new ketquahoctap();
            //kq.FormClosed += new FormClosedEventHandler(KetQuaHocTap_FormClosed);
            kq.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            doimatkhau d = new doimatkhau(tentaikhoan);
            d.FormClosed += new FormClosedEventHandler(DoiMatKhau_FormClosed);
            d.Show();
            this.Hide();
        }
        private void DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void dataviewquanly_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dataviewquanly.SelectedRows.Count > 0)
                {
                    DataRow selectedRow = ((DataRowView)dataviewquanly.SelectedRows[0].DataBoundItem).Row;
                    sua s = new sua(selectedRow);
                    s.Owner = this;
                    s.FormClosed += new FormClosedEventHandler(Sua_FormClosed);
                    s.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void danhSáchLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lop l = new lop(tentaikhoan);
            //l.FormClosed += new FormClosedEventHandler(DanhSachLop_FormClosed);
            l.Show();
            this.Hide();
        }
        
    }
}
