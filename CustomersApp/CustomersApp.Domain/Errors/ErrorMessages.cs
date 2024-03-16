namespace CustomersApp.Domain.Errors
{
    public static class ErrorMessages
    {
        public const string CustomerInfoAlreadyExists = "This customer already exists in the system. Adding multiple entries with the same first name and last name is not yet supported.";

        public const string FirstNameRequired = "First name is required.";
        public const string FirstNameTooLong = "First name is too long.";
        public const string LastNameRequired = "Last name is required.";
        public const string LastNameTooLong = "Last name is too long.";
        public const string EmailRequired = "Email is required.";
        public const string EmailTooLong = "Email is too long.";
        public const string InvalidEmail = "Email is invalid.";
        public const string MobileNumberRequired = "Mobile number is required.";
        public const string InvalidMobileNumber = "Mobile number is invalid.";
        public const string AddressRequired = "Address is required.";
        public const string AddressTooLong = "Address is too long.";
    }
}
