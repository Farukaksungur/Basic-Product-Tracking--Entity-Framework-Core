using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework_.net_core.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }

    }
}
