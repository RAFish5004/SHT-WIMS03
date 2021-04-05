// ========================================================
// UrlExtensions.cs, p 261
// enables creating and managing navigation urls 
// url updates are developed automatically 
// ========================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SHTWIMS02.Infrastructure
{
    public static class UrlExtensions // static reqd --------------------------------------------
    {
        public static string PathAndQuery(this HttpRequest request) // ---------------------------
        {
            string returnUrl = request.QueryString.HasValue ?
                $"{request.Path}{request.QueryString}"
                : request.Path.ToString();
            return returnUrl;

        } // eo PathAndQuery method --------------------------------------------------------------

    } // eo UrlExtensions class -------------------------------------------------------------------
} // eo namespace
