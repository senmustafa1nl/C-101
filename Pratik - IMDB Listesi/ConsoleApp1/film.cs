using System;
using System.Collections.Generic;

namespace IMDB
{
    public class Film
    {
        // Property to store the name of the film
        public string Ad { get; set; }

        // Property to store the IMDb rating of the film
        public double ImdbPuani { get; set; }

        // Constructor to initialize a Film object with name and IMDb rating
        public Film(string ad, double imdbPuani)
        {
            Ad = ad; // Set the film's name
            ImdbPuani = imdbPuani; // Set the film's IMDb rating
        }

        // Override the ToString method to return a formatted string representing the film
        public override string ToString()
        {
            // Format the string to display the film's name and IMDb rating
            return $"{Ad} - IMDb Rating: {ImdbPuani}";
        }
    }
}
