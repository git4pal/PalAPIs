using CustomerMaintenanceManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenanceManager.DataGenerator
{
    public class CustomerDataGenerator
    {
        public static List<Customer> _customers;
        public CustomerDataGenerator()
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
    }
}
