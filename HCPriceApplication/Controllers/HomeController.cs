
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HCPriceApplication.Models;

namespace HCPriceApplication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] // http get request
        public IActionResult Index() // Index method view returned
        {
            ViewBag.Discount = 0; // discount variable declared
            ViewBag.Total = 0; // total variable declared
            return View(); // view returned
        }

        [HttpPost] // http post request
        public IActionResult Index(Quotation model) //index view with calculations calculated
        {
            if (ModelState.IsValid) // if the model state is valid..
            {
                ViewBag.Discount = model.CalculateDiscount(); // set discount variable in view model to the calculated discount
                ViewBag.Total = model.CalculateTotal(); // set total variable in view model to the calculated total
            }
            else // if model state isnt valid..
            {
                ViewBag.Discount = 0; // keep variables at 0
                ViewBag.Total = 0; // keep variables at 0
            }
            return View(model); //return completed model

        }
    }
}