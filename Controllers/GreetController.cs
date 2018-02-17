using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mvcdemo.Controllers
{
    public class GreetController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Web API";
        }
        [HttpGet]
        public string Get(string id)
        {
            return id + ",Hello Web API";
        }
    }
}
