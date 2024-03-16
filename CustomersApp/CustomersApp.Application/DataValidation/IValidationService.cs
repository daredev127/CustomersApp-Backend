using FluentValidation.Results;

namespace CustomersApp.Application.DataValidation
{
    public interface IValidationService
    {
        void FormatValidationErrorsAndThrow(ValidationResult validationResult);
    }
}
