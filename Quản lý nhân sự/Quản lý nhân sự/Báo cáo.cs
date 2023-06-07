using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace Quản_lý_nhân_sự
{
    public partial class baocao : Form
    {
        public baocao()
        {
            InitializeComponent();
          
        }

        private void Báo_cáo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnht_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1, ngaybd.Text, ngaykt.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
            ToExcel(bang, @"D:\", "xuatfileExcel");


        }
        private void ToExcel(DataGridView g, string duongdan, string tentap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for(int i=1;i<g.Columns.Count+1;i++)
            {
                obj.Cells[1,i] = g.Columns[i - 1].HeaderText;
            }
            for(int i=0;i<g.Rows.Count;i++)
            {
                for(int j=0;j<g.Columns.Count;j++)
                {
                    if(g.Rows[i].Cells[j].Value !=null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tentap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
