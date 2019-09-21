using Invoicing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomer(int customerId);
    }
}
