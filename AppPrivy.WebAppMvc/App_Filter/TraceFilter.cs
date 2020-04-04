using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;


namespace AppPrivy.WebAppMvc.App_Filter
{
    public class TraceFilter : IActionFilter
    {
        public bool AllowMultiple { get { return true; } }

      

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Trace.WriteLine(string.Format("Action Method {0} executing at {1}", context.ActionDescriptor.DisplayName, DateTime.Now.ToShortDateString()), "Web API Logs");
                           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Trace.WriteLine(string.Format("Action Method {0} executing at {1}", context.ActionDescriptor.DisplayName, DateTime.Now.ToShortDateString()), "Web API Logs");
        }
    }
}