using Invoicing.Interfaces;
using Invoicing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoicingTests.Mocks
{
    internal class CustomerServiceMock : ICustomerService
    {
        public Customer GetCustomer(int customerId)
        {
            return new Customer
            {
                Id = customerId,
                FirstName = "Dan",
                LastName = "Patrascu"
            };
        }
    }
}
