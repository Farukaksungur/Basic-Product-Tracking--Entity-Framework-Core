using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework_.net_core.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
                new Product(){ProductId=1,Name="Phone 1",Price=2000,Category="Phone"},
                new Product(){ProductId=2,Name="Phone 2",Price=3000,Category="Phone"},
                new Product(){ProductId=3,Name="Phone 3",Price=4000,Category="Phone"},
                new Product(){ProductId=4,Name="Phone 4",Price=5000,Category="Phone"},
                new Product(){ProductId=5,Name="Phone 5",Price=6000,Category="Phone"},
                new Product(){ProductId=6,Name="Phone 6",Price=7000,Category="Phone"}

        }.AsQueryable();

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int productid)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
