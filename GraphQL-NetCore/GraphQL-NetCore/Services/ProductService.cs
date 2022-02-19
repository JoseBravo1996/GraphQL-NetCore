using GraphQL_NetCore.Interfaces;
using GraphQL_NetCore.Models;
using System.Collections.Generic;

namespace GraphQL_NetCore.Services
{
    public class ProductService : IProduct
    {
        private static List<Product> products = new List<Product>()
        {
            new Product(){ Id = 1, Name = "Coffee", Price = 100},
            new Product(){ Id = 1, Name = "Tea", Price = 50}
        };

        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }

        public void DeleteProduct(int id)
        {

            products.RemoveAt(id);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);     
        }

        public Product UpdateProduct(int id, Product product)
        {
            products[id] = product;
            return product;
        }
    }
}
