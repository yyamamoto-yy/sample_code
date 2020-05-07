using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDbConn
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            int id = 0;
            string name = string.Empty;
            int age = 0;
            string country = string.Empty;

            try
            {
                command.Connection = connection;
                connection.ConnectionString = @"Data Source=.\SQLEXPRESS;Persist Security Info=True;Initial Catalog=test;Integrated Security=True;";
                //User ID =anvil; Password =anvil; ";

                // データベースの接続開始
                connection.Open();

                // SELECT文を設定
                command.CommandText = "SELECT id,name,age,c.country_name " +
                                    "FROM students s join country c " +
                                    "ON s.country_id = c.country_id";
                // SQLを実行
                SqlDataReader reader = command.ExecuteReader();

                // 結果を表示
                while (reader.Read())
                {
                    id = (int)reader.GetValue(0);
                    name = (string)reader.GetValue(1);
                    age = (int)reader.GetValue(2);
                    country = (string)reader.GetValue(3);

                    Console.WriteLine("ID:" + id + " 名前:" + name + " 年齢:" + age + " 国:" + country);
                }
               
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            finally
            {
                // データベースの接続終了
                connection.Close();
            }
        }
    }
}
    

