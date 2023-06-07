namespace Quản_lý_nhân_sự
{
    partial class chamcong
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
            this.macongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msnvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTchamcongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanSuDataSet6 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet6();
            this.quanLyNhanSuDataSet5 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet5();
            this.tTchamcongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTchamcongTableAdapter = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet5TableAdapters.TTchamcongTableAdapter();
            this.tTchamcongTableAdapter1 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet6TableAdapters.TTchamcongTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrs = new System.Windows.Forms.Button();
            this.btnxoaall = new System.Windows.Forms.Button();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btncn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.cbtt = new System.Windows.Forms.ComboBox();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTchamcongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTchamcongBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bang
            // 
            this.bang.AutoGenerateColumns = false;
            this.bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macongDataGridViewTextBoxColumn,
            this.msnvDataGridViewTextBoxColumn,
            this.ngayDataGridViewTextBoxColumn,
            this.tinhtrangDataGridViewTextBoxColumn});
            this.bang.DataSource = this.tTchamcongBindingSource1;
            this.bang.Location = new System.Drawing.Point(12, 209);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(1016, 407);
            this.bang.TabIndex = 1;
            this.bang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // macongDataGridViewTextBoxColumn
            // 
            this.macongDataGridViewTextBoxColumn.DataPropertyName = "macong";
            this.macongDataGridViewTextBoxColumn.HeaderText = "macong";
            this.macongDataGridViewTextBoxColumn.Name = "macongDataGridViewTextBoxColumn";
            // 
            // msnvDataGridViewTextBoxColumn
            // 
            this.msnvDataGridViewTextBoxColumn.DataPropertyName = "msnv";
            this.msnvDataGridViewTextBoxColumn.HeaderText = "msnv";
            this.msnvDataGridViewTextBoxColumn.Name = "msnvDataGridViewTextBoxColumn";
            // 
            // ngayDataGridViewTextBoxColumn
            // 
            this.ngayDataGridViewTextBoxColumn.DataPropertyName = "ngay";
            this.ngayDataGridViewTextBoxColumn.HeaderText = "ngay";
            this.ngayDataGridViewTextBoxColumn.Name = "ngayDataGridViewTextBoxColumn";
            // 
            // tinhtrangDataGridViewTextBoxColumn
            // 
            this.tinhtrangDataGridViewTextBoxColumn.DataPropertyName = "tinhtrang";
            this.tinhtrangDataGridViewTextBoxColumn.HeaderText = "tinhtrang";
            this.tinhtrangDataGridViewTextBoxColumn.Name = "tinhtrangDataGridViewTextBoxColumn";
            // 
            // tTchamcongBindingSource1
            // 
            this.tTchamcongBindingSource1.DataMember = "TTchamcong";
            this.tTchamcongBindingSource1.DataSource = this.quanLyNhanSuDataSet6;
            // 
            // quanLyNhanSuDataSet6
            // 
            this.quanLyNhanSuDataSet6.DataSetName = "QuanLyNhanSuDataSet6";
            this.quanLyNhanSuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyNhanSuDataSet5
            // 
            this.quanLyNhanSuDataSet5.DataSetName = "QuanLyNhanSuDataSet5";
            this.quanLyNhanSuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tTchamcongBindingSource
            // 
            this.tTchamcongBindingSource.DataMember = "TTchamcong";
            this.tTchamcongBindingSource.DataSource = this.quanLyNhanSuDataSet5;
            // 
            // tTchamcongTableAdapter
            // 
            this.tTchamcongTableAdapter.ClearBeforeFill = true;
            // 
            // tTchamcongTableAdapter1
            // 
            this.tTchamcongTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrs);
            this.groupBox1.Controls.Add(this.btnxoaall);
            this.groupBox1.Controls.Add(this.txtcc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btncn);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.cbtt);
            this.groupBox1.Controls.Add(this.cbnv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "s";
            this.groupBox1.Text = "Chấm Công";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnrs
            // 
            this.btnrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrs.Location = new System.Drawing.Point(558, 124);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(75, 32);
            this.btnrs.TabIndex = 14;
            this.btnrs.Text = "Mới";
            this.btnrs.UseVisualStyleBackColor = true;
            this.btnrs.Click += new System.EventHandler(this.btnrs_Click);
            // 
            // btnxoaall
            // 
            this.btnxoaall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaall.Location = new System.Drawing.Point(667, 124);
            this.btnxoaall.Name = "btnxoaall";
            this.btnxoaall.Size = new System.Drawing.Size(75, 32);
            this.btnxoaall.TabIndex = 13;
            this.btnxoaall.Text = "Xóa All";
            this.btnxoaall.UseVisualStyleBackColor = true;
            this.btnxoaall.Click += new System.EventHandler(this.btnxoaall_Click);
            // 
            // txtcc
            // 
            this.txtcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcc.Location = new System.Drawing.Point(130, 38);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(100, 26);
            this.txtcc.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã chấm công";
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(773, 124);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 32);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(454, 124);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 32);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(347, 124);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 32);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btncn
            // 
            this.btncn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncn.Location = new System.Drawing.Point(240, 124);
            this.btncn.Name = "btncn";
            this.btncn.Size = new System.Drawing.Size(88, 32);
            this.btncn.TabIndex = 7;
            this.btncn.Text = "Cập nhật";
            this.btncn.UseVisualStyleBackColor = true;
            this.btncn.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(130, 81);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 26);
            this.date.TabIndex = 6;
            this.date.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbtt
            // 
            this.cbtt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtt.FormattingEnabled = true;
            this.cbtt.Items.AddRange(new object[] {
            "Vắng",
            "Đi làm"});
            this.cbtt.Location = new System.Drawing.Point(636, 36);
            this.cbtt.Name = "cbtt";
            this.cbtt.Size = new System.Drawing.Size(121, 28);
            this.cbtt.TabIndex = 5;
            // 
            // cbnv
            // 
            this.cbnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(374, 35);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(121, 28);
            this.cbnv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tình trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // chamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 628);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chamcong";
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.chamcong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTchamcongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTchamcongBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.ComboBox cbtt;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bang;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btncn;
        private QuanLyNhanSuDataSet5 quanLyNhanSuDataSet5;
        private System.Windows.Forms.BindingSource tTchamcongBindingSource;
        private QuanLyNhanSuDataSet5TableAdapters.TTchamcongTableAdapter tTchamcongTableAdapter;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtcc;
        private System.Windows.Forms.Label label4;
        private QuanLyNhanSuDataSet6 quanLyNhanSuDataSet6;
        private System.Windows.Forms.BindingSource tTchamcongBindingSource1;
        private QuanLyNhanSuDataSet6TableAdapters.TTchamcongTableAdapter tTchamcongTableAdapter1;
        private System.Windows.Forms.Button btnxoaall;
        private System.Windows.Forms.DataGridViewTextBoxColumn macongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msnvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnrs;
    }
}