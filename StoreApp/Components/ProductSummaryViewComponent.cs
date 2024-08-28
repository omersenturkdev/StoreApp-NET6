using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;

namespace StoreApp.Components
{
    public class ProductSummaryViewComponent : ViewComponent
    {
       
        private readonly IServiceManager _serviceManager;

        public ProductSummaryViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        //Invoke adı verilmesi zorunlu.
        public string Invoke()
        {
            return _serviceManager.ProductService.GetProducts(false).Count().ToString();
        }

    }
}
