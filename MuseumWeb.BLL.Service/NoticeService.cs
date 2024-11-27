using MuseumWeb.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePalaceMuseumWeb.BLL.Service;
using ThePalaceMuseumWeb.EF.Model;

namespace MuseumWeb.BLL.Service
{
    public class NoticeService : BaseService, IHomeInterface
    {
        MuseumContext museumContext = new MuseumContext();
        public List<Notice> GetNotice()
        {
            List<Notice> noticeList = (from item in museumContext.Notice
                                                 orderby item.id
                                                          select item).ToList();
            return noticeList;
        }
    }
}
