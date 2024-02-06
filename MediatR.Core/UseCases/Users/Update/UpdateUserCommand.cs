namespace MediatR.Core.UseCases.Users.Update
{
      public class UpdateUserCommand : IRequest<bool>
      {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
