namespace Quản_lý_nhân_sự
{
    partial class DSnhanvien
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
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.dateTimePickerNamSinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bang = new System.Windows.Forms.DataGridView();
            this.msnvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenmonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTnhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyNhanSuDataSet1 = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet1();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txthocvan = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.cbchuyenmon = new System.Windows.Forms.ComboBox();
            this.btnrs = new System.Windows.Forms.Button();
            this.btnxuat = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.quanLyNhanSuDataSet = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet();
            this.quanLyNhanSuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTnhanvienTableAdapter = new Quản_lý_nhân_sự.QuanLyNhanSuDataSet1TableAdapters.TTnhanvienTableAdapter();
            this.pictureBoxAnhDaiDien = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTnhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnhDaiDien)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(794, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Thông tin nhân viên";
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(931, 125);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNu.TabIndex = 22;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Location = new System.Drawing.Point(854, 125);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonNam.TabIndex = 23;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNamSinh
            // 
            this.dateTimePickerNamSinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNamSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNamSinh.Location = new System.Drawing.Point(889, 161);
            this.dateTimePickerNamSinh.Name = "dateTimePickerNamSinh";
            this.dateTimePickerNamSinh.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerNamSinh.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(712, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(712, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Năm sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(711, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(711, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ảnh đại diện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã số nhân viên";
            // 
            // bang
            // 
            this.bang.AutoGenerateColumns = false;
            this.bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msnvDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.namsinhDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.sodienthoaiDataGridViewTextBoxColumn,
            this.hinhDataGridViewImageColumn,
            this.cmndDataGridViewTextBoxColumn,
            this.trinhdoDataGridViewTextBoxColumn,
            this.chuyenmonDataGridViewTextBoxColumn});
            this.bang.DataSource = this.tTnhanvienBindingSource;
            this.bang.Location = new System.Drawing.Point(12, 12);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(693, 604);
            this.bang.TabIndex = 26;
            this.bang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_CellClick);
            this.bang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_CellContentClick);
            // 
            // msnvDataGridViewTextBoxColumn
            // 
            this.msnvDataGridViewTextBoxColumn.DataPropertyName = "msnv";
            this.msnvDataGridViewTextBoxColumn.FillWeight = 50.76143F;
            this.msnvDataGridViewTextBoxColumn.HeaderText = "ID";
            this.msnvDataGridViewTextBoxColumn.Name = "msnvDataGridViewTextBoxColumn";
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.FillWeight = 105.471F;
            this.hotenDataGridViewTextBoxColumn.HeaderText = "tên";
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.FillWeight = 105.471F;
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            // 
            // namsinhDataGridViewTextBoxColumn
            // 
            this.namsinhDataGridViewTextBoxColumn.DataPropertyName = "namsinh";
            this.namsinhDataGridViewTextBoxColumn.FillWeight = 105.471F;
            this.namsinhDataGridViewTextBoxColumn.HeaderText = "namsinh";
            this.namsinhDataGridViewTextBoxColumn.Name = "namsinhDataGridViewTextBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.FillWeight = 105.471F;
            this.diachiDataGridViewTextBoxColumn.HeaderText = "diachi";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // sodienthoaiDataGridViewTextBoxColumn
            // 
            this.sodienthoaiDataGridViewTextBoxColumn.DataPropertyName = "sodienthoai";
            this.sodienthoaiDataGridViewTextBoxColumn.FillWeight = 105.471F;
            this.sodienthoaiDataGridViewTextBoxColumn.HeaderText = "sodienthoai";
            this.sodienthoaiDataGridViewTextBoxColumn.Name = "sodienthoaiDataGridViewTextBoxColumn";
            // 
            // hinhDataGridViewImageColumn
            // 
            this.hinhDataGridViewImageColumn.DataPropertyName = "hinh";
            this.hinhDataGridViewImageColumn.FillWeight = 105.471F;
            this.hinhDataGridViewImageColumn.HeaderText = "hinh";
            this.hinhDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.hinhDataGridViewImageColumn.Name = "hinhDataGridViewImageColumn";
            // 
            // cmndDataGridViewTextBoxColumn
            // 
            this.cmndDataGridViewTextBoxColumn.DataPropertyName = "cmnd";
            this.cmndDataGridViewTextBoxColumn.FillWeight = 105.471F;
            this.cmndDataGridViewTextBoxColumn.HeaderText = "cmnd";
            this.cmndDataGridViewTextBoxColumn.Name = "cmndDataGridViewTextBoxColumn";
            // 
            // trinhdoDataGridViewTextBoxColumn
            // 
            this.trinhdoDataGridViewTextBoxColumn.DataPropertyName = "trinhdo";
            this.trinhdoDataGridViewTextBoxColumn.FillWeight = 105.471F;
            this.trinhdoDataGridViewTextBoxColumn.HeaderText = "trinhdo";
            this.trinhdoDataGridViewTextBoxColumn.Name = "trinhdoDataGridViewTextBoxColumn";
            // 
            // chuyenmonDataGridViewTextBoxColumn
            // 
            this.chuyenmonDataGridViewTextBoxColumn.DataPropertyName = "chuyenmon";
            this.chuyenmonDataGridViewTextBoxColumn.FillWeight = 105.471F;
            this.chuyenmonDataGridViewTextBoxColumn.HeaderText = "chuyenmon";
            this.chuyenmonDataGridViewTextBoxColumn.Name = "chuyenmonDataGridViewTextBoxColumn";
            // 
            // tTnhanvienBindingSource
            // 
            this.tTnhanvienBindingSource.DataMember = "TTnhanvien";
            this.tTnhanvienBindingSource.DataSource = this.quanLyNhanSuDataSet1;
            // 
            // quanLyNhanSuDataSet1
            // 
            this.quanLyNhanSuDataSet1.DataSetName = "QuanLyNhanSuDataSet1";
            this.quanLyNhanSuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(889, 54);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(129, 20);
            this.txtma.TabIndex = 27;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(890, 87);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(129, 20);
            this.txtten.TabIndex = 28;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(763, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(890, 216);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(128, 20);
            this.txtdc.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(711, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Chứng minh nhân dân";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(712, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Trình độ học vấn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(711, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 33;
            this.label10.Text = "Chuyên môn";
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(890, 260);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(128, 20);
            this.txtcmnd.TabIndex = 34;
            // 
            // txthocvan
            // 
            this.txthocvan.Location = new System.Drawing.Point(890, 292);
            this.txthocvan.Name = "txthocvan";
            this.txthocvan.Size = new System.Drawing.Size(128, 20);
            this.txthocvan.TabIndex = 35;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(748, 546);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 37;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(852, 546);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 38;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(957, 546);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 39;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // cbchuyenmon
            // 
            this.cbchuyenmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbchuyenmon.FormattingEnabled = true;
            this.cbchuyenmon.Items.AddRange(new object[] {
            "CEO",
            "IT",
            "Kĩ thuật",
            "CSKH",
            "Bảo vệ",
            "Nhân viên"});
            this.cbchuyenmon.Location = new System.Drawing.Point(889, 327);
            this.cbchuyenmon.Name = "cbchuyenmon";
            this.cbchuyenmon.Size = new System.Drawing.Size(129, 21);
            this.cbchuyenmon.TabIndex = 40;
            // 
            // btnrs
            // 
            this.btnrs.Location = new System.Drawing.Point(852, 582);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(75, 23);
            this.btnrs.TabIndex = 41;
            this.btnrs.Text = "Mới";
            this.btnrs.UseVisualStyleBackColor = true;
            this.btnrs.Click += new System.EventHandler(this.btnrs_Click);
            // 
            // btnxuat
            // 
            this.btnxuat.Location = new System.Drawing.Point(957, 582);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(75, 23);
            this.btnxuat.TabIndex = 42;
            this.btnxuat.Text = "Thoát";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(712, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Số điện thoại";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(889, 187);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(128, 20);
            this.txtsdt.TabIndex = 44;
            // 
            // quanLyNhanSuDataSet
            // 
            this.quanLyNhanSuDataSet.DataSetName = "QuanLyNhanSuDataSet";
            this.quanLyNhanSuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyNhanSuDataSetBindingSource
            // 
            this.quanLyNhanSuDataSetBindingSource.DataSource = this.quanLyNhanSuDataSet;
            this.quanLyNhanSuDataSetBindingSource.Position = 0;
            // 
            // tTnhanvienTableAdapter
            // 
            this.tTnhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBoxAnhDaiDien
            // 
            this.pictureBoxAnhDaiDien.BackColor = System.Drawing.Color.White;
            this.pictureBoxAnhDaiDien.Location = new System.Drawing.Point(854, 367);
            this.pictureBoxAnhDaiDien.Name = "pictureBoxAnhDaiDien";
            this.pictureBoxAnhDaiDien.Size = new System.Drawing.Size(178, 134);
            this.pictureBoxAnhDaiDien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAnhDaiDien.TabIndex = 24;
            this.pictureBoxAnhDaiDien.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(748, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Xóa All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DSnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 628);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.btnrs);
            this.Controls.Add(this.cbchuyenmon);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txthocvan);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxAnhDaiDien);
            this.Controls.Add(this.radioButtonNu);
            this.Controls.Add(this.radioButtonNam);
            this.Controls.Add(this.dateTimePickerNamSinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DSnhanvien";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.DSnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTnhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyNhanSuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnhDaiDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.PictureBox pictureBoxAnhDaiDien;
        public System.Windows.Forms.RadioButton radioButtonNu;
        public System.Windows.Forms.RadioButton radioButtonNam;
        public System.Windows.Forms.DateTimePicker dateTimePickerNamSinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bang;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txthocvan;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ComboBox cbchuyenmon;
        private System.Windows.Forms.Button btnrs;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.BindingSource quanLyNhanSuDataSetBindingSource;
        private QuanLyNhanSuDataSet quanLyNhanSuDataSet;
        private QuanLyNhanSuDataSet1 quanLyNhanSuDataSet1;
        private System.Windows.Forms.BindingSource tTnhanvienBindingSource;
        private QuanLyNhanSuDataSet1TableAdapters.TTnhanvienTableAdapter tTnhanvienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn msnvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn hinhDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trinhdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyenmonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}