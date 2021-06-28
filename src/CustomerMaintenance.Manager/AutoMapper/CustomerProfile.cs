using AutoMapper;
using CustomerMaintenanceManager.Dto;
using CustomerMaintenanceManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenanceManager.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDto, Customer>().ReverseMap();
            //CreateMap<IEnumerable<CustomerDto>, IEnumerable<Customer>>().ReverseMap();
        }
    }
}
