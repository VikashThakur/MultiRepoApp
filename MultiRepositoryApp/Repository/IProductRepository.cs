using MultiRepositoryApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiRepositoryApp.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
