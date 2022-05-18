using System;
using jeweleryShop.Data.Interfaces;
using jeweleryShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace jeweleryShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProducts _prodRep;
        public HomeController(IProducts pRep)
        {
           _prodRep = pRep;
        }
        [Route("")]
        public ViewResult Index()
        {
            var homeProds = new HomeViewModel
            {
                popularProduct = _prodRep.getPopulars
            };

            return View(homeProds);
        }
    }
}
