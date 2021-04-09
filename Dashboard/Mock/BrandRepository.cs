using DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Mock
{
    public class BrandRepository
    {
        public List<Brand> getAllBrandList()
        {
            List<Brand> list = new List<Brand>();
            list.Add(new Brand(1, "YPF", 1207, null));
            list.Add(new Brand(2, "Quilmes", 603, null));
            list.Add(new Brand(3, "Macro", 502, null));
            list.Add(new Brand(4, "Personal", 348, null));
            list.Add(new Brand(5, "Galicia", 297, null));
            list.Add(new Brand(6, "Mercado Libre", 265, null));
            return (list);

        }
    }
}
