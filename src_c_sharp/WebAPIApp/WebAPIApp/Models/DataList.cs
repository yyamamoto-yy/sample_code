using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAPIApp.Models
{
    

    public class DataList {
        public List<Models.DataList> list = new List<DataList>();
        public int id;
        public string name;
        public int age;
        public string country;



            public void setId(int id)
            {
                this.id = id;
            }
            public void setName(string name)
            {
                this.name = name;
            }
            public void setAge(int age)
            {
                this.age = age;
            }
            public void setCountry(string country)
            {
                this.country = country;
            }

                 

        public static explicit operator DataList(ArrayList v)
        {
            throw new NotImplementedException();
        }

        public void SelectData() {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
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
                 
                // 結果を取得
                while (reader.Read())
                {
                    DataList bean = new DataList();
                    bean.setId((int)reader.GetValue(0));
                    bean.setName((string)reader.GetValue(1));
                    bean.setAge((int)reader.GetValue(2));
                    bean.setCountry((string)reader.GetValue(3));

                    //id.Add((int) reader.GetValue(0));
                    //name.Add((string) reader.GetValue(1));
                    //age.Add((int) reader.GetValue(2));
                    //country.Add((string) reader.GetValue(3));

                    list.Add(bean);
                                       
                    //Console.WriteLine("ID:" + id + " 名前:" + name + " 年齢:" + age + " 国:" + country);
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