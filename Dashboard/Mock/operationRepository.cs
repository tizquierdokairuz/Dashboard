using DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Mock
{
    public class OperationRepository
    {

        public List<Operation> getAllOperationList()
        {
            List<Operation> list = new List<Operation>();

            List<double> dataj = new List<double>() { 43000, 19000, 60000, 35000, 17000, 10000 };
            List<double> dataf = new List<double>() { 50000, 39000, 42000, 31000, 26000, 14000 };

            list.Add(new Operation("Personas Juridicas", dataj, "on"));
            list.Add(new Operation("Personas Fisicas", dataf, "on"));

            return list;
        }

    }
}
