using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Models
{
    public class Operation
    {
        public string name { get; set; }

        public List<double> data { get; set; }

        public string pointPlacement { get; set; }

        public Operation()
        {
        }
        public Operation(string name, List<double> data, string pointPlacement)
        {
            this.name = name;
            this.data = data;
            this.pointPlacement = pointPlacement;
        }




    }
}
