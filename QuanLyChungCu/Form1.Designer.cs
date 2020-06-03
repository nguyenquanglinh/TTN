namespace QuanLyChungCu
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThongTin
            // 
            this.ThongTin.AutoSize = true;
            this.ThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ThongTin.Location = new System.Drawing.Point(0, 0);
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.Size = new System.Drawing.Size(35, 13);
            this.ThongTin.TabIndex = 0;
            this.ThongTin.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hiển thị dữ liệu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ThongTin);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ CĂN HỘ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThongTin;
        private System.Windows.Forms.Button button2;
    }
}

