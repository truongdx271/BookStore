using SachApp.Service.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SachApp.Service.Dao
{
    public class NhanVienDao : dbContext
    {
        public DataTable GetDataByName(string userName, string password)
        {
            SqlParameter[] para =
            {
                new SqlParameter("TAIKHOAN", userName),
                new SqlParameter("MATKHAU",password)
            };
            return base.GetData("NHANVIEN_GET_BY_USER", para);
        }
    }
}
