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
using System.IO;
using System.Text.RegularExpressions;


namespace Quản_lý_nhân_sự
{
    public partial class DSnhanvien : Form
    {
        public DSnhanvien()
        {
            InitializeComponent();
        }

        private void DSnhanvien_Load(object sender, EventArgs e)
        {
            
             getdata();

            

        }
        public void getdata()
        {

            this.tTnhanvienTableAdapter.Fill(this.quanLyNhanSuDataSet1.TTnhanvien);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
           

            if ((ofp.ShowDialog() == DialogResult.OK))
            {
                pictureBoxAnhDaiDien.Image = Image.FromFile(ofp.FileName);
               
                this.Text = ofp.FileName;
            }
            
        }
        bool kiemtranhap()
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Nhập mã nhân viên");
                txtma.Focus();
                return false;
            }
            if (txtten.Text == "")
            {
                MessageBox.Show("Nhập tên nhân viên");
                txtten.Focus();
                return false;
            }
            if (txtsdt.Text == "")
            {
                MessageBox.Show("Nhập số điện thoại nhân viên");
                txtsdt.Focus();
                return false;
            }
            if (txtdc.Text == "")
            {
                MessageBox.Show("Nhập địa chỉ nhân viên");
                txtdc.Focus();
                return false;
            }
            if (txtcmnd.Text == "")
            {
                MessageBox.Show("Nhập chứng minh nhân dân nhân viên");
                txtcmnd.Focus();
                return false;
            }
            if (txthocvan.Text == "")
            {
                MessageBox.Show("Nhập trình độ học vấn nhân viên");
                txtsdt.Focus();
                return false;
            }
            if (cbchuyenmon.Text == "")
            {
                MessageBox.Show("Nhập chuyên môn nhân viên");
                cbchuyenmon.Focus();
                return false;
            }
            if (pictureBoxAnhDaiDien.Image == null)
            {
                MessageBox.Show("Thêm ảnh nhân viên");

                return false;
            }

            return true;
        }
        bool kiemtraid()
        {
            string con_tr = "Data Source = (local); INitial Catalog = QuanLyNhanSu; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 msnv FROM TTnhanvien where msnv='" + txtma.Text + "'";
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
        public bool checksdt(string ac)
        {
            return Regex.IsMatch(ac, @"^\d{9,11}$");
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!kiemtranhap())
            {
                return;
            }
            if (!kiemtraid())
            {
                return;
            }
            if (!checksdt(txtsdt.Text))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
                return;
            }


            string msnv = txtma.Text;
            string hoten = txtten.Text;
            string diachi = txtdc.Text;
            DateTime namsinh = dateTimePickerNamSinh.Value;
            string sdt = txtsdt.Text;
            string cmnd = txtcmnd.Text;
            string hocvan = txthocvan.Text;
            string chuyenmon = cbchuyenmon.Text;
            string gioitinh = "Nam";

            if (radioButtonNu.Checked)
            {
                gioitinh = "Nữ";
            }
           
            byte[] hinh = ImageToByteArray(pictureBoxAnhDaiDien.Image);
            int born_year = dateTimePickerNamSinh.Value.Year;
            int this_year = DateTime.Now.Year;
            //ràng buộc dữ liệu về độ tuổi(ko cho người dùng nhập sai)
            //svv từ 10-100
            if (((this_year - born_year) < 15) || ((this_year - born_year) > 60))
            {
                MessageBox.Show("Độ tuổi phải trong khoảng từ 15-60", "Nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            
            SqlCommand cmd = new SqlCommand("Insert into TTnhanvien values(@msnv,@hoten,@gioitinh,@namsinh,@diachi,@sodienthoai,@hinh,@cmnd,@trinhdo,@chuyenmon)",conn);
            cmd.Parameters.AddWithValue("@msnv", msnv);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@namsinh", namsinh);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@sodienthoai", sdt);
            cmd.Parameters.AddWithValue("@hinh", hinh);
            cmd.Parameters.AddWithValue("@cmnd", cmnd);
            cmd.Parameters.AddWithValue("@trinhdo", hocvan);
            cmd.Parameters.AddWithValue("@chuyenmon", chuyenmon);
            if(cmd.ExecuteNonQuery() == 1)
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
        
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream mr = new MemoryStream();
            
            img.Save(mr, System.Drawing.Imaging.ImageFormat.Png);
            return mr.ToArray();
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(txtma.Text=="")
            {
                MessageBox.Show("Nhập mã nhân viên");
                txtma.Focus();
                return;
            }



            string msnv = txtma.Text;
            string hoten = txtten.Text;
            string diachi = txtdc.Text;
            DateTime namsinh = dateTimePickerNamSinh.Value;
            string sodienthoai = txtsdt.Text;
            string cmnd = txtcmnd.Text;
            string trinhdo = txthocvan.Text;
            string chuyenmon = cbchuyenmon.Text;
            string gioitinh = "Nam";

            if (radioButtonNu.Checked)
            {
                gioitinh = "Nữ";
            }

            byte[] hinh = ImageToByteArray(pictureBoxAnhDaiDien.Image);

            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Update TTnhanvien set hoten=@hoten,gioitinh=@gioitinh,namsinh=@namsinh,diachi=@diachi,sodienthoai=@sodienthoai,hinh=@hinh,cmnd=@cmnd,trinhdo=@trinhdo,chuyenmon=@chuyenmon WHERE msnv=@msnv", conn);
            cmd.Parameters.AddWithValue("@msnv", msnv);
            cmd.Parameters.AddWithValue("@hoten", hoten);
            cmd.Parameters.AddWithValue("@gioitinh", gioitinh);
            cmd.Parameters.AddWithValue("@namsinh", namsinh);
            cmd.Parameters.AddWithValue("@diachi", diachi);
            cmd.Parameters.AddWithValue("@sodienthoai", sodienthoai);
            cmd.Parameters.AddWithValue("@hinh", hinh);
            cmd.Parameters.AddWithValue("@cmnd", cmnd);
            cmd.Parameters.AddWithValue("@trinhdo", trinhdo);
            cmd.Parameters.AddWithValue("@chuyenmon", chuyenmon);
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
                MessageBox.Show("Nhập mã nhân viên cần xóa");
                txtma.Focus();
                return;
            }
            string msnv = txtma.Text;
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM TTnhanvien where msnv=" + msnv, conn);
            

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Xóa thành công");
                getdata();
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
            conn.Close();
        }
        private void bang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
          




        }

        private void bang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Enabled = false;
            txtma.Text = bang.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = bang.CurrentRow.Cells[1].Value.ToString();
            if ((bang.CurrentRow.Cells[2].Value.ToString() == "Nam"))
            {

                radioButtonNam.Checked = true;
                radioButtonNu.Checked = false;
            }
            else
            {
                radioButtonNam.Checked = false;
                radioButtonNu.Checked = true;
            }
            dateTimePickerNamSinh.Value = (DateTime)bang.CurrentRow.Cells[3].Value;
            txtdc.Text = bang.CurrentRow.Cells[4].Value.ToString();
            txtsdt.Text = bang.CurrentRow.Cells[5].Value.ToString();
            byte[] pic;
            pic = (byte[])bang.CurrentRow.Cells[6].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxAnhDaiDien.Image = Image.FromStream(picture);
            txtcmnd.Text = bang.CurrentRow.Cells[7].Value.ToString();
            txthocvan.Text = bang.CurrentRow.Cells[8].Value.ToString();
            cbchuyenmon.Text = bang.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnrs_Click(object sender, EventArgs e)
        {
            string con_tr = "Data Source=(local); INitial Catalog=QuanLyNhanSu; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string query = string.Format("select * from TTnhanvien ",conn);
            SqlCommand com = new SqlCommand(query, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            bang.DataSource = dt;
            txtma.Text = "";
            txtten.Text = "";
            txtdc.Text = "";
            txtsdt.Text = "";
            radioButtonNam.Checked = false;
            radioButtonNu.Checked = false;
            txtdc.Text = "";
            txtcmnd.Text = "";
            txthocvan.Text = "";
            cbchuyenmon.Text = "";
            txtma.Enabled = true;
        }

        private void pictk_Click(object sender, EventArgs e)
        {
            
        }

        private void btnxuat_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("DELETE FROM TTnhanvien " , conn);


                if (cmd.ExecuteNonQuery() > -1)
                {
                    MessageBox.Show("Xóa thành công");
                    getdata();
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông báo");
                }
                conn.Close();
            }
        }
    }
}

    

