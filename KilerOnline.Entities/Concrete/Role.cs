﻿using KilerOnline.Entities.Abstact;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.Entities.Concrete
{
	public class Role : IRole
	{
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
		public string Name { get; set; }
		
		public ICollection<User> Users { get; set;}

		
	}
}
