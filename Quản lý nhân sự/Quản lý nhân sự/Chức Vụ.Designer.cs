namespace Quản_lý_nhân_sự
{
    partial class chucvu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcv = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnrs = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.bang = new System.Windows.Forms.DataGridView();
            this.macvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTchucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanSuDataSet2 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet2();
            this.tTchucvuTableAdapter = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet2TableAdapters.TTchucvuTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTchucvuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcv);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên chức vụ";
            // 
            // txtcv
            // 
            this.txtcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcv.Location = new System.Drawing.Point(132, 65);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(147, 24);
            this.txtcv.TabIndex = 1;
            // 
            // txtma
            // 
            this.txtma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(132, 19);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(147, 24);
            this.txtma.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnrs);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(296, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(452, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnrs
            // 
            this.btnrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrs.Location = new System.Drawing.Point(374, 37);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(63, 45);
            this.btnrs.TabIndex = 3;
            this.btnrs.Text = "Mới";
            this.btnrs.UseVisualStyleBackColor = true;
            this.btnrs.Click += new System.EventHandler(this.btnrs_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(132, 37);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(62, 45);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(217, 37);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(62, 45);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(31, 37);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(66, 45);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // bang
            // 
            this.bang.AutoGenerateColumns = false;
            this.bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macvDataGridViewTextBoxColumn,
            this.tencvDataGridViewTextBoxColumn});
            this.bang.DataSource = this.tTchucvuBindingSource;
            this.bang.Location = new System.Drawing.Point(12, 242);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(537, 196);
            this.bang.TabIndex = 2;
            this.bang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_CellContentClick);
            // 
            // macvDataGridViewTextBoxColumn
            // 
            this.macvDataGridViewTextBoxColumn.DataPropertyName = "macv";
            this.macvDataGridViewTextBoxColumn.HeaderText = "Mã chức vụ";
            this.macvDataGridViewTextBoxColumn.Name = "macvDataGridViewTextBoxColumn";
            // 
            // tencvDataGridViewTextBoxColumn
            // 
            this.tencvDataGridViewTextBoxColumn.DataPropertyName = "tencv";
            this.tencvDataGridViewTextBoxColumn.HeaderText = "Tên chức vụ";
            this.tencvDataGridViewTextBoxColumn.Name = "tencvDataGridViewTextBoxColumn";
            // 
            // tTchucvuBindingSource
            // 
            this.tTchucvuBindingSource.DataMember = "TTchucvu";
            this.tTchucvuBindingSource.DataSource = this.quanLyNhanSuDataSet2;
            // 
            // quanLyNhanSuDataSet2
            // 
            this.quanLyNhanSuDataSet2.DataSetName = "QuanLyNhanSuDataSet2";
            this.quanLyNhanSuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTchucvuTableAdapter
            // 
            this.tTchucvuTableAdapter.ClearBeforeFill = true;
            // 
            // chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chucvu";
            this.Text = "Chức_Vụ";
            this.Load += new System.EventHandler(this.chucvu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTchucvuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnrs;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView bang;
        private QuanLyNhanSuDataSet2 quanLyNhanSuDataSet2;
        private System.Windows.Forms.BindingSource tTchucvuBindingSource;
        private QuanLyNhanSuDataSet2TableAdapters.TTchucvuTableAdapter tTchucvuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn macvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}