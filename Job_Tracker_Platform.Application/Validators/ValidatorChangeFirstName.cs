using FluentValidation;
using Job_Tracker_Platform.Application.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Validators
{
    public class ValidatorChangeFirstName : AbstractValidator<ChangeFirstNameDto>
    {
        public ValidatorChangeFirstName()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MinimumLength(3);
        }
    }
}
