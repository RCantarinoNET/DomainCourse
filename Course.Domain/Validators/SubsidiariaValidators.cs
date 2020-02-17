using FluentValidation;

namespace Course.Domain.Validators
{
    public class SubsidiariaValidators : AbstractValidator<Entities.Subsidiaria>
    {
        public SubsidiariaValidators()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name is required");
        }
    }
}