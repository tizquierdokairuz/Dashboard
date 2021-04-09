using DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Mock
{
    public class brandRepository
    {
        public List<brand> GetAllBrandList()
        {
            List<brand> list = new List<brand>();
            list.Add(new brand(1, "YPF", 1207, null));
            list.Add(new brand(2, "Quilmes", 603, null));
            list.Add(new brand(3, "Macro", 502, null));
            list.Add(new brand(4, "Personal", 348, null));
            list.Add(new brand(5, "Galicia", 297, null));
            list.Add(new brand(6, "Mercado Libre", 265, null));
            return (list);

        }
    }
}
