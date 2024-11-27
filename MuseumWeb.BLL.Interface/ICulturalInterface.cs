using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePalaceMuseumWeb.BLL.Interface;
using ThePalaceMuseumWeb.EF.Model;

namespace MuseumWeb.BLL.Interface
{
    public interface ICulturalInterface: IBaseInterface
    {
        List<Cultural> GetCulturalByPage(int pageIndex, int pageNum, out int totalPage);
    }
}
