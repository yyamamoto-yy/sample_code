using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Content()
        {
            Models.Item item = new Models.Item();
            item.Name = "ペンギン";
            item.Value = 830;
            item.Code = "p-001";

            return View(item);
        }

        public ActionResult DataList()
        {
            Models.DataList data = new Models.DataList();
            data.SelectData();
            
            List<Models.DataList> list = new List<Models.DataList>();
            list = data.list;
            return View(list);
        }
        [HttpPost]
        public ActionResult DataAdd(string name,string age,string country)
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
                command.CommandText = "INSERT INTO student (name,age,country_id) " +
                                        "VALUES ('" + name + "'," +
                                        int.Parse(age) + ",'0001')";
                                        //+ "," + "SELECT country_id FROM country WHERE country_name = '" + country + "')" ;
                // SQLを実行
                int lineCount = command.ExecuteNonQuery();


                return View();//DataAdd.cshtml

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