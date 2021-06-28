using AutoMapper;
using CustomerMaintenanceManager.Repository;
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
        private readonly CustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerManager(IMapper mapper)
        {
            _mapper = mapper;
            _customerRepository = new CustomerRepository();
        }
        public CustomerDto AddCustomer(CustomerDto customer)
        {
            customer = _mapper.Map<CustomerDto>(_customerRepository.AddCustomer(_mapper.Map<Customer>(customer)));
            return customer;
        }

        public int DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }

        public CustomerDto GetCustomer(int id)
        {
            Customer cust = _customerRepository.GetCustomer(id);
            return _mapper.Map<CustomerDto>(cust);
        }

        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDto>>(_customerRepository.GetCustomers());            
        }

        public CustomerDto UpdateCustomer(CustomerDto customer)
        {
            customer = _mapper.Map<CustomerDto>(_customerRepository.UpdateCustomer(_mapper.Map<Customer>(customer)));
            return customer;
        }
    }
}
