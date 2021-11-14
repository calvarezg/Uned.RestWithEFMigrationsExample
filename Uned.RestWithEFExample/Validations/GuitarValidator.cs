using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uned.RestWithEFExample.Models;

namespace Uned.RestWithEFExample.Validations
{
    public class GuitarValidator : AbstractValidator<Guitar>
    {
        public GuitarValidator()
        {
            RuleFor(g => g.Name).NotEmpty().MaximumLength(50).WithMessage("Name must be a string between 1 and 50 characters");
            RuleFor(g => g.FilePath).Matches(@"^(.+)\/([^\/]+)$").WithMessage("File path must be a valid path");
        }
    }
}
