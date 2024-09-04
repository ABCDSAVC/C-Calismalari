using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veyaoperatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 23;
            int sayi2 = 56;
            int sayi3 = 45;
            int sayi4 = 23;

            bool kontrol1 = sayi1 == sayi2 || sayi3 > sayi4; // 23 56 ya eşit olmadığı için FALSE 45 23 ten büyük olduğu için TRUE veya operatöründe en az bir tane true olması sistemin true olmasına yeter bu yüzden sistem TRUE.
            bool kontrol2 = sayi1 > sayi3 || sayi4 == sayi2; // 23 56 dan büyük olmadığı için FALSE. 45 23 e eşit olmadığı için FALSE bu sebeple sistem FALSE.

            Console.WriteLine(kontrol1);
            Console.WriteLine(kontrol2);
            Console.ReadLine();

        }
    }
}
