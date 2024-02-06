using MediatR.Core.Models;
using MediatR.Core.Repositories;

namespace MediatR.Core.UseCases.Users.Get
{
      public class GetUserQueryHandler : IRequestHandler<GetUserQuery, User>
      {
            private readonly IUserRepository userRepository;

            public GetUserQueryHandler(IUserRepository userRepository)
        {
                  this.userRepository = userRepository;
            }
        public Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
            {
                 return Task.FromResult(this.userRepository.GetUser(request.Id));
            }
      }
}
