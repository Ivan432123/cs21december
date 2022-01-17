using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());
            
            // ввод (x) = 2
                while (x <= 32 && x >= 2)
                {
                    
                    
                    Console.Write("{0} ", x);
                x += 3;
            }

            // ввод (x) = 4   
                while (x <= 34 && x >= 4)
                {
                    
                    Console.Write("{0} ", x);
                x += 3;
                }


            // ввод (x) = -6  
                while (x <= 24 && x >= -6)
                {

                    Console.Write("{0} ", x);
                    x += 3;
                }


            // ввод (x) = 1000
                while (x >= 1000 && x <= 1030)
                {
                    
                    Console.Write("{0} ", x);
                    x += 3;
                }



                }
            }
        }
    

