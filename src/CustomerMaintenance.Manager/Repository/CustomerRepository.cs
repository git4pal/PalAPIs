using CustomerMaintenanceManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceManager.Repository
{
    public class CustomerRepository
    {
        public static List<Customer> _customers;
        public CustomerRepository()
        {
            _customers = new List<Customer>();
            Customer cust = new Customer();
            cust.CustomerID = 1;
            cust.FirstName = "Arindam";
            cust.LastName = "Pal";
            cust.Email = "arindam.pal@tiffany.com";
            _customers.Add(cust);
            cust = new Customer();
            cust.CustomerID = 2;
            cust.FirstName = "Jagannath";
            cust.LastName = "Panda";
            cust.Email = "jaganath.panda@tiffany.com";
            _customers.Add(cust);
        }
        public List<Customer> GetCustomers()
        {
            return _customers;
        }
        public Customer GetCustomer(int Id)
        {
            return _customers.Find(x => x.CustomerID == Id);
        }

        public Customer AddCustomer(Customer customer)
        {
            customer.CustomerID = _customers.Select(x => x.CustomerID).Max() + 1;
            _customers.Add(customer);
            return customer;
        }
        public int DeleteCustomer(int customerId)
        {
            return _customers.RemoveAll(x => x.CustomerID == customerId);
        }


        public Customer UpdateCustomer(Customer customer)
        {
            DeleteCustomer(customer.CustomerID);
            _customers.Add(customer);
            return customer;
        }
    }
}
