using Serilog;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using AppPrivyException = System.Exception;


namespace AppPrivy.CrossCutting.Fault
{
    public class FaultException : AppPrivyException
    {
     

        public FaultException() : base()
        {
        }

        public FaultException(string message) : base(message)
        {
            Log.Error(message);
        }

        public FaultException(string message, AppPrivyException innerException) : base(message, innerException)
        {
            Log.Error(innerException, message);
        }
       

    }
}
