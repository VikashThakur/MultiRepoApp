using MultiRepositoryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiRepositoryApp.Repository
{
    public class ProductRepositorySql : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{Id=1,Name ="Sql Product" }
            };
        }
    }
}
