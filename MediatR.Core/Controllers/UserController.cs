using MediatR.Core.UseCases.Users.Create;
using MediatR.Core.UseCases.Users.Delete;
using MediatR.Core.UseCases.Users.Get;
using MediatR.Core.UseCases.Users.Update;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatR.Core.Controllers
{
      [Route("api/[controller]")]
      [ApiController]
      public class UserController : ControllerBase
      {
            private readonly IMediator mediator;

            public UserController(IMediator mediator)
            {
                  this.mediator = mediator;
            }

            [HttpPost]
            public async Task<IActionResult> Post([FromBody]CreateUserCommand request)
            {
                  await this.mediator.Send(request);
                  return Ok();
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> Get([FromQuery] GetUserQuery request)
            {
                 return Ok(await this.mediator.Send(request));
            }

            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                  return Ok(await this.mediator.Send(new GetAllUsersQuery()));
            }

            [HttpPut]
            public async Task<IActionResult> Put([FromQuery] UpdateUserCommand request)
            {
                  return Ok(this.mediator.Send(request));
            }

            [HttpDelete]
            public async  Task<IActionResult> Delete([FromBody] DeleteUserCommand  request)
            {
                 return Ok( this.mediator.Send(request));
            }

    }
}
