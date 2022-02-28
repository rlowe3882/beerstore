using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeerStore.Models;
using BeerStore.ViewModels;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeerStore.Controllers
{
    public class BeerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Beer> beers = new List<Beer>();

            BeerViewModel beer = new BeerViewModel();
            beers = beer.GetBeers();

            return View(beers);
        }
    }
}

