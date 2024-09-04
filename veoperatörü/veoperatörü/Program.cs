using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veoperatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 14;
            int sayi2 = 56;
            int sayi3 = 56;
            int sayi4 = 34;

            bool kontrol1 = sayi1 < sayi2 && sayi2 == sayi3; // sayi1 sayi2 den küçüktür TRUE sayi2 sayi3 e eşittir TRUE iki true sistemin TRUE olmasını sağlar.
            bool kontrol2 = sayi1 == sayi3 && sayi3 > sayi4; //sayi1 sayi3 e eşit değildir FALSE sayi3 sayi4 ten büyüktür TRUE ama sistemde bir tane false olduğu için sistem FALSE olur.

            Console.WriteLine(kontrol1);
            Console.WriteLine(kontrol2);
            Console.ReadLine();

        }
    }
}
