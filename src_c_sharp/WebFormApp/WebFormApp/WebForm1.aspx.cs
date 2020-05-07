using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }
    

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Convert.ToString(int.Parse(Label1.Text) + 1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text.Equals("＋"))
            {
                Label2.Text = Convert.ToString(int.Parse(TextBox1.Text) + int.Parse(TextBox2.Text));
            }else if (DropDownList1.Text.Equals("－"))
            {
                Label2.Text = Convert.ToString(int.Parse(TextBox1.Text) - int.Parse(TextBox2.Text));
            }else if (DropDownList1.Text.Equals("×"))
                {
                    Label2.Text = Convert.ToString(int.Parse(TextBox1.Text) * int.Parse(TextBox2.Text));
            }else if (DropDownList1.Text.Equals("÷"))
            {
                Label2.Text = Convert.ToString(int.Parse(TextBox1.Text) / int.Parse(TextBox2.Text));
            }

}

        protected void Button3_Click(object sender, EventArgs e)
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
                                    "FROM student s join country c " +
                                    "ON s.country_id = c.country_id " +
                                    "ORDER BY id";
                // SQLを実行
                SqlDataReader reader = command.ExecuteReader();

                StringBuilder sb = new StringBuilder();

                // 結果を表示
                while (reader.Read())
                {
                    id = (int)reader.GetValue(0);
                    name = (string)reader.GetValue(1);
                    age = (int)reader.GetValue(2);
                    country = (string)reader.GetValue(3);

                    sb.Append("ID:" + id + " 名前:" + name + " 年齢:" + age + " 国:" + country);
                }

                Label3.Text = sb.ToString();

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