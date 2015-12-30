using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDesignPatterns_in_CS_LiskovSubstitution.Validation
{
    public class InvoiceSubtotalValidator : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            if (invoice.Subtotal < 0)
            {
                return false;
            }
            return true;
        }
    }
}
