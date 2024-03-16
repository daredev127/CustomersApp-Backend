using FluentValidation.Results;

namespace CustomersApp.Application.DataValidation
{
    public class ValidationService : IValidationService
    {
        public void FormatValidationErrorsAndThrow(ValidationResult validationResult)
        {
            if (validationResult.IsValid)
            {
                return;
            }

            var errorMessages = new HashSet<string>();
            foreach (var error in validationResult.Errors)
            {
                errorMessages.Add(error.ErrorMessage);
            }

            string exceptionMessage = "Data validation failed due to the following:\r\n";
            foreach (var error in errorMessages)
            {
                exceptionMessage += $"{error}\r\n";
            }

            throw new Exception(exceptionMessage);
        }
    }
}
