using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Models
{
    public class DataBrand
    {
        public List<Brand> data { get; set; }

        public DataBrand()
        {
        }

        public DataBrand(List<Brand> data)
        {
            this.data = data;
        }

    }
    public class Brand
    {
        public int position { get; set; }
        public string name { get; set; }

        public double y { get; set; }

        public string drilldown { get; set; }

        public Brand()
        {
        }
        public Brand(int position, string name, double y, string drilldown)
        {
            this.position = position;
            this.name = name;
            this.y = y;
            this.drilldown = drilldown;
        }
    }
}
