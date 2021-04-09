using DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Mock
{
    public class creditCardRepository
    {

        public List<creditCard> GetAllCreditCardList()
        {
            List<creditCard> list = new List<creditCard>();
            list.Add(new creditCard("BBVA Tarjeta Visa Internacional", 183));
            list.Add(new creditCard("Visa Internacional Banco Itaú", 181.50));
            list.Add(new creditCard("ICBC Start Visa", 107));
            list.Add(new creditCard("Naranja Visa", 301.29));
            list.Add(new creditCard("Visa Internacional Banco Comafi", 155));
            list.Add(new creditCard("Galicia Visa Internacional", 220));
            list.Add(new creditCard("Galicia Visa Gold", 220));
            list.Add(new creditCard("BBVA Tarjeta Visa Gold Latam Pass", 1916));
            return list;
        }

    }
}
