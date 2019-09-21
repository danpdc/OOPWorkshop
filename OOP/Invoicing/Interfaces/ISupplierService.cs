using Invoicing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Interfaces
{
    public interface ISupplierService
    {
        Supplier GetSupplier(int supplierId);
    }
}
