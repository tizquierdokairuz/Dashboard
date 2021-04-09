using DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Mock
{
    public class CreditCardRepository
    {

        public List<CreditCard> getAllCreditCardList()
        {
            List<CreditCard> list = new List<CreditCard>();
            list.Add(new CreditCard("BBVA Tarjeta Visa Internacional", 183));
            list.Add(new CreditCard("Visa Internacional Banco Itaú", 181.50));
            list.Add(new CreditCard("ICBC Start Visa", 107));
            list.Add(new CreditCard("Naranja Visa", 301.29));
            list.Add(new CreditCard("Visa Internacional Banco Comafi", 155));
            list.Add(new CreditCard("Galicia Visa Internacional", 220));
            list.Add(new CreditCard("Galicia Visa Gold", 220));
            list.Add(new CreditCard("BBVA Tarjeta Visa Gold Latam Pass", 1916));
            return list;
        }

    }
}
