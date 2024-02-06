namespace MediatR.Core.UseCases.Users.Delete
{
      public class DeleteUserCommand : IRequest<bool>
      {
            public int Id { get; set; }
      }
}
