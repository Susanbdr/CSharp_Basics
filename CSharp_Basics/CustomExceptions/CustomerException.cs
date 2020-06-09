using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp_Basics.CustomExceptions
{
    public class CustomerException : Exception
    {
        public CustomerException(string message)
            : base(message)
        {
            
        }
    }
}
