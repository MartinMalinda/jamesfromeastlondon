using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FoxClub.Models
{
    public class FoxClubMiddleware : IMiddleware
    {
        public FoxClubMiddleware()
        {
        }

        Task IMiddleware.InvokeAsync(HttpContext context, RequestDelegate next)
        {
            return next (context);
        }
    }
}
