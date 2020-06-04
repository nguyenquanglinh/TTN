namespace QuanLyChungCu
{
    partial class SuaThanNhan
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
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.Location = new System.Drawing.Point(139, 220);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(195, 20);
            this.txtQuanHe.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Quan hệ với chủ hộ:";
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(112, 179);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(222, 20);
            this.txtNamSinh.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Năm sinh:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(169, 257);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(93, 37);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Sửa";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cbNam
            // 
            this.cbNam.AutoSize = true;
            this.cbNam.Location = new System.Drawing.Point(379, 25);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(66, 17);
            this.cbNam.TabIndex = 43;
            this.cbNam.Text = "Giới tính";
            this.cbNam.UseVisualStyleBackColor = true;
            // 
            // txtNgayvao
            // 
            this.txtNgayvao.Location = new System.Drawing.Point(112, 134);
            this.txtNgayvao.Name = "txtNgayvao";
            this.txtNgayvao.Size = new System.Drawing.Size(222, 20);
            this.txtNgayvao.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Ngày vào:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(112, 94);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(222, 20);
            this.txtQueQuan.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Quê quán:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(112, 61);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(222, 20);
            this.txtCMND.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Số CMND:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(112, 26);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(222, 20);
            this.txtTen.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên thân nhân:";
            // 
            // SuaThanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 320);
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
            this.Name = "SuaThanNhan";
            this.Text = "Sửa thân nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuanHe;
        private System.Windows.Forms.Label label3;
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
    }
}