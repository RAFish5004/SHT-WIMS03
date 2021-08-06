// ========================================================
// SessionExtensions.cs, 201005 p 266
// Author: Russell Fisher
// methods rely on Json.Net pkg to serialize objects into 
// JavaScript Object Notation
// ========================================================
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SHTWIMS03.Infrastructure
{
    public static class SessionExtensions // ------------------------------------------------------
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        } // eo SetJson method --------------------------------------------------------------------

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null
                ? default(T) : JsonConvert.DeserializeObject<T>(sessionData);
        }

    } // eo SessionExtensions class ---------------------------------------------------------------
} // eo namespace

