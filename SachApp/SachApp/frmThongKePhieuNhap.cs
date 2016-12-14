﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SachApp.Service.Dao;
using System.Globalization;
using SachApp.Service.BLL;

namespace SachApp
{
    public partial class frmThongKePhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKePhieuNhap()
        {
            InitializeComponent();
        }

        void show()
        {
          //  gridControl1.DataSource = 
        }
        PhieuNhapBus bus = new PhieuNhapBus();
        int id;
        string time1 = null;
        string time2 = null;
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            
            showHD();
        }
        void showHD()
        {
            //gridControl1.DataSource = dao.GetData();
        }

        private void cbThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThongKe.Text == "Tuần")
            {
                deTo.Text = DateTime.Now.ToString("dd/MM/yyyy");
                deFrom.Text = DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy");
            }
            if (cbThongKe.Text == "Tháng")
            {
                deTo.Text = DateTime.Now.ToString("dd/MM/yyyy");
                deFrom.Text = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");
            }
            if (cbThongKe.Text == "Quý")
            {
                deTo.Text = DateTime.Now.ToString("dd/MM/yyyy");
                deFrom.Text = DateTime.Now.AddMonths(-3).ToString("dd/MM/yyyy");
            }
            if (cbThongKe.Text == "Năm")
            {
                deTo.Text = DateTime.Now.ToString("dd/MM/yyyy");
                deFrom.Text = DateTime.Now.AddYears(-1).ToString("dd/MM/yyyy");
            }
            showTk();

        }

        private void showTk()
        {
            try
            {
                time1 = DateTime.ParseExact(deFrom.EditValue.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");
                time2 = DateTime.ParseExact(deTo.EditValue.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");
            }
            catch
            {
                try
                {
                    time1 = Convert.ToDateTime(Convert.ToDateTime(deFrom.EditValue.ToString()).ToString("yyyy/MM/dd")).ToString("yyyy/MM/dd");
                    time2 = Convert.ToDateTime(Convert.ToDateTime(deTo.EditValue.ToString()).ToString("yyyy/MM/dd")).ToString("yyyy/MM/dd");
                }
                catch { }
            }

            try
            {
                gridControl1.DataSource = bus.ThongKePhieuNhap(id, time1, time2);
            }
            catch { }
        }

        private void deFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (cbThongKe.Text == "Tuần")
            {
                deTo.Text = Convert.ToDateTime(deFrom.EditValue.ToString()).AddDays(7).ToString("dd/MM/yyyy");
            }
            else
            if (cbThongKe.Text == "Tháng")
            {
                deTo.Text = Convert.ToDateTime(deFrom.EditValue.ToString()).AddMonths(1).ToString("dd/MM/yyyy");
            }
            else
            if (cbThongKe.Text == "Quý")
            {
                deTo.Text = Convert.ToDateTime(deFrom.EditValue.ToString()).AddMonths(3).ToString("dd/MM/yyyy");
            }
            else
            if (cbThongKe.Text == "Năm")
            {
                deTo.Text = Convert.ToDateTime(deFrom.EditValue.ToString()).AddYears(1).ToString("dd/MM/yyyy");
            }
            showTk();
        }

        private void lkNhanvien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmThongKePhieuNhap_Load(object sender, EventArgs e)
        {
         

        }

      
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = bus.GetData().Rows[gridView1.FocusedRowHandle];
            frmChiTietPhieuNhap frm = new frmChiTietPhieuNhap(int.Parse(row["MAPN"].ToString()));
            frm.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void deTo_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}