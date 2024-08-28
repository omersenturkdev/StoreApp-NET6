﻿using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }
        public Product? GetOneProduct(int id, bool trackChanges)
        {
            return FindByCondition(p => p.Id.Equals(id), trackChanges);
        }
        public IQueryable<Product> GetAllProduct(bool trackChanged) => FindAll(trackChanged);

    }
}
