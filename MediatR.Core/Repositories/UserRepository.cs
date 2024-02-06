using MediatR.Core.Data;
using MediatR.Core.Models;

namespace MediatR.Core.Repositories
{
      public class UserRepository : IUserRepository
      {
            private readonly AppDbContext appDbContext;

            public UserRepository(AppDbContext appDbContext)
        {
                  this.appDbContext = appDbContext;
            }
        public bool CreateUser(User user)
            {
                 this.appDbContext.Users.Add(user);
                  return this.appDbContext.SaveChanges() > 0;
            }

            public bool DeleteUser(int id)
            {
                  var user = this.appDbContext.Users.FirstOrDefault(x => x.Id == id);
                  this.appDbContext.Users.Remove(user);
                  return this.appDbContext.SaveChanges() > 0;
            }

            public List<User> GetAllUsers()
            {
                  return this.appDbContext.Users.ToList();
            }

            public User? GetUser(int id)
            {
                  return this.appDbContext.Users.FirstOrDefault(u=>u.Id == id);
            }

            public bool UpdateUser(User user)
            {
                  this.appDbContext.Users.Update(user);
                  return this.appDbContext.SaveChanges() > 0;
            }
      }
}
