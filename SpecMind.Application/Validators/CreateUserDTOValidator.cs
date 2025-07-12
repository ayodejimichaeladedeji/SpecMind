using FluentValidation;

namespace SpecMind.Application.Validators
{
    public class CreateUserDTOValidator: AbstractValidator<CreateUserDTO>
    {
        public CreateUserDTOValidator()
        {
            RuleFor(x => x.FirstName)
                        .NotEmpty().WithMessage("First name is required");
            RuleFor(x => x.LastName)
                        .NotEmpty().WithMessage("Last name is required");
            RuleFor(x => x.EmailAddress)
                        .NotEmpty().WithMessage("Email address is required")
                        .EmailAddress().WithMessage("Email address is invalid");
            RuleFor(x => x.Password)
                        .NotEmpty().WithMessage("Password is required");
        }
    }
}