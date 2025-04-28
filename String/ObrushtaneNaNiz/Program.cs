namespace ObrushtaneNaNiz
{
    internal class Program
    {
        static void Niz(string simvoli)
        {
            for (int i  = simvoli.Length -1 ; i >= 0; i--)
            {
                Console.Write(simvoli[i]);
            }
        }
        static void Main(string[] args)
        {
            string simvoli = Console.ReadLine();
            Niz(simvoli);
        }
    }
}
