namespace Quản_lý_nhân_sự
{
    partial class baocao
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
            this.dataSet1 = new Quản_lý_nhân_sự.DataSet1();
            this.btnht = new System.Windows.Forms.Button();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Quản_lý_nhân_sự.DataSet1TableAdapters.DataTable1TableAdapter();
            this.ngaybd = new System.Windows.Forms.DateTimePicker();
            this.ngaykt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songaylamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bang
            // 
            this.bang.AutoGenerateColumns = false;
            this.bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotenDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.namsinhDataGridViewTextBoxColumn,
            this.ngaybdDataGridViewTextBoxColumn,
            this.ngayktDataGridViewTextBoxColumn,
            this.songaylamDataGridViewTextBoxColumn,
            this.tongtienDataGridViewTextBoxColumn});
            this.bang.DataSource = this.dataTable1BindingSource;
            this.bang.Location = new System.Drawing.Point(28, 222);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(1000, 384);
            this.bang.TabIndex = 1;
            this.bang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnht
            // 
            this.btnht.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnht.Location = new System.Drawing.Point(335, 22);
            this.btnht.Name = "btnht";
            this.btnht.Size = new System.Drawing.Size(88, 30);
            this.btnht.TabIndex = 4;
            this.btnht.Text = "Hiển thị";
            this.btnht.UseVisualStyleBackColor = true;
            this.btnht.Click += new System.EventHandler(this.btnht_Click);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // ngaybd
            // 
            this.ngaybd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaybd.Location = new System.Drawing.Point(186, 22);
            this.ngaybd.Name = "ngaybd";
            this.ngaybd.Size = new System.Drawing.Size(99, 24);
            this.ngaybd.TabIndex = 5;
            // 
            // ngaykt
            // 
            this.ngaykt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaykt.Location = new System.Drawing.Point(186, 65);
            this.ngaykt.Name = "ngaykt";
            this.ngaykt.Size = new System.Drawing.Size(99, 24);
            this.ngaykt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "ngày kết thúc";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(335, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(495, 47);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 42);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            // 
            // namsinhDataGridViewTextBoxColumn
            // 
            this.namsinhDataGridViewTextBoxColumn.DataPropertyName = "namsinh";
            this.namsinhDataGridViewTextBoxColumn.HeaderText = "Năm sinh";
            this.namsinhDataGridViewTextBoxColumn.Name = "namsinhDataGridViewTextBoxColumn";
            // 
            // ngaybdDataGridViewTextBoxColumn
            // 
            this.ngaybdDataGridViewTextBoxColumn.DataPropertyName = "ngaybd";
            this.ngaybdDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu";
            this.ngaybdDataGridViewTextBoxColumn.Name = "ngaybdDataGridViewTextBoxColumn";
            // 
            // ngayktDataGridViewTextBoxColumn
            // 
            this.ngayktDataGridViewTextBoxColumn.DataPropertyName = "ngaykt";
            this.ngayktDataGridViewTextBoxColumn.HeaderText = "Ngày kết thúc";
            this.ngayktDataGridViewTextBoxColumn.Name = "ngayktDataGridViewTextBoxColumn";
            // 
            // songaylamDataGridViewTextBoxColumn
            // 
            this.songaylamDataGridViewTextBoxColumn.DataPropertyName = "songaylam";
            this.songaylamDataGridViewTextBoxColumn.HeaderText = "Số ngày làm";
            this.songaylamDataGridViewTextBoxColumn.Name = "songaylamDataGridViewTextBoxColumn";
            // 
            // tongtienDataGridViewTextBoxColumn
            // 
            this.tongtienDataGridViewTextBoxColumn.DataPropertyName = "tongtien";
            this.tongtienDataGridViewTextBoxColumn.HeaderText = "Lương";
            this.tongtienDataGridViewTextBoxColumn.Name = "tongtienDataGridViewTextBoxColumn";
            // 
            // baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 628);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ngaykt);
            this.Controls.Add(this.ngaybd);
            this.Controls.Add(this.btnht);
            this.Controls.Add(this.bang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "baocao";
            this.Text = "Báo_cáo";
            this.Load += new System.EventHandler(this.Báo_cáo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView bang;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenpbDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnht;
        private System.Windows.Forms.DateTimePicker ngaybd;
        private System.Windows.Forms.DateTimePicker ngaykt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songaylamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
    }
}