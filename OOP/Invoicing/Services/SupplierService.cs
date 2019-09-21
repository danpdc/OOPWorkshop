using Invoicing.Interfaces;
using Invoicing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Services
{
    public class SupplierService : ISupplierService
    {  
        public Supplier GetSupplier(int supplierId)
        {
            return new Supplier
            {
                Id = supplierId,
                Name = "Supplier",
                VatId = "RO456789"
            };
        }
    }
}
