using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KilerOnline.Entities.Abstact;

namespace KilerOnline.Entities.Concrete
{
	public class Food : IFood
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int Id { get; set; }
		[StringLength(50)]

		public string Name { get; set; }
		public string Preparation { get; set; }
		[StringLength(20)]

		public string Time { get; set; }
		[StringLength(20)]

		public string PersonCount { get; set; }
		public string Story { get; set; }
		public string Ingredients { get; set; }
		public string ImageUrl { get; set; }
		public int CategoryId { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
        public Category Category { get; set; }
	}
}
