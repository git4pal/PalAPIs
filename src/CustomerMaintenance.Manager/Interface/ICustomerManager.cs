using CustomerMaintenanceManager.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenanceManager.Interface
{
    public interface ICustomerManager
    {
        IEnumerable<CustomerDto> GetCustomers();
        CustomerDto GetCustomer(int id);

        CustomerDto AddCustomer(CustomerDto customer);
        int DeleteCustomer(int customer);
        CustomerDto UpdateCustomer(CustomerDto customer);
    }
}
