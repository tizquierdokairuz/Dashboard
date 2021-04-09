using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Models
{
    public class CreditCard
    {
        public string name { get; set;}

        public double y { get; set; }

        public bool sliced { get; set; }

        public bool selected { get; set; }
        public CreditCard()
        {
        }
        public CreditCard(string name, double y, bool sliced = false , bool selected = false)
        {
            this.name = name;
            this.y = y;
            this.sliced = sliced;
            this.selected = selected;
        }




    }
}
