﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDDesignPatterns_in_CS_Open_Closed_Principle.Validation
{
    public abstract class Validator
    {
        public abstract bool Validate(Invoice invoice);
    }
}
