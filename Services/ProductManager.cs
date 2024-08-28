﻿using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;
        public ProductManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public Product? GetOneProduct(int id, bool trackChanges)
        {
            var product = _manager.Product.GetOneProduct(id, trackChanges);
            if(product is null)
            {
                throw new Exception("Product not found");
            }
            return product;
        }

        public IEnumerable<Product> GetProducts(bool trackChanges)
        {
            return _manager.Product.GetAllProduct(trackChanges);
        }
    }
}
