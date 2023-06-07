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

namespace Quản_lý_nhân_sự
{
    public partial class chamcong : Form
    {
        public chamcong()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chamcong_Load(object sender, EventArgs e)
        {
            
            getdata();

        }
        public void getdata()
        {
            this.tTchamcongTableAdapter1.Fill(this.quanLyNhanSuDataSet6.TTchamcong);
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string query = string.Format("select * from TTnhanvien");
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            cbnv.DataSource = dt;
            cbnv.DisplayMember = "msnv";
        }
        bool kiemtraid()
        {
            string con_tr = "Data Source = (local); INitial Catalog = QuanLyNhanSu; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 macong FROM TTchamcong where macong='" + txtcc.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Mã chấm công đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if(!kiemtraid())
            {
                return;
            }
            string msnv = cbnv.Text;
            string tinhtrang = cbtt.Text;
            string ngay = date.Text;
            string macong = txtcc.Text;


            SqlCommand cmd = new SqlCommand("Insert into TTchamcong values(@macong,@msnv,@ngay,@tinhtrang)", conn);
            cmd.Parameters.AddWithValue("@macong", macong);
            cmd.Parameters.AddWithValue("@msnv", msnv);
            cmd.Parameters.AddWithValue("@ngay", ngay);
            cmd.Parameters.AddWithValue("@tinhtrang",tinhtrang);

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
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            string msnv = cbnv.Text;
            string tinhtrang = cbtt.Text;
            string ngay = date.Text;
            string macong = txtcc.Text;

            SqlCommand cmd = new SqlCommand("Update TTchamcong set msnv=@msnv,ngay=@ngay,tinhtrang=@tinhtrang where macong=@macong", conn);
            cmd.Parameters.AddWithValue("@macong", macong);
            cmd.Parameters.AddWithValue("@msnv", msnv);
            cmd.Parameters.AddWithValue("@ngay", ngay);
            cmd.Parameters.AddWithValue("@tinhtrang", tinhtrang);


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
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            string macong = txtcc.Text;
            SqlCommand cmd = new SqlCommand("Delete from TTchamcong  where macong=@macong", conn);
            cmd.Parameters.AddWithValue("@macong", macong);


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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnxoaall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa toàn bộ danh sách không", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
                SqlConnection conn = new SqlConnection(con_tr);
                conn.Open();


                SqlCommand cmd = new SqlCommand("Delete from TTchamcong ", conn);



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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btncn.Enabled = false;
            txtcc.Enabled = false;
            txtcc.Text = bang.CurrentRow.Cells[0].Value.ToString();
            cbnv.Text = bang.CurrentRow.Cells[1].Value.ToString();
            date.Text = bang.CurrentRow.Cells[2].Value.ToString();
            cbtt.Text = bang.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnrs_Click(object sender, EventArgs e)
        {
            btncn.Enabled = true;
            txtcc.Enabled = true;
            txtcc.Text = "";
            date.Text = DateTime.Now.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
