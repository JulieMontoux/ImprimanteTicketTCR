using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsImprimante
{
    internal class Imprimante
    {

        private const string TextePrixTotal = "Prix total : ";

        public string HelloWorld()
        {
            return "Hello, World!";
        }

        public string PrixTotal() 
        {
            return (TextePrixTotal+"0 EUR");
        }
    }
}
