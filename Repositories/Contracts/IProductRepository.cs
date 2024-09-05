using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProduct(bool trackChanged);
        Product? GetOneProduct(int id, bool trackChanged);
        void CreateProduct(Product product);
        void DeleteOneProduct(Product prd);
        void UpdateOneProduct(Product entity);
    }
}
