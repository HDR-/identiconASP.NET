using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdenticonTest1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string c)
        {
            ViewBag.Message = "One simple solution for you to recognize people online";
            if (string.IsNullOrEmpty(c))
            {
                ViewBag.imageURL1 = "http://54.213.104.16:8080/heng_identicon/IdenticonServlet?c=123456&s=64";
                ViewBag.imageURL2 = "http://54.213.104.16:8080/heng_identicon/MyIdenticonServlet?c=123456&s=64";
                ViewBag.code = " Example: 123456";
            }
            else
            {
                ViewBag.imageURL1 = "http://54.213.104.16:8080/heng_identicon/IdenticonServlet?c="+c+"&s=64";
                ViewBag.imageURL2 = "http://54.213.104.16:8080/heng_identicon/MyIdenticonServlet?c=" + c + "&s=64";
                ViewBag.code=c;
            }
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "identicon demo";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "me";

            return View();
        }
    }
}
