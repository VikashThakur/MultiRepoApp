using MultiRepositoryApp.Model;
using MultiRepositoryApp.Repository;
using System;

namespace MultiRepositoryApp.Factory
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly Func<ProductRepositorySql> sqlRepository;
        private readonly Func<ProductRepositoryMySql> mySqlRepository;

        public RepositoryFactory(Func<ProductRepositorySql> sqlRepository,
                                 Func<ProductRepositoryMySql> mySqlRepository)
        {
            this.sqlRepository = sqlRepository;
            this.mySqlRepository = mySqlRepository;
        }
        public IProductRepository Get(DbType dbType)
        {
            return dbType switch
            {
                DbType.Sql => sqlRepository(),
                DbType.MySql => mySqlRepository(),
                _ => throw new NotSupportedException("This Database is not supported yet.")
            };
        }
    }
}
