using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    public class AjaxController : Controller
    {
        Dictionary<string, string> accounts = new Dictionary<string, string>()
            {
                    { "1001", "Bill Gates"},
                    { "1002", "Larry Ellison"},
                    { "1003", "Larry Page"}
            };

        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public string Now()
        {
            return DateTime.Now.ToString();
        }


        public string GetHolder(string id)
        {
            if (accounts.Keys.Contains(id))
                return accounts[id];
            else
                return "Account Not Found!";

        }

        public string ListAccount()
        {
            string  output = "<table><tr><th>Acno </th><th>Holder Name</th></tr>";

            foreach (string key in accounts.Keys)
                output += "<tr><td>" + key + "</td><td>" + accounts[key] + "</td></tr>";

            output += "</table>";

            return output;

        }
    }
}