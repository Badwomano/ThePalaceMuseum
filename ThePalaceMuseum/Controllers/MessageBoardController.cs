using MuseumWeb.BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThePalaceMuseumWeb.EF.Model;

namespace ThePalaceMuseum.Controllers
{
    public class MessageBoardController : Controller
    {
        // GET: MessageBoard
        VoiceService voiceService = new VoiceService();
        public ActionResult MessageBoard(int pageIndex=1)
        {
            int totalPage = 0;
            List<Voice> voiceList = voiceService.GetVoiceByPage(pageIndex, 9, out totalPage);
            ViewBag.totalPage = totalPage;
            ViewBag.pageIndex = pageIndex;

            return View(voiceList);
        }
    }
}