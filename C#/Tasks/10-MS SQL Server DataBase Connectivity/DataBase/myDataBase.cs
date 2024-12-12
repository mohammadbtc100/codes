using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace DataBase
{
    public class myDataBase
    {
        public static SqlConnection cnn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        public string strcnn;
        public string sqlcmd;
        public myDataBase()
        {
            cnn = new SqlConnection();
            strcnn = File.ReadAllText(Application.StartupPath + @"\database\database.add");
            cnn.ConnectionString = strcnn;
            cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = sqlcmd;
        }
        public static void connect()
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            else
                MessageBox.Show("فایل بانک اطلاعاتی دردسترس نیست");
        }
        public static void disconnect()
        {
            if (cnn.State != ConnectionState.Closed)
                cnn.Close();
        }
        public void connectionSetting()
        {
            SettingForm frmst = new SettingForm();
            frmst.ShowDialog();
        }
        public string workWithData(string str)
        {
        //  try
        //  {
              
                cmd.CommandText = str;
                connect();
                cmd.ExecuteNonQuery();
                disconnect();
                return "درخواست شما با موفقیت انجام شد";
         //  }
         //   catch
          //  {
          //      return "ثبت اطلاعات با مشکل مواجه شدواطلاعات شما ثبت نشد";
          //  }
        }
        public DataTable selectDataFromDB(string str)
        {
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(str, cnn);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }

        }
        public DataSet selectDataFromDBDataSet(string str1)
        {
            DataSet dt = new DataSet();
            try
            {
                da = new SqlDataAdapter(str1, cnn);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public DataTable selectWithStoreProcedure(string StoreProcedureName)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = new SqlCommand();
            da1.SelectCommand.Connection = cnn;
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            da1.SelectCommand.CommandText = StoreProcedureName;
            da1.Fill(dt);
            return dt;
        }
        public DataSet selectWithStoreProcedureDataSet(string StoreProcedureName)
        {
            DataSet dt = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = new SqlCommand();
            da1.SelectCommand.Connection = cnn;
            da1.SelectCommand.CommandType = CommandType.StoredProcedure;
            da1.SelectCommand.CommandText = StoreProcedureName;
            da1.Fill(dt);
            return dt;
        }
    }
}

