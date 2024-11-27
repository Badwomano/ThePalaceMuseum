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
    public class CulturalCollectService : BaseService, CulturalCollectInterface
    {
        MuseumContext museumContext = new MuseumContext();
        public List<CollectCategory> GetCollectCategory()
        {
            List<CollectCategory> collectCategorieList = (from item in museumContext.CollectCategory
                                                          orderby item.id select item).ToList();
            return collectCategorieList;
        }
    }
}
 