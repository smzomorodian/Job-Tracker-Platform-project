using FluentValidation;
using Job_Tracker_Platform.Application.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Tracker_Platform.Application.Validators
{
    public class ValidatorUser : AbstractValidator<UserDTO>
    {
        public ValidatorUser()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("نام کاربر نمیتواند خالی باشد.");
            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("نام خانوادگی کاربر نمیتواند خالی باشد.");
            RuleFor(x => x.DateOfBirth)
                .NotEmpty()
                .LessThan(DateTime.UtcNow)
                .WithMessage("تاریخ تولد نمیتواند بزرگتر از تاریخ زمان حال باشد.");
        }
    }
}
