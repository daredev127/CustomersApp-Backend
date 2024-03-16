using CustomersApp.Domain.Entities;
using System.Collections.ObjectModel;

namespace CustomersApp.Infrastructure.Persistence
{
    internal class CustomerContext
    {
        private static CustomerContext instance = null;
        private static readonly object instanceLock = new object();

        private List<Customer> customers = new List<Customer>();
        public ReadOnlyCollection<Customer> Customers { get { return customers.AsReadOnly(); } }

        private CustomerContext() { }
        public static CustomerContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerContext();
                    }
                    return instance;
                }
            }
        }
    }
}
