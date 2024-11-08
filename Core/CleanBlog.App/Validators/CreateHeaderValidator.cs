using CleanBlog.App.Dto_s.Header;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Validators
{
    public class CreateHeaderValidator:AbstractValidator<CreateHeaderDto>
    {
        public CreateHeaderValidator()
        {
               RuleFor(a=>a.Title)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please do not enter blank information.")
                .MaximumLength(150)
                .MinimumLength(4)
                .WithMessage("Please enter information between 4 and 150 characters.");

            RuleFor(a=>a.Description)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please do not enter blank information.")
                .MaximumLength(150)
                .MinimumLength(4)
                .WithMessage("Please enter information between 4 and 150 characters.");
            RuleFor(a => a.PageNumber)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Page number cannot be negative.")
                .Must(pageNumber => pageNumber>0)
                .WithMessage("Page number must be unique.")
                .LessThanOrEqualTo(150)
                .WithMessage("Page number cannot exceed 150.");
           
                       

        }


    }

}

