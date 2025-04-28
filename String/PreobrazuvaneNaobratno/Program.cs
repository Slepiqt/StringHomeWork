namespace PreobrazuvaneNaobratno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi broinata sistema i chisloto: ");
            int[] chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        }
    }
}
