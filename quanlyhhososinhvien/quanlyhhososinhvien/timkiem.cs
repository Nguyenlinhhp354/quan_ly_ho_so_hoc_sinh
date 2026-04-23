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
    public partial class timkiem : Form
    {
        public SqlCommand command;
        static string connect = @"Data Source=DESKTOP-RA233V8\SQLEXPRESS;Initial Catalog=quanlyhososinhvien;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connect);
        public string n;
        public int dem = 0;
        public timkiem()
        {
            InitializeComponent();
        }

        private void timkiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlyhososinhvienDataSet35.hedaotao' table. You can move, or remove it, as needed.
            this.hedaotaoTableAdapter.Fill(this.quanlyhososinhvienDataSet35.hedaotao);
            // TODO: This line of code loads data into the 'quanlyhososinhvienDataSet34.lop' table. You can move, or remove it, as needed.
            //this.lopTableAdapter.Fill(this.quanlyhososinhvienDataSet34.lop);
            LoadHedaotao();
            LoadLop();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Ban co muon thoat khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txtcccd1.Text != "" || txtmahocsinh1.Text != ""   || txthoten.Text != "" || txtsdt.Text != "" || (datengaysinh1.Value <= datengaysinh2.Value) || rdnam.Checked || rdnu.Checked){
                n = "select*from thongtin where";
                if (txtmahocsinh1.Text != "" && txtmahocsinh2.Text != "" && (int.Parse(txtmahocsinh1.Text)) <= int.Parse(txtmahocsinh2.Text))
                {
                    n += " mahocsinh between " + txtmahocsinh1.Text+ " and " + txtmahocsinh2.Text;
                    dem++;
                }
                if (txtmahocsinh1.Text != "" && txtmahocsinh2.Text == "")
                {
                    n += " mahocsinh = " + txtmahocsinh1.Text;
                    dem++;
                }
                if (txthoten.Text != "")
                {
                    if (dem >= 1)
                    {
                        n += " and tenhocsinh = '" + txthoten.Text + "'";
                        dem++;
                    }
                    else
                    {
                        n += " tenhocsinh = '" + txthoten.Text + "'";
                        dem++;
                    }
                }

                if (datengaysinh1.Value <= datengaysinh2.Value)
                {
                    if (dem >= 1)
                    {
                        n += " and ngaysinh between '" + datengaysinh1.Value.ToString("yyyy-MM-dd") + "'" + " and '" + datengaysinh2.Value.ToString("yyyy-MM-dd") + "'";
                        dem++;
                    }
                    else
                    {
                        n += " ngaysinh between '" + datengaysinh1.Value.ToString("yyyy-MM-dd") + "'" + " and '" + datengaysinh2.Value.ToString("yyyy-MM-dd") + "'";
                        dem++;
                    }
                }
                
                if (rdnu.Checked || rdnam.Checked)
                {
                    if ((rdnam.Checked || rdnu.Checked) && dem >= 1)
                    {
                        if (rdnu.Checked) n += " and gioitinh = '" + rdnu.Text + "'";
                        else n += " and gioitinh = '" + rdnam.Text + "'";
                        dem++;
                    }
                    else
                    {
                        if (rdnu.Checked) n += " gioitinh = '" + rdnu.Text + "'";
                        else n += " gioitinh = '" + rdnam.Text + "'";
                        dem++;
                    }
                }
                if (txtcccd1.Text != "" && txtcccd2.Text != "" && (int.Parse(txtcccd1.Text)) <= int.Parse(txtcccd2.Text))
                {
                    if (dem >= 1)
                    {
                        n += " and cccd between '" + txtcccd1.Text + "'" + " and " + txtcccd2.Text + "'";
                        dem++;
                    }
                    else
                    {
                        n += " cccd between '" + txtcccd1.Text +"'"+ " and '" + txtcccd2.Text + "'";
                        dem++;
                    }
                }
                if (txtcccd1.Text != "" && txtcccd2.Text == "")
                {
                    if (dem >= 1)
                    {
                        n += " and cccd = '" + txtcccd1.Text + "'";
                        dem++;
                    }
                    else
                    {
                        n += " cccd = '" + txtcccd1.Text + "'";
                        dem++;
                    }
                }
                
                if (txtsdt.Text != "")
                {
                    if (dem >= 1)
                    {
                        n += " and sdt = '" + txtsdt.Text + "'";
                        dem++;
                    }
                    else
                    {
                        n += " sdt = '" + txtsdt.Text + "'";
                        dem++;
                    }
                }
               
                if (checklop.Checked)
                {
                    if (dem >= 1)
                    {
                        n += " and lop = '" + combolop.Text +"'";
                        dem++;
                    }
                    else
                    {
                        n += " lop = '" + combolop.Text + "'";
                        dem++;
                    }
                }
                if (checkhedaotao.Checked)
                {
                    if (dem >= 1)
                    {
                        n += " and tenhedaotao = '" + combohedaotao.Text + "'";
                        dem++;
                    }
                    else
                    {
                        n += " tenhedaotao = '" + combohedaotao.Text + "'";
                        dem++;
                    }
                }
                //n += ";";
                command = new SqlCommand(n, conn);
                if (this.Owner != null && this.Owner is quanly q)
                {
                    // Gọi phương thức UpdateLabel của MainForm
                    q.setcommand(command);
                }
            }
            this.Close();
        }

        private void checklop_CheckedChanged(object sender, EventArgs e)
        {
            if (checklop.Checked) combolop.Enabled = true;
            else combolop.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkhedaotao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkhedaotao.Checked) combohedaotao.Enabled = true;
            else combohedaotao.Enabled = false;
        }
        private void LoadHedaotao()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            combohedaotao.Items.Clear();

            using (SqlCommand cmd = new SqlCommand("SELECT tenhedaotao FROM hedaotao", conn))
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
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            combohedaotao.Items.Clear();

            using (SqlCommand cmd = new SqlCommand("SELECT tenlop FROM lop", conn))
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
        public DataTable table()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //SqlCommand command = new SqlCommand(n, conn);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            conn.Close();
            return data;
        }
    }
}
