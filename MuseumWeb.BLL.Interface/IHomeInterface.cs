using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePalaceMuseumWeb.BLL.Interface;
using ThePalaceMuseumWeb.EF.Model;

namespace MuseumWeb.BLL.Interface
{
    public interface IHomeInterface: IBaseInterface
    {
        List<Notice> GetNotice();
    }
}
