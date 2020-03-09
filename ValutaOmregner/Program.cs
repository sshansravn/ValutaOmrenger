using System;

namespace ValutaOmregner
{
    class program
    {
        public static void Main(string[] args)
        {
            var calctest = new omregnerClass();
            Console.WriteLine("Indtast beløb i danske kroner");
            Console.WriteLine("");
            string tempCurr = Console.ReadLine();
            calctest.dkk = (float) Convert.ToDouble(tempCurr);
            calctest.calculateCurrency();


        }
    }
}
