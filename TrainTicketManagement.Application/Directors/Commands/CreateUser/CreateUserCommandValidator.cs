using FluentValidation;

namespace TrainTicketManagement.Application.Directors.Commands.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().MaximumLength(10);
        RuleFor(x => x.PeselNumber).NotEmpty().MaximumLength(11);
       
    }
    
}