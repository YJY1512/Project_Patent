using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;


namespace Project_Patent
{
    public class CommonDAO : IDisposable
    {
        string connStr = ConfigurationManager.ConnectionStrings["jyproject"].ConnectionString;
        MySqlConnection conn;

        public CommonDAO()
        {
            conn = new MySqlConnection(connStr);
        }

        public void Dispose()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // 복수의 카테고리를 배열로 입력 받음
        // DB에 접속 하나 이상의 카테고리에 대한 DB를 리턴
        public DataTable CommonDataList(string[] categorys)
        {
            DataTable dt = new DataTable();

            string temp = "'" + string.Join("','", categorys) + "'";

            string sql = $@"select * from cmntable
                            where category in ({temp})";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);



            da.Fill(dt);

            return dt;
        }


    }
}
