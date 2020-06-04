namespace QuanLyKho.ThongKe
{
    partial class FormThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXuat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewXuat = new System.Windows.Forms.DataGridView();
            this.dataGridViewNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(302, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thống Kê Hóa Đơn";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(52, 393);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(252, 32);
            this.txtNhap.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 445);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số Lượng Phiếu Nhập";
            // 
            // txtXuat
            // 
            this.txtXuat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuat.Location = new System.Drawing.Point(590, 393);
            this.txtXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtXuat.Name = "txtXuat";
            this.txtXuat.Size = new System.Drawing.Size(252, 32);
            this.txtXuat.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 432);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số Lượng Phiếu Xuất";
            // 
            // dataGridViewXuat
            // 
            this.dataGridViewXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXuat.Location = new System.Drawing.Point(483, 101);
            this.dataGridViewXuat.Name = "dataGridViewXuat";
            this.dataGridViewXuat.Size = new System.Drawing.Size(502, 271);
            this.dataGridViewXuat.TabIndex = 13;
            // 
            // dataGridViewNhap
            // 
            this.dataGridViewNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhap.Location = new System.Drawing.Point(12, 101);
            this.dataGridViewNhap.Name = "dataGridViewNhap";
            this.dataGridViewNhap.Size = new System.Drawing.Size(465, 271);
            this.dataGridViewNhap.TabIndex = 13;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 479);
            this.Controls.Add(this.dataGridViewNhap);
            this.Controls.Add(this.dataGridViewXuat);
            this.Controls.Add(this.txtXuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewXuat;
        private System.Windows.Forms.DataGridView dataGridViewNhap;
    }
}