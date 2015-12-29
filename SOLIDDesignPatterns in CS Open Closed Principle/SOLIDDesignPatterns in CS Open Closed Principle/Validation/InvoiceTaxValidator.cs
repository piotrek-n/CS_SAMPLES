using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDesignPatterns_in_CS_Open_Closed_Principle.Validation
{
    public class InvoiceTaxValidator: Validator
    {
        public override bool Validate(Invoice invoice)
        {
            return invoice.CalculateTax() >= 0;
        }
    }
}
