using System;
using ProductService.Data;
using ProductService.Models;

namespace ProductService.Repositories
{
	public class ProductRepository : IProductRepository
	{
        private readonly ApplicationDbContext applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        //Add
        public Product AddProduct(Product product)
        {
           var result= applicationDbContext.Products.Add(product);
            applicationDbContext.SaveChanges();
            return result.Entity;
        }

        //Delete
        public void DeleteProuct(int id)
        {
            var result = applicationDbContext.Products.FirstOrDefault(a => a.Id == id);
            if (result != null )
            {
                applicationDbContext.Products.Remove(result);
                applicationDbContext.SaveChanges();
            }
        }

        //Get by ID
        public Product GetProduct(int id)
        {
            //return applicationDbContext.Products.Find(id);
            return applicationDbContext.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        //Get all
        public IEnumerable<Product> GetProducts()
        {
            return applicationDbContext.Products.ToList();
        }

        //Update
        public Product UpdateProduct(Product product)
        {
            var result = applicationDbContext.Products.FirstOrDefault(a => a.Id == product.Id );
            if (result != null)
            {
                applicationDbContext.Products.Update(product);
                applicationDbContext.SaveChanges();
                return result;
            }

            return null;
        }
    }
}

