using DashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Mock
{
    public class PaymentRepository
    {
        public List<Payment> getAllPaymentList()
        {
            List<Payment> list = new List<Payment>();
            list.Add(new Payment(1, "Mercado Pago", 155, null));
            list.Add(new Payment(2, "Visa", 134, null));
            list.Add(new Payment(3, "Master Card", 125, null));
            list.Add(new Payment(4, "American Express", 110, null));
            list.Add(new Payment(5, "Paypal", 67, null));
            list.Add(new Payment(6, "Naranja X", 55, null));
            list.Add(new Payment(7, "Dinners Club", 54, null));
            list.Add(new Payment(8, "2CheckOut", 34, null));
            list.Add(new Payment(9, "Lay-Buy", 12, null));
            list.Add(new Payment(10, "Payu", 11, null));
            list.Add(new Payment(11, "Yacare", 10, null));
            return (list);

        }
    }
}
