using Invoicing.Interfaces;
using Invoicing.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoicing.Models
{
    public class Invoice
    {
        private readonly ISupplierService _supplierService;
        private readonly ICustomerService _customerService;
        private List<Product> _products;
        private Invoice(ISupplierService supplierService, ICustomerService customerService)
        {
            _supplierService = supplierService;
            _customerService = customerService;
        }
        public Supplier Supplier { get; private set; }
        public Customer Customer { get; private set; }
        public IReadOnlyList<Product> Products {
            get { return _products; }
        }
        public double TotalPriceWithoutVat { 
            get 
            {
                double totalPriceWithoutVat = 0;
                _products.ForEach(p => totalPriceWithoutVat += p.Price);
                return totalPriceWithoutVat;
            }
        }
        public double TotalPriceWithVat { 
            get 
            {
                return TotalPriceWithoutVat + (TotalPriceWithoutVat * 100 / 20);
            } 
        }

        public static Invoice Create(ISupplierService supplierService, 
            ICustomerService customerService, 
            int customerId, int supplierId, List<Product> products)
        {
            var invoice = new Invoice(supplierService, customerService);
            invoice.Customer = invoice.GetCustomer(customerId);
            invoice.Supplier = invoice.GetSupplier(supplierId);
            invoice.SetProducts(products);
            return invoice;
        }

        public void InsertProduct(Product product)
        {
            _products.Add(product);
        }

        private Supplier GetSupplier(int supplierId)
        {
            return _supplierService.GetSupplier(supplierId);
        }

        private Customer GetCustomer(int customerId)
        {
            return _customerService.GetCustomer(customerId);
        }

        private void SetProducts(List<Product> products)
        {
            _products = products;
        }
    }
}
