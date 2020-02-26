using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L5R_DBH_MVC.Controllers
{
    public class DecksController : Controller
    {
        // GET: Decks
        public ActionResult Index()
        {
            return View();
        }
    }
}