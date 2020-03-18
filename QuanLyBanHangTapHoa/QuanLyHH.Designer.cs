namespace QuanLyBanHangTapHoa
{
    partial class QuanLyHH
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
            this.btnQuanLyHangHoa = new System.Windows.Forms.Button();
            this.btnLoaiHH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLyHangHoa
            // 
            this.btnQuanLyHangHoa.Location = new System.Drawing.Point(40, 61);
            this.btnQuanLyHangHoa.Name = "btnQuanLyHangHoa";
            this.btnQuanLyHangHoa.Size = new System.Drawing.Size(75, 80);
            this.btnQuanLyHangHoa.TabIndex = 0;
            this.btnQuanLyHangHoa.Text = "Quản lý hàng hóa";
            this.btnQuanLyHangHoa.UseVisualStyleBackColor = true;
            this.btnQuanLyHangHoa.Click += new System.EventHandler(this.btnQuanLyHangHoa_Click);
            // 
            // btnLoaiHH
            // 
            this.btnLoaiHH.Location = new System.Drawing.Point(212, 61);
            this.btnLoaiHH.Name = "btnLoaiHH";
            this.btnLoaiHH.Size = new System.Drawing.Size(75, 80);
            this.btnLoaiHH.TabIndex = 1;
            this.btnLoaiHH.Text = "Quản lý loại hàng hóa";
            this.btnLoaiHH.UseVisualStyleBackColor = true;
            // 
            // QuanLyHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 231);
            this.Controls.Add(this.btnLoaiHH);
            this.Controls.Add(this.btnQuanLyHangHoa);
            this.Name = "QuanLyHH";
            this.Text = "QuanLyHH";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyHangHoa;
        private System.Windows.Forms.Button btnLoaiHH;
    }
}