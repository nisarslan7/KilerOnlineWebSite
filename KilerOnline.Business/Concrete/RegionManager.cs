using KilerOnline.Business.Abstract;
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
	public class RegionManager : IRegionService
	{
		private IRegionRepository _regionRepository;
		public RegionManager(IRegionRepository regionRepository)
		{
			_regionRepository = regionRepository;
		}
		public Region CreateRegion(Region region)
		{
			return _regionRepository.CreateRegion(region);
		}

		public void DeleteRegion(int id)
		{
			_regionRepository.DeleteRegion(id);
		}

		public List<Region> GetAllRegions()
		{
			return _regionRepository.GetAllRegions();
		}

		public Region GetRegionById(int id)
		{
			if(id > 0)
			{
				return _regionRepository.GetRegionById(id);
			}
			throw new Exception("Id 0'dan büyük olmalı");
		}

		public Region UpdateRegion(Region region)
		{
			return _regionRepository.UpdateRegion(region);
		}
	}
}
