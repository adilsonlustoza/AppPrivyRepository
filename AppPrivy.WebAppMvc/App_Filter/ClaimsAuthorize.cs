using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace AppPrivy.WebAppMvc.App_Filter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class ClaimsAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly string _claimName;
        private readonly string _claimValue;

        public ClaimsAuthorizeAttribute(string claimName, string claimValue)
        {
            this._claimName = claimName;
            this._claimValue = claimValue;
        }

        public void OnAuthorization(AuthorizationFilterContext httpContext)
        {
            var user = httpContext.HttpContext.User;

            if (!user.Identity.IsAuthenticated)
            {
                httpContext.Result = new UnauthorizedResult();
                return;
            }



            foreach (var item in user.Claims)
            {
                if (item.Value.Contains(this._claimName) || item.Value.Contains(this._claimValue))
                    return;
                else
                {
                    httpContext.Result = new StatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);                    
                    return;
                }
            }

        }


    }
}