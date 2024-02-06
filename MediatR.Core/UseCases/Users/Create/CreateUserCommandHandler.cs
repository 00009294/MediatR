
using MediatR.Core.Models;
using MediatR.Core.Repositories;

namespace MediatR.Core.UseCases.Users.Create
{
      public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
      {
            private readonly IUserRepository userRepository;

            public CreateUserCommandHandler(IUserRepository userRepository)
        {
                  this.userRepository = userRepository;
            }
        public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
            {
                  var user = new User
                  {
                        Name = request.Name,
                        Address = request.Address
                  };
                  return Task.FromResult(this.userRepository.CreateUser(user));
            }
      }
}
