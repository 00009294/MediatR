
using MediatR.Core.Models;
using MediatR.Core.Repositories;

namespace MediatR.Core.UseCases.Users.Update
{
      public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
      {
            private readonly IUserRepository userRepository;

            public UpdateUserCommandHandler(IUserRepository userRepository)
        {
                  this.userRepository = userRepository;
            }
        public Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
            {
                  var user = new User
                  {
                        Id = request.Id,
                        Name = request.Name,
                        Address = request.Address,
                  };
                  return Task.FromResult(this.userRepository.UpdateUser(user));
            }
      }
}
