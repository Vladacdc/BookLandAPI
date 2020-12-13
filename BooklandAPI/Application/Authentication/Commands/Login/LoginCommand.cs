using MediatR;

namespace Application.Authentication.Commands.Login
{
    public class LoginCommand : IRequest<string>
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}