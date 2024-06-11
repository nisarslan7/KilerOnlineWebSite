using KilerOnline.DataAccess.Abstract;
using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.DataAccess.Concrete
{
	public class RegionRepository : IRegionRepository
	{
		ApplicationDbContext _context;
		public RegionRepository(ApplicationDbContext context)
		{
			_context = context;

		}
		public Region CreateRegion(Region region)
		{
			_context.Regions.Add(region);
			_context.SaveChanges();
			return region;
		}

		public void DeleteRegion(int id)
		{
			var region = GetRegionById(id);
			_context.Regions.Remove(region);
			_context.SaveChanges();
		}

		public List<Region> GetAllRegions()
		{
			return _context.Regions.ToList();
		}

		public Region GetRegionById(int id)
		{
			return _context.Regions.Find(id);
		}

		public Region UpdateRegion(Region region)
		{
			_context.Regions.Update(region);
			_context.SaveChanges();
			return region;
		}
	}
}
