using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DefaultController : ApiController
    {
        public ArrayList Get()
        {
            ArrayList list = new ArrayList();
            list.Add("yamamoto");
            list.Add("yuuki");
            list.Add("aaa");
            return list;
        }
    }
}
