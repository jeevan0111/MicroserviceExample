using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Repositories;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewProductController : ControllerBase
    {

        private readonly IProductRepository productRepository;

        public NewProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        // GET: api/NewProduct
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productRepository.GetProducts();
        }

        // GET: api/NewProduct/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return productRepository.GetProduct(id);
        }

       
    }
}
