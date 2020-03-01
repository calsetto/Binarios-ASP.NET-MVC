using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Binarios.Models
{
    public class NumerosModel
    {
        public List<int> Numeros { get; set; } = new List<int>();
        public List<string> Binarios { get; set; } = new List<string>();
    }
}