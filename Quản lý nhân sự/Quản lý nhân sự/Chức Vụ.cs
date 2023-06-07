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
    public partial class chucvu : Form
    {
        public chucvu()
        {
            InitializeComponent();
        }
        bool kiemtraid()
        {
            string con_tr = "Data Source = (local); INitial Catalog = QuanLyNhanSu; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 macv FROM TTchucvu where macv='" + txtma.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Mã chức vụ đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Nhập mã chức vụ");
                txtma.Focus();
                return;
            }
            if (txtcv.Text == "")
            {
                MessageBox.Show("Nhập tên chức vụ");
                txtcv.Focus();
                return;
            }
            if (!kiemtraid())
            {
                return;
            }
            string ma = txtma.Text;
            string ten = txtcv.Text;

            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Insert into TTchucvu values(@macv,@tencv)", conn);
            cmd.Parameters.AddWithValue("@macv", ma);
            cmd.Parameters.AddWithValue("@tencv", ten);
            
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void chucvu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet2.TTchucvu' table. You can move, or remove it, as needed.
            getdata();
          
        }
        public void getdata()
        {
            this.tTchucvuTableAdapter.Fill(this.quanLyNhanSuDataSet2.TTchucvu);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Nhập mã chức vụ");
                txtma.Focus();
                return;
            }
          
           
            string macv = txtma.Text;
            string tencv = txtcv.Text;

            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Update TTchucvu set tencv=@tencv WHERE macv=@macv", conn);
            cmd.Parameters.AddWithValue("@macv", macv);
            cmd.Parameters.AddWithValue("@tencv", tencv);

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
                MessageBox.Show("Nhập mã chức vụ cần xóa");
                txtma.Focus();
                return;
            }


            string macv = txtma.Text;
            

            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("DELETE FROM TTchucvu where macv=@macv", conn);
            cmd.Parameters.AddWithValue("@macv", macv);
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

        private void button1_Click(object sender, EventArgs e)
        {

           
            
        }

        private void btnrs_Click(object sender, EventArgs e)
        {
            txtma.Enabled = true;
            txtcv.Text = "";
            txtma.Text = "";
            btnthem.Enabled = true;
        }

        private void bang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnthem.Enabled = false;
            txtma.Enabled = false;
            txtma.Text = bang.CurrentRow.Cells[0].Value.ToString();
            txtcv.Text = bang.CurrentRow.Cells[1].Value.ToString();
       
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa toàn bộ danh sách không", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
                SqlConnection conn = new SqlConnection(con_tr);
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM TTchucvu", conn);
                
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
        }
    }
}
