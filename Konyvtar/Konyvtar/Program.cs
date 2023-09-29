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
    public struct Bookbuy
    {
        public string PersonID { get; set; }
        public string BookID { get; set; }
        public DateTime Date { get; set; }
        public DateTime ReDate { get; set; }
        public override string ToString()
        {
            return $"{PersonID};{BookID};{Date};{ReDate}";
        }
    }
    public class  BookBuy
    {
        public Dictionary<int,Bookbuy> Out = new Dictionary<int,Bookbuy>();

        public void Upset(Bookbuy bookbuy, int lines)
        {
            Dictionary<int, Bookbuy> Out = this.Out;
            for (int i = 1; i <= lines ; i++)
            {
                Out[i + 1] = Out[i];
            }
            Out[1] = bookbuy;
        }
        public string Read(int lines)
        {
            Dictionary<int, Bookbuy> Out = this.Out;
            return Out.GetValueOrDefault(lines).ToString();
        }
        public Dictionary<int, Bookbuy> Return()
        {
            Dictionary<int, Bookbuy> Out = this.Out;
            return Out;
        }
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
            Readers.Add(code, menber);
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
        public Dictionary<string, Readers> retur()
        { 
            return this.Readers; 
        }
    }
    public struct BOOK
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
        Dictionary<string, BOOK> Books = new Dictionary<string, BOOK>(); 
        public void Creates(string code, BOOK menber)
        {
            Dictionary<string, BOOK> Books = this.Books;
            Books.Add(code, menber);
        }
        public void Delete(string code)
        {
            Dictionary<string, BOOK> Books = this.Books;
            Books.Remove(code);
            Console.WriteLine("A konyv el lett tavolitva!");
        }
        public string Read(string code)
        {
            Dictionary<string, BOOK> Books = this.Books;
            BOOK value = Books[code];
            return value.ToString();
        }
        public void Update(string code, BOOK emb)
        {
            Dictionary<string, BOOK> Books = this.Books;
            Books[code] = emb;
        }
        public Dictionary<string, BOOK> retur()
        {
            return this.Books;
        }
    }
}