
using MediatR.Core.Repositories;

namespace MediatR.Core.UseCases.Users.Delete
{
      public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, bool>
      {
            private readonly IUserRepository userRepository;

            public DeleteUserCommandHandler(IUserRepository userRepository)
        {
                  this.userRepository = userRepository;
            }
        public Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
            {
                  return Task.FromResult(this.userRepository.DeleteUser(request.Id));
            }
      }
}
