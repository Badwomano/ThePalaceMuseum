using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePalaceMuseumWeb.BLL.Interface;
using ThePalaceMuseumWeb.EF.Model;

namespace MuseumWeb.BLL.Interface
{
    public interface IVoiceInterface: IBaseInterface
    {
        //分页的操作 输出参数return
        List<Voice> GetVoiceByPage(int pageIndex, int pageNum,out int totalPage);
    }
}
