
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
	public class ProductManager : IProductService
	{
		private IProductRepository _productRepository;
		public ProductManager(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public Product CreateProduct(Product product)
		{
			return _productRepository.CreateProduct(product);
		}

		public void DeleteProduct(int id)
		{
			_productRepository.DeleteProduct(id);
		}

		public List<Product> GetAllProducts()
		{
			return _productRepository.GetAllProducts();
		}

		public Product GetProductById(int id)
		{
			if (id > 0)
			{
				return _productRepository.GetProductById(id);
			}
			throw new Exception("Id 0'dan büyük olmalı");

		}

        public List<Product> GetProductsByRegionId(int RegionId)
        {
            return _productRepository.GetProductsByRegionId(RegionId);
        }

        public Product UpdateProduct(Product product)
		{
			return _productRepository.UpdateProduct(product);
		}
	}
}
