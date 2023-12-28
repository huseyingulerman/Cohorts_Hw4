using Cohorts_Hw4.Api.BookOperations;
using FluentValidation;

namespace Cohorts_Hw4.Api.Validator
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
        }
    }
}
