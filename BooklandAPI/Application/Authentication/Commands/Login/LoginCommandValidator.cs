using FluentValidation;

namespace Application.Authentication.Commands.Login
{
    public class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(x => x.Username).EmailAddress();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}