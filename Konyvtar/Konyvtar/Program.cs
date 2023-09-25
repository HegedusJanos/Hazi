using System.Collections;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Konyvtar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    
    public class  BookBuy
    { 
    }
    public struct Readers 
    {
        public string name {get;set;}
        public string adress {get;set;}
        public DateTime Date {get;set;}
        public override string ToString()
        {
            return $"Neve: {name}  Lakhelye: {adress}  Született: {Date.Year}.{Date.Month}.{Date.Day}.";
        }
    }
    public class Reader
    {
        public Dictionary<string, Readers> Readers = new Dictionary<string, Readers>();
        public void Creates(string code, Readers menber)
        {
            Dictionary<string, Readers> Readers = this.Readers;
            Readers.Add(code,menber);
        }
        public void Delete(string code) 
        {
            Dictionary<string, Readers> Readers = this.Readers;
            Readers.Remove(code);
            Console.WriteLine("A jomadar torolve lett!");
        }
        public string Read(string code)
        {
            Dictionary<string, Readers> Readers = this.Readers;
            Readers value = Readers[code];
            return value.ToString();
        }
        public void Update(string code, Readers emb)
        {
            Dictionary<string, Readers> Readers = this.Readers;
            Readers[code] = emb;
        }
    }
    public struct book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Forg { get; set; }
        public  DateTime DateB { get; set; }
        public override string ToString()
        {
            return $"Cime: {Title}  Lakhelye: {Author}  Forgalmazva: {Forg} altal  Kiadva: {DateB.Year}.{DateB.Month}.{DateB.Day}.";
        }
    }
    public class Book
    {
        Dictionary<string, book> Books = new Dictionary<string, book>(); 
        public void Creates(string code, book menber)
        {
            Dictionary<string, book> Books = this.Books;
            Books.Add(code, menber);
        }
        public void Delete(string code)
        {
            Dictionary<string, book> Books = this.Books;
            Books.Remove(code);
            Console.WriteLine("A konyv el lett tavolitva!");
        }
        public string Read(string code)
        {
            Dictionary<string, book> Books = this.Books;
            book value = Books[code];
            return value.ToString();
        }
        public void Update(string code, book emb)
        {
            Dictionary<string, book> Books = this.Books;
            Books[code] = emb;
        }
    }
}