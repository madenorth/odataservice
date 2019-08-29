using Microsoft.AspNet.OData;
using ODataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataService.Controllers
{
    public class ProductsController : ODataController
    {
        private List<Product> products = new List<Product>()
        {
            new Product()
            {
                ID = 1,
                Name = "Bread",
            }
        };

        [EnableQuery]
        public List<Product> Get()
        {
            return products;
        }
    }
}
