namespace Patterns.Structural.Facade.DvdPlayer;


    public class Dvd
    {
        public Dvd(string name)
        {
            Movie = name;
        }
        public string Movie { get; set; }
    }
