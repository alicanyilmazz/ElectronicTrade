using ElectronicTrade.BusinessLayer;
using ElectronicTrade.BusinessLayer.OperationManagers;
using ElectronicTrade.Web.ViewModels.EntityViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElectronicTrade.Web.Controllers
{
    public class HomeController : Controller
    {
        ProductManager mngr_product = new ProductManager();

        [HttpGet]
        public ActionResult Index()
        {
            //Testing ts = new Testing();
            //ts.testing_method();


            return View();
        }

        [HttpGet]
        public PartialViewResult HomeProduct()
        {
            var products = mngr_product.List();
            ProductViewModel vm_product = new ProductViewModel();
            vm_product.products = products;

            return PartialView("_PartialHomePageProduct",vm_product);
        }
    }
}