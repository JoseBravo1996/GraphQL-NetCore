using GraphQL_NetCore.Interfaces;
using GraphQL_NetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GraphQL_NetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProduct _productService;

        public ProductsController(IProduct productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return _productService.AddProduct(product);
        }

        [HttpPut]
        public Product Put(int id, [FromBody] Product product)
        {
            return _productService.UpdateProduct(id, product);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _productService.DeleteProduct(id);
        }

    }
}
