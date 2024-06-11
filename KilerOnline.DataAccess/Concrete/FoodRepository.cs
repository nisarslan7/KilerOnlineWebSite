using KilerOnline.DataAccess.Abstract;
using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.DataAccess.Concrete
{
	public class FoodRepository : IFoodRepository
	{
		ApplicationDbContext _context;
		public FoodRepository(ApplicationDbContext context)
		{
			_context = context;

		}
		public Food CreateFood(Food food)
		{
			_context.Foods.Add(food);
			_context.SaveChanges();
			return food;
		}

		public void DeleteFood(int id)
		{
			var food = GetFoodById(id);
			_context.Foods.Remove(food);
			_context.SaveChanges();
		}

		public List<Food> GetAllFoods()
		{
			return _context.Foods.ToList();
		}

		public Food GetFoodById(int id)
		{
			return _context.Foods.Find(id);
		}

        

        public List<Food> GetFoodsByRegionId(int RegionId)
        {
            using (var context = new ApplicationDbContext())
            {
                return _context.Foods.Where(p => p.RegionId == RegionId).ToList();
            }
        }

        public Food UpdateFood(Food food)
		{
			_context.Foods.Update(food);
			_context.SaveChanges();
			return food;
		}
	}
}
