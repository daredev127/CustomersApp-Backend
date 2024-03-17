using CustomersApp.Application.DataValidation;
using CustomersApp.Application.DTOs;
using CustomersApp.Application.Services.AddCustomer;
using CustomersApp.Infrastructure.Repositories;
using CustomersApp.Tests.Helpers;
using FluentAssertions;

namespace CustomersApp.Tests.UnitTests
{
    public class AddCustomerTests
    {
        [Fact]
        public async void AddCustomer_Should_Pass()
        {
            var addCustomerService = new AddCustomerService(
                customerRepository: new CustomerRepository(),
                mapper: MapperProvider.Provide(),
                validationService: new ValidationService()
                );

            var newCustomer = GenerateValidAddNewCustomerRequest();
            var result = await addCustomerService.AddNewCustomer(newCustomer);
            result.Should().NotBeNull();
        }

        [Fact]
        public async void AddCustomer_WithNoData_Should_Throw()
        {
            var addCustomerService = new AddCustomerService(
                customerRepository: new CustomerRepository(),
                mapper: MapperProvider.Provide(),
                validationService: new ValidationService()
                );

            var newCustomer = new AddCustomerRequestDto();
            Func<Task> addingNewCustomer = async () => await addCustomerService.AddNewCustomer(newCustomer);
            await addingNewCustomer.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async void AddCustomer_WithInvalidEmail_Should_Throw()
        {
            var addCustomerService = new AddCustomerService(
                customerRepository: new CustomerRepository(),
                mapper: MapperProvider.Provide(),
                validationService: new ValidationService()
                );

            var newCustomer = GenerateValidAddNewCustomerRequest();
            newCustomer.Email = "invalidEmail";
            Func<Task> addingNewCustomer = async () => await addCustomerService.AddNewCustomer(newCustomer);
            await addingNewCustomer.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async void AddCustomer_WithInvalidMobileNumber_Should_Throw()
        {
            var addCustomerService = new AddCustomerService(
                customerRepository: new CustomerRepository(),
                mapper: MapperProvider.Provide(),
                validationService: new ValidationService()
                );

            var newCustomer = GenerateValidAddNewCustomerRequest();
            newCustomer.MobileNumber = "1234";
            Func<Task> addingNewCustomer = async () => await addCustomerService.AddNewCustomer(newCustomer);
            await addingNewCustomer.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async void AddCustomer_WithLongFirstName_Should_Throw()
        {
            var addCustomerService = new AddCustomerService(
                customerRepository: new CustomerRepository(),
                mapper: MapperProvider.Provide(),
                validationService: new ValidationService()
                );

            var newCustomer = GenerateValidAddNewCustomerRequest();
            newCustomer.FirstName = new string('a', 51);
            Func<Task> addingNewCustomer = async () => await addCustomerService.AddNewCustomer(newCustomer);
            await addingNewCustomer.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async void AddCustomer_WithLongLastName_Should_Throw()
        {
            var addCustomerService = new AddCustomerService(
                customerRepository: new CustomerRepository(),
                mapper: MapperProvider.Provide(),
                validationService: new ValidationService()
                );

            var newCustomer = GenerateValidAddNewCustomerRequest();
            newCustomer.LastName = new string('a', 51);
            Func<Task> addingNewCustomer = async () => await addCustomerService.AddNewCustomer(newCustomer);
            await addingNewCustomer.Should().ThrowAsync<Exception>();
        }

        [Fact]
        public async void AddCustomer_WithLongAddress_Should_Throw()
        {
            var addCustomerService = new AddCustomerService(
                customerRepository: new CustomerRepository(),
                mapper: MapperProvider.Provide(),
                validationService: new ValidationService()
                );

            var newCustomer = GenerateValidAddNewCustomerRequest();
            newCustomer.Address = new string('a', 251);
            Func<Task> addingNewCustomer = async () => await addCustomerService.AddNewCustomer(newCustomer);
            await addingNewCustomer.Should().ThrowAsync<Exception>();
        }

        private AddCustomerRequestDto GenerateValidAddNewCustomerRequest()
        {
            return new AddCustomerRequestDto
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@gmail.com",
                MobileNumber = "0412345678",
                Address = "Macquarie Street, Sydney, NSW"
            };
        }
    }
}