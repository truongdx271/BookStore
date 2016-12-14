﻿namespace SachApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhapSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnBanSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnNXB = new DevExpress.XtraBars.BarButtonItem();
            this.btnTacGia = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnNhapSach,
            this.btnBanSach,
            this.btnSach,
            this.btnTheLoai,
            this.btnNXB,
            this.btnTacGia,
            this.btnNhanVien,
            this.btnKhachHang,
            this.btnHoaDon,
            this.btnPhieuNhap});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(863, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.Caption = "Nhập sách";
            this.btnNhapSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhapSach.Glyph")));
            this.btnNhapSach.Id = 1;
            this.btnNhapSach.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1));
            this.btnNhapSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhapSach.LargeGlyph")));
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapSach_ItemClick);
            // 
            // btnBanSach
            // 
            this.btnBanSach.Caption = "Bán sách";
            this.btnBanSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBanSach.Glyph")));
            this.btnBanSach.Id = 2;
            this.btnBanSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBanSach.LargeGlyph")));
            this.btnBanSach.Name = "btnBanSach";
            this.btnBanSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanSach_ItemClick);
            // 
            // btnSach
            // 
            this.btnSach.Caption = "Sách";
            this.btnSach.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSach.Glyph")));
            this.btnSach.Id = 3;
            this.btnSach.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSach.LargeGlyph")));
            this.btnSach.Name = "btnSach";
            this.btnSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSach_ItemClick);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Caption = "Thể loại";
            this.btnTheLoai.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTheLoai.Glyph")));
            this.btnTheLoai.Id = 4;
            this.btnTheLoai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTheLoai.LargeGlyph")));
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTheLoai_ItemClick);
            // 
            // btnNXB
            // 
            this.btnNXB.Caption = "Nhà Xuất bản";
            this.btnNXB.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNXB.Glyph")));
            this.btnNXB.Id = 5;
            this.btnNXB.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNXB.LargeGlyph")));
            this.btnNXB.Name = "btnNXB";
            // 
            // btnTacGia
            // 
            this.btnTacGia.Caption = "Tác giả";
            this.btnTacGia.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTacGia.Glyph")));
            this.btnTacGia.Id = 6;
            this.btnTacGia.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTacGia.LargeGlyph")));
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTacGia_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhapSach);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBanSach);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nhập - Bán sách";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSach);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTheLoai);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNXB);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTacGia);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thông tin sách";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Báo cáo & Thống kê";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Hệ thống";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 461);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(863, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKhachHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Glyph")));
            this.btnNhanVien.Id = 7;
            this.btnNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.LargeGlyph")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Glyph")));
            this.btnKhachHang.Id = 8;
            this.btnKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.LargeGlyph")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnHoaDon);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPhieuNhap);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Thống kê";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Caption = "Thống kê hóa đơn";
            this.btnHoaDon.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Glyph")));
            this.btnHoaDon.Id = 9;
            this.btnHoaDon.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.LargeGlyph")));
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoaDon_ItemClick);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Caption = "Thống kê phiếu nhập";
            this.btnPhieuNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhieuNhap.Glyph")));
            this.btnPhieuNhap.Id = 10;
            this.btnPhieuNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhieuNhap.LargeGlyph")));
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhieuNhap_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 492);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Hệ thống quản lý cửa hàng bán sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnNhapSach;
        private DevExpress.XtraBars.BarButtonItem btnBanSach;
        private DevExpress.XtraBars.BarButtonItem btnSach;
        private DevExpress.XtraBars.BarButtonItem btnTheLoai;
        private DevExpress.XtraBars.BarButtonItem btnNXB;
        private DevExpress.XtraBars.BarButtonItem btnTacGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnHoaDon;
        private DevExpress.XtraBars.BarButtonItem btnPhieuNhap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}