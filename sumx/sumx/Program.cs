using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumx
{
    class Program
    {
        
        public static int sumX(int x, int n) {
            int a , b ;
            int hasil;
            hasil = 0;
            a = x;
            b = n;
            if (a > 0 && b > 0)
            {
                
                    for (int i = 1; i <= b; i++)
                    {
                        if ((i) % (a) == 0)
                        {
                            hasil = i + hasil;
                            
                        }
                        
                        else
                        {
                            
                        }
                    }
                
            }
            else if (a < 0 && b < 0)
            {
               a= a * -1;
                b = b * -1;

                    for (int i = 1; i <= b; i++)
                    {
                        if ((i) % (a) == 0)
                        {
                        hasil = i + hasil;
                      
                            
                        }
                        else
                        {

                          
                        }
                    
                }hasil = hasil * -1;
            }
           else if (a < 0 && b > 0 || a > 0 && b < 0 || a == 0 && (b > 0 || b < 0) || (a > 0 || a < 0) && b == 0)
            {
                hasil = 0;
            }
            return hasil;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine((sumX(-1,-10)));
            Console.WriteLine("sumX(3, 10): " + (sumX(3, 10) == 18));
            Console.WriteLine("sumX(1, 10): " + (sumX(1, 10) == 55));
            Console.WriteLine("sumX(0, 10): " + (sumX(0, 10) == 0));
            Console.WriteLine("sumX(-1, 10): " + (sumX(-1, 10) == 0));
            Console.WriteLine("sumX(-1, -10): " + (sumX(-1, -10) == -55));
        }
    }
}
