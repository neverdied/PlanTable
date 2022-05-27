using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace mySQLtest
{
    public class sqlhelp
    {

        public static bool local;
        //name="zxcx" connectionString="Server=//IP地址,1433//端口;Database=数据库名字;uid=sa、用户名;pwd=密码;" providerName="System.Data.SqlClient" 
        //server = 47.104.9.146;uid = administrator; pwd = zxwailm1.;database = PLAN
        static string configServer = ConfigurationManager.AppSettings["server"];
        static string configUid = ConfigurationManager.AppSettings["uid"];
        static string configPwd = ConfigurationManager.AppSettings["pwd"];
        static string configDatabase = ConfigurationManager.AppSettings["database"];
        static string configConnectionTimeout = ConfigurationManager.AppSettings["ConnectionTimeout"];
        public static string MySqlCon = "server = " + configServer + ";uid = " + configUid + "; pwd = " + configPwd + ";database = " + configDatabase + ";Connection Timeout=" + configConnectionTimeout;             //在下面我会介绍这部分怎么填写;
        public DataTable ExecuteQuery(string sqlStr)      //用于查询；其实是相当于提供一个可以传参的函数，到时候写一个sql语句，存在string里，传给这个函数，就会自动执行。
        {
            try
            {
                SqlConnection con = new SqlConnection(@MySqlCon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                DataTable dt = new DataTable();
                SqlDataAdapter msda;
                msda = new SqlDataAdapter(cmd);
                msda.Fill(dt);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public int ExecuteUpdate(string sqlStr)      //用于增删改;
        {
            try
            {
                SqlConnection con = new SqlConnection(@MySqlCon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                int iud = 0;
                iud = cmd.ExecuteNonQuery();
                con.Close();
                return iud;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public int GetOneValue(string strStr)
        {
            try
            {
                SqlConnection con = new SqlConnection(@MySqlCon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strStr;
                DataTable dt = new DataTable();
                SqlDataAdapter msda;
                msda = new SqlDataAdapter(cmd);
                msda.Fill(dt);
                con.Close();
                return Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                // MessageBox.Show(ex.Message);
                Console.Write(ex.Message);
                return -1;
            }
        }
        public string GetOneStringValue(string strStr)
        {
            try
            {
                SqlConnection con = new SqlConnection(@MySqlCon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strStr;
                DataTable dt = new DataTable();
                SqlDataAdapter msda;
                msda = new SqlDataAdapter(cmd);
                msda.Fill(dt);
                con.Close();
                return dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return "fail";
            }
        }
    }
}
