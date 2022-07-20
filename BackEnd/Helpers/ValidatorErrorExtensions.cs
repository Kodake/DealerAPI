using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Helpers
{
    public static class ValidatorErrorExtensions
    {
        public static Dictionary<string, string[]> GetValidatorErrors(List<ValidationFailure> errors)
        {
            return errors
                .GroupBy(x => x.PropertyName)
                .ToDictionary(g => g.Key, g => g
                .Select(x => x.ErrorMessage)
                .ToArray());
        }
    }
}
