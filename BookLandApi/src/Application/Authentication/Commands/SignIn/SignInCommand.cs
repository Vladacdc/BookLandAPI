using Application.Common.Models;
using MediatR;

namespace Application.Authentication.Commands.SignIn
{
    public class SignInCommand : IRequest<string>
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}