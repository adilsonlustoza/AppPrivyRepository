using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using AppPrivyException = System.Exception;


namespace AppPrivy.CrossCutting.Fault
{
    public class FaultException : AppPrivyException
    {
        private StreamWriter _sw;
        private string _path = AppDomain.CurrentDomain.BaseDirectory;
        private string _directory = "Log";
        private string _file = "AppPrivy_{0}.log";

        public FaultException() : base()
        {
        }

        public FaultException(string message) : base(message)
        {
              WriteInfo(message).ConfigureAwait(false); 
        }

        public FaultException(string message, AppPrivyException innerException) : base(message, innerException)
        {
             WriteError(message, innerException).ConfigureAwait(false) ;
        }

        public async Task WriteError(string message, AppPrivyException exception)
        {
            try
            {
                if (!Directory.Exists(string.Format(@"{0}\{1}", _path, _directory)))
                    Directory.CreateDirectory(string.Format(@"{0}\{1}", _path, _directory));


                using (_sw = new StreamWriter(string.Format(@"{0}\{1}\{2}", _path, _directory, string.Format(_file, DateTime.Now.ToString("yyyyMMdd"))), true))
                {
                    await _sw.WriteLineAsync("Operation : " + message);
                    await _sw.WriteLineAsync("Mensagem : " + exception.Message);
                    await _sw.WriteLineAsync("Trace : " + exception.StackTrace);
                    await _sw.WriteLineAsync("Exception : " + exception.InnerException);
                    await _sw.WriteLineAsync("Source : " + exception.Source);
                    await _sw.WriteLineAsync(Environment.NewLine);
                   
                }

            }
            catch (AppPrivyException e)
            {
                Debug.WriteLine(e.Message) ;
            }

        }

        public async Task WriteInfo(string mensage)
        {
            try
            {

                if (!Directory.Exists(string.Format(@"{0}\{1}", _path, _directory)))
                    Directory.CreateDirectory(string.Format(@"{0}\{1}", _path, _directory));

                using (_sw = new StreamWriter(string.Format(@"{0}\{1}\{2}", _path, _directory, string.Format(_file, DateTime.Now.ToString("yyyyMMdd"))), true))
                {
                    await _sw.WriteLineAsync(mensage);
                    await _sw.WriteLineAsync(Environment.NewLine);
                    
                }

            }
            catch (AppPrivyException e)
            {
                Debug.WriteLine(e.Message);
            }

        }

    }
}
