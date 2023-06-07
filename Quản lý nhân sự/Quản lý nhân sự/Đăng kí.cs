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
using System.Text.RegularExpressions;

namespace Quản_lý_nhân_sự
{
    public partial class dangki : Form
    {
        public dangki()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-z0-9]{6,15}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)");
        }
        bool kiemtraemail()
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 email FROM login where email='" + txtemaildk.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Email đã đăng kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        bool kiemtratentk()
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 taikhoan FROM login where taikhoan='" + txttkdk.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Tên tài khoản đã đăng kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        SqlConnection cn = new SqlConnection(@"Data Source = (local); INitial Catalog = QuanLyXeMay; Integrated Security = SSPI");
        private void btndk_Click(object sender, EventArgs e)
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            if (txttkdk.Text == ("") || txtmkdk.Text == ("") || txtxndk.Text == ("") || txtemaildk.Text == (""))
            {
                txttkdk.Focus();
                txtmkdk.Focus();
                txtxndk.Focus();
                txtemaildk.Focus();
                MessageBox.Show("Nhập đủ thông tin");
                return;
            }
           if (txtmkdk.Text != txtxndk.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            

                string taikhoan = txttkdk.Text;
                string matkhau = txttkdk.Text;
                string email = txtemaildk.Text;
                if (!checkAccount(taikhoan))
                {
                    MessageBox.Show("Tài khoản phải đủ từ 6-15 kí tự và bao gồm các chữ cái từ a-z");
                    return;
                }
                if (!CheckEmail(email))
                {
                    MessageBox.Show("Email không đúng định dạng");
                    return;
                }
                if (!kiemtraemail())
                {

                    return;
                }
                if (!kiemtratentk())
                {

                    return;
                }
                string Query = $"INSERT INTO login(taikhoan,matkhau,email,quyen) VALUES('{taikhoan}', '{matkhau}','{email}','nhanvien')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int s = cmd.ExecuteNonQuery();
                if (s == 1)
                {
                    MessageBox.Show("Đăng kí thành công");
                }
                else
                {
                    MessageBox.Show("Lôi");
                }
            
            conn.Close();

        }

        private void lbdn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dangnhap frm = new dangnhap();
            frm.ShowDialog();
            this.Close();
        }
    }
}
