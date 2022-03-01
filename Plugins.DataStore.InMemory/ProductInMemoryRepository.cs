using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;

        public ProductInMemoryRepository()
        {
            products = new List<Product>()
            {
                new Product{ ProductId = 1, CategoryId = 1, Name ="E9 Pro", Quantity = 100, Price = 4.250},
                new Product{ ProductId = 2, CategoryId = 2, Name ="Comfort V2", Quantity = 50, Price = 16.500},
                new Product{ ProductId = 3, CategoryId = 3, Name ="FatBike", Quantity = 30, Price = 15.250},
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
