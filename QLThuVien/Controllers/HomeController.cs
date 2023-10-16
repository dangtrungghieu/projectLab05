using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLThuVien.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult navBarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult Sach()
        {
            return View();
        }
    }
}