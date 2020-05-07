using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
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
                command.CommandText = "DELETE from student " + 
                                      "WHERE id = " + int.Parse(TextBox1.Text);
                //+ "," + "SELECT country_id FROM country WHERE country_name = '" + country + "')" ;
                // SQLを実行
                int lineCount = command.ExecuteNonQuery();

                Label1.Text = "削除しました。";

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

        protected void Button2_Click(object sender, EventArgs e)
        {
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
                command.CommandText = "UPDATE student " +
                                      "SET name = '" + TextBox3.Text + 
                                      "',age = " + int.Parse(TextBox4.Text) +
                                      "WHERE id = " + int.Parse(TextBox2.Text);
                //+ "," + "SELECT country_id FROM country WHERE country_name = '" + country + "')" ;
                // SQLを実行
                int lineCount = command.ExecuteNonQuery();

                Label6.Text = "更新しました。";

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