using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>();
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine("There are 10 movies of in the list.");


            Console.Write("What category are you interested in? Choose from the following below.");
            Console.WriteLine();
            Console.Write("Your choices are: Drama, Scifi, Horror, Suspense, or Action: ");
            string category = Console.ReadLine();
           


            MovieList.Add(new Movie("Star Wars", "Scifi"));
            MovieList.Add(new Movie("2001: A Space Odyssey", "Scifi"));
            MovieList.Add(new Movie("Don't Breathe", "Horror"));
            MovieList.Add(new Movie("The Conjuring", "Horror"));
            MovieList.Add(new Movie("Finest Hours", "Drama"));
            MovieList.Add(new Movie("Bleed for This", "Drama"));
            MovieList.Add(new Movie("Shutter Island", "Suspense"));
            MovieList.Add(new Movie("Seven", "Suspense"));
            MovieList.Add(new Movie("The Dark Knight", "Action"));
            MovieList.Add(new Movie("The Avengers", "Action"));

            searchByCategory(MovieList, category);

        }


        public static void searchByCategory(List<Movie> MovieList, string category)
        {
            for (int i = 0; i < MovieList.Count; i++)
            {
                //char Yes = 'y';
                if (MovieList[i].Category == category)

                {
                    Console.WriteLine(MovieList[i].Title);
                                      
                 //   searchByCategory(MovieList, category);
                }
                             
            }
            Console.WriteLine("Would you like to choose another category? Enter y/n: ");



        }
    }
}
    
        
            
            

       

