string[] Data = GetDataFromFile();
TakeApartLines(Data);


// Function 1 - Splitting lines and using them.
static string[] TakeApartLines(string[] Data)
{
    List<Movie> SomeMovies = new List<Movie>();

    foreach (string Line in Data)
    {
        string[] TempArray = Line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        Movie NewMovie = new Movie(TempArray[0], TempArray[1], TempArray[2]);
        SomeMovies.Add(NewMovie);
    }

    foreach (Movie NewMovie in SomeMovies)
    {
        Console.WriteLine($"One of my lector's favourite movies {NewMovie.Title} " +
            $"was released in {NewMovie.Year} " +
            $"and its rating is {NewMovie.Rating}/10 stars.");
    }
    return Data;
}


// Function 2 - File path
static string[] GetDataFromFile()
{
    string FilePath = "C:\\Users\\(string UserName)\\source\\data\\movies.txt";
    return File.ReadAllLines(FilePath);
}


// To see all lines

//static void ReadDataFromArray(string[] SomeArray)
//{
//    foreach (string Line in SomeArray)
//    {
//        Console.WriteLine(Line);
//    }
//}


class Movie
{
    // Fields
    string title;
    string rating;
    string year;


    // Getters
    public string Title
    { 
        get { return title; } 
    }

    public string Rating
    {
        get { return rating; }
    }

    public string Year
    {
        get { return year; }
    }


    // Method
    public Movie (string _title, string _rating, string _year)
    {
        title = _title;
        rating = _rating;
        year = _year;
    }
}