using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeznutePetlje
{
    class ZeznutePetlje
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a = Math.Abs(a);
            b = Math.Abs(b);
            int first = a - 1;
            int second = b - 1;
            int GCD = 0;

            for (; ; )
            {
                while (a % first != 0)
                {
                    
                    first--;
                }

                for (; ; )
                {
                    while (b % second != 0)
                    {
                        
                        second--;
                    }
                    if (second == first)
                    {
                        GCD = second;
                        break;
                    }
                    if (second == 1) { break; }
                    second--;
                }
                second=b-1;
                if (GCD != 0) { break; }
                first--;
            }
           
            Console.WriteLine("GCD = " + GCD);
            int LCM = a*b/GCD;
            Console.WriteLine("LCM = " + LCM);
        
            
        }
    }
}
