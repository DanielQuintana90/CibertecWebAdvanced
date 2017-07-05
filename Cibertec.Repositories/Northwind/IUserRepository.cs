using Cibertec.Models;

namespace Cibertec.Repositories.Northwind
{
    public interface IUserRepository
    {
        User ValidateUser(string email, string password);
    }
}
