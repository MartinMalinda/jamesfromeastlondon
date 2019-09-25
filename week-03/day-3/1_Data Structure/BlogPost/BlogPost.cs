using System;
namespace OOP
{
    public class BlogPost
    {
        public string authorName { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string publicationDate { get; set; }

        public BlogPost()
        {

        }

        public BlogPost(string authorName, string title, string text, string publicationDate)
        {
            this.authorName = authorName;
            this.title = title;
            this.text = text;
            this.publicationDate = publicationDate;
        }
    }
}
