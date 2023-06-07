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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        int dem;
        SqlConnection cn = new SqlConnection(@"Data Source = (local); INitial Catalog = QuanLyNhanSu; Integrated Security = SSPI");
        private void Form1_Load(object sender, EventArgs e)
        {
           txttk.Text= Properties.Settings.Default.taikhoan;
           txtmk.Text= Properties.Settings.Default.matkhau;
            if(Properties.Settings.Default.taikhoan !="")
            {
                checkBox1.Checked = true;
            }
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            if (txttk.Text == ("") || txtmk.Text == (""))
            {

                txttk.Focus();
                txtmk.Focus();
                lb.ForeColor = Color.Red;
                lb.Text = "Chưa nhập tài khoản hoặc mật khẩu";
                return;
            }
            dem++;
            cn.Open();
            string sql = "select * from login where taikhoan='" + txttk.Text + "'and matkhau='" + txtmk.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >0)
            {

                lb.ForeColor = Color.Blue;
                lb.Text = "Đăng nhập thành công";


                this.Hide();

                trangchu frmtc = new trangchu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                frmtc.ShowDialog();
                this.Close();

            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Sai tài khoản hoặc mật khẩu";

            }
            if (dem == 3)
            {
                MessageBox.Show("Nhập sai quá 3 lần! Thoát chương trình", "Thông báo");
                Application.Exit();
            }
            cn.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txttk.Text != "" && txtmk.Text != "")
            {
                if(checkBox1.Checked==true)
                {
                    string tk = txttk.Text;
                    string mk = txtmk.Text;
                    Properties.Settings.Default.taikhoan = tk;
                    Properties.Settings.Default.matkhau = mk;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void phide_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '*')
            {
                peye.BringToFront();

                txtmk.PasswordChar = '\0';
            }
        }

        private void pyey_Click(object sender, EventArgs e)
        {

            if (txtmk.PasswordChar == '\0')
            {
               phide.BringToFront();
                
                txtmk.PasswordChar = '*';
            }
        }

        private void linkdk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dangki frm = new dangki();
            frm.ShowDialog();
            this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
