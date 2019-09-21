using Invoicing.Interfaces;
using Invoicing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoicingTests.Mocks
{
    internal class SupplierServiceMock : ISupplierService
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
