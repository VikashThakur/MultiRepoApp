using MultiRepositoryApp.Model;
using MultiRepositoryApp.Repository;

namespace MultiRepositoryApp.Factory
{
    public interface IRepositoryFactory
    {
        IProductRepository Get(DbType dbType);
     }
}
