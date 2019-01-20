using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectLyrics.Controllers
{
    public class NarutoController : Controller
    {
        // GET: Naruto
        public string Opening()
        {
            return "This is going to be lit. Believe it!";
        }

        public ActionResult Layout()
        {
            return View();
        }
    }
}