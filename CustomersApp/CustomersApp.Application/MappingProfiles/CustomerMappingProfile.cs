using AutoMapper;
using CustomersApp.Application.DTOs;
using CustomersApp.Domain.Entities;

namespace CustomersApp.Application.MappingProfiles
{
    public class CustomerMappingProfile : Profile
    {
        public CustomerMappingProfile()
        {
            CreateMap<Customer, CustomerNameDto>().ReverseMap();
        }
    }
}
