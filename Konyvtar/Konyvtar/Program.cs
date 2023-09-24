using System.Collections;
namespace Konyvtar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asd");
            Console.WriteLine("Bsd");
        }
    }
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AName { get; set; }
        public string PublishingPlace { get; set; }
        public int PublihingYear { get; set; }

    }
    public class Reader
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int BirthYear { get; set; }
    }

}