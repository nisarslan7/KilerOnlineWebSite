using KilerOnline.DataAccess.Abstract;
using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.DataAccess.Concrete
{
	public class CategoryRepository : ICategoryRepository
	{
		ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
			_context = context;
			
        }
        public Category CreateCategory(Category category)
		{
			_context.Categories.Add(category);
			_context.SaveChanges();
			return category;
		}

		public void DeleteCategory(int id)
		{
			var category = GetCategoryById(id);
			_context.Categories.Remove(category);
			_context.SaveChanges();
		}

		public List<Category> GetAllCategories()
		{
			return _context.Categories.ToList();
		}

		public Category GetCategoryById(int id)
		{
			return _context.Categories.Find(id);
		}

		public Category UpdateCategory(Category category)
		{
			_context.Categories.Update(category);
			_context.SaveChanges();
			return category;
		}
	}
}
