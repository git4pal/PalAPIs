using AutoMapper;
using CustomerMaintenanceManager.DataGenerator;
using CustomerMaintenanceManager.Dto;
using CustomerMaintenanceManager.Interface;
using CustomerMaintenanceManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenanceManager.Managers
{
    public class CustomerManager : ICustomerManager
    {
        private readonly CustomerDataGenerator _customerDataGenerator;
        private readonly IMapper _mapper;
        public CustomerManager(IMapper mapper)
        {
            _mapper = mapper;
            _customerDataGenerator = new CustomerDataGenerator();
        }
        public CustomerDto AddCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        public int DeleteCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }

        public CustomerDto GetCustomer(int id)
        {
            Customer cust = _customerDataGenerator.GetCustomer(id);
            return _mapper.Map<CustomerDto>(cust);
        }

        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDto>>(_customerDataGenerator.GetCustomers());            
        }

        public CustomerDto UpdateCustomer(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
