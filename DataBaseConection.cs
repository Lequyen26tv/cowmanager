﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DataBase
    {
        SqlConnection sqlConn; //Doi tuong ket noi CSDL 
        SqlDataAdapter da;//Bo dieu phoi du lieu 
        DataSet ds; //Doi tuong chhua CSDL khi giao tiep 
        public DataBase()
        {
            string strCnn = "Data Source=HuyLeNe\\HUYLE;Database=QuanLiTrangTrai;User ID=sa;Password=123";

            sqlConn = new SqlConnection(strCnn);
        }
        //Phuong thuc de thuc hien cau lenh strSQL truy vân du lieu 
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        //Phuong thuc de thuc hien cac lenh Them, Xoa, Sua 
        public void ExecuteNonQuery(string strSQL)

        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open(); //Mo ket noi 
            sqlcmd.ExecuteNonQuery();//Lenh hien lenh Them/Xoa/Sua 
            sqlConn.Close();//Dong ket noi 
        }
    }
}
