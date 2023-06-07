namespace Quản_lý_nhân_sự
{
    partial class tinhluong
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
            this.bang = new System.Windows.Forms.DataGridView();
            this.quanLyNhanSuDataSet7 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet7();
            this.tTluongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTluongTableAdapter = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet7TableAdapters.TTluongTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.datekt = new System.Windows.Forms.DateTimePicker();
            this.datebd = new System.Windows.Forms.DateTimePicker();
            this.cbhsl = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnrs = new System.Windows.Forms.Button();
            this.btnxoaall = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtngaylam = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.quanLyNhanSuDataSet8 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet8();
            this.tTluongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tTluongTableAdapter1 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet8TableAdapters.TTluongTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTluongBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTluongBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bang
            // 
            this.bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang.Location = new System.Drawing.Point(12, 304);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(1016, 312);
            this.bang.TabIndex = 0;
            this.bang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_CellContentClick);
            // 
            // quanLyNhanSuDataSet7
            // 
            this.quanLyNhanSuDataSet7.DataSetName = "QuanLyNhanSuDataSet7";
            this.quanLyNhanSuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTluongBindingSource
            // 
            this.tTluongBindingSource.DataMember = "TTluong";
            this.tTluongBindingSource.DataSource = this.quanLyNhanSuDataSet7;
            // 
            // tTluongTableAdapter
            // 
            this.tTluongTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbnv);
            this.groupBox1.Controls.Add(this.datekt);
            this.groupBox1.Controls.Add(this.datebd);
            this.groupBox1.Controls.Add(this.cbhsl);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtlcb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtngaylam);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bảng lương";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(606, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Tổng ngày làm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbnv
            // 
            this.cbnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(152, 80);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(121, 28);
            this.cbnv.TabIndex = 25;
            // 
            // datekt
            // 
            this.datekt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datekt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datekt.Location = new System.Drawing.Point(429, 84);
            this.datekt.Name = "datekt";
            this.datekt.Size = new System.Drawing.Size(109, 26);
            this.datekt.TabIndex = 24;
            // 
            // datebd
            // 
            this.datebd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datebd.Location = new System.Drawing.Point(429, 40);
            this.datebd.Name = "datebd";
            this.datebd.Size = new System.Drawing.Size(109, 26);
            this.datebd.TabIndex = 23;
            // 
            // cbhsl
            // 
            this.cbhsl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhsl.FormattingEnabled = true;
            this.cbhsl.Items.AddRange(new object[] {
            "1.7",
            "1.9"});
            this.cbhsl.Location = new System.Drawing.Point(152, 128);
            this.cbhsl.Name = "cbhsl";
            this.cbhsl.Size = new System.Drawing.Size(121, 28);
            this.cbhsl.TabIndex = 22;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(742, 39);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(87, 37);
            this.btnthoat.TabIndex = 21;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnrs
            // 
            this.btnrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrs.Location = new System.Drawing.Point(631, 39);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(84, 37);
            this.btnrs.TabIndex = 20;
            this.btnrs.Text = "Mới";
            this.btnrs.UseVisualStyleBackColor = true;
            this.btnrs.Click += new System.EventHandler(this.btnrs_Click);
            // 
            // btnxoaall
            // 
            this.btnxoaall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaall.Location = new System.Drawing.Point(507, 39);
            this.btnxoaall.Name = "btnxoaall";
            this.btnxoaall.Size = new System.Drawing.Size(92, 37);
            this.btnxoaall.TabIndex = 19;
            this.btnxoaall.Text = "Xóa All";
            this.btnxoaall.UseVisualStyleBackColor = true;
            this.btnxoaall.Click += new System.EventHandler(this.btnxoaall_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(382, 39);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 37);
            this.btnxoa.TabIndex = 18;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(261, 39);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(82, 37);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(117, 39);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(103, 37);
            this.btnthem.TabIndex = 16;
            this.btnthem.Text = "Cập nhật";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(603, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lương cơ bản";
            // 
            // txtlcb
            // 
            this.txtlcb.Enabled = false;
            this.txtlcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlcb.Location = new System.Drawing.Point(742, 40);
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(100, 26);
            this.txtlcb.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Hệ số lương";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã";
            // 
            // txtngaylam
            // 
            this.txtngaylam.Enabled = false;
            this.txtngaylam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaylam.Location = new System.Drawing.Point(742, 81);
            this.txtngaylam.Name = "txtngaylam";
            this.txtngaylam.Size = new System.Drawing.Size(100, 26);
            this.txtngaylam.TabIndex = 2;
            this.txtngaylam.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtma
            // 
            this.txtma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(152, 39);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(121, 26);
            this.txtma.TabIndex = 0;
            // 
            // quanLyNhanSuDataSet8
            // 
            this.quanLyNhanSuDataSet8.DataSetName = "QuanLyNhanSuDataSet8";
            this.quanLyNhanSuDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTluongBindingSource1
            // 
            this.tTluongBindingSource1.DataMember = "TTluong";
            this.tTluongBindingSource1.DataSource = this.quanLyNhanSuDataSet8;
            // 
            // tTluongTableAdapter1
            // 
            this.tTluongTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxoaall);
            this.groupBox2.Controls.Add(this.btnrs);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 92);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // tinhluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tinhluong";
            this.Text = "Tính lương";
            this.Load += new System.EventHandler(this.tinhluong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTluongBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTluongBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bang;
        private QuanLyNhanSuDataSet7 quanLyNhanSuDataSet7;
        private System.Windows.Forms.BindingSource tTluongBindingSource;
        private QuanLyNhanSuDataSet7TableAdapters.TTluongTableAdapter tTluongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msnvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcobanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtngaylam;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.DateTimePicker datekt;
        private System.Windows.Forms.DateTimePicker datebd;
        private System.Windows.Forms.ComboBox cbhsl;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnrs;
        private System.Windows.Forms.Button btnxoaall;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.Button button1;
        private QuanLyNhanSuDataSet8 quanLyNhanSuDataSet8;
        private System.Windows.Forms.BindingSource tTluongBindingSource1;
        private QuanLyNhanSuDataSet8TableAdapters.TTluongTableAdapter tTluongTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}