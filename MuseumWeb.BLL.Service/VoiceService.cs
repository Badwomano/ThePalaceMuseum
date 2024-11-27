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
    public class VoiceService : BaseService, IVoiceInterface
    {
        MuseumContext museumContext = new MuseumContext();
        public List<Voice> GetVoiceByPage(int pageIndex, int pageNum, out int totalPage)
        {
            //LINQ分页
            List<Voice> voiceList = (from item in museumContext.Voice
                                     orderby item.id
                                     select item).Skip((pageIndex - 1) * pageNum).Take(pageNum).ToList();
            int totalNum = museumContext.Voice.Count();
            if (totalNum/pageNum==0)
            {
                totalPage = totalNum / pageNum;
            }
            else
            {
                totalPage = totalNum / pageNum + 1;
            }
            return voiceList;
        }
    }
}
