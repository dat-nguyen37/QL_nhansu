namespace Quản_lý_nhân_sự
{
    partial class hopdong
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
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Quản_lý_nhân_sự.DataSet2();
            this.tThopdongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanSuDataSet4 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet4();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnrs = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbcv = new System.Windows.Forms.ComboBox();
            this.cbpb = new System.Windows.Forms.ComboBox();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.tThopdongTableAdapter = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet4TableAdapters.TThopdongTableAdapter();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Quản_lý_nhân_sự.DataSet2TableAdapters.DataTable1TableAdapter();
            this.quanLyNhanSuDataSet11 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet11();
            this.tThopdongBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tThopdongTableAdapter1 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet11TableAdapters.TThopdongTableAdapter();
            this.quanLyNhanSuDataSet12 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet12();
            this.tThopdongBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tThopdongTableAdapter2 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet12TableAdapters.TThopdongTableAdapter();
            this.mahdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msnvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayvaolamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcobanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.macvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mapbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThopdongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet4)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThopdongBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThopdongBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bang
            // 
            this.bang.AutoGenerateColumns = false;
            this.bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahdDataGridViewTextBoxColumn,
            this.msnvDataGridViewTextBoxColumn,
            this.ngayvaolamDataGridViewTextBoxColumn,
            this.luongcobanDataGridViewTextBoxColumn,
            this.macvDataGridViewTextBoxColumn,
            this.mapbDataGridViewTextBoxColumn});
            this.bang.DataSource = this.tThopdongBindingSource2;
            this.bang.Location = new System.Drawing.Point(12, 302);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(1016, 314);
            this.bang.TabIndex = 5;
            this.bang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_CellContentClick);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tThopdongBindingSource
            // 
            this.tThopdongBindingSource.DataMember = "TThopdong";
            this.tThopdongBindingSource.DataSource = this.quanLyNhanSuDataSet4;
            // 
            // quanLyNhanSuDataSet4
            // 
            this.quanLyNhanSuDataSet4.DataSetName = "QuanLyNhanSuDataSet4";
            this.quanLyNhanSuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnrs);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 96);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(448, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(608, 29);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(64, 45);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnrs
            // 
            this.btnrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrs.Location = new System.Drawing.Point(534, 29);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(66, 45);
            this.btnrs.TabIndex = 3;
            this.btnrs.Text = "Mới";
            this.btnrs.UseVisualStyleBackColor = true;
            this.btnrs.Click += new System.EventHandler(this.btnrs_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(266, 29);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(67, 45);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(354, 29);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 45);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(176, 29);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(68, 45);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbcv);
            this.groupBox1.Controls.Add(this.cbpb);
            this.groupBox1.Controls.Add(this.cbnv);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtlcb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hợp đồng";
            // 
            // cbcv
            // 
            this.cbcv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcv.FormattingEnabled = true;
            this.cbcv.Location = new System.Drawing.Point(658, 66);
            this.cbcv.Name = "cbcv";
            this.cbcv.Size = new System.Drawing.Size(147, 21);
            this.cbcv.TabIndex = 15;
            // 
            // cbpb
            // 
            this.cbpb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpb.FormattingEnabled = true;
            this.cbpb.Location = new System.Drawing.Point(658, 108);
            this.cbpb.Name = "cbpb";
            this.cbpb.Size = new System.Drawing.Size(147, 21);
            this.cbpb.TabIndex = 14;
            // 
            // cbnv
            // 
            this.cbnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(186, 71);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(147, 21);
            this.cbnv.TabIndex = 13;
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(186, 110);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(147, 20);
            this.date.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày vào làm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(464, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(464, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lương cơ bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã chức vụ";
            // 
            // txtlcb
            // 
            this.txtlcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlcb.Location = new System.Drawing.Point(658, 27);
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(147, 24);
            this.txtlcb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã hợp đồng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // txtma
            // 
            this.txtma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(186, 26);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(147, 24);
            this.txtma.TabIndex = 0;
            // 
            // tThopdongTableAdapter
            // 
            this.tThopdongTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // quanLyNhanSuDataSet11
            // 
            this.quanLyNhanSuDataSet11.DataSetName = "QuanLyNhanSuDataSet11";
            this.quanLyNhanSuDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tThopdongBindingSource1
            // 
            this.tThopdongBindingSource1.DataMember = "TThopdong";
            this.tThopdongBindingSource1.DataSource = this.quanLyNhanSuDataSet11;
            // 
            // tThopdongTableAdapter1
            // 
            this.tThopdongTableAdapter1.ClearBeforeFill = true;
            // 
            // quanLyNhanSuDataSet12
            // 
            this.quanLyNhanSuDataSet12.DataSetName = "QuanLyNhanSuDataSet12";
            this.quanLyNhanSuDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tThopdongBindingSource2
            // 
            this.tThopdongBindingSource2.DataMember = "TThopdong";
            this.tThopdongBindingSource2.DataSource = this.quanLyNhanSuDataSet12;
            // 
            // tThopdongTableAdapter2
            // 
            this.tThopdongTableAdapter2.ClearBeforeFill = true;
            // 
            // mahdDataGridViewTextBoxColumn
            // 
            this.mahdDataGridViewTextBoxColumn.DataPropertyName = "mahd";
            this.mahdDataGridViewTextBoxColumn.HeaderText = "mahd";
            this.mahdDataGridViewTextBoxColumn.Name = "mahdDataGridViewTextBoxColumn";
            // 
            // msnvDataGridViewTextBoxColumn
            // 
            this.msnvDataGridViewTextBoxColumn.DataPropertyName = "msnv";
            this.msnvDataGridViewTextBoxColumn.HeaderText = "msnv";
            this.msnvDataGridViewTextBoxColumn.Name = "msnvDataGridViewTextBoxColumn";
            // 
            // ngayvaolamDataGridViewTextBoxColumn
            // 
            this.ngayvaolamDataGridViewTextBoxColumn.DataPropertyName = "ngayvaolam";
            this.ngayvaolamDataGridViewTextBoxColumn.HeaderText = "ngayvaolam";
            this.ngayvaolamDataGridViewTextBoxColumn.Name = "ngayvaolamDataGridViewTextBoxColumn";
            // 
            // luongcobanDataGridViewTextBoxColumn
            // 
            this.luongcobanDataGridViewTextBoxColumn.DataPropertyName = "luongcoban";
            this.luongcobanDataGridViewTextBoxColumn.HeaderText = "luongcoban";
            this.luongcobanDataGridViewTextBoxColumn.Name = "luongcobanDataGridViewTextBoxColumn";
            // 
            // macvDataGridViewTextBoxColumn
            // 
            this.macvDataGridViewTextBoxColumn.DataPropertyName = "macv";
            this.macvDataGridViewTextBoxColumn.HeaderText = "macv";
            this.macvDataGridViewTextBoxColumn.Name = "macvDataGridViewTextBoxColumn";
            // 
            // mapbDataGridViewTextBoxColumn
            // 
            this.mapbDataGridViewTextBoxColumn.DataPropertyName = "mapb";
            this.mapbDataGridViewTextBoxColumn.HeaderText = "mapb";
            this.mapbDataGridViewTextBoxColumn.Name = "mapbDataGridViewTextBoxColumn";
            // 
            // hopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 628);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hopdong";
            this.Text = "Hợp_đồng";
            this.Load += new System.EventHandler(this.hopdong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThopdongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThopdongBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tThopdongBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnrs;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private QuanLyNhanSuDataSet4 quanLyNhanSuDataSet4;
        private System.Windows.Forms.BindingSource tThopdongBindingSource;
        private QuanLyNhanSuDataSet4TableAdapters.TThopdongTableAdapter tThopdongTableAdapter;
        private System.Windows.Forms.ComboBox cbcv;
        private System.Windows.Forms.ComboBox cbpb;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private QuanLyNhanSuDataSet11 quanLyNhanSuDataSet11;
        private System.Windows.Forms.BindingSource tThopdongBindingSource1;
        private QuanLyNhanSuDataSet11TableAdapters.TThopdongTableAdapter tThopdongTableAdapter1;
        private QuanLyNhanSuDataSet12 quanLyNhanSuDataSet12;
        private System.Windows.Forms.BindingSource tThopdongBindingSource2;
        private QuanLyNhanSuDataSet12TableAdapters.TThopdongTableAdapter tThopdongTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msnvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayvaolamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcobanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn macvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mapbDataGridViewTextBoxColumn;
    }
}