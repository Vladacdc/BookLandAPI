using System;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Common.Models;
using MediatR;

namespace Application.Authentication.Commands.SignIn
{
    public class LoginCommandHandler : IRequestHandler<SignInCommand, string>
    {
        private readonly IIdentityService _identityService;
        private readonly ITokenService _tokenService;

        public LoginCommandHandler(IIdentityService identityService, ITokenService tokenService)
        {
            _identityService = identityService;
            _tokenService = tokenService;
        }

        public async Task<string> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            if (!await _identityService.IsValidUsernameAndPasswordAsync(request.Username, request.Password))
            {
                throw new AuthenticationException();
            }

            return await _tokenService.GenerateTokenAsync(request.Username);
        }
    }
}