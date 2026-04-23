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
    public partial class hocki : Form
    {
        public string ma1;
        private SqlTransaction transaction;
        private DataRow row;
        private DataTable data;
        private SqlDataAdapter adapter;
        private SqlCommand command;
        public int ma;
        public int sohocki;
        public string hoten;
        public object temp;
        public string temp1;
        static string connecting = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection connected = new SqlConnection(connecting);
        public hocki()
        {
            InitializeComponent();
        }
        public hocki(DataRow row1)
        {
            InitializeComponent();
            row = row1;
        }

        

        private void hocki_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyhososinhvienDataSet25.ketquahoctap' table. You can move, or remove it, as needed.
            this.ketquahoctapTableAdapter2.Fill(this.quanlyhososinhvienDataSet25.ketquahoctap);
            // TODO: This line of code loads data into the 'quanlyhososinhvienDataSet25.hocki' table. You can move, or remove it, as needed.
            this.hockiTableAdapter1.Fill(this.quanlyhososinhvienDataSet25.hocki);
            
            if (connected.State == ConnectionState.Closed)
            {
                connected.Open();
            }
            lbhoten.Text = row[1].ToString();
            lbmasinhvien.Text = row[0].ToString();
            ma = int.Parse(row[0].ToString());
            SqlCommand cmd = new SqlCommand("select*from ketquahoctap where mahocsinh = @a",connected);
            cmd.Parameters.AddWithValue("@a", ma);
            adapter = new SqlDataAdapter(cmd);
            data = new DataTable();
            adapter.Fill(data);
            datadiemhocki.DataSource = data;
            //hoten = gethoten().ToString();
        }

        private void combohocki_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connected.State == ConnectionState.Closed)
            {
                connected.Open();
            }
            try
            {
                //data.Clear();
                SqlCommand command = new SqlCommand("select*from ketquahoctap where mahocsinh = @a and hocki = @b", connected);
                command.Parameters.AddWithValue("@a", ma);
                sohocki = int.Parse(combohocki.Text);
                command.Parameters.AddWithValue("@b", sohocki);
                adapter = new SqlDataAdapter(command);
                //data.Clear();
                adapter.Fill(data);
                datadiemhocki.DataSource = data;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //public void ReLoad()
        //{
        //    if (connected.State == ConnectionState.Closed)
        //    {
        //        connected.Open();
        //    }
        //    sohocki = int.Parse(combohocki.SelectedText);
        //    SqlCommand command = new SqlCommand("select from ketquahoctap where mahocsinh = @a and hocki = @b",connected);
        //    command.Parameters.AddWithValue("@a", ma);
        //    command.Parameters.AddWithValue("@b", sohocki);
        //    adapter = new SqlDataAdapter(command);
        //    data.Clear();
        //    adapter.Fill(data);
        //    datadiemhocki.DataSource = data;
            
        //}

        private void btnthem_Click(object sender, EventArgs e)
        {
            diem d = new diem(row);
            d.Owner = this;
            d.FormClosed += new FormClosedEventHandler(Diem_FormClosed);
            d.ShowDialog();
        }

        private void lbhoten_Click(object sender, EventArgs e)
        {
            
        }
        private void Diem_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReLoad();
        }
        public void ReLoad()
        {
            if (connected.State == ConnectionState.Closed)
            {
                connected.Open();
            }
            int tongtinchi = 0;
            float tongdiem = 0;
            foreach (DataGridViewRow row1 in datadiemhocki.Rows)
            {
                //DataRow row4 = row1;
                if ( row1.Cells[7].Value != null && row1.Cells[7].Value != null && !row1.Cells[7].Value.ToString().Equals("FALSE")  && !row1.Cells[7].Value.ToString().Equals("MTC") )
                {
                    command = new SqlCommand("select sotin from monhoc where tenmonhoc = @a", connected);
                    command.Parameters.AddWithValue("@a", row1.Cells[2].Value.ToString());
                    temp = command.ExecuteScalar();

                    int soTinChi = Convert.ToInt32(temp.ToString());
                    float diem = float.Parse(row1.Cells[7].Value.ToString());

                    tongtinchi += soTinChi;
                    tongdiem += diem;
                }
            }
            float gpa = tongdiem / (float)tongtinchi;
            
            transaction = connected.BeginTransaction();
            SqlCommand cmd = connected.CreateCommand();
            cmd.Transaction = transaction;
            try
            {
                cmd.CommandText = "update diemgpa set diemgpa = @a where mahocsinh = @b";
                cmd.Parameters.AddWithValue("@a", gpa);
                cmd.Parameters.AddWithValue("@b", int.Parse(row[0].ToString()));
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            catch(Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            data.Clear();
            adapter.Fill(data);
            datadiemhocki.DataSource = data;
        }

        private void datadiemhocki_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (datadiemhocki.SelectedRows.Count > 0)
                {
                    DataRow selectedRow = ((DataRowView)datadiemhocki.SelectedRows[0].DataBoundItem).Row;
                    suadiem s = new suadiem(selectedRow);
                    s.Owner = this;
                    s.FormClosed += new FormClosedEventHandler(SuaDiem_FormClosed);
                    s.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SuaDiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReLoad();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datadiemhocki.SelectedCells.Count > 0)
            {
                // Lấy index của hàng được chọn
                int selectedRowIndex = datadiemhocki.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = datadiemhocki.Rows[selectedRowIndex];
                string temp = datadiemhocki.Rows[selectedRowIndex].Cells[3].Value.ToString();
                int hocki = int.Parse(temp);
                string tenmonhoc = datadiemhocki.Rows[selectedRowIndex].Cells[2].Value.ToString();
                ma1 = datadiemhocki.Rows[selectedRowIndex].Cells[0].Value.ToString();
                int index = int.Parse(ma1);
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //using (SqlConnection connection = new SqlConnection(connected))
                    //{
                        if (connected.State == ConnectionState.Closed)
                        {
                            connected.Open();
                        }
                        SqlTransaction transaction = connected.BeginTransaction();
                        SqlCommand cmdthongtin = connected.CreateCommand();
                        //SqlCommand cmddiemgpa = connected.CreateCommand();
                        cmdthongtin.Transaction = transaction;
                        //cmddiemgpa.Transaction = transaction;
                        try
                        {
                            //SqlCommand cmddiemgpa = new SqlCommand("DELETE FROM diemgpa WHERE mahocsinh = @a", conn, transaction);
                            //cmddiemgpa.CommandText = "delete from diemgpa where mahocsinh = @a";
                            //cmddiemgpa.Parameters.AddWithValue("@a", index);
                            //cmddiemgpa.ExecuteNonQuery();

                            cmdthongtin.CommandText = "delete from ketquahoctap where mahocsinh = @a and hocki = @b and tenmonhoc = @c";
                            cmdthongtin.Parameters.AddWithValue("@a", index);
                            cmdthongtin.Parameters.AddWithValue("@b", hocki);
                            cmdthongtin.Parameters.AddWithValue("@c", tenmonhoc);
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

                    //}
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
