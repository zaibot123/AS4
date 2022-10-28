namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Rumst r = new Rumst(1);
            Console.Write(r.b);
        }
    }

    public class Rumst
    {

        public int b;

        public Rumst(int b)
        {
            this.b = b;
        }
    }
}