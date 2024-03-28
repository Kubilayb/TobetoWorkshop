using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;


namespace Business.Concretes
{
    public class CustomerManager : ICustomerService
    {
        List<Customer> customers;

        public CustomerManager()
        {
            customers = new List<Customer>();
        }

        public List<Customer> GetAll()
        {
            return this.customers;
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Delete(int customerId)
        {
            customers.Remove(customers.Find(c => c.CustomerId == customerId));
        }

        public void Update(Customer customer)
        {
            Customer showCustomer = customers.Find(c => c.CustomerId == customer.CustomerId);
            showCustomer.FirstName = customer.FirstName;
            showCustomer.LastName = customer.LastName;
            
        }

        public Customer GetById(int customerId)
        {
            return customers.Find(c => c.CustomerId == customerId);
        }
    }
}
