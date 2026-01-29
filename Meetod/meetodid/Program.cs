namespace meetodid
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere");
            Console.WriteLine("Palun kirjuta 5 arvutavat arvu");
            int[] arvutatavadArvud = new int[] { 2, 3, 4 };

                 static int ArvutaKokku(int[] arvud)
                

            {
                
                int summa = 0;
                summa = int.Parse(Console.ReadLine());
                
                foreach (int i in arvud)
                {
                    summa += i;
                }
                return summa;
            }
            

        }
    }
}
