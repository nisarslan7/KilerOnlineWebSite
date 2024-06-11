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
	public class Region : IRegion
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[StringLength(50)]

		public string Name { get; set; }
		[StringLength(50)]

		public ICollection<Product> Products { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
