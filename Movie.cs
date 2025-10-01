namespace Cinema_UML
{
    public class Movie
    {
        public string Title { get; private set; }
        public int Duration { get; private set; } // in minutes
        public string Genre { get; private set; }

        public Movie(string title, int duration, string genre)
        {
            Title = title;
            Duration = duration;
            Genre = genre;
        }

        public string GetInfo()
        {
            return $"{Title} ({Genre}), {Duration} min";
        }
    }
}
