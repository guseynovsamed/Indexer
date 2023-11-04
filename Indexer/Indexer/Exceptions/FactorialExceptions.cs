using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Exceptions
{
    public class FactorialExceptions : Exception
    {
        public FactorialExceptions() : this("Operation is not correct")
        {
            
        }
        public FactorialExceptions(string msj) : base(msj)
        {
            
        }
    }
}
