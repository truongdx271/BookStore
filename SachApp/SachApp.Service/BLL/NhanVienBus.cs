using SachApp.Service.Dao;
using SachApp.Service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachApp.Service.BLL
{
    public class NhanVienBus
    {
        NhanVienDao dao = new NhanVienDao();
        public DataTable GetData()
        {
            return dao.GetData();
        }
        public DataTable GetDataByAccount(string TK, string MK)
        {
            return dao.GetDataByAccount(TK,MK);
        }

        public int Insert(NhanVien obj)
        {
            return dao.Insert(obj);
        }
        public int Update(NhanVien obj)
        {
            return dao.Update(obj);
        }
        public int Update_MK(NhanVien obj)
        {
            return dao.Update_MK(obj);
        }
        public int Delete(int id)
        {
            return dao.Delete(id);
        }
    }
}
