using Cibertec.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;

namespace Cibertec.Repositories.Northwind.Dapper
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"[{type.Name}]"; };

            _connectionString = connectionString;
        }

        public User ValidateUser(string email, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@email", email);
                parameters.Add("@password", password);

                return connection.QueryFirst<User>("dbo.ValidateUser", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
