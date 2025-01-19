using IMDB;

public class Program
{
    public static void Main()
    {
        // List to store film objects
        List<Film> filmler = new List<Film>();

        // Welcome message
        Console.WriteLine("Welcome to Patika Culture Center!");
        Console.WriteLine("Please enter the name and IMDb rating of the movie you want to select.");
        Console.WriteLine("\n\n");

        // Predefined list of movies with their IMDb ratings
        Console.WriteLine("The Room - IMDb Rating: 1.9");
        Console.WriteLine("Gigli - IMDb Rating: 2.5");
        Console.WriteLine("Kirk Cameron's Saving Christmas - IMDb Rating: 2.7");
        Console.WriteLine("Troll 2 - IMDb Rating: 3.2");
        Console.WriteLine("Slender Man - IMDb Rating: 3.3");
        Console.WriteLine("Kirk Cameron: A Matter of Faith - IMDb Rating: 3.8");
        Console.WriteLine("Catwoman - IMDb Rating: 3.3");
        Console.WriteLine("The Last Airbender - IMDb Rating: 4.3");
        Console.WriteLine("Mortal Kombat: Annihilation - IMDb Rating: 3.7");
        Console.WriteLine("Batman & Robin - IMDb Rating: 3.7");
        Console.WriteLine("Leprechaun in the Hood - IMDb Rating: 4.0");
        Console.WriteLine("Transformers: The Last Knight - IMDb Rating: 5.2");
        Console.WriteLine("Kirk Cameron's Saving Christmas - IMDb Rating: 4.7");
        Console.WriteLine("The Happytime Murders - IMDb Rating: 5.1");
        Console.WriteLine("Pacific Rim: Uprising - IMDb Rating: 5.6");
        Console.WriteLine("Fifty Shades of Grey - IMDb Rating: 4.1");
        Console.WriteLine("Alone in the Dark - IMDb Rating: 2.3");
        Console.WriteLine("Trolls World Tour - IMDb Rating: 6.1");
        Console.WriteLine("Godzilla: King of the Monsters - IMDb Rating: 6.0");
        Console.WriteLine("Aquaman - IMDb Rating: 6.9");
        Console.WriteLine("Venom - IMDb Rating: 6.7");
        Console.WriteLine("Justice League - IMDb Rating: 6.2");
        Console.WriteLine("Shazam! - IMDb Rating: 7.0");
        Console.WriteLine("Guardians of the Galaxy Vol. 2 - IMDb Rating: 7.6");
        Console.WriteLine("Spider-Man: Into the Spider-Verse - IMDb Rating: 8.4");
        Console.WriteLine("Interstellar - IMDb Rating: 8.6");
        Console.WriteLine("The Dark Knight - IMDb Rating: 9.0");
        Console.WriteLine("The Shawshank Redemption - IMDb Rating: 9.3");
        Console.WriteLine("The Godfather - IMDb Rating: 9.2");
        Console.WriteLine("Schindler's List - IMDb Rating: 9.0");

        // Film creation method
        void filmOlustur()
        {
            // Asking user to input movie name
            Console.WriteLine("What is the name of the film?");
            string filmAdiGirdisi = Console.ReadLine();
            
            // Asking user to input IMDb rating
            Console.WriteLine("What is the IMDb rating?");
            double imdbPuaniGirdisi = Convert.ToDouble(Console.ReadLine());
            
            // Adding the movie to the list
            filmler.Add(new Film(filmAdiGirdisi, imdbPuaniGirdisi));  
        }

        // Creating the first movie
        filmOlustur();  

        // Asking user if they want to add more films
        string tekrarFilmOlusturCevap;
        do
        {
            Console.WriteLine("Would you like to enter another film? (Yes/No)");
            tekrarFilmOlusturCevap = Console.ReadLine().ToLower();

            if (tekrarFilmOlusturCevap == "evet")
            {
                filmOlustur();  // Add a new film
            }

        } while (tekrarFilmOlusturCevap == "evet");

        // Menu for choosing operations
        string secim;
        do
        {
            Console.WriteLine("\n\nPlease choose an action from the following options:");
            Console.WriteLine("1--> List all movies");
            Console.WriteLine("2--> List all movies with IMDb rating between 4 and 9.");
            Console.WriteLine("3--> List all movies whose name starts with 'A' and their IMDb ratings.");
            Console.WriteLine("Please enter the corresponding number:");

            secim = Console.ReadLine();

            // List all movies
            if (secim == "1")
            {
                foreach (var film in filmler)
                {
                    Console.WriteLine(film);  // Print the film object
                }
            }
            // List movies with IMDb rating between 4 and 9
            else if (secim == "2")
            {
                foreach (var film in filmler)
                {
                    if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
                    {
                        Console.WriteLine(film);  // Print the film object
                    }
                }
            }
            // List movies starting with 'A'
            else if (secim == "3")
            {
                foreach (var film in filmler)
                {
                    if (film.Ad.ToLower().StartsWith("a"))
                    {
                        Console.WriteLine(film);  // Print the film object
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }

        } while (secim != "1" && secim != "2" && secim != "3");
    }
}
