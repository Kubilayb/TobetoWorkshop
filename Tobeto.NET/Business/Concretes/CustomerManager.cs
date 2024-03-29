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

        public void Delete(int id)
        {
            customers.Remove(customers.Find(c => c.Id == id));
        }

        public void Update(Customer customer)
        {
            Customer showCustomer = customers.Find(c => c.Id == customer.Id);
            showCustomer.FirstName = customer.FirstName;
            showCustomer.LastName = customer.LastName;
            
        }

        public Customer GetById(int id)
        {
            return customers.Find(c => c.Id == id);
        }
    }
}
