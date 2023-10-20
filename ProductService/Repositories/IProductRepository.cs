using System;
using ProductService.Models;

namespace ProductService.Repositories
{
	public interface IProductRepository
	{
		IEnumerable<Product> GetProducts();

		Product GetProduct(int id);

		Product AddProduct(Product product);

		Product UpdateProduct(Product product);

		void DeleteProuct(int id);
	}
}

