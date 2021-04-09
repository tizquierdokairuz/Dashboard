using DashBoard.Mock;
using DashBoard.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashBoard.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult getCreditCardList()
        {
            CreditCardRepository serie = new CreditCardRepository();
            return Json(serie.getAllCreditCardList());
        }

        public JsonResult getBankList()
        {
            BankRepository serie = new BankRepository();
            return Json(serie.getAllBankList());
        }

        public JsonResult getBrandList()
        {
            BrandRepository serie = new BrandRepository();
            return Json(new DataBrand(serie.getAllBrandList()));
        }

        public JsonResult getOperationList()
        {
            OperationRepository serie = new OperationRepository();
            return Json(serie.getAllOperationList());
        }

        public JsonResult getPaymentList()
        {
            PaymentRepository serie = new PaymentRepository();
            return Json(new DataPayment(serie.getAllPaymentList()));
        }
    }
}
