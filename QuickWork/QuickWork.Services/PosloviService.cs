using QuickWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickWork.Services
{
    public class PosloviService : IPosloviService
    {
        public List<Poslovi> List = new List<Poslovi>()
        {
            new Poslovi()
            {
                PosaoID = 1,
                Naziv = "Pomagac",
                Cijena = 30
            },
            new Poslovi()
            {
                PosaoID = 2,
                Naziv = "Irget",
                Cijena = 40
            }
        };
        public List<Poslovi> GetList()
        {
            return List;
        }
    }
}