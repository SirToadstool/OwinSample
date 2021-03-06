﻿using Microsoft.Owin;
using System.Linq;

namespace OwinSample.Extensions
{
    public static class OwinContextExtensions
    {
        public static string GetUserId(this IOwinContext context)
        {
            var result = "-1";
            var claim = context.Authentication.User.Claims.FirstOrDefault(c => c.Type == "UserID");
            if (claim != null)
            {
                result = claim.Value;
            }
            return result;
        }
    }
}