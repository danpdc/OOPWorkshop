using Invoicing.Interfaces;
using Invoicing.Models;
using InvoicingTests.Mocks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace InvoicingTests
{
    public class InvoiceTests
    {
        private readonly ISupplierService _supplierService = new SupplierServiceMock();
        private readonly ICustomerService _customerService = new CustomerServiceMock();

        [Fact]
        public void InvoiceShouldNotBeNull()
        {
            var invoice = Invoice.Create(_supplierService, _customerService, 1, 2, GenerateProductList());
            Assert.NotNull(invoice);
        }

        [Fact]
        public void InvoiceMembersShouldNotBeNullOrDefault()
        {
            var invoice = Invoice.Create(_supplierService, _customerService, 1, 2, GenerateProductList());
            Assert.NotNull(invoice.Customer);
            Assert.True(invoice.Products.Count > 0);
            Assert.True(invoice.TotalPriceWithoutVat > 0);
            Assert.True(invoice.TotalPriceWithVat > 0);
            Assert.NotNull(invoice.Supplier);
        }

        [Fact]
        public void ShouldBeAbleToAddNewProductToInvoice()
        {
            var invoice = Invoice.Create(_supplierService, _customerService, 1, 2, GenerateProductList());
            var currentProductCount = invoice.Products.Count;
            invoice.InsertProduct(new Product { Id = 4, Name = "New Product", Description = "Description", Price = 78.15});
            Assert.Equal(invoice.Products.Count, currentProductCount + 1);
        }

        public List<Product> GenerateProductList()
        {
            var products = new List<Product>();
            var product = new Product
            {
                Id = 1,
                Name = "MyProduct",
                Description = "Product description",
                Price = 21.54
            };
            products.Add(product);
            return products;
        }
    }
}
