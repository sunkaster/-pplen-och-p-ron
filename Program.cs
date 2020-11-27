using System;

namespace Äpplen_och_päron
{
    class Program
    {
        static void Main(string[] args)
        {
            int äpple = 7;
            int päron = 13;
            Console.WriteLine("Axels äpplen:");
            int Axel = int.Parse(Console.ReadLine());
            Console.WriteLine("Petras äpplen:");
            int Petra = int.Parse(Console.ReadLine());

            int AxelResultat = Axel * äpple;
            int PetraResultat = Petra * päron;

            if (AxelResultat < PetraResultat)
            {
                Console.WriteLine("Petra har tjänat mest");
            }
            else if (AxelResultat > PetraResultat)
            {
                Console.WriteLine("Axel har tjänat mest");
            }
            else
            {
                Console.WriteLine("Dem har tjänat lika mycket");
            }
        }
    }
}
