using FluentValidation;
using Job_Tracker_Platform.Application.DTO.Company;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Validators
{
    public class ValidatorCompany : AbstractValidator<CompanyDTO>
    {
        public ValidatorCompany()
        {
            RuleFor(x => x.CompanyName)
                .NotEmpty()
                .MinimumLength(3);
            RuleFor(x => x.Location)
                .NotEmpty()
                .MinimumLength(5);
            RuleFor(x => x.Size)
                .NotNull();

        }
    }
}
