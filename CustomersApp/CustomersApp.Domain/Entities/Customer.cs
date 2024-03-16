using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomersApp.Domain.Entities
{
    public class Customer : EntityBase
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string MobileNumber { get; set; }
        public required string Address { get; set; }
    }
}
