using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Validation
{
    public class PersonValidator : AbstractValidator<PersonModel>
    {
        public PersonValidator() {

            RuleFor(p => p.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} is invalid")
                .Must(BeAValidValue).WithMessage("{PropertyName} Contains invalid characters");
           RuleFor(p => p.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of {PropertyName} is invalid")
                .Must(BeAValidValue).WithMessage("{PropertyName} Contains invalid characters");

            RuleFor(p => p.DateOfBirth)
                 .Must(BeAValidAge).WithMessage("Invalid {PropertyName}");
        }
        
        protected bool BeAValidValue(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }

        protected bool BeAValidAge(DateTime date)
        {
            int currentYear = DateTime.Now.Year;
            int dobYear = date.Year;

            if(dobYear <= currentYear && dobYear > (currentYear - 120))
            {
                return true;
            }
            return false;
        }
    }
}
