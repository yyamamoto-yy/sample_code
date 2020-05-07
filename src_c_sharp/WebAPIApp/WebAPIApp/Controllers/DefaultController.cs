using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using WebAPIApp.Models;
using DataList = WebAPIApp.Models.DataList;

namespace WebAPIApp.Controllers
{
    public class DefaultController : ApiController
    {
        public MyItem GetItem()
        {
            MyItem item = new MyItem();
            item.name = "ペンギンクッキー";
            item.count = 8;
            item.price = 280;
            item.code = "PC-01W";

            return item;
        }

        public List<DataList> PostList()
        {
            DataList data = new DataList();
            data.SelectData();

            List<DataList> list = new List<DataList>();
            list = data.list;
            return list;
        }
    }
}
