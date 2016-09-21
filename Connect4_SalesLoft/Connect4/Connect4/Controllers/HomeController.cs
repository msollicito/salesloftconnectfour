using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Connect4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Play Connect4 with SalesLoft by clicking where you wish to place a piece and making a line of four in any direction - vertically, horizontally or diagonally.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Connect4 from Salesloft is a brand new concept in online games for Sales Freaks.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "To get in touch with us, call us at";

            return View();
        }
    }
}
