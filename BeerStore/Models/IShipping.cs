using System;
namespace BeerStore.Models
{
	public interface IShipping
	{
		string Carrier { get; set; }
		DateTime PickUpDate { get; set; }
		decimal CalculateShipping();
	}
}

