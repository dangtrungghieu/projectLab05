using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLThuVien.Areas.DocGia.Controllers
{
    public class DocGiaController : Controller
    {
        // GET: DocGia/DocGia
        public ActionResult DocGia()
        {
            return View();
        }
        public ActionResult navDocGiaPartial()
        {
            return PartialView();
        }

    }
}