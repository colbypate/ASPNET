using Testing.Models;
using System.Collections.Generic;

namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);

    
    }
}
