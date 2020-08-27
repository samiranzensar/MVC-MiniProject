using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BethanyPieShop.Models;

namespace BethanyPieShop.ViewModel
{
	public class ProDetailsAndCatagory
	{
		public ProductDetail ProductDetail { get; set; }
		public IEnumerable<Catagory> Catagories { get; set; }

		
	}

}