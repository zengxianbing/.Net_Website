using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    class DataAccess
    {
        string sqlstr = @"server=HP-PC;database=CCUT;uid=sa;pwd=336699asdf";
        string sqlstr1 = @"server=HP-HP\HP;database=Information;integrated security=sspi";
        SqlConnection con;
        private void open()
        {
            con = new SqlConnection(sqlstr );
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
         }
        private void open1()
        {
            con = new SqlConnection(sqlstr1);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void close()
        {
            con = new SqlConnection(sqlstr);
            if (con.State == ConnectionState.Open )
            {
                con.Close() ;
            }
        }
        public DataTable gettable(string str)
        {
            open();
            SqlDataAdapter ada = new SqlDataAdapter(str, con);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }
        public DataTable gettable(string str, SqlParameter[] para)
        {
            open();
            SqlDataAdapter ada = new SqlDataAdapter(str,con);
            ada.SelectCommand.Parameters.AddRange(para );
            DataTable table = new DataTable();
            ada.Fill(table );
            return table;
        }
        public int ExecuteSQL(string strSql)
        {
            open();
            SqlCommand com = new SqlCommand(strSql, con);
            com.CommandType = CommandType.Text;
            int i = com.ExecuteNonQuery();
       
            return i;
        }
        public int ExecuteSQL(string strSql, SqlParameter[] param)//重载
        {
            open();
            SqlCommand com = new SqlCommand(strSql, con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddRange(param);
            int i = com.ExecuteNonQuery();
            return i;
        }
        public SqlDataReader getreader(string str, SqlParameter[] param)
        {
            open();
            SqlCommand com = new SqlCommand(str,con );
            com.Parameters.AddRange(param );
            SqlDataReader reader = com.ExecuteReader();
            return reader;
        }
        public SqlDataReader getreader(string str)
        {
            open();
            SqlCommand com = new SqlCommand(str, con);
            SqlDataReader reader = com.ExecuteReader();
         
            return reader;
        }
        public DataTable getDataTable(string proName, SqlParameter[] param)
        {
            open();
            SqlCommand com = new SqlCommand();
            com.CommandText = proName;
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddRange(param);
            SqlDataAdapter ada = new SqlDataAdapter();
            ada.SelectCommand = com;
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
        }
      
    }
}
