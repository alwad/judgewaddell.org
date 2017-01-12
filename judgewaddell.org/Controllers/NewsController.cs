using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace judgewaddell.org.Controllers
{
    public class NewsController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

    }
}