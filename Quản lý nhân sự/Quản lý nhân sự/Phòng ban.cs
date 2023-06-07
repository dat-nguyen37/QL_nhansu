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

namespace Quản_lý_nhân_sự
{
    public partial class phongban : Form
    {
        public phongban()
        {
            InitializeComponent();
        }

        private void Phòng_ban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet3.TTphongban' table. You can move, or remove it, as needed.
            getdata();

        }
        public void getdata()
        {
            this.tTphongbanTableAdapter.Fill(this.quanLyNhanSuDataSet3.TTphongban);
        }
        bool kiemtraid()
        {
            string con_tr = "Data Source = (local); INitial Catalog = QuanLyNhanSu; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 mapb FROM TTphongban where mapb='" + txtma.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Mã phòng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Nhập mã phòng");
                txtma.Focus();
                return;
            }
            if (txtpb.Text == "")
            {
                MessageBox.Show("Nhập tên phòng");
                txtpb.Focus();
                return;
            }
            if (!kiemtraid())
            {
                return;
            }
            string ma = txtma.Text;
            string ten = txtpb.Text;

            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into TTphongban values(@mapb,@tenpb)", conn);
            cmd.Parameters.AddWithValue("@mapb", ma);
            cmd.Parameters.AddWithValue("@tenpb", ten);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Thêm thành công");
                getdata();
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông Báo");
            }

            conn.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Nhập mã phòng");
                txtma.Focus();
                return;
            }


            string mapb = txtma.Text;
            string tenpb = txtpb.Text;

            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Update TTphongban set tenpb=@tenpb WHERE mapb=@mapb", conn);
            cmd.Parameters.AddWithValue("@mapb", mapb);
            cmd.Parameters.AddWithValue("@tenpb", tenpb);

            if (cmd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Sửa thành công");
                getdata();

            }
            else
            {
                MessageBox.Show("Lỗi", "Thông Báo");
            }

            conn.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Nhập mã phóng cần xóa");
                txtma.Focus();
                return;
            }


            string mapb = txtma.Text;


            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM TTphongban where mapb=@mapb", conn);
            cmd.Parameters.AddWithValue("@mapb", mapb);
            if (cmd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Xóa thành công");
                getdata();

            }
            else
            {
                MessageBox.Show("Lỗi", "Thông Báo");
            }

            conn.Close();
        }

        private void btnrs_Click(object sender, EventArgs e)
        {
            txtma.Enabled = true;
            txtpb.Text = "";
            txtma.Text = "";
            btnthem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void bang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnthem.Enabled = false;
            txtma.Enabled = false;
            txtma.Text = bang.CurrentRow.Cells[0].Value.ToString();
            txtpb.Text = bang.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa toàn bộ danh sách không", "Thông báo..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
                SqlConnection conn = new SqlConnection(con_tr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM TTphongban", conn);

                if (cmd.ExecuteNonQuery() > -1)
                {
                    MessageBox.Show("Xóa thành công");
                    getdata();

                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông Báo");
                }
                conn.Close();
            }

           
        }
    }
}
