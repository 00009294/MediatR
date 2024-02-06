using MediatR.Core.Models;
using MediatR.Core.Repositories;

namespace MediatR.Core.UseCases.Users.Get
{
      public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
      {
            private readonly IUserRepository userRepository;

            public GetAllUsersQueryHandler(IUserRepository userRepository)
        {
                  this.userRepository = userRepository;
            }
        public Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
            {
                  return Task.FromResult(this.userRepository.GetAllUsers());

            }
      }
}
