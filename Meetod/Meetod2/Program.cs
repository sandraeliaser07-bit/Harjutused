using System.Security.Cryptography.X509Certificates;

namespace Meetod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vastus = "";
            Console.WriteLine("Palun sisesta filtreeritav lähteinfo");
            string info = GetResponse();
            Console.WriteLine("Palun sisesta otsitav info");
            string searchThisWord = GetResponse();


            bool doesWordExist = FindThisWord(searchThisWord, info);
            if (doesWordExist == true)
            {
                Console.WriteLine("Leidsite sõna \"" + searchThisWord + "\" sinu sisestatud infost:");
                Console.WriteLine(info);
            }
            else
            {
                Console.WriteLine("sõna \"" + searchThisWord + "\" infost puudub");
            }
            vastus = ReapeatAction();
            {
                while (vastus == "jah") ;


                do
                {
                    Console.WriteLine("Kas soovid infosse midagi juurde lisada?");
                    if (vastus == "jah")
                    {
                        Console.WriteLine("Kirjuta juurde lisatav info");
                        info += GetResponse();
                    }
                } while (vastus == "jah");

                Console.WriteLine("Kas salvestad dokumendi töölauale, või dokumendikausta?");
                string kuhu = GetResponse();

                string saveFileHere = "";
                if (kuhu == "töölaud")
                {
                    saveFileHere = @"C:\Users\opilane\Desktop\info.txt";
                    File.WriteAllText(saveFileHere, info);
                }
                else if (kuhu == "dokumendid")
                {
                    saveFileHere = @"C:\Users\opilane\Documents\info.txt";
                    File.WriteAllText(saveFileHere, info);
                }
                else
                {
                    Console.WriteLine("ei saa are, " + kuhu + " ei ole salvestatav asukoht");
                }
                


                    Console.WriteLine("Headaega");
            }

        }

        private static string ReapeatAction()
        {
            string vastus;
            Console.WriteLine("kas tahad tegevust korrata (jah/ei)");
            vastus = GetResponse();
            return vastus;
        }

        public static bool FindThisWord(string filter, string toBeFiltered)
        {
            if (toBeFiltered.Contains(filter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetResponse()
        {
            string sisestus = "";
            while (sisestus == "")
            {
                sisestus = Console.ReadLine();
            }
            return sisestus;
        }
    }
}
