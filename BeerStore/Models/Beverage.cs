using System;
namespace BeerStore.Models
{
	public abstract class Beverage
	{
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public decimal ABV { get; set; }
        public bool InStock { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}

