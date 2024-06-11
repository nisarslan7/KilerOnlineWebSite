using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.DataAccess.Abstract
{
	public interface IRegionRepository
	{
		List<Region> GetAllRegions();
		Region GetRegionById(int id);

		Region CreateRegion(Region region);
		Region UpdateRegion(Region region);

		void DeleteRegion(int id);
	}
}
