﻿using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ServiceManager(IProductService productService,ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public IProductService ProductService => _productService;

        public ICategoryService CategoryService => _categoryService;
    }
}
