using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BethanyPieShop.Models
{
    public class ProductDetail
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        [Required]
        public double Price { get; set; }

        
        public byte[] Image { get; set; }
		public Catagory Catagory { get; set; }
		public int CatagoryId { get; set; }
	}
}