using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationDb.Models;
using Npgsql;
using System.Data;

namespace WebApplicationDb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var connString = @"Server=localhost;Port=5432;User Id=postgres;Password=anvil;Database=testdb";

            var model = new WebApplicationDb.Models.List();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                var dataAdapter = new NpgsqlDataAdapter(@"select * from list", conn);

                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                model.id = (int)dataSet.Tables[0].Rows[1]["id"];
                model.name = (string)dataSet.Tables[0].Rows[1]["name"];
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
