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
            //Load Movies 

            List<Movie> MovieList = new List<Movie>();

            MovieList.Add(new Movie("Star Wars", "Scifi"));
            MovieList.Add(new Movie("2001: A Space Odyssey", "Scifi"));
            MovieList.Add(new Movie("Don't Breathe", "Horror"));
            MovieList.Add(new Movie("The Conjuring", "Horror"));
            MovieList.Add(new Movie("Finest Hours", "Drama"));
            MovieList.Add(new Movie("Bleed for This", "Drama"));
            MovieList.Add(new Movie("Nemo", "Animated"));
            MovieList.Add(new Movie("Frozen", "Animated"));
            MovieList.Add(new Movie("The Dark Knight", "Action"));
            MovieList.Add(new Movie("The Avengers", "Action"));


            //Prompt the User the first time
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine("There are 10 movies in the list.");
            Console.WriteLine();

            Console.Write("What category are you interested in? ");
            Console.WriteLine();
            Console.Write("Drama, Scifi, Horror, Animated, or Action: ");

            //Read User Input and search categories until their is a match the first time
            string category = Console.ReadLine();
            searchByCategory(MovieList, category);

            //User is prompted to choose to continue, if enter y without invalid data, the search will continue or else the app exits
            Console.WriteLine("Would you like to continue? Enter y/n ");
            string Yes = Console.ReadLine();
            while (true)
            {


                if (Yes == "y")

                {
                    Console.Write("What category are you interested in? ");
                    Console.WriteLine();
                    category = Console.ReadLine();
                    searchByCategory(MovieList, category);
                    Console.WriteLine("Continue? y or n");

                }

                else if (Yes == "Yes" || Yes == "YES" || Yes == "yes")
                {
                    Console.WriteLine("Invalid Choice. Please type either y or n. ");
                }
                else
                {
                    Console.WriteLine("Good Bye!");
                }
                //Print out Search after looping through the method
            }
        }
        public static void searchByCategory(List<Movie> MovieList, string category)
        {
            for (int i = 0; i < MovieList.Count; i++)
            {

                if (MovieList[i].Category == category)

                {
                    Console.WriteLine(MovieList[i].Title);

                }
            }




        }
    }
}
    
        
            
            

       

