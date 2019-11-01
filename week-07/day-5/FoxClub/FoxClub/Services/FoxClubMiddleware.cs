using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FoxClub.Models
{
    public class FoxService : IMiddleware
    {
        public List<Fox> Foxes { get; private set; }
        //public int Counter { get; private set; }

        public void AddFox(string name)
        {
            Foxes = new List<Fox>();
            //Counter++;
            Fox fox = new Fox(name);
            Foxes.Add(fox);
        }

        public FoxService()
        {
        }

        Task IMiddleware.InvokeAsync(HttpContext context, RequestDelegate next)
        {
            return next (context);
        }
    }
}
