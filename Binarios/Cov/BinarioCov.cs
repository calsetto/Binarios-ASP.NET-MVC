using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Binarios.HLP
{
    public class BinarioCov
    {
        public string NumeroBinario(int n)
        {
            string binary = Convert.ToString(n, 2);
            return binary;
        }
    }
}