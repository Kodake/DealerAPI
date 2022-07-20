using Core.DTO;
using FluentValidation;

namespace Core.Validators
{
    public class VehicleModelValidator : AbstractValidator<VehicleModelDTO>
    {
        public VehicleModelValidator()
        {
            RuleFor(x => x.Brand).Length(2, 100).NotEmpty().NotNull();
            RuleFor(x => x.Model).Length(2, 50).NotEmpty().NotNull();
            RuleFor(x => x.Year).ExclusiveBetween(1900, 9999).NotEmpty().NotNull();
        }
    }
}
