﻿using KilerOnline.Entities.Abstact;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.Entities.Concrete
{
	public class Category : ICategory
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[StringLength(50)]
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public ICollection<Food> Foods { get; set; }
		

	}
}