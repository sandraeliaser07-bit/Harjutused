using System.Security.Cryptography.X509Certificates;

namespace meetod3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testmethod();
            int sisend1 = int.Parse(Console.ReadLine());
            int sisend2 = int.Parse(Console.ReadLine());
            float tulemus = Arvutaja(sisend1, sisend2);
            Console.WriteLine(tulemus);
            // kirjuta meetod mis tagastab kasutajale true või false, kui kasutaja poolt sisestatud arv ületab 100

      
        }

        public static void TrueFalse()
        {
            Console.WriteLine(true);
            if ()

            
        }
        public static void Testmethod()
        {
            Console.WriteLine("tere");
        }
        public static float Arvutaja(int arv1, int arv2)
        {
            return (float)arv1 / (float)arv2;
        } 
    }
}
