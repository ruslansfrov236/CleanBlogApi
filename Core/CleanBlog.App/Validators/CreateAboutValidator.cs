using CleanBlog.App.Dto_s.About;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Validators
{
    public class CreateAboutValidator:AbstractValidator<UpdateAboutDto>
    {
        public CreateAboutValidator()
        {
            RuleFor(a => a.Description)
                .NotEmpty()
                .WithMessage("Please do not enter blank information.")
                .MaximumLength(250)
                .WithMessage("Please enter information between maximum 250 characters.")
                .MinimumLength(4)
                .WithMessage("Please enter information between minimum 4 characters.");


        }
    }
}
