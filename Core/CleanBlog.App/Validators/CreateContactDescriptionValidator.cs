using CleanBlog.App.Dto_s.ContactsDescription;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Validators
{
    public class CreateContactDescriptionValidator:AbstractValidator<CreateContactsDescriptionDto>
    {
        public CreateContactDescriptionValidator()
        {
            RuleFor(a=>a.Description)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please do not enter blank information.")
                .MaximumLength(150)
                .MinimumLength(4)
                .WithMessage("Please enter information between 4 and 150 characters.");
        }
    }
}
