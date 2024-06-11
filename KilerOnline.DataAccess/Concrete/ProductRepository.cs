using KilerOnline.DataAccess.Abstract;
using KilerOnline.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.DataAccess.Concrete
{
	public class ProductRepository : IProductRepository
	{
		ApplicationDbContext _context;
		public ProductRepository(ApplicationDbContext context)
		{
			_context = context;

		}
		public Product CreateProduct(Product product)
		{
			_context.Products.Add(product);
			_context.SaveChanges();
			return product;
		}

		public void DeleteProduct(int id)
		{
			var product = GetProductById(id);
			_context.Products.Remove(product);
			_context.SaveChanges();

		}

		public List<Product> GetAllProducts()
		{
			return _context.Products.ToList();
		}

		public Product GetProductById(int id)
		{
            return _context.Products.Find(id);
        }

        public List<Product> GetProductsByRegionId(int RegionId)
        {
            using (var context = new ApplicationDbContext())
            {
                return _context.Products.Where(p => p.RegionId == RegionId).ToList();
            }
        }

        public Product UpdateProduct(Product product)
		{
			_context.Products.Update(product);
			_context.SaveChanges();
			return product;
		}
	}
}
