using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDesignPatterns_in_CS_LiskovSubstitution.Validation
{
    class InvoiceTaxRateCalculator : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            return invoice.TaxRate >= 0;
        }
    }
}
