using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace FoxClub.Models
{
    public class FoxService : IMiddleware
    {
        static List<string> ListOfTricks = new List<string>()
        {
            new string("Write HTML"),
            new string("Code in Java")
        };

        static List<Fox> Foxes = new List<Fox>()
        {
            new Fox("Mr. Fox", ListOfTricks, "pizza", "lemonade")
        };

        public bool AddFox(string name)
        {
            bool nameExists = false;
            foreach (var foxx in Foxes)
            {
                if (foxx.Name == name)
                {
                    nameExists = true;
                    return nameExists;
                }
            }
            ListOfTricks = new List<string>();
            Fox fox = new Fox(name, ListOfTricks, "salad", "water");
            Foxes.Add(fox);
            return nameExists;
        }

        public void AddTrick(string trick)
        {
            ListOfTricks = new List<string>();
            ListOfTricks.Add(trick);
        }

        public List<Fox> GetFoxList(string name)
        {
            var SelectedFox = Foxes.Where(f => f.Name == name).ToList();
            return SelectedFox;
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
