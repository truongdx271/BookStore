﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SachApp.Service.Models;

namespace SachApp
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public NhanVien nvObj;





        Form CheckActiveForm(Type fType)
        {
            foreach (var f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }

        private void btnSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmListSach));
            if (frm != null)
                frm.Activate();
            else
            {
                frmListSach fr = new frmListSach();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnTheLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmTheLoai));
            if (frm != null)
                frm.Activate();
            else
            {
                frmTheLoai fr = new frmTheLoai();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnNhapSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmNhapSach));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNhapSach fr = new frmNhapSach();
                fr.nvObj = nvObj;
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnTacGia_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnBanSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmBanSach));
            if (frm != null)
                frm.Activate();
            else
            {
                frmBanSach fr = new frmBanSach();
                fr.nvObj = nvObj;
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (nvObj.MAQUYEN == 2)
            {
                //btnBanSach.Enabled = false;
                //btnNhapSach.Enabled = false;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmNhanVien));
            if (frm != null)
                frm.Activate();
            else
            {
                frmNhanVien fr = new frmNhanVien();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmKhachHang));
            if (frm != null)
                frm.Activate();
            else
            {
                frmKhachHang fr = new frmKhachHang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmThongKeHoaDon));
            if (frm != null)
                frm.Activate();
            else
            {
                frmThongKeHoaDon fr = new frmThongKeHoaDon();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void btnPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckActiveForm(typeof(frmThongKePhieuNhap));
            if (frm != null)
                frm.Activate();
            else
            {
                frmThongKePhieuNhap fr = new frmThongKePhieuNhap();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}