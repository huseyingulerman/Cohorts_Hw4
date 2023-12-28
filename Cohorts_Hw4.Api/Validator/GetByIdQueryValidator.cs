using Cohorts_Hw4.Api.BookOperations;
using FluentValidation;

namespace Cohorts_Hw4.Api.Validator
{
    public class GetByIdQueryValidator : AbstractValidator<GetByIdQuery>
    {
        public GetByIdQueryValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
        }
    }
}
