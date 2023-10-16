using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLThuVien.Areas.DocGia.Controllers
{
    public class AdminController : Controller
    {
        // GET: DocGia/Admin
        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult navAdminPartial()
        {
            return PartialView();
        }

        public ActionResult NhanVien()
        {
            return PartialView();
        }
    }
}