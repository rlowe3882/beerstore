using System;
using BeerStore.Models;
using System.Collections;

namespace BeerStore.ViewModels
{
	public class BeerViewModel
	{
	
        
		public List<Beer> BeerList = new List<Beer>
		{
			new Beer{ Id=1, ABV=(decimal)10.0, BeerType = BeerType.Stout, Brand = "Great Lakes", Title="Xmas Ale" },
			new Beer{ Id=2, ABV=(decimal)7.0, BeerType = BeerType.IPA, Brand = "Mad Dog", Title="Orange Spice" },
			new Beer{ Id=3, ABV=(decimal)12.0, BeerType = BeerType.Porter, Brand = "Dog Fish", Title="120 Minute" },

		};

		public List<Beer> GetBeers()
        {
			return BeerList;

        }
		
	}
}

