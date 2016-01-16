using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADVANCE.MichaelLam_Patterns._14_PrototypePattern
{
    public abstract class XBoxGame
    {
        public string Title { get; set; }
        public string ProducKey { get; set; }

        public abstract XBoxGame Clone();

        public static string ProductKeyGeneration()
        {
            Random r = new Random();
            string productKey = "";

            for (int x = 0; x < 20; x++)
            {
                if (x % 5 == 0 && x != 0)
                {
                    productKey += "-";
                }
                productKey += (char)(r.Next(26) + 65);
            }

            return productKey;
        }
    }
}
