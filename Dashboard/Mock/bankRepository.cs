using DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Mock
{
    public class BankRepository
    {

        public List<Bank> getAllBankList()
        {
            List<Bank> list = new List<Bank>();
            list.Add(new Bank("Santander Rio", 36.4, null));
            list.Add(new Bank("Galicia", 31.9, null));
            list.Add(new Bank("BBVA Francés", 26.6, null));
            list.Add(new Bank("Nación", 23.5, null));
            list.Add(new Bank("Macro", 14.8, null));
            list.Add(new Bank("ICBC", 13.3, null));
            return list;
        }

    }
}
