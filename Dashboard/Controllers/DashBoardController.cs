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
            creditCardRepository serie = new creditCardRepository();
            return Json(serie.GetAllCreditCardList());
        }

        public JsonResult getBankList()
        {
            bankRepository serie = new bankRepository();
            return Json(serie.GetAllBankList());
        }

        public JsonResult getBrandList()
        {
            brandRepository serie = new brandRepository();
            return Json(new dataBrand(serie.GetAllBrandList()));
        }

        public JsonResult getOperationList()
        {
            operationRepository serie = new operationRepository();
            return Json(serie.GetAllOperationList());
        }

        public JsonResult getPaymentList()
        {
            paymentRepository serie = new paymentRepository();
            return Json(new dataPayment(serie.GetAllPaymentList()));
        }
    }
}
