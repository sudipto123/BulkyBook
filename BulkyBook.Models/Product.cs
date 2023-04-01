﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BulkyBook.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		public string Description { get; set; }
		[Required]
		public string ISBN { get; set; }
		[Required]
		public string Author { get; set; }
		[Required]
		[Display(Name = "List Price")]
		[Range(1, 1000)]
		public double ListPrice { get; set; }
		[Required]
		[Range(1, 1000)]
		public double Price { get; set; }
		[Required]
		[Range(1, 1000)]
		public double Price50 { get; set; }
		[Required]
		[Range(1, 1000)]
		public double Price100 { get; set; }
		[Display(Name = "Image URL")]
		public string ImageUrl { get; set; }
		[Required]
		[Display(Name = "Category")]
		public int CategoryId { get; set; }
		[ForeignKey("CategoryId")]
        public Category Category { get; set; }
		[Required]
		[Display(Name = "Cover Type")]
		public int CoverTypeId { get; set; }
		public CoverType CoverType { get; set; }
	}
}
