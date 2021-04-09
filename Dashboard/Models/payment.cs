using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Models
{
    public class dataPayment
    {
        public List<payment> data { get; set; }

        public dataPayment()
        {
        }

        public dataPayment(List<payment> data)
        {
            this.data = data;
        }

    }
    public class payment
    {
        public int position { get; set; }
        public string name { get; set; }

        public double y { get; set; }

        public string drilldown { get; set; }

        public payment()
        {
        }
        public payment(int position, string name, double y, string drilldown)
        {
            this.position = position;
            this.name = name;
            this.y = y;
            this.drilldown = drilldown;
        }
    }
}
