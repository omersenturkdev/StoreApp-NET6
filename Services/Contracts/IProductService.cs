using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IProductService
    {
        void DeleteOneProduct(int id);
        void UpdateOneProduct(ProductDtoForUpdate productDto);
        void CreateProduct(ProductDtoForInsertion productDto);
        IEnumerable<Product> GetProducts(bool trackChanges);
        Product? GetOneProduct(int id, bool trackChanges);
        ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges);
    }
}
