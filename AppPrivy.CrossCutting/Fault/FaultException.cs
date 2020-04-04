using System;
using System.IO;
using System.Threading.Tasks;
using AppPrivyException = System.Exception;


namespace AppPrivy.CrossCutting.Fault
{
    public class FaultException : AppPrivyException
    {
        private StreamWriter _sw;
        private string _path = AppDomain.CurrentDomain.BaseDirectory;
        public FaultException() : base()
        {
        }

        public async Task WriteError(AppPrivyException exception)
        {
            try
            {
                _sw = new StreamWriter(_path, true);
                await _sw.WriteLineAsync("Mensagem : " + exception.Message + Environment.NewLine);
                await _sw.WriteLineAsync("Trace : " + exception.StackTrace + Environment.NewLine);
                await _sw.WriteLineAsync("Exception : " + exception.InnerException + Environment.NewLine);
                await _sw.WriteLineAsync("Source : " + exception.Source + Environment.NewLine);
                await _sw.FlushAsync();
                _sw.Close();
                _sw.Dispose();

            }
            catch (AppPrivyException e)
            {
                throw e;
            }

        }

        public async Task WriteInfo(string mensage)
        {
            try
            {
                _sw = new StreamWriter(_path, true);
                await _sw.WriteLineAsync(mensage);
                await _sw.FlushAsync();
                _sw.Close();
                _sw.Dispose();

            }
            catch (AppPrivyException e)
            {
                throw e;
            }

        }

    }
}
