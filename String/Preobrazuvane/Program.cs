namespace Preobrazuvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi broinata sistema i 10-ichnoto chislo: ");
            int[] chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = chisla[1];
            if (chisla[0] >= 2 && chisla[0] <= 10)
            {
                string result = "";
                while (chisla[1] > 0)
                {
                    result = (chisla[1] % chisla[0]) + result;
                    chisla[1] = chisla[1] / chisla[0];
                }
                Console.WriteLine($"Chisloto {number} v {chisla[0]} broina sistema e = {result}");
            }
            
        }









    }
    
}
