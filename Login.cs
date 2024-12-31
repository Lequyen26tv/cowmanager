using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace QuanLiTrangTraiBoSua
{
    internal class Login
    {
        DataBase db;
        public Login() {
            db  = new DataBase();
        }
        public DataTable LayPhanQuyen()
        {
            string sqlSQL = "Select TENPHANQUYEN from DANGNHAP";
            DataTable dt = db.Execute(sqlSQL);
            return dt;
        }
    }
}
