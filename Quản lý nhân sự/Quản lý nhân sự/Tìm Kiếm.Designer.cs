namespace Quản_lý_nhân_sự
{
    partial class timkiem
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
            this.bang = new System.Windows.Forms.DataGridView();
            this.txttk = new System.Windows.Forms.TextBox();
            this.btntk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdcc = new System.Windows.Forms.RadioButton();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.rdhd = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.rdma = new System.Windows.Forms.RadioButton();
            this.rdcm = new System.Windows.Forms.RadioButton();
            this.rdten = new System.Windows.Forms.RadioButton();
            this.rdhv = new System.Windows.Forms.RadioButton();
            this.rđc = new System.Windows.Forms.RadioButton();
            this.rdcv = new System.Windows.Forms.RadioButton();
            this.rdpb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bang
            // 
            this.bang.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang.Location = new System.Drawing.Point(15, 265);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(1013, 351);
            this.bang.TabIndex = 1;
            // 
            // txttk
            // 
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.Location = new System.Drawing.Point(68, 19);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(522, 29);
            this.txttk.TabIndex = 0;
            // 
            // btntk
            // 
            this.btntk.BackgroundImage = global::Quản_lý_nhân_sự.Properties.Resources.Search;
            this.btntk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntk.Location = new System.Drawing.Point(612, 21);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(60, 30);
            this.btntk.TabIndex = 1;
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.rdpb);
            this.groupBox1.Controls.Add(this.rdcv);
            this.groupBox1.Controls.Add(this.rdcc);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.rdhd);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.rdma);
            this.groupBox1.Controls.Add(this.rdcm);
            this.groupBox1.Controls.Add(this.rdten);
            this.groupBox1.Controls.Add(this.btntk);
            this.groupBox1.Controls.Add(this.rdhv);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.rđc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdcc
            // 
            this.rdcc.AutoSize = true;
            this.rdcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdcc.Location = new System.Drawing.Point(21, 142);
            this.rdcc.Name = "rdcc";
            this.rdcc.Size = new System.Drawing.Size(289, 24);
            this.rdcc.TabIndex = 13;
            this.rdcc.TabStop = true;
            this.rdcc.Text = "Thông tin chấm công(YYYY-MM-DD)";
            this.rdcc.UseVisualStyleBackColor = true;
            this.rdcc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(552, 138);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(209, 20);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Sắp xếp tiền lương giảm dần";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(911, 182);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 48);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(552, 115);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(215, 20);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Nhân viên có lương thấp nhất";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // rdhd
            // 
            this.rdhd.AutoSize = true;
            this.rdhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdhd.Location = new System.Drawing.Point(282, 112);
            this.rdhd.Name = "rdhd";
            this.rdhd.Size = new System.Drawing.Size(134, 24);
            this.rdhd.TabIndex = 10;
            this.rdhd.TabStop = true;
            this.rdhd.Text = "Hợp đồng (tên)";
            this.rdhd.UseVisualStyleBackColor = true;
            this.rdhd.CheckedChanged += new System.EventHandler(this.rdhd_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(552, 89);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(209, 20);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nhân viên có lương cao nhât";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // rdma
            // 
            this.rdma.AutoSize = true;
            this.rdma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdma.Location = new System.Drawing.Point(21, 64);
            this.rdma.Name = "rdma";
            this.rdma.Size = new System.Drawing.Size(121, 24);
            this.rdma.TabIndex = 2;
            this.rdma.TabStop = true;
            this.rdma.Text = "Mã nhân viên";
            this.rdma.UseVisualStyleBackColor = true;
            // 
            // rdcm
            // 
            this.rdcm.AutoSize = true;
            this.rdcm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdcm.Location = new System.Drawing.Point(282, 89);
            this.rdcm.Name = "rdcm";
            this.rdcm.Size = new System.Drawing.Size(116, 24);
            this.rdcm.TabIndex = 4;
            this.rdcm.TabStop = true;
            this.rdcm.Text = "Chuyên môn";
            this.rdcm.UseVisualStyleBackColor = true;
            // 
            // rdten
            // 
            this.rdten.AutoSize = true;
            this.rdten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdten.Location = new System.Drawing.Point(21, 90);
            this.rdten.Name = "rdten";
            this.rdten.Size = new System.Drawing.Size(126, 24);
            this.rdten.TabIndex = 7;
            this.rdten.TabStop = true;
            this.rdten.Text = "Tên nhân viên";
            this.rdten.UseVisualStyleBackColor = true;
            // 
            // rdhv
            // 
            this.rdhv.AutoSize = true;
            this.rdhv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdhv.Location = new System.Drawing.Point(282, 63);
            this.rdhv.Name = "rdhv";
            this.rdhv.Size = new System.Drawing.Size(143, 24);
            this.rdhv.TabIndex = 5;
            this.rdhv.TabStop = true;
            this.rdhv.Text = "Trình độ học vấn";
            this.rdhv.UseVisualStyleBackColor = true;
            // 
            // rđc
            // 
            this.rđc.AutoSize = true;
            this.rđc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rđc.Location = new System.Drawing.Point(21, 113);
            this.rđc.Name = "rđc";
            this.rđc.Size = new System.Drawing.Size(75, 24);
            this.rđc.TabIndex = 6;
            this.rđc.TabStop = true;
            this.rđc.Text = "Địa chỉ";
            this.rđc.UseVisualStyleBackColor = true;
            // 
            // rdcv
            // 
            this.rdcv.AutoSize = true;
            this.rdcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdcv.Location = new System.Drawing.Point(21, 172);
            this.rdcv.Name = "rdcv";
            this.rdcv.Size = new System.Drawing.Size(116, 24);
            this.rdcv.TabIndex = 14;
            this.rdcv.TabStop = true;
            this.rdcv.Text = "Chức vụ(mã)";
            this.rdcv.UseVisualStyleBackColor = true;
            // 
            // rdpb
            // 
            this.rdpb.AutoSize = true;
            this.rdpb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdpb.Location = new System.Drawing.Point(273, 172);
            this.rdpb.Name = "rdpb";
            this.rdpb.Size = new System.Drawing.Size(136, 24);
            this.rdpb.TabIndex = 15;
            this.rdpb.TabStop = true;
            this.rdpb.Text = "Phòng ban(mã)";
            this.rdpb.UseVisualStyleBackColor = true;
            // 
            // timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 628);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "timkiem";
            this.Text = "Tìm_Kiếm";
            this.Load += new System.EventHandler(this.timkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView bang;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RadioButton rdma;
        private System.Windows.Forms.RadioButton rdcm;
        private System.Windows.Forms.RadioButton rdten;
        private System.Windows.Forms.RadioButton rdhv;
        private System.Windows.Forms.RadioButton rđc;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton rdhd;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.RadioButton rdcc;
        private System.Windows.Forms.RadioButton rdpb;
        private System.Windows.Forms.RadioButton rdcv;
    }
}