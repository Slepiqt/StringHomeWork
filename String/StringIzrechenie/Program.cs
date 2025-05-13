using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace StringIzrechenie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vuvedete izrechenie: ");
            string izrechenie = Console.ReadLine();
            int izbor = 0;
            do
            {
                Console.WriteLine("Izberete is funkciq koqto iskate da polzvate.");
                Console.WriteLine("1.CountWords (broi dumite)");
                Console.WriteLine("2.LastWord(poslednata duma naobratno)");
                Console.WriteLine("3.TurseneNaPodniz(turzi izbrana ot vas duma)");
                Console.WriteLine("4.NaiDulgaDuma(pokazva nai dulgata duma)");
                Console.WriteLine("5.Remove(premahva purvata i poslednata duma)");
                Console.WriteLine("6.Palindrom(tova e duma koqto e sushtata kogato q oburnesh na obratno)");
                Console.WriteLine("0.Exit");
                Console.Write("Vashiq izbor: ");               
                izbor = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------");
                switch (izbor)
                {
                    case 1:
                        CountWords(izrechenie);
                        break;
                    case 2:
                        LastWord(izrechenie);
                        break;
                    case 3:
                        TurseneNaPodniz(izrechenie);
                        break;
                    case 4:
                        NaiDulgaDuma(izrechenie);
                        break;
                    case 5:
                        Remove(izrechenie);
                        break;
                    case 6:
                        Palindrom(izrechenie);
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Error!!");
                        break;
                }

            } while (izbor != 0);


        }
        static void CountWords(string izrechenie)
        {
            int count = 0;
            bool Vutre = false;
            for (int i = 0; i < izrechenie.Length; i++)
            {
                char bukva = izrechenie[i];
                if (bukva != ' ')
                {
                    if (Vutre == false)
                    {
                        Vutre = true;
                        count++;
                    }

                }
                else
                {
                    Vutre = false;
                }



            }
            Console.WriteLine($"Broi dumi: {count}");
            Console.WriteLine("----------------------------------------------------------------");
        }
        static void LastWord(string izrechinie)
        {
            string[] dumi = izrechinie.Split(' ');
            string lastword = dumi[dumi.Length - 1];
            string oburnata = "";
            for (int i = lastword.Length - 1; i >= 0; i--)
            {
                oburnata += lastword[i];
            }
            Console.WriteLine($"Poslednata duma na obratno: {oburnata}");
            Console.WriteLine("----------------------------------------------------------------");
        }
        static void TurseneNaPodniz(string izrechenie)
        {
            Console.WriteLine("Vuvedi duma koqto tursite: ");
            string podniz = Console.ReadLine();

            int count = 0;
            int index = izrechenie.IndexOf(podniz);

            while (index != -1)
            {
                count++;

                index = izrechenie.IndexOf(podniz, index + 1);
            }
            if (count > 0)
            {
                Console.WriteLine($"Dumata se sreshta: {count} puti");
            }
            else
            {
                Console.WriteLine("Dumata q nqma v izrechenieto!");
            }
            Console.WriteLine("----------------------------------------------------------------");

            Console.WriteLine("Iskate li da zamenite dumite s \"###\" ako da zapishete (1) ako ne (-1): ");
            int otgovor = int.Parse(Console.ReadLine());
            if (otgovor == 1)
            {
                string replace = izrechenie.Replace(podniz, "###");
                Console.WriteLine($"Zamenite sa : {count}");
                string CleanReplace = replace.Trim();
                Console.WriteLine($"Tova e izrechenieto s zamenenite dumi: {CleanReplace}");
            }
            Console.WriteLine("----------------------------------------------------------------");
        }
        static void NaiDulgaDuma(string izrechenie)
        {
            string[] dumi = izrechenie.Split(' ');
            string NaiDulga = "";
            int max = 0;
            for (int i = 0; i < dumi.Length; i++)
            {
                string word = dumi[i];
                if (word.Length > max)
                {
                    NaiDulga = word;
                    max = word.Length;
                }
            }
            if (max > 0)
            {
                Console.WriteLine($"nai dulgata duma e : {NaiDulga} s duljina {max} bukvi");
            }
            Console.WriteLine("----------------------------------------------------------------");
        }
        static void Remove(string izrechenie)
        {
            List<string> dumi = izrechenie.Split().ToList();
            if (dumi.Count < 2)
            {
                Console.WriteLine("Dve dumi ne sa dostatuchni za tova deistvie molq vuvedete poveche ot dve dumi!");
                Console.WriteLine("----------------------------------------------------------------");
                return;
            }
            dumi.RemoveAt(dumi.Count - 1);
            dumi.RemoveAt(0);
            Console.WriteLine("Eto izrechenieto bez purva i posledna duma: ");
            Console.WriteLine(string.Join(" ", dumi));
            Console.WriteLine("----------------------------------------------------------------");
        }
        static void Palindrom(string izrechenie)
        {
            string[] dumi = izrechenie.Split();
            bool palindrom = false;
            for (int i = 0; i < dumi.Length; i++)
            {
                string real = dumi[i].ToLower();
                string naobratno = Reverse(real);

                if (naobratno == real)
                {
                    Console.WriteLine($"Dumata ({dumi[i]}) e Palindrom : {dumi[i]} == {naobratno}");

                }

            }



            Console.WriteLine("----------------------------------------------------------------");

        }
        static string Reverse(string real)
        {
            string reversed = "";
            for (int i = real.Length - 1; i >= 0; i--)
            {
                reversed += real[i];
            }
            return reversed;
        }

    }
}
