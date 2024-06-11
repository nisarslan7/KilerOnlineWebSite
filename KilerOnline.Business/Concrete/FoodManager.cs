using KilerOnline.Business.Abstract;
using KilerOnline.DataAccess;
using KilerOnline.DataAccess.Abstract;
using KilerOnline.DataAccess.Concrete;
using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.Business.Concrete
{
	public class FoodManager : IFoodService
	{
		private IFoodRepository _foodRepository;
		public FoodManager(IFoodRepository foodRepository)
		{
			_foodRepository = foodRepository;
		}
		public Food CreateFood(Food food)
		{
			return _foodRepository.CreateFood(food);
		}

		public void DeleteFood(int id)
		{
			_foodRepository.DeleteFood(id);
		}

		public List<Food> GetAllFoods()
		{
			return _foodRepository.GetAllFoods();
		}

		public Food GetFoodById(int id)
		{
			if (id > 0)
			{
				return _foodRepository.GetFoodById(id);
			}
			throw new Exception("Id 0'dan büyük olmalı");
		}

        

        public List<Food> GetFoodsByRegionId(int RegionId)
        {
            return _foodRepository.GetFoodsByRegionId(RegionId);
        }

        public Food UpdateFood(Food food)
		{
			return _foodRepository.UpdateFood(food);
		}
	}
}
