namespace UnicodeSimvoli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string simvoli = Console.ReadLine();
            for (int i = 0; i< simvoli.Length; i++)
            {
                Console.Write($"\\u{(int)simvoli[i]:X4}");
            }
        }
    }
}
