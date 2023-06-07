namespace Quản_lý_nhân_sự
{
    partial class dangnhap
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
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btndn = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.linkdk = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.phide = new System.Windows.Forms.PictureBox();
            this.peye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.phide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peye)).BeginInit();
            this.SuspendLayout();
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(95, 30);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(149, 20);
            this.txttk.TabIndex = 0;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(95, 56);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(149, 20);
            this.txtmk.TabIndex = 1;
            // 
            // btndn
            // 
            this.btndn.Location = new System.Drawing.Point(47, 114);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(75, 23);
            this.btndn.TabIndex = 2;
            this.btndn.Text = "Đăng Nhập";
            this.btndn.UseVisualStyleBackColor = true;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(150, 114);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // linkdk
            // 
            this.linkdk.AutoSize = true;
            this.linkdk.Location = new System.Drawing.Point(131, 149);
            this.linkdk.Name = "linkdk";
            this.linkdk.Size = new System.Drawing.Size(144, 13);
            this.linkdk.TabIndex = 5;
            this.linkdk.TabStop = true;
            this.linkdk.Text = "Đăng ký tài khoản nhân viên";
            this.linkdk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkdk_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(95, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Ghi nhớ tài khoản";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(44, 9);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 13);
            this.lb.TabIndex = 9;
            // 
            // phide
            // 
            this.phide.BackColor = System.Drawing.SystemColors.Window;
            this.phide.Image = global::Quản_lý_nhân_sự.Properties.Resources.invisible;
            this.phide.Location = new System.Drawing.Point(252, 56);
            this.phide.Name = "phide";
            this.phide.Size = new System.Drawing.Size(25, 20);
            this.phide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.phide.TabIndex = 11;
            this.phide.TabStop = false;
            this.phide.Click += new System.EventHandler(this.phide_Click);
            // 
            // peye
            // 
            this.peye.Image = global::Quản_lý_nhân_sự.Properties.Resources.visible;
            this.peye.Location = new System.Drawing.Point(250, 56);
            this.peye.Name = "peye";
            this.peye.Size = new System.Drawing.Size(25, 20);
            this.peye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.peye.TabIndex = 10;
            this.peye.TabStop = false;
            this.peye.Click += new System.EventHandler(this.pyey_Click);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 171);
            this.Controls.Add(this.phide);
            this.Controls.Add(this.peye);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkdk);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dangnhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.LinkLabel linkdk;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.PictureBox peye;
        private System.Windows.Forms.PictureBox phide;
    }
}

