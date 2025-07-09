using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace judgewaddell.org.Controllers
{
    public class AboutController : Controller
    {
        [HttpGet]
        public ActionResult TheJudge()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Scholarship()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Awards()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Books()
        {
            return View();
        }

        [HttpGet]
        public ActionResult RiceLetter()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Donate()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Gallery()
        {
            ViewBag.Images = Directory.EnumerateFiles(Server.MapPath("~/content/gallery"))
                            .Select(fn => "/content/gallery/" + Path.GetFileName(fn)).ToList();

            ViewBag.Count = ViewBag.Images.Count;

            return View();
        }

		[HttpGet]
		public ActionResult HallOfFameGallery()
		{
			ViewBag.Images = Directory.EnumerateFiles(Server.MapPath("~/content/hof-gallery"))
							.Select(fn => "/content/hof-gallery/" + Path.GetFileName(fn)).ToList();

			ViewBag.Count = ViewBag.Images.Count;

			return View();
		}
	}
}
