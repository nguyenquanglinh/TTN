namespace QuanLyBanHangTapHoa
{
    partial class Form1
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
            this.ThongTin = new System.Windows.Forms.Label();
            this.btnDangNhapUser = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnHH = new System.Windows.Forms.Button();
            this.btnHDN = new System.Windows.Forms.Button();
            this.btnHDX = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThongTin
            // 
            this.ThongTin.AutoSize = true;
            this.ThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThongTin.Location = new System.Drawing.Point(12, 0);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(35, 13);
            this.ThongTin.TabIndex = 1;
            this.ThongTin.Text = "label1";
            // 
            // btnDangNhapUser
            // 
            this.btnDangNhapUser.Location = new System.Drawing.Point(126, 129);
            this.btnDangNhapUser.Name = "btnDangNhapUser";
            this.btnDangNhapUser.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhapUser.TabIndex = 2;
            this.btnDangNhapUser.Text = "Đăng nhập";
            this.btnDangNhapUser.UseVisualStyleBackColor = true;
            this.btnDangNhapUser.Visible = false;
            // 
            // btnNV
            // 
            this.btnNV.Location = new System.Drawing.Point(37, 59);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(83, 44);
            this.btnNV.TabIndex = 3;
            this.btnNV.Text = "Quản lý nhân viên";
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnHH
            // 
            this.btnHH.Location = new System.Drawing.Point(207, 59);
            this.btnHH.Name = "btnHH";
            this.btnHH.Size = new System.Drawing.Size(85, 44);
            this.btnHH.TabIndex = 4;
            this.btnHH.Text = "Quản lý hàng hóa";
            this.btnHH.UseVisualStyleBackColor = true;
            this.btnHH.Click += new System.EventHandler(this.btnHH_Click);
            // 
            // btnHDN
            // 
            this.btnHDN.Location = new System.Drawing.Point(37, 177);
            this.btnHDN.Name = "btnHDN";
            this.btnHDN.Size = new System.Drawing.Size(83, 44);
            this.btnHDN.TabIndex = 7;
            this.btnHDN.Text = "Quản lý hóa đơn nhập";
            this.btnHDN.UseVisualStyleBackColor = true;
            this.btnHDN.Click += new System.EventHandler(this.btnHDN_Click);
            // 
            // btnHDX
            // 
            this.btnHDX.Location = new System.Drawing.Point(207, 177);
            this.btnHDX.Name = "btnHDX";
            this.btnHDX.Size = new System.Drawing.Size(85, 44);
            this.btnHDX.TabIndex = 8;
            this.btnHDX.Text = "Quàn lý hóa đơn xuất";
            this.btnHDX.UseVisualStyleBackColor = true;
            this.btnHDX.Click += new System.EventHandler(this.btnHDX_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quản lý loại hàng hóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quản lý kho";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 252);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHDX);
            this.Controls.Add(this.btnHDN);
            this.Controls.Add(this.btnHH);
            this.Controls.Add(this.btnNV);
            this.Controls.Add(this.btnDangNhapUser);
            this.Controls.Add(this.ThongTin);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ BÁN HÀNG TẠP HÓA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ThongTin;
        private System.Windows.Forms.Button btnDangNhapUser;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnHH;
        private System.Windows.Forms.Button btnHDN;
        private System.Windows.Forms.Button btnHDX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

