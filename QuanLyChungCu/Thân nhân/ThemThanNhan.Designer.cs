namespace QuanLyChungCu
{
    partial class ThemThanNhan
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
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbNam = new System.Windows.Forms.CheckBox();
            this.txtNgayvao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(102, 202);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(222, 20);
            this.txtNamSinh.TabIndex = 32;
            this.txtNamSinh.TextChanged += new System.EventHandler(this.txtNamSinh_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Năm sinh:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(159, 280);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 37);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Location = new System.Drawing.Point(369, 48);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(66, 17);
            this.cbNam.TabIndex = 29;
            this.cbNam.Text = "Giới tính";
            this.cbNam.UseVisualStyleBackColor = true;
            this.cbNam.CheckedChanged += new System.EventHandler(this.cbNam_CheckedChanged);
            // 
            // txtNgayvao
            // 
            this.txtNgayvao.Location = new System.Drawing.Point(102, 157);
            this.txtNgayvao.Name = "txtNgayvao";
            this.txtNgayvao.Size = new System.Drawing.Size(222, 20);
            this.txtNgayvao.TabIndex = 28;
            this.txtNgayvao.TextChanged += new System.EventHandler(this.txtNgayvao_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ngày vào:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(102, 117);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(222, 20);
            this.txtQueQuan.TabIndex = 26;
            this.txtQueQuan.TextChanged += new System.EventHandler(this.txtQueQuan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Quê quán:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(102, 84);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(222, 20);
            this.txtCMND.TabIndex = 20;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Số CMND:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(102, 49);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(222, 20);
            this.txtTen.TabIndex = 18;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên thân nhân:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.Location = new System.Drawing.Point(129, 243);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(195, 20);
            this.txtQuanHe.TabIndex = 34;
            this.txtQuanHe.TextChanged += new System.EventHandler(this.txtQuanHe_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Quan hệ với chủ hộ:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ThemThanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 339);
            this.Controls.Add(this.txtQuanHe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNamSinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.txtNgayvao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "ThemThanNhan";
            this.Text = "Thêm thân nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckBox cbNam;
        private System.Windows.Forms.TextBox txtNgayvao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuanHe;
        private System.Windows.Forms.Label label3;
    }
}