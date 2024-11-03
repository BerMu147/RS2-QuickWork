using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickWork.Model;

namespace QuickWork.Services
{
    public interface IPosloviService
    {
        List<Poslovi> GetList();
    }
}
