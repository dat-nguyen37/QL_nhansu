using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_nhân_sự
{
    public partial class trangchu : Form
    {
        string taikhoan = "", matkhau = "", email = "", quyen = "";
        public trangchu()
        {
            InitializeComponent();
        }
        public trangchu(string taikhoan, string matkhau, string email, string quyen)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.email = email;
            this.quyen = quyen;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pn.Controls.Add(childForm);
            pn.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(new timkiem());
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new DSnhanvien());
            }
            else
            {
                MessageBox.Show("Bạn không có đủ quyền hạn truy cập");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new chucvu());
            }
            else
            {
                MessageBox.Show("Bạn không có đủ quyền hạn truy cập");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (quyen == "admin")
            {
                OpenChildForm(new phongban());
            }
            else
            {
                MessageBox.Show("Bạn không có đủ quyền hạn truy cập");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (quyen == "admin")
            {
                OpenChildForm(new hopdong());
            }
            else
            {
                MessageBox.Show("Bạn không có đủ quyền hạn truy cập");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new chamcong());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tinhluong());
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qunarLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap frm = new dangnhap();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new DSnhanvien());
            }
            else
            {
                MessageBox.Show("Bạn không có đủ quyền hạn truy cập");
            }
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (quyen == "admin")
            {
                OpenChildForm(new chucvu());
            }
            else
            {
                MessageBox.Show("Bạn không có đủ quyền hạn truy cập");
            }
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new phongban());
            }
            else
            {
                MessageBox.Show("Bạn không có đủ quyền hạn truy cập");
            }
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new hopdong());
            }
            else
            {
                MessageBox.Show("Bạn không có đủ quyền hạn truy cập");
            }
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new chamcong());
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new tinhluong());
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new baocao());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new baocao());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap frm = new dangnhap();
            frm.ShowDialog();
        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            lbtk.Text = taikhoan;
            lbq.Text = quyen;
            if(quyen=="admin")
            {
                MessageBox.Show("Bạn đang đăng nhập với tư cách là admin");
            }
            else
            {
                MessageBox.Show("Bạn đang đăng nhập với tư cách là nhân viên");
            }
        }
    }
}
