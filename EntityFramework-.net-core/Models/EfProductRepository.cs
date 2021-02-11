using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework_.net_core.Models
{
    public class EfProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public EfProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<Product> Products => _context.Products;

        public void CreateProduct(Product product)
        {

            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productid)
        {
            var product = GetById(productid);
            if (productid != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int productid)
        {
            return _context.Products.FirstOrDefault(i => i.ProductId == productid);
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
