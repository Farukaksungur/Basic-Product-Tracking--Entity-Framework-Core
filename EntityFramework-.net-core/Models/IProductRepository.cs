using System.Linq;

namespace EntityFramework_.net_core.Models
{
    public interface IProductRepository
    {

        Product GetById(int productid);
        IQueryable<Product> Products { get; }

        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        void DeleteProduct(int id);
    }
}
