namespace UmnojavaneNaKodove
{
    internal class Program
    {
        static void Sum(string str1, string str2)
        {
            int sum = 0;
            int minstr;
            if (str1.Length < str2.Length)
            {
                minstr = str1.Length;
            }
            else
            {
                minstr = str2.Length;
            }
            for (int i = 0; i < minstr; i++)
            {
                sum = sum + (str1[i] * str2[i]);
            }
            if (str1.Length > str2.Length)
            {
                for (int i = minstr; i < str1.Length; i++)
                {
                    sum += str1[i];
                }
            }
            else
            {
                for (int i = minstr; i < str2.Length; i++)
                {
                    sum += str2[i];
                }
            }
            
            Console.WriteLine($"Suma e :{sum}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vkarai dva niza: ");
            string[] str = Console.ReadLine().Split(' ');
            string str1 = str[0];
            string str2 = str[1];


            Sum(str1, str2);


        }
    }
}
