using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace QuanLiTrangTraiBoSua
{
    internal class QuanLiDangNhap
    {
        DataBase db;
        public QuanLiDangNhap()
        {
            db = new DataBase();
        }
        public void ThemUserDangNhap(string ten, string matkhau, string tenphanquyen, int capdophanquyen )
        {
            string sql = string.Format("Insert Into DANGNHAP (USERNAME, PASS, TENPHANQUYEN, CAPDOPHANQUYEN) Values ('{0}','{1}', N'{2}', '{3}')", ten, matkhau, tenphanquyen, capdophanquyen);
            db.ExecuteNonQuery( sql );
        }
    }
}
