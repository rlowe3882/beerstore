using System;
using BeerStore.Models;

namespace BeerStore.Models
{
	public static class Shipping
	{
        public static decimal Cost { get; set; }

		public static decimal CalculateShippingCost(List<IShipping> Items)
        {
			

			foreach(var item in Items)
            {
				Cost += item.CalculateShipping();
            }

			return Cost;

        }


		
	}
}

