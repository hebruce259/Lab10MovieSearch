using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    class Movie
    {  //Variables 
        private string title;
        private string category;


        public Movie(string Title, string Category)

        {
            //Constructors
            this.Title = Title;
            this.Category = Category;
        }

        //Get or Give Access here
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }
        


    }


}
