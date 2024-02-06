using MediatR.Core.Models;

namespace MediatR.Core.Repositories
{
      public interface IUserRepository
      {
            List<User> GetAllUsers();
            User GetUser(int id);
            bool CreateUser(User user);
            bool UpdateUser(User user);
            bool DeleteUser(int id);
      }
}
