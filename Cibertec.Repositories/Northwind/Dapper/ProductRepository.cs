using Cibertec.Models;
using Dapper;
using System.Data.SqlClient;

namespace Cibertec.Repositories.Northwind.Dapper
{
    public class ProductRepository : RepositoryDapper<Product>, IProductRepository
    {
        public ProductRepository(string connectionString) : base(connectionString)
        {

        }        

        public Product GetByProductName(string productName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@productName", productName);

                return connection.QueryFirst<Product>("dbo.SearchByProductName",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
