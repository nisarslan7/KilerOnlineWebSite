using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KilerOnline.Entities.Abstact;
using Microsoft.AspNetCore.Http;

namespace KilerOnline.Entities.Concrete
{
	public class Product : IProduct
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int Id { get; set; }
		[StringLength(50)]

		public string Name { get; set; }
		public string ProductExplanation { get; set; }
		public string ImageUrl { get; set; }
        //[NotMapped]
        //public HttpPostedFileBase ImageFile { get; set; } // Dosya yükleme işlemi için geçici özellik
        public int RegionId { get; set; }	
        public Region Region { get; set; }

    }
}
