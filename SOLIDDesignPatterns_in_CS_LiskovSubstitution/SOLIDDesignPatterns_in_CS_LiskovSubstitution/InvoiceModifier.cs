using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDesignPatterns_in_CS_LiskovSubstitution
{
    public class InvoiceModifier
    {
        private Invoice _invoice;
        /// <summary>
        /// Poprzez dodanie ComplexInvoice, następuje złamanie LSP, gdyż InvoiceModifier nie poradzi sobie z przekazanym ob. ComplexInvoice
        /// </summary>
        /// <param name="invoice"></param>
        public InvoiceModifier(Invoice invoice)
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

        public Invoice GenerateInvoice()
        {
            return _invoice;
        }
    }
}
