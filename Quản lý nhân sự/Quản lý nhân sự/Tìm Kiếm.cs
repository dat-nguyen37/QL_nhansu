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
    public partial class timkiem : Form
    {
        public timkiem()
        {
            InitializeComponent();
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            
            if (txttk.Text == "")
            {
                MessageBox.Show("Nhập thông tin tìm kiếm");
                txttk.Focus();
                return;
            }
            string tk = txttk.Text;
            
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (rdma.Checked)
            {
               
                string query = string.Format("select * from TTnhanvien where msnv like N'%{0}%'", tk);
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bang.DataSource = dt;
                if (bang.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin");
                }
                else
                {
                    MessageBox.Show("Tìm thấy thông tin phù hợp");
                    
                }
            }
            else if (rdten.Checked)
            {
                string query = string.Format("select * from TTnhanvien where hoten like N'%{0}%'", tk);
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bang.DataSource = dt;
                if (bang.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin");
                }
                else
                {
                    MessageBox.Show("Tìm thấy thông tin phù hợp");
                }
            }
            else if (rđc.Checked)
            {
                string query = string.Format("select * from TTnhanvien where diachi like N'%{0}%'", tk);
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bang.DataSource = dt;
                if (bang.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin");
                }
                else
                {
                    MessageBox.Show("Tìm thấy thông tin phù hợp");
                }
            }
           else if (rdhv.Checked)
            {
                string query = string.Format("select * from TTnhanvien where trinhdo like N'%{0}%'", tk);
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bang.DataSource = dt;
                if (bang.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin");
                }
                else
                {
                    MessageBox.Show("Tìm thấy thông tin phù hợp");
                }
            }
            else if (rdcm.Checked)
            {
                string query = string.Format("select * from TTnhanvien where chuyenmon like N'%{0}%'", tk);
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bang.DataSource = dt;
                if (bang.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin");
                }
                else
                {
                    MessageBox.Show("Tìm thấy thông tin phù hợp");
                }
            }
            else if(rdhd.Checked)
            {
                string query = string.Format("select mahd,hoten,ngayvaolam,luongcoban,tencv,tenpb from TThopdong,TTnhanvien,TTchucvu,TTphongban where  TTnhanvien.msnv=TThopdong.msnv and TTchucvu.macv=TThopdong.macv and TThopdong.mapb=TTphongban.mapb and hoten like N'%{0}%'", tk);
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bang.DataSource = dt;
                if (bang.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin");
                }
                else
                {
                    MessageBox.Show("Tìm thấy thông tin phù hợp");
                }
            }
            else if(rdcc.Checked)
            {
                string query = string.Format("select * from TTchamcong where ngay ='"+tk+"'");
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bang.DataSource = dt;
                if (bang.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin");
                }
                else
                {
                    MessageBox.Show("Tìm thấy thông tin phù hợp");
                }
            }
            else if (rdcv.Checked)
            {
                string query = string.Format("select * from TTchucvu where macv ='" + tk + "'");
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bang.DataSource = dt;
                if (bang.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin");
                }
                else
                {
                    MessageBox.Show("Tìm thấy thông tin phù hợp");
                }
            }
            else if (rdpb.Checked)
            {
                string query = string.Format("select * from TTphongban where mapb ='" + tk + "'");
                SqlCommand com = new SqlCommand(query, conn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                bang.DataSource = dt;
                if (bang.Rows[0].Cells[0].Value == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin");
                }
                else
                {
                    MessageBox.Show("Tìm thấy thông tin phù hợp");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

       

        private void timkiem_Load(object sender, EventArgs e)
        {
            
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string query = string.Format("Select hoten,tongtien from TTluong,TTnhanvien where TTluong.msnv=TTnhanvien.msnv and tongtien = (SELECT MAX(tongtien) FROM TTluong ) ");
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            bang.DataSource = dt;
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string query = string.Format("Select hoten,tongtien from TTluong,TTnhanvien where TTluong.msnv=TTnhanvien.msnv and tongtien = (SELECT MIN(tongtien) FROM TTluong ) ");
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            bang.DataSource = dt;
           
        }

        private void rdhd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string query = string.Format("Select hoten,tongtien from TTluong,TTnhanvien Where TTluong.msnv=TTnhanvien.msnv order by tongtien DESC  ");
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            bang.DataSource = dt;
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
