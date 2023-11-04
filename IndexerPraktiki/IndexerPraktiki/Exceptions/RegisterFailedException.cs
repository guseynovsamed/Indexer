using IndexerPraktiki.Helpers.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPraktiki.Exceptions
{
    public class RegisterFailedException : Exception
    {
        public RegisterFailedException() : this (AccountMessages.RegisterFaild)
        {
            
        }
        public RegisterFailedException(string msj) : base (msj) 
        {
            
        }
    }
}
