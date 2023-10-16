using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLThuVien.Areas.DocGia.Controllers
{
    public class ThuThuController : Controller
    {
        // GET: DocGia/ThuThu
        public ActionResult ThuThu()
        {
            return View();
        }
        public ActionResult navThuThu()
        {
            return PartialView();
        }
        public ActionResult Docgia()
        {
            return View();
        }
    }
}