using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDesignPatterns_in_CS_LiskovSubstitution
{
    public class ComplexInvoice: Invoice
    {
        public decimal Subtotal { get; set; }
        public decimal TaxRate { get; set; }
        public decimal SecondTaxRate { get; set; }
        public decimal CalculateTax()
        {
            return (Subtotal * TaxRate / 100) + (Subtotal * SecondTaxRate / 100);
        }

        public decimal CalculateTotal()
        {
            return Subtotal + CalculateTax();
        }
    }
}
