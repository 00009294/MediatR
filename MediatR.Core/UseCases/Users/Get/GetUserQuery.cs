using MediatR.Core.Models;

namespace MediatR.Core.UseCases.Users.Get
{
      public class GetUserQuery : IRequest<User>
      {
            public int Id { get; set; }
      }
}
