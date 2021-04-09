using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Models
{
    public class dataBrand
    {
        public List<brand> data { get; set; }

        public dataBrand()
        {
        }

        public dataBrand(List<brand> data)
        {
            this.data = data;
        }

    }
    public class brand
    {
        public int position { get; set; }
        public string name { get; set; }

        public double y { get; set; }

        public string drilldown { get; set; }

        public brand()
        {
        }
        public brand(int position, string name, double y, string drilldown)
        {
            this.position = position;
            this.name = name;
            this.y = y;
            this.drilldown = drilldown;
        }
    }
}
