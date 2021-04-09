using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Models
{
    public class Bank
    {
        public string name { get; set; }

        public double y { get; set; }

        public string drilldown { get; set; }

        public Bank()
        {
        }
        public Bank(string name, double y, string drilldown)
        {
            this.name = name;
            this.y = y;
            this.drilldown = drilldown;
        }




    }
}
