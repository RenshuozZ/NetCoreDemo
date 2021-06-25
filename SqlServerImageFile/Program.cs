using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SqlServerImageFile
{
    class Program
    {
        public static string connectionString = "Server=.; Database=Demo; User ID=sa; Password=qq123456; Trusted_Connection=False";
        static void Main(string[] args)
        {

            Save();
            Console.WriteLine("Hello World!");
        }
        public static void Save()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            //打开数据库  
            connection.Open();
            //Console.WriteLine("打开数据库连接成功");
            string strqry = "select * from FileBlob";
            SqlCommand cmd = new SqlCommand(strqry, connection);
            SqlDataReader dr;//创建DataReader对象  
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.Write(dr["id"].ToString() + ",");
                Console.Write(dr["Blob"].ToString() + ",");
                using (FileStream wr = new FileStream(@"D:\11.docx", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    var bt = (byte[])dr["Blob"];
                    wr.Write(bt, 0, bt.Length);
                }

            }
            dr.Close();
        }
        public static void Insert()
        {
            byte[] photo = null;
            using (FileStream stream = new FileStream(@"D:\新建文本文档.txt", FileMode.Open, FileAccess.Read))
            {
                BinaryReader reader = new BinaryReader(stream);
                photo = reader.ReadBytes((int)stream.Length);
            }
            using (SqlConnection connection = new SqlConnection(
    connectionString))
            {
                SqlCommand command = new SqlCommand(
                  "INSERT INTO FileBlob (Id, Blob) Values(@Id, @Blob)", connection);

                command.Parameters.Add("@Id",
                   SqlDbType.Int).Value = 1;

                command.Parameters.Add("@Blob",
                    SqlDbType.Image, photo.Length).Value = photo;

                connection.Open();
                command.ExecuteNonQuery();

            }


        }

    }
}
