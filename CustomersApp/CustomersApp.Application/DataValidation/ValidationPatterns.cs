namespace CustomersApp.Application.DataValidation
{
    public static class ValidationPatterns
    {
        public const string EMAIL = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        public const string MOBILE_NUMBER = @"^\d{10}$";
    }
}
