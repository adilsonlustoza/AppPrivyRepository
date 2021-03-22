using AppPrivy.CrossCutting.Commom;
using Serilog;
using Serilog.Events;
using System;
using System.IO;
using AppPrivyException = System.Exception;


namespace AppPrivy.CrossCutting.WLog
{
    public class AppPrivyLog 
    {
        private static AppPrivyLog appPrivyLog;

        public static AppPrivyLog GetInstance()
        {
            if (appPrivyLog == null)
                appPrivyLog = new AppPrivyLog();
            return appPrivyLog;
        }

        private AppPrivyLog() 
        {
                 Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 .WriteTo.Console()
                 .WriteTo.File(Path.Combine(Environment.CurrentDirectory, ConstantHelper.AppPrivyLogFolderPath) ,
                              outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
                              restrictedToMinimumLevel: LogEventLevel.Verbose,                               
                              rollingInterval: RollingInterval.Day)
                 .CreateLogger();

        }

        public void Verbose(string message,AppPrivyException ex=null) 
        {
            Log.Verbose(ex,message);
        }

        public void Information(string message,AppPrivyException ex = null)
        {
            Log.Information(ex,message);
        }


        public void Error(string message, AppPrivyException ex=null)
        {
            Log.Error(ex,message);
        }

        public void Warning(string message, AppPrivyException ex=null)
        {
            Log.Warning(ex, message);
        }


    }
}
