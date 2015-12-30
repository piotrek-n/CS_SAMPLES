using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDesignPatterns_in_CS_LiskovSubstitution
{
    public class ComplexInvoiceModifier
    {
        private ComplexInvoice _invoice;
        /// <summary>
        /// Poprzez dodanie ComplexInvoice, następuje złamanie LSP, gdyż InvoiceModifier nie poradzi sobie z przekazanym ob. ComplexInvoice
        /// </summary>
        /// <param name="invoice"></param>
        public ComplexInvoiceModifier(ComplexInvoice invoice)
        {
            _invoice = invoice;
        }

        public void SetSubtotal(decimal subtotal)
        {
            _invoice.Subtotal = subtotal;
        }

        public void SetTaxRate(decimal taxRate)
        {
            _invoice.TaxRate = taxRate;
        }
        public void SetSecondTaxRate(decimal taxRate)
        {
            _invoice.SecondTaxRate = taxRate;
        }

        public Invoice GenerateInvoice()
        {
            return _invoice;
        }
    }
}
