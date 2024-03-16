namespace CustomersApp.Application.DTOs
{
    public class CustomerNameDto
    {
        public required Guid Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
    }
}
