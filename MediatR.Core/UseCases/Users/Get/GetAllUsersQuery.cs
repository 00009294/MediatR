using MediatR.Core.Models;

namespace MediatR.Core.UseCases.Users.Get
{
      public class GetAllUsersQuery : IRequest<List<User>>
      {
      }
}
