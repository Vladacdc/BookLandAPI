using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using MediatR;

namespace Application.Authentication.Commands.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IIdentityService _identityService;

        public LoginCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}