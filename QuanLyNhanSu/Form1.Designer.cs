﻿namespace QuanLyNhanSu
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTTCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCheDo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPB = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBangCong = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuanLy = new System.Windows.Forms.Panel();
            this.buttonBacLuong = new System.Windows.Forms.Button();
            this.buttonPhongBan = new System.Windows.Forms.Button();
            this.panelDanhMuc = new System.Windows.Forms.Panel();
            this.buttonCheDo = new System.Windows.Forms.Button();
            this.buttonTTCaNhan = new System.Windows.Forms.Button();
            this.buttonNhanVien = new System.Windows.Forms.Button();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.buttonTroGiup = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.buttonDangKy = new System.Windows.Forms.Button();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonChucNang = new System.Windows.Forms.Button();
            this.buttonQuanLy = new System.Windows.Forms.Button();
            this.buttonTaiKhoan = new System.Windows.Forms.Button();
            this.buttonDanhMuc = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panelQuanLy.SuspendLayout();
            this.panelDanhMuc.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.panelTaiKhoan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.panelShow);
            this.panel3.Controls.Add(this.menuStrip2);
            this.panel3.Location = new System.Drawing.Point(145, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 438);
            this.panel3.TabIndex = 2;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.dataGridView1);
            this.panelShow.Location = new System.Drawing.Point(0, 26);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(701, 395);
            this.panelShow.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTaiKhoan,
            this.ToolStripMenuItemDanhMuc,
            this.ToolStripMenuItemQuanLy,
            this.chứcNăngToolStripMenuItem,
            this.ToolStripMenuItemSearch});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(704, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ToolStripMenuItemTaiKhoan
            // 
            this.ToolStripMenuItemTaiKhoan.Checked = true;
            this.ToolStripMenuItemTaiKhoan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItemTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDoiMK,
            this.ToolStripMenuItemLogout});
            this.ToolStripMenuItemTaiKhoan.Image = global::QuanLyNhanSu.Properties.Resources.add_user;
            this.ToolStripMenuItemTaiKhoan.Name = "ToolStripMenuItemTaiKhoan";
            this.ToolStripMenuItemTaiKhoan.Size = new System.Drawing.Size(86, 20);
            this.ToolStripMenuItemTaiKhoan.Text = "Tài Khoản";
            // 
            // ToolStripMenuItemDoiMK
            // 
            this.ToolStripMenuItemDoiMK.Name = "ToolStripMenuItemDoiMK";
            this.ToolStripMenuItemDoiMK.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItemDoiMK.Text = "Đổi Mật Khẩu";
            this.ToolStripMenuItemDoiMK.Click += new System.EventHandler(this.ToolStripMenuItemDoiMK_Click);
            // 
            // ToolStripMenuItemLogout
            // 
            this.ToolStripMenuItemLogout.Name = "ToolStripMenuItemLogout";
            this.ToolStripMenuItemLogout.Size = new System.Drawing.Size(146, 22);
            this.ToolStripMenuItemLogout.Text = "Đăng Xuất";
            this.ToolStripMenuItemLogout.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // ToolStripMenuItemDanhMuc
            // 
            this.ToolStripMenuItemDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNhanVien,
            this.ToolStripMenuItemTTCaNhan,
            this.ToolStripMenuItemCheDo});
            this.ToolStripMenuItemDanhMuc.Image = global::QuanLyNhanSu.Properties.Resources.Icon0011;
            this.ToolStripMenuItemDanhMuc.Name = "ToolStripMenuItemDanhMuc";
            this.ToolStripMenuItemDanhMuc.Size = new System.Drawing.Size(90, 20);
            this.ToolStripMenuItemDanhMuc.Text = "Nhân Viên";
            // 
            // ToolStripMenuItemNhanVien
            // 
            this.ToolStripMenuItemNhanVien.Name = "ToolStripMenuItemNhanVien";
            this.ToolStripMenuItemNhanVien.Size = new System.Drawing.Size(135, 22);
            this.ToolStripMenuItemNhanVien.Text = "Nhân Viên";
            this.ToolStripMenuItemNhanVien.Click += new System.EventHandler(this.buttonNhanVien_Click);
            // 
            // ToolStripMenuItemTTCaNhan
            // 
            this.ToolStripMenuItemTTCaNhan.Name = "ToolStripMenuItemTTCaNhan";
            this.ToolStripMenuItemTTCaNhan.Size = new System.Drawing.Size(135, 22);
            this.ToolStripMenuItemTTCaNhan.Text = "TT Cá Nhân";
            this.ToolStripMenuItemTTCaNhan.Click += new System.EventHandler(this.buttonTTCaNhan_Click);
            // 
            // ToolStripMenuItemCheDo
            // 
            this.ToolStripMenuItemCheDo.Name = "ToolStripMenuItemCheDo";
            this.ToolStripMenuItemCheDo.Size = new System.Drawing.Size(135, 22);
            this.ToolStripMenuItemCheDo.Text = "Chế Độ";
            this.ToolStripMenuItemCheDo.Click += new System.EventHandler(this.buttonCheDo_Click);
            // 
            // ToolStripMenuItemQuanLy
            // 
            this.ToolStripMenuItemQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPB,
            this.ToolStripMenuItemBangCong});
            this.ToolStripMenuItemQuanLy.Image = global::QuanLyNhanSu.Properties.Resources.Icon0119;
            this.ToolStripMenuItemQuanLy.Name = "ToolStripMenuItemQuanLy";
            this.ToolStripMenuItemQuanLy.Size = new System.Drawing.Size(78, 20);
            this.ToolStripMenuItemQuanLy.Text = "Quản Lý";
            // 
            // ToolStripMenuItemPB
            // 
            this.ToolStripMenuItemPB.Name = "ToolStripMenuItemPB";
            this.ToolStripMenuItemPB.Size = new System.Drawing.Size(132, 22);
            this.ToolStripMenuItemPB.Text = "Phòng Ban";
            this.ToolStripMenuItemPB.Click += new System.EventHandler(this.buttonPhongBan_Click);
            // 
            // ToolStripMenuItemBangCong
            // 
            this.ToolStripMenuItemBangCong.Name = "ToolStripMenuItemBangCong";
            this.ToolStripMenuItemBangCong.Size = new System.Drawing.Size(132, 22);
            this.ToolStripMenuItemBangCong.Text = "Bậc Lương";
            this.ToolStripMenuItemBangCong.Click += new System.EventHandler(this.buttonBacLuong_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBangLuong});
            this.chứcNăngToolStripMenuItem.Image = global::QuanLyNhanSu.Properties.Resources.Icon0011;
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chứcNăngToolStripMenuItem.Text = "Báo Cáo";
            // 
            // ToolStripMenuItemBangLuong
            // 
            this.ToolStripMenuItemBangLuong.Name = "ToolStripMenuItemBangLuong";
            this.ToolStripMenuItemBangLuong.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemBangLuong.Text = "Bảng Lương";
            this.ToolStripMenuItemBangLuong.Click += new System.EventHandler(this.buttonBangLuong_Click);
            // 
            // ToolStripMenuItemSearch
            // 
            this.ToolStripMenuItemSearch.Image = global::QuanLyNhanSu.Properties.Resources.Icon00191;
            this.ToolStripMenuItemSearch.Name = "ToolStripMenuItemSearch";
            this.ToolStripMenuItemSearch.Size = new System.Drawing.Size(85, 20);
            this.ToolStripMenuItemSearch.Text = "Tìm Kiếm";
            this.ToolStripMenuItemSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelQuanLy.Controls.Add(this.buttonBacLuong);
            this.panelQuanLy.Controls.Add(this.buttonPhongBan);
            this.panelQuanLy.Location = new System.Drawing.Point(15, 396);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.Size = new System.Drawing.Size(115, 95);
            this.panelQuanLy.TabIndex = 9;
            // 
            // buttonBacLuong
            // 
            this.buttonBacLuong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBacLuong.BackgroundImage")));
            this.buttonBacLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBacLuong.Font = new System.Drawing.Font("UVN Da Lat", 11.25F);
            this.buttonBacLuong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBacLuong.Location = new System.Drawing.Point(22, 49);
            this.buttonBacLuong.Name = "buttonBacLuong";
            this.buttonBacLuong.Size = new System.Drawing.Size(72, 34);
            this.buttonBacLuong.TabIndex = 10;
            this.buttonBacLuong.Text = "Bậc Lương";
            this.buttonBacLuong.UseVisualStyleBackColor = true;
            this.buttonBacLuong.Click += new System.EventHandler(this.buttonBacLuong_Click);
            // 
            // buttonPhongBan
            // 
            this.buttonPhongBan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPhongBan.BackgroundImage")));
            this.buttonPhongBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPhongBan.Font = new System.Drawing.Font("UVN Da Lat", 11.25F);
            this.buttonPhongBan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPhongBan.Location = new System.Drawing.Point(22, 9);
            this.buttonPhongBan.Name = "buttonPhongBan";
            this.buttonPhongBan.Size = new System.Drawing.Size(72, 34);
            this.buttonPhongBan.TabIndex = 1;
            this.buttonPhongBan.Text = "Phòng Ban";
            this.buttonPhongBan.UseVisualStyleBackColor = true;
            this.buttonPhongBan.Click += new System.EventHandler(this.buttonPhongBan_Click);
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelDanhMuc.Controls.Add(this.buttonCheDo);
            this.panelDanhMuc.Controls.Add(this.buttonTTCaNhan);
            this.panelDanhMuc.Controls.Add(this.buttonNhanVien);
            this.panelDanhMuc.Location = new System.Drawing.Point(24, 262);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(115, 130);
            this.panelDanhMuc.TabIndex = 6;
            // 
            // buttonCheDo
            // 
            this.buttonCheDo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCheDo.BackgroundImage")));
            this.buttonCheDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCheDo.Font = new System.Drawing.Font("UVN Da Lat", 11.25F);
            this.buttonCheDo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCheDo.Location = new System.Drawing.Point(22, 90);
            this.buttonCheDo.Name = "buttonCheDo";
            this.buttonCheDo.Size = new System.Drawing.Size(72, 34);
            this.buttonCheDo.TabIndex = 9;
            this.buttonCheDo.Text = "Chế Độ";
            this.buttonCheDo.UseVisualStyleBackColor = true;
            this.buttonCheDo.Click += new System.EventHandler(this.buttonCheDo_Click);
            // 
            // buttonTTCaNhan
            // 
            this.buttonTTCaNhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTTCaNhan.BackgroundImage")));
            this.buttonTTCaNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTTCaNhan.Font = new System.Drawing.Font("UVN Da Lat", 11.25F);
            this.buttonTTCaNhan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTTCaNhan.Location = new System.Drawing.Point(22, 50);
            this.buttonTTCaNhan.Name = "buttonTTCaNhan";
            this.buttonTTCaNhan.Size = new System.Drawing.Size(72, 34);
            this.buttonTTCaNhan.TabIndex = 8;
            this.buttonTTCaNhan.Text = "TT Nhân Viên";
            this.buttonTTCaNhan.UseVisualStyleBackColor = true;
            this.buttonTTCaNhan.Click += new System.EventHandler(this.buttonTTCaNhan_Click);
            // 
            // buttonNhanVien
            // 
            this.buttonNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNhanVien.BackgroundImage")));
            this.buttonNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNhanVien.Font = new System.Drawing.Font("UVN Da Lat", 11.25F);
            this.buttonNhanVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonNhanVien.Location = new System.Drawing.Point(22, 9);
            this.buttonNhanVien.Name = "buttonNhanVien";
            this.buttonNhanVien.Size = new System.Drawing.Size(72, 34);
            this.buttonNhanVien.TabIndex = 1;
            this.buttonNhanVien.Text = "Hồ Sơ";
            this.buttonNhanVien.UseVisualStyleBackColor = true;
            this.buttonNhanVien.Click += new System.EventHandler(this.buttonNhanVien_Click);
            // 
            // panelChucNang
            // 
            this.panelChucNang.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelChucNang.Controls.Add(this.buttonTroGiup);
            this.panelChucNang.Controls.Add(this.buttonSearch);
            this.panelChucNang.Location = new System.Drawing.Point(-2, 114);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(115, 99);
            this.panelChucNang.TabIndex = 8;
            // 
            // buttonTroGiup
            // 
            this.buttonTroGiup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTroGiup.BackgroundImage")));
            this.buttonTroGiup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTroGiup.Font = new System.Drawing.Font("UVN Da Lat", 11.25F);
            this.buttonTroGiup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTroGiup.Location = new System.Drawing.Point(22, 50);
            this.buttonTroGiup.Name = "buttonTroGiup";
            this.buttonTroGiup.Size = new System.Drawing.Size(72, 34);
            this.buttonTroGiup.TabIndex = 9;
            this.buttonTroGiup.Text = "Trợ Giúp";
            this.buttonTroGiup.UseVisualStyleBackColor = true;
            this.buttonTroGiup.Click += new System.EventHandler(this.buttonTroGiup_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Font = new System.Drawing.Font("UVN Da Lat", 11.25F);
            this.buttonSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSearch.Location = new System.Drawing.Point(22, 8);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(72, 34);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Tìm Kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelTaiKhoan.Controls.Add(this.buttonDangKy);
            this.panelTaiKhoan.Controls.Add(this.buttonDangNhap);
            this.panelTaiKhoan.Location = new System.Drawing.Point(37, 281);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(115, 97);
            this.panelTaiKhoan.TabIndex = 4;
            // 
            // buttonDangKy
            // 
            this.buttonDangKy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDangKy.BackgroundImage")));
            this.buttonDangKy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDangKy.Font = new System.Drawing.Font("UVN Da Lat", 11.25F);
            this.buttonDangKy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDangKy.Location = new System.Drawing.Point(22, 50);
            this.buttonDangKy.Name = "buttonDangKy";
            this.buttonDangKy.Size = new System.Drawing.Size(72, 34);
            this.buttonDangKy.TabIndex = 8;
            this.buttonDangKy.Text = "Đổi Mật Khẩu";
            this.buttonDangKy.UseVisualStyleBackColor = true;
            this.buttonDangKy.Click += new System.EventHandler(this.ToolStripMenuItemDoiMK_Click);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDangNhap.BackgroundImage")));
            this.buttonDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDangNhap.Font = new System.Drawing.Font("UVN Da Lat", 11.25F);
            this.buttonDangNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDangNhap.Location = new System.Drawing.Point(22, 10);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(72, 34);
            this.buttonDangNhap.TabIndex = 1;
            this.buttonDangNhap.Text = "Đăng Xuất";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.labelChao);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 75);
            this.panel1.TabIndex = 5;
            // 
            // labelChao
            // 
            this.labelChao.AutoSize = true;
            this.labelChao.Font = new System.Drawing.Font("UVN Ai Cap Nhe", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelChao.Location = new System.Drawing.Point(787, 50);
            this.labelChao.Name = "labelChao";
            this.labelChao.Size = new System.Drawing.Size(151, 23);
            this.labelChao.TabIndex = 9;
            this.labelChao.Text = "Hello hoangman!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::QuanLyNhanSu.Properties.Resources.SeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Image = global::QuanLyNhanSu.Properties.Resources.icons8_close_window_30;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(817, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 39);
            this.button1.TabIndex = 8;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("UVN Da Lat", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(244, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ Thống Quản Lý Nhân Sự";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Location = new System.Drawing.Point(-2, 497);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(854, 87);
            this.panel4.TabIndex = 7;
            // 
            // buttonChucNang
            // 
            this.buttonChucNang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChucNang.BackgroundImage")));
            this.buttonChucNang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChucNang.Font = new System.Drawing.Font("UVN Da Lat", 14.25F);
            this.buttonChucNang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonChucNang.Location = new System.Drawing.Point(15, 230);
            this.buttonChucNang.Name = "buttonChucNang";
            this.buttonChucNang.Size = new System.Drawing.Size(115, 45);
            this.buttonChucNang.TabIndex = 2;
            this.buttonChucNang.Text = "Trợ Giúp";
            this.buttonChucNang.UseVisualStyleBackColor = true;
            this.buttonChucNang.Click += new System.EventHandler(this.buttonChucNang_Click);
            // 
            // buttonQuanLy
            // 
            this.buttonQuanLy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonQuanLy.BackgroundImage")));
            this.buttonQuanLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQuanLy.Font = new System.Drawing.Font("UVN Da Lat", 14.25F);
            this.buttonQuanLy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonQuanLy.Location = new System.Drawing.Point(15, 180);
            this.buttonQuanLy.Name = "buttonQuanLy";
            this.buttonQuanLy.Size = new System.Drawing.Size(115, 45);
            this.buttonQuanLy.TabIndex = 3;
            this.buttonQuanLy.Text = "Quản Lý";
            this.buttonQuanLy.UseVisualStyleBackColor = true;
            this.buttonQuanLy.Click += new System.EventHandler(this.buttonQuanLy_Click);
            // 
            // buttonTaiKhoan
            // 
            this.buttonTaiKhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTaiKhoan.BackgroundImage")));
            this.buttonTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTaiKhoan.Font = new System.Drawing.Font("UVN Da Lat", 14.25F);
            this.buttonTaiKhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTaiKhoan.Location = new System.Drawing.Point(15, 80);
            this.buttonTaiKhoan.Name = "buttonTaiKhoan";
            this.buttonTaiKhoan.Size = new System.Drawing.Size(115, 45);
            this.buttonTaiKhoan.TabIndex = 0;
            this.buttonTaiKhoan.Text = "Tài Khoản";
            this.buttonTaiKhoan.UseVisualStyleBackColor = true;
            this.buttonTaiKhoan.Click += new System.EventHandler(this.buttonTaiKhoan_Click);
            // 
            // buttonDanhMuc
            // 
            this.buttonDanhMuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDanhMuc.BackgroundImage")));
            this.buttonDanhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDanhMuc.Font = new System.Drawing.Font("UVN Da Lat", 14.25F);
            this.buttonDanhMuc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDanhMuc.Location = new System.Drawing.Point(15, 130);
            this.buttonDanhMuc.Name = "buttonDanhMuc";
            this.buttonDanhMuc.Size = new System.Drawing.Size(115, 45);
            this.buttonDanhMuc.TabIndex = 1;
            this.buttonDanhMuc.Text = "Nhân Viên";
            this.buttonDanhMuc.UseVisualStyleBackColor = true;
            this.buttonDanhMuc.Click += new System.EventHandler(this.buttonDanhMuc_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(849, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.panelDanhMuc);
            this.Controls.Add(this.panelQuanLy);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelTaiKhoan);
            this.Controls.Add(this.buttonChucNang);
            this.Controls.Add(this.buttonQuanLy);
            this.Controls.Add(this.buttonTaiKhoan);
            this.Controls.Add(this.buttonDanhMuc);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(60, 0);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Sự";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelQuanLy.ResumeLayout(false);
            this.panelDanhMuc.ResumeLayout(false);
            this.panelChucNang.ResumeLayout(false);
            this.panelTaiKhoan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonChucNang;
        private System.Windows.Forms.Button buttonQuanLy;
        private System.Windows.Forms.Button buttonTaiKhoan;
        private System.Windows.Forms.Button buttonDanhMuc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTaiKhoan;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Button buttonDangKy;
        private System.Windows.Forms.Panel panelDanhMuc;
        private System.Windows.Forms.Button buttonTTCaNhan;
        private System.Windows.Forms.Button buttonNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCheDo;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button buttonTroGiup;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBacLuong;
        private System.Windows.Forms.Panel panelQuanLy;
        private System.Windows.Forms.Button buttonPhongBan;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDoiMK;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPB;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBangCong;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBangLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLogout;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTTCaNhan;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCheDo;
        private System.Windows.Forms.Label labelChao;
    }
}

