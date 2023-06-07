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
    public partial class tinhluong : Form
    {
        public tinhluong()
        {
            InitializeComponent();
        }

        private void tinhluong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyNhanSuDataSet8.TTluong' table. You can move, or remove it, as needed.
            // this.tTluongTableAdapter1.Fill(this.quanLyNhanSuDataSet8.TTluong);

            txtngaylam.Text = "0";
           
            getdatasv();
            getdatalcb();
            getdata();
           

        }
       
        public void getdata()
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLynhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from TTluong ";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();
            bang.DataSource = dt;
           
        }
        public void getdatasv()
        {
            
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
            cbnv.ValueMember = "msnv";
            

        }

        
        public void getdatalcb()
    {
       
        string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
        SqlConnection conn = new SqlConnection(con_tr);
        conn.Open();
        
        string query = String.Format("Select * from TThopdong");
        SqlCommand com = new SqlCommand(query, conn);
        com.CommandType = CommandType.Text;
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        conn.Close();

        cbnv.DataSource = dt;
        cbnv.DisplayMember = "msnv";
        txtlcb.DataBindings.Clear();
        txtlcb.DataBindings.Add("Text", cbnv.DataSource, "luongcoban");

    }
    private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string nv = cbnv.Text;
            DateTime ngaybd = datebd.Value;
            DateTime ngaykt = datekt.Value;
            string Query = "Select Count(tinhtrang) as Ngay from TTchamcong Where msnv=" + nv + " and tinhtrang=N'Đi làm' and ngay >='" + ngaybd + "'  and ngay <= '" + ngaykt + "'  Group By msnv ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                txtngaylam.Text = rd["Ngay"].ToString();
            }
            conn.Close();
        }
        bool kiemtraid()
        {
            string con_tr = "Data Source = (local); INitial Catalog = QuanLyNhanSu; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 msnv FROM TTluong where msnv='" + cbnv.Text + "'";
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
        bool kiemtraml()
        {
            string con_tr = "Data Source = (local); INitial Catalog = QuanLyNhanSu; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 maluong FROM TTluong where maluong='" + txtma.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Mã lương đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (txtma.Text == "" || cbhsl.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return;
            }
            if (!kiemtraml())
            {
                return;
            }
            if (!kiemtraid())
            {
                return;
            }
            if (txtngaylam.Text == "0")
            {
                MessageBox.Show("Không tìm thấy ngày công");
                return;
            }

           
                string maluong = txtma.Text;
                string msnv = cbnv.Text;

                DateTime ngaybd = datebd.Value;
                DateTime ngaykt = datekt.Value;
                double luongcoban = double.Parse(txtlcb.Text);
                double hesoluong = double.Parse(cbhsl.Text);
                string songaylam = txtngaylam.Text;


                string sql = "insert into TTluong(maluong,msnv,ngaybd,ngaykt,hesoluong,luongcoban,songaylam) values('" + maluong + "','" + msnv + "','" + ngaybd + "','" + ngaykt + "','" + hesoluong + "','" + luongcoban + "','" + songaylam + "') ";
                SqlCommand com = new SqlCommand(sql, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                if (da.Fill(dt) > -1)
                {
                    MessageBox.Show("Cập nhật thành công");
                    getdata();
                }
                else
                {
                    MessageBox.Show("Lỗi");
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
                MessageBox.Show("Nhập mã lương cần sửa");
                return;
            }
            
            string maluong = txtma.Text;
            string msnv = cbnv.Text;

            DateTime ngaybd = datebd.Value;
            DateTime ngaykt = datekt.Value;
            double luongcoban = double.Parse(txtlcb.Text);
            double hesoluong = double.Parse(cbhsl.Text);
            string songaylam = txtngaylam.Text;

            string sql = "Update TTluong set msnv='"+msnv+"',ngaybd='"+ngaybd+"',ngaykt='"+ngaykt+"',hesoluong='"+hesoluong+"',luongcoban='"+luongcoban+"',songaylam='"+songaylam+"' Where maluong='"+maluong+"' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int s1 = cmd.ExecuteNonQuery();
            if (s1==1)
            {
                MessageBox.Show("Sửa thành công");
                getdata();
            }
            else
            {
                MessageBox.Show("Lỗi");
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
                MessageBox.Show("Nhập mã lương cần xóa");
                return;
            }

            string maluong = txtma.Text;
           

            string sql = "Delete from TTluong Where maluong='" + maluong + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int s1 = cmd.ExecuteNonQuery();
            if (s1 == 1)
            {
                MessageBox.Show("Xóa thành công");
                getdata();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
            conn.Close();

        }

        private void btnxoaall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa toàn bộ danh sách không", "Thông báo..", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
                SqlConnection conn = new SqlConnection(con_tr);
                conn.Open();

                string maluong = txtma.Text;


                string sql = "Delete from TTluong  ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int s1 = cmd.ExecuteNonQuery();
                if (s1 >-1)
                {
                    MessageBox.Show("Xóa thành công");
                    getdata();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
                conn.Close();
            }
        }

        private void btnrs_Click(object sender, EventArgs e)
        {
            txtma.Enabled = true;
            btnthem.Enabled = true;
            txtma.Text = "";
            txtngaylam.Text = "0";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Enabled = false;
            btnthem.Enabled = false;
            txtma.Text = bang.CurrentRow.Cells[0].Value.ToString();
            cbnv.Text = bang.CurrentRow.Cells[1].Value.ToString();

            datebd.Value = (DateTime)bang.CurrentRow.Cells[2].Value;
            datekt.Value = (DateTime)bang.CurrentRow.Cells[3].Value;
            cbhsl.Text = bang.CurrentRow.Cells[4].Value.ToString();
            txtlcb.Text = bang.CurrentRow.Cells[5].Value.ToString();
            txtngaylam.Text = bang.CurrentRow.Cells[6].Value.ToString();

            
        }
    }
}
