using KilerOnline.Business.Abstract;
using KilerOnline.DataAccess.Abstract;
using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category CreateCategory(Category category)
		{
			return _categoryRepository.CreateCategory(category);
		}

		public void DeleteCategory(int id)
		{
			_categoryRepository.DeleteCategory(id);
		}

		public List<Category> GetAllCategories()
		{
			return _categoryRepository.GetAllCategories();
		}

		public Category GetCategoryById(int id)
		{
			if (id > 0)
			{
				return _categoryRepository.GetCategoryById(id);
			}
			throw new Exception("Id 0'dan büyük olmalı");
		}

		public Category UpdateCategory(Category category)
		{
			return _categoryRepository.UpdateCategory(category);
		}
	}
}
