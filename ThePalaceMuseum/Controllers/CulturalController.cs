using MuseumWeb.BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThePalaceMuseumWeb.EF.Model;

namespace ThePalaceMuseum.Controllers
{
    public class CulturalController : Controller
    {
        CulturalService culturalService = new CulturalService();
        CulturalCollectService collectService = new CulturalCollectService();
        // GET: Cultural
        public ActionResult Cultural()
        {
            return View();
        }
        public ActionResult CulturalCollect()
        {
            List<CollectCategory> collectCategorieList = collectService.GetCollectCategory();
            return View(collectCategorieList);
        }
        public ActionResult CulturalCollectContext(int pageIndex = 1)
        {
            int totalPage = 0;
            List<Cultural> culturalList = culturalService.GetCulturalByPage(pageIndex, 30, out totalPage);
            ViewBag.totalPage = totalPage;
            ViewBag.pageIndex = pageIndex;

            return View(culturalList);
        }
    }
}