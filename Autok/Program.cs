namespace Autok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ugyfel ugyfel = new Ugyfel();
        }
    }
    public struct Ugyfel
    {
        public string UgyfelNev { get; set; }
        public string Lakcim { get; set; }
        public string Email { get; set; }
    }
    public class Ugyfelek
    {
        Dictionary<string, Ugyfel> ugyfelek = new Dictionary<string, Ugyfel>();
        public void Creat(string Usam,Ugyfel ugyf)
        {
            Dictionary<string, Ugyfel> ugyfelek = this.ugyfelek;
            ugyfelek.Add(Usam,ugyf);
        }
        public void Update(string Usam, Ugyfel ugyf)
        {
            Dictionary<string, Ugyfel> ugyfelek = this.ugyfelek;
            ugyfelek.Add(Usam, ugyf);
        }
    }
}