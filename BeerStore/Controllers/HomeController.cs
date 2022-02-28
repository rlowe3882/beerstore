using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BeerStore.Models;
using BeerStore.Services;

namespace BeerStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        



        return View();
    }

 
    public async Task<IActionResult> ShippingCost()
    {
        //calc shipping costs from view post method
        List<IShipping> items = new List<IShipping>();
        items.Add(new Beer { Id = 1, ABV = (decimal)10.0, BeerType = BeerType.Stout, Brand = "Great Lakes", Title = "Xmas Ale" });
        items.Add(new Wine { Id = 2, ABV = (decimal)7.0, Brand = "California Wines", Title = "Red Wine" });

        Orders orders = new Orders();
        orders.GetOrderTotal(items);

        await orders.GetResponse();

        

    


        return View(orders);

    }

  

    public async Task<IActionResult> Privacy()
    {

        await Service.GetStringTestAsync();



        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

