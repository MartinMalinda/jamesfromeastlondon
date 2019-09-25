using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost blogPostOne = new BlogPost();
            {
                blogPostOne.authorName = "John Doe";
                blogPostOne.title = "Lorem Ipsum";
                blogPostOne.text = "Lorem ipsum dolor sit amet.";
                blogPostOne.publicationDate = "2000.05.04.";
            }
            BlogPost blogPostTwo = new BlogPost();
            {
                blogPostTwo.authorName = "Tim Urban";
                blogPostTwo.title = "Wait but why";
                blogPostTwo.text = "A popular long-form, stick-figure-illustrated blog about almost everything.";
                blogPostTwo.publicationDate = "2010.10.10.";
            }
            BlogPost blogPostThree = new BlogPost();
            {
                blogPostThree.authorName = "William Turton";
                blogPostThree.title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
                blogPostThree.text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";
                blogPostThree.publicationDate = "2017.03.28.";
            }
        }   
    }
}

// Create a BlogPost class that has
// an authorName
// a title
// a text
// a publicationDate
// Create a few blog post objects:
// "Lorem Ipsum" titled by John Doe posted at "2000.05.04."
// Lorem ipsum dolor sit amet.
// "Wait but why" titled by Tim Urban posted at "2010.10.10."
// A popular long-form, stick-figure-illustrated blog about almost everything.
// "One Engineer Is Trying to Get IBM to Reckon With Trump" titled by William Turton at "2017.03.28."
// Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.
// When I asked to take his picture outside one of IBM’s New York City offices,
// he told me that he wasn’t really into the whole organizer profile thing.
