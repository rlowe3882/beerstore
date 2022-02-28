using System;
namespace BeerStore.Models
{
    public class Wine : Beverage, IShipping
    {
        public string Carrier { get; set; }
        public DateTime PickUpDate { get; set; }

        public decimal CalculateShipping()
        {
            decimal cost = 0;
            return cost = (decimal)(.10 * 25);
        }
    }
}

