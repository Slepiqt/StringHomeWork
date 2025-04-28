namespace Palindrom
{
    internal class Program
    {
        static string Sravnqvane(string str )
        {
            string obrDuma = "";
            for ( int i = str.Length - 1;i >= 0; i--)
            {
                obrDuma += str[i];
            }
            if ( obrDuma == str)
            {
                return "true";
            }
            else
            {
                return "false";
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi duma: ");
            string str = Console.ReadLine();

            string rezult = Sravnqvane(str);
            Console.WriteLine(rezult);
            
        }
    }
}
