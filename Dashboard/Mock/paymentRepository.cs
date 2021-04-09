using DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Mock
{
    public class paymentRepository
    {
        public List<payment> GetAllPaymentList()
        {
            List<payment> list = new List<payment>();
            list.Add(new payment(1, "Mercado Pago", 155, null));
            list.Add(new payment(2, "Visa", 134, null));
            list.Add(new payment(3, "Master Card", 125, null));
            list.Add(new payment(4, "American Express", 110, null));
            list.Add(new payment(5, "Paypal", 67, null));
            list.Add(new payment(6, "Naranja X", 55, null));
            list.Add(new payment(7, "Dinners Club", 54, null));
            list.Add(new payment(8, "2CheckOut", 34, null));
            list.Add(new payment(9, "Lay-Buy", 12, null));
            list.Add(new payment(10, "Payu", 11, null));
            list.Add(new payment(11, "Yacare", 10, null));
            return (list);

        }
    }
}
