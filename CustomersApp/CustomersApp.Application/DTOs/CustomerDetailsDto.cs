namespace CustomersApp.Application.DTOs
{
    public class CustomerDetailsDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string MobileNumber { get; set; }
        public required string Address { get; set; }
    }
}
