using MuseumWeb.BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThePalaceMuseumWeb.EF.Model;

namespace ThePalaceMuseum.Controllers
{
    public class HomeController : Controller
    {
        NoticeService noticeService = new NoticeService();
        // GET: Home
        public ActionResult Index()
        {
            List<Notice> noticeList = noticeService.GetNotice();
            return View(noticeList);
        }
    }
}