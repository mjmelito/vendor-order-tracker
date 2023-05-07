using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
  
namespace Vendor.Controllers
{
    public class VendorsController : Controller
    {

        [HttpGet("/Vendors")]
        public ActionResult Index()
        {
        List<Vendor> allVendors = Vendor.GetAll();
        return View(allVendors);
        }
  

    }
}
