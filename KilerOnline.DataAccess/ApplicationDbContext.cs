using KilerOnline.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.DataAccess
{
	public class ApplicationDbContext: DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=KilerOnline;Trusted_Connection=True;MultipleActiveResultSets=true");
		}
		public DbSet<Category> Categories { get; set; }
        public DbSet<Food> Foods { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Region> Regions { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<User> Users { get; set; }


	}
}
