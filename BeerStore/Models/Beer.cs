using System;
using BeerStore.Models;

namespace BeerStore.Models
{
	public class Beer :  Beverage, IShipping
	{
		public BeerType BeerType { get; set; }
        public string Carrier { get; set; }
        public DateTime PickUpDate { get; set; }

        public decimal CalculateShipping()
        {
            decimal cost = 0;

            return cost = (decimal)(.10 * 15);
        }
    }
}

