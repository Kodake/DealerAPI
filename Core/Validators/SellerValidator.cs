using Core.DTO;
using FluentValidation;

namespace Core.Validators
{
    public class SellerValidator: AbstractValidator<SellerDTO>
    {
        public SellerValidator()
        {
            RuleFor(x => x.FirstName).Length(2, 100).NotEmpty().NotNull();
            RuleFor(x => x.LastName).Length(2, 50).NotEmpty().NotNull();
            RuleFor(x => x.IdentificationNumber).MaximumLength(20).NotEmpty().NotNull();
        }
    }
}
