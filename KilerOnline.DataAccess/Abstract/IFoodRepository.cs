using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.DataAccess.Abstract
{
	public interface IFoodRepository
	{
		List<Food> GetAllFoods();
		Food GetFoodById(int id);

		Food CreateFood(Food food);
		Food UpdateFood(Food food);

		void DeleteFood(int id);
        List<Food> GetFoodsByRegionId(int RegionId);
       
    }
}
