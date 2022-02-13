using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace funktiot

{

    class Program

    {

        private static int Pienin(int eka, int toka, int kolmas)

        {
            if (eka <= toka && eka <= kolmas)
                return eka;
            else if (toka <= eka && toka <= kolmas)
                return toka;
            else
                return kolmas;


        }

        private static int Suurin(int eka, int toka, int kolmas)

        {
            if (eka >= toka && eka >= kolmas)
                return eka;
            else if (toka >= eka && toka >= kolmas)
                return toka;
            else
                return kolmas;


        }



        static void Main(string[] args)

        {

            int luku1, luku2, luku3, suurinLuku, pieninLuku;

            string syote;



            Console.WriteLine("Anna eka luku:");

            syote = Console.ReadLine();

            luku1 = int.Parse(syote);

            Console.WriteLine("Anna toka luku:");

            syote = Console.ReadLine();

            luku2 = int.Parse(syote);

            Console.WriteLine("Anna kolmas luku:");

            syote = Console.ReadLine();

            luku3 = int.Parse(syote);


            pieninLuku = Pienin(luku1, luku2, luku3);

            suurinLuku = Suurin(luku1, luku2, luku3);

            Console.WriteLine("Pienin luku on " + pieninLuku + " ja suurin luku on " + suurinLuku);







        }

    }

}

