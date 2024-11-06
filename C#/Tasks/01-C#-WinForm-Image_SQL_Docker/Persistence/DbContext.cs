using DbLab2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbLab2.Persistence
{
    internal class DbContext
    {
        private string strCnn;
        private SqlConnection cnn;
        private SqlCommand cmd;
        public DbContext()
        {
            strCnn = @"Server=localhost,1433;Database=mydb1;User Id=dblab2;Password=Fall@f2024;";
           cnn=new SqlConnection(strCnn);
        }
        public int add(Novel novel)
        {
            cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "addNovel";
            cmd.Parameters.AddWithValue("@name",novel.name);
            cmd.Parameters.AddWithValue("@cover", novel.cover);
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
            int r=cmd.ExecuteNonQuery();
            if (cnn.State!=ConnectionState.Closed)
                cnn.Close();
            return r;
        }
        public int delete(int id) {

            cmd = new SqlCommand("delete from novels where id="+id, cnn);
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
            int r = cmd.ExecuteNonQuery();
            if (cnn.State != ConnectionState.Closed)
                cnn.Close();
            return r;
        }
        public DataTable getList() { 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from novels",cnn);
            da.Fill(dt);
            return dt;
        }
        public byte[] imageToBytes(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }
        public Image bytesToImage(byte[] imageData)
        {
            Image newImage;
            using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
            {
                ms.Write(imageData, 0, imageData.Length);
                newImage = Image.FromStream(ms, true);
            }
            return newImage;
        }
    }
}
