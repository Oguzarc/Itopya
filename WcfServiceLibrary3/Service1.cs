using System;
using System.ServiceModel;

namespace GettingStartedLib
{
    public class CalculatorService : ICalculator
    {   
        public bool Kontrol(string name)
        {
            string KartNo =  "123456789" ;

            Console.WriteLine("Girilen KartNo :" + name);
            if(name==KartNo )
            {
                Console.WriteLine("Kartno Doğru");
                return true;
            }
            Console.WriteLine("Kart No yanlıs");
            return false;
        }

        public bool Kontrolay(string name)
        {
            string ay = "2";

            Console.WriteLine("Girilen ay :" + name);
            if (name == ay)
            {
                Console.WriteLine("ay Doğru");
                return true;
            }
            Console.WriteLine("ay yanlıs");
            return false;
        }

        public bool Kontrolcvv(string name)
        {
            string KartNo = "545";

            Console.WriteLine("Girilen cvv :" + name);
            if (name == KartNo)
            {
                Console.WriteLine("CVV Doğru");
                return true;
            }
            Console.WriteLine("CVV yanlıs");
            return false;
        }

        public bool Kontroldate(string name)
        {
            string tarih = "19";

            Console.WriteLine("Girilen tarih :" + name);
            if (name == tarih)
            {
                Console.WriteLine("tarih Doğru");
                return true;
            }
            Console.WriteLine("tarih yanlıs");
            return false;
        }
    }
}