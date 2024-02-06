namespace MediatR.Core.UseCases.Users.Create
{
      public class CreateUserCommand : IRequest<bool>
      {
            public string Name { get; set; }
            public string Address { get; set; }
      }
}
