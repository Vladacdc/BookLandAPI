using System.Threading.Tasks;
using Application.Authentication.Commands.SignIn;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AuthenticationController : BaseApiController
    {
        [HttpPost]
        [Route("SignIn")]
        public async Task<string> SignIn([FromBody] SignInCommand request)
        {
            return await Mediator.Send(request);
        }
    }
}