using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            // www.patika.dev
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 12)
            {
                Console.WriteLine("GÜNAYDIN..");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İYİ GÜNLER..");
            }
            else {
                Console.WriteLine("İYİ GECELER..");

                


        }
            string sonuc = time <= 18 ? "İyi Günler!!" : "İyi Geceler!!";

           string sonuc1 = time >= 6 && time < 12 ? "Günaydın*" : time <= 18 ? "İyi Günler*" : "İyi geceler*";
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc1);

            Console.ReadLine();
        }
    }
}
