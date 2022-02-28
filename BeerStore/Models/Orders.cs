using System;
using BeerStore.Models;

namespace BeerStore.Models
{
	public class Orders
	{
		public decimal Cost { get; set; }


		public decimal GetOrderTotal(List<IShipping> items)
        {
			Shipping.CalculateShippingCost(items);
			this.Cost = Shipping.Cost;

			return Cost;


        }

		public async Task<string> GetResponse()
        {
			string x = await Services.Service.GetResponse("ASDF");
			return x;

        }
	}
}

