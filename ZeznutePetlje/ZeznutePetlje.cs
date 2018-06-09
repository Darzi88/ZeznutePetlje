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
            int first = a - 1; // Reduces its value until its divisible for variable a
            int second = b - 1; // Reduces its value until its divisible for variable b
            int GCD = 0; // Greatest common divisor, set as 0 because its should be have a value

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
            Console.WriteLine();
        
            
        }
    }
}
