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
using DevExpress.XtraEditors.Repository;
using SachApp.Service.Dao;
using System.Globalization;
using SachApp.Service.BLL;

namespace SachApp
{
    public partial class frmThongKeHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeHoaDon()
        {
            InitializeComponent();
        }
        HoaDonBus bus = new HoaDonBus();
        int id;
        bool change =false;
        string time1;
        string time2;
        private void frmThongKe_Load(object sender, EventArgs e)
        {
          
            showHD();
        }
        void showHD()
        {
            gridControl1.DataSource = bus.GetData();
        }
        void showTk()
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
                gridControl1.DataSource = bus.ThongKeHoaDon(id, time1, time2);
            }
            catch { }


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


   //     private void deFrom_EditValueChanged(object sender, EventArgs e)
    //    {
       //     time1 = DateTime.ParseExact(deFrom.EditValue.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd");
            //if (!change)
            //{
            //    try
            //    {
            //        if (cbThongKe.Text == "Tuần")
            //        {
            //            deTo.Text = Convert.ToDateTime(deFrom.EditValue.ToString()).AddDays(7).ToString("dd/MM/yyyy");
            //        }
            //        else
            //    if (cbThongKe.Text == "Tháng")
            //        {
            //            deTo.Text = Convert.ToDateTime(deFrom.EditValue.ToString()).AddMonths(1).ToString("dd/MM/yyyy");
            //        }
            //        else
            //    if (cbThongKe.Text == "Quý")
            //        {
            //            deTo.Text = Convert.ToDateTime(deFrom.EditValue.ToString()).AddMonths(3).ToString("dd/MM/yyyy");
            //        }
            //        else
            //    if (cbThongKe.Text == "Năm")
            //        {
            //            deTo.Text = Convert.ToDateTime(deFrom.EditValue.ToString()).AddYears(1).ToString("dd/MM/yyyy");
            //        }
            //    }
            //    catch { }

            //}
            //else
            //{
        //    showTk();
            //    change = false;
            //}

     //   }

        private void lkNhanvien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(lkNhanvien.EditValue.ToString());
            }
            catch { }
            showTk();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = bus.GetData().Rows[gridView1.FocusedRowHandle];
            frmChiTietHoaDon frm = new frmChiTietHoaDon(int.Parse(row["MAHD"].ToString()));
            frm.Show();
        }

    
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void deTo_EditValueChanged(object sender, EventArgs e)
        {
            //if (!change)
            //{
            try
            {
                if (cbThongKe.Text == "Tuần")
                {
                    deFrom.Text = Convert.ToDateTime(deTo.EditValue.ToString()).AddDays(-7).ToString("dd/MM/yyyy");
                }
                if (cbThongKe.Text == "Tháng")
                {
                    deFrom.Text = Convert.ToDateTime(deTo.EditValue.ToString()).AddMonths(-1).ToString("dd/MM/yyyy");
                }
                if (cbThongKe.Text == "Quý")
                {
                    deFrom.Text = Convert.ToDateTime(deTo.EditValue.ToString()).AddMonths(-3).ToString("dd/MM/yyyy");
                }
                if (cbThongKe.Text == "Năm")
                {
                    deFrom.Text = Convert.ToDateTime(deTo.EditValue.ToString()).AddYears(-1).ToString("dd/MM/yyyy");
                }
            }
            catch { }

            showTk();
            //}
            //else
            //{

            //    change = false;
            //}
        }

        private void deFrom_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbThongKe.Text == "Tuần")
                {
                    deTo.Text = Convert.ToDateTime(deTo.EditValue.ToString()).AddDays(-7).ToString("dd/MM/yyyy");
                }
                if (cbThongKe.Text == "Tháng")
                {
                    deTo.Text = Convert.ToDateTime(deTo.EditValue.ToString()).AddMonths(-1).ToString("dd/MM/yyyy");
                }
                if (cbThongKe.Text == "Quý")
                {
                    deTo.Text = Convert.ToDateTime(deTo.EditValue.ToString()).AddMonths(-3).ToString("dd/MM/yyyy");
                }
                if (cbThongKe.Text == "Năm")
                {
                    deTo.Text = Convert.ToDateTime(deTo.EditValue.ToString()).AddYears(-1).ToString("dd/MM/yyyy");
                }
            }
            catch { }

            showTk();
          
        }
    }
}