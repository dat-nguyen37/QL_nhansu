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
    public partial class hopdong : Form
    {
        public hopdong()
        {
            InitializeComponent();
        }

        private void hopdong_Load(object sender, EventArgs e)
        {
            
           
            getdata();
            getdatacv();
            getdatapb();

        }
        public void getdata()
        {
            this.tThopdongTableAdapter2.Fill(this.quanLyNhanSuDataSet12.TThopdong);
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
        public void getdatacv()
        {
            this.tThopdongTableAdapter.Fill(this.quanLyNhanSuDataSet4.TThopdong);
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string query = string.Format("select * from TTchucvu");
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            cbcv.DataSource = dt;
            cbcv.DisplayMember = "macv";

        }
        public void getdatapb()
        {
            this.tThopdongTableAdapter.Fill(this.quanLyNhanSuDataSet4.TThopdong);
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string query = string.Format("select * from TTphongban");
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();

            cbpb.DataSource = dt;
            cbpb.DisplayMember = "mapb";

        }
        bool kiemtramahd()
        {
            string con_tr = "Data Source = (local); INitial Catalog = QuanLyNhanSu; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 mahd FROM TThopdong where mahd='" + txtma.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Mã hợp đồng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        bool kiemtramanv()
        {
            string con_tr = "Data Source = (local); INitial Catalog = QuanLyNhanSu; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 msnv FROM TThopdong where msnv='" +cbnv.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Mã nhân viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        
        private void btnthem_Click(object sender, EventArgs e)
        {
            
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if(txtma.Text==""||txtlcb.Text=="")
            {
                MessageBox.Show("Nhập đủ thông tin");
                return;
            }
            if (!kiemtramahd())
            {
                return;
            }
            if (!kiemtramanv())
            {
                return;
            }


            string mahd = txtma.Text;
            string msnv = cbnv.Text;
            
            DateTime ngayvaolam = date.Value;
            double luongcoban = float.Parse(txtlcb.Text);
            string macv = cbcv.Text;
            string mapb = cbpb.Text;
            
            SqlCommand cmd = new SqlCommand("Insert into TThopdong values(@mahd,@msnv,@ngayvaolam,@luongcoban,@macv,@mapb)", conn);
            cmd.Parameters.AddWithValue("@mahd", mahd);
            cmd.Parameters.AddWithValue("@msnv", msnv);
            cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
            cmd.Parameters.AddWithValue("@luongcoban", luongcoban);
            cmd.Parameters.AddWithValue("@macv", macv);
            cmd.Parameters.AddWithValue("@mapb", mapb);
           
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
            if(txtma.Text=="")
            {
                MessageBox.Show("Nhập mã cần sửa");
                return;
            }

            string mahd = txtma.Text;
            string msnv = cbnv.Text;

            DateTime ngayvaolam = date.Value;
            double luongcoban = float.Parse(txtlcb.Text);
            string macv = cbcv.Text;
            string mapb = cbpb.Text;

            SqlCommand cmd = new SqlCommand("Update TThopdong set msnv=@msnv,ngayvaolam=@ngayvaolam,luongcoban=@luongcoban,macv=@macv,mapb=@mapb where mahd=@mahd", conn);
            cmd.Parameters.AddWithValue("@mahd", mahd);
            cmd.Parameters.AddWithValue("@msnv", msnv);
            cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
            cmd.Parameters.AddWithValue("@luongcoban", luongcoban);
            cmd.Parameters.AddWithValue("@macv", macv);
            cmd.Parameters.AddWithValue("@mapb", mapb);

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
            if(txtma.Text=="")
            {
                MessageBox.Show("Nhập mã hợp đồng cần xóa");
                txtma.Focus();
                return;
            }



            string mahd = txtma.Text;
            string msnv = cbnv.Text;

            DateTime ngayvaolam = date.Value;
            double luongcoban = float.Parse(txtlcb.Text);
            string macv = cbcv.Text;
            string mapb = cbpb.Text;

            SqlCommand cmd = new SqlCommand("Delete from TThopdong  where mahd=@mahd", conn);
            cmd.Parameters.AddWithValue("@mahd", mahd);
            

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
            txtma.Text = "";
            txtma.Enabled = true;
            txtlcb.Text = "";
            btnthem.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void bang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Enabled = false;
            txtma.Enabled = false;
            txtma.Text = bang.CurrentRow.Cells[0].Value.ToString();
            cbnv.Text = bang.CurrentRow.Cells[1].Value.ToString();
           
            date.Value = (DateTime)bang.CurrentRow.Cells[2].Value;
            txtlcb.Text = bang.CurrentRow.Cells[3].Value.ToString();
            cbcv.Text = bang.CurrentRow.Cells[4].Value.ToString();
            
            cbpb.Text = bang.CurrentRow.Cells[5].Value.ToString();
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa toàn bộ danh sách không", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
                SqlConnection conn = new SqlConnection(con_tr);
                conn.Open();


                SqlCommand cmd = new SqlCommand("Delete from TThopdong ", conn);



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
