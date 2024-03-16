using CustomersApp.Application.DTOs;
using CustomersApp.Domain.Errors;
using FluentValidation;

namespace CustomersApp.Application.DataValidation
{
    public class AddCustomerRequestValidator : AbstractValidator<AddCustomerRequestDto>
    {
        private const int FIRST_NAME_MAX_LEN = 50;
        private const int LAST_NAME_MAX_LEN = 50;
        private const int EMAIL_MAX_LEN = 50;
        private const int ADDRESS_MAX_LEN = 250;

        public AddCustomerRequestValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage(ErrorMessages.FirstNameRequired)
                .MaximumLength(FIRST_NAME_MAX_LEN).WithMessage(ErrorMessages.FirstNameTooLong);

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage(ErrorMessages.LastNameRequired)
                .MaximumLength(LAST_NAME_MAX_LEN).WithMessage(ErrorMessages.LastNameTooLong);

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(ErrorMessages.EmailRequired)
                .MaximumLength(EMAIL_MAX_LEN).WithMessage(ErrorMessages.EmailTooLong)
                .Matches(ValidationPatterns.EMAIL).WithMessage(ErrorMessages.InvalidEmail);

            RuleFor(x => x.MobileNumber)
                .NotEmpty().WithMessage(ErrorMessages.MobileNumberRequired)
                .Matches(ValidationPatterns.MOBILE_NUMBER).WithMessage(ErrorMessages.InvalidMobileNumber);

            RuleFor(x => x.Address)
                .NotEmpty().WithMessage(ErrorMessages.AddressRequired)
                .MaximumLength(ADDRESS_MAX_LEN).WithMessage(ErrorMessages.AddressTooLong);
        }
    }
}
