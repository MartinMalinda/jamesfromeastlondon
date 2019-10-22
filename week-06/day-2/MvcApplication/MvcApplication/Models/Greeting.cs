using System;
namespace MvcApplication.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }

        public Greeting(long id, string content)
        {
            Id = id;
            Content = content;
        }
        public Greeting()
        {
        }
    }
}
