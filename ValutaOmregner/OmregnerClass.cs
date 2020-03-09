using System;
namespace ValutaOmregner
{
    public class omregnerClass{
       public float dkk;
       public const float kurs= 7.45f;
       
        public void calculateCurrency() {

            Console.WriteLine(dkk + " danske kroner, svarer til " + (dkk/100)*kurs + " euro");
        }

    }
}
