using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace mvcdemo.Controllers
{
    [Authorize]
    public class AjaxController : Controller
    {
        Dictionary<string, string> accounts = new Dictionary<string, string>()
            {
                    { "1001", "Bill Gates"},
                    { "1002", "Larry Ellison"},
                    { "1003", "Larry Page"},
                    { "1004", "Jeff Bezos"},
                    { "1005", "Mark Zukerberg"},
                    { "1006", "Elon Musk"}
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

        public  ActionResult ListAccounts()
        {
            Thread.Sleep(5000);  // 5 sec

            return PartialView(accounts); 
             
        }

        public ActionResult SearchAccounts(string pattern)
        {
            var result = new Dictionary<string, string>();

            foreach (var key in accounts.Keys)
                if (accounts[key].Contains(pattern))
                    result.Add(key, accounts[key]);

            return PartialView("ListAccounts", result);

        }
    }
}