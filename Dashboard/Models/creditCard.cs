using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Models
{
    public class creditCard
    {
        public string name { get; set;}

        public double y { get; set; }

        public bool sliced { get; set; }

        public bool selected { get; set; }
        public creditCard()
        {
        }
        public creditCard(string name, double y, bool sliced = false , bool selected = false)
        {
            this.name = name;
            this.y = y;
            this.sliced = sliced;
            this.selected = selected;
        }




    }
}
