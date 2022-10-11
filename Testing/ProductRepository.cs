
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository
    {
      private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("select * from products");
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id",
                new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("update products set name = @name, price = @price where ProductID = @ID", 
                new {name = product.Name, price = product.Price, id = product.ProductID});
        }


    }
}
