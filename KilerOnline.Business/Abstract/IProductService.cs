using KilerOnline.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilerOnline.Business.Abstract
{
	public interface IProductService
	{
		List<Product> GetAllProducts();
		Product GetProductById(int id);

		Product CreateProduct(Product product);
		Product UpdateProduct(Product product);

		void DeleteProduct(int id);
        List<Product> GetProductsByRegionId(int RegionId);

    }
}
