using CleanBlog.App.Dto_s.Message;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.App.Validators
{
    public class CreateMessageValidators:AbstractValidator<CreateMessageDto>
    {
        public CreateMessageValidators()
        {
            RuleFor(a=>a.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please do not enter blank information.")
                .MaximumLength(150)
                .MinimumLength(4)
                .WithMessage("Please enter information between 4 and 150 characters.");

            RuleFor(a => a.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please do not enter blank information.")
                 .EmailAddress()
                 .WithMessage("Invalid email  format.");

            RuleFor(c => c.Phone)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("Please do not enter blank information.")
                    .Matches(@"^(\+?[0-9]{1,3})?[-. ]?(\(?[0-9]{1,4}?\)?[-. ]?)?[0-9]{1,4}[-. ]?[0-9]{1,4}[-. ]?[0-9]{1,9}$")
                    .WithMessage("Invalid phone number format.");

            RuleFor(c => c.Messages)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please do not enter blank information.");
        }
    }
}
