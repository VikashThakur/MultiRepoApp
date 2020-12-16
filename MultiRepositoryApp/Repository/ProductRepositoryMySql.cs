using MultiRepositoryApp.Model;
using System;
using System.Collections.Generic;

namespace MultiRepositoryApp.Repository
{
    public class ProductRepositoryMySql : IProductRepository
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>
            {
                new Product{ Id=2 ,Name ="My Sql Product" }
            };
        }
    }
}
