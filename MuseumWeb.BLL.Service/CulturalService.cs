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
    public class CulturalService : BaseService, ICulturalInterface
    {
        MuseumContext museumContext = new MuseumContext();
        public List<Cultural> GetCulturalByPage(int pageIndex, int pageNum, out int totalPage)
        {
            //LINQ分页
            List<Cultural> culturalList = (from item in museumContext.Cultural
                                     orderby item.id
                                     select item).Skip((pageIndex - 1) * pageNum).Take(pageNum).ToList();
            int totalNum = museumContext.Cultural.Count();
            if (totalNum / pageNum == 0)
            {
                totalPage = totalNum / pageNum;
            }
            else
            {
                totalPage = totalNum / pageNum + 1;
            }
            return culturalList;
        }
    }
}
