using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Models
{
    public class DataPayment
    {
        public List<Payment> data { get; set; }

        public DataPayment()
        {
        }

        public DataPayment(List<Payment> data)
        {
            this.data = data;
        }

    }
    public class Payment
    {
        public int position { get; set; }
        public string name { get; set; }

        public double y { get; set; }

        public string drilldown { get; set; }

        public Payment()
        {
        }
        public Payment(int position, string name, double y, string drilldown)
        {
            this.position = position;
            this.name = name;
            this.y = y;
            this.drilldown = drilldown;
        }
    }
}
