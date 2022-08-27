using System;
using System.Timers;

namespace RMira_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Timer t = new Timer(300);
            string userRenk;
            string[] renkler = new string[5];
            string[] newRenk = new string[5];
            renkler[0] = "mavi";
            renkler[1] = "pembe";
            renkler[2] = "kırmızı";
            renkler[3] = "turuncu";
            renkler[4] = "lila";
            Random rnd = new Random();
            int randomRenk = rnd.Next(0, renkler.Length);
           // t.Start();
            Console.WriteLine("Game sequence :" + renkler[randomRenk]);
            Console.ReadKey();
            //t.Stop();
            newRenk[0] = renkler[randomRenk];
            Console.WriteLine("User input :");
            userRenk = Console.ReadLine();
            Console.ReadKey();

            if(userRenk == renkler[randomRenk])
            {
                int randomNewRenk = rnd.Next(0, renkler.Length);
                Console.WriteLine("Game sequence :" + renkler[randomNewRenk]);
                Console.ReadKey();
                Console.WriteLine("User input :");
                userRenk = Console.ReadLine();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Game Over");
            }










        }
    }
}
