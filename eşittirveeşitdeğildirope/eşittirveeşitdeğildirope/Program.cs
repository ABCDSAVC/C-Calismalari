using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eşittirveeşitdeğildirope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 24;
            int sayi2 = 34;
            int sayi3 = 66;
            int sayi4 = 66;
            int sayi5 = 59;
            int sayi6 = 59;
            int sayi7 = 53;
            int sayi8 = 45;

            bool kontrolet = sayi1 == sayi2; //1 ve 2 eşit olamadığı için false
            bool kontrolet1 = sayi3 == sayi4; //3 ve 4 eşi olduğu için true

            bool kontrolet2 = sayi5 != sayi6; //5 ve 6 eşit olduğu için sorgulama eşit olamamsına göre yapılmakta false
            bool kontrolet3 = sayi7 != sayi8; // sorgulama eşit olmadığına göre yapılmakta 7 ve 8 eşit değildir true 

            Console.WriteLine(kontrolet);
            Console.WriteLine(kontrolet1);
            Console.WriteLine(kontrolet2);
            Console.WriteLine(kontrolet3);
            Console.ReadLine();

        }
    }
}
