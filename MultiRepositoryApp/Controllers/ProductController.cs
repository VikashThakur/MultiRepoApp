using Microsoft.AspNetCore.Mvc;
using MultiRepositoryApp.Factory;
using MultiRepositoryApp.Model;
using MultiRepositoryApp.Repository;
using System.Collections.Generic;

namespace MultiRepositoryApp.Controllers
{
    [ApiController]
    [Route("product")]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryFactory repositoryFactory;

        public ProductController(IRepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }

        [HttpGet]
        [Route("all")]
        public IEnumerable<Product> GetAll(DbType dbType)
        {
            IProductRepository productRepository = repositoryFactory.Get(dbType);
            return productRepository.GetAll();
        }
    }
}
