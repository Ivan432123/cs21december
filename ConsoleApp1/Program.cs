using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n = 3;
            double[] a = new double[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Введите элемент массива: ");
                a[i] = Convert.ToDouble(Console.ReadLine());
            }

            double min = a[0];
            for (i = 1; i < n; i++)
            {
                if (min > a[i])
                    min = a[i];
            }
            Console.WriteLine("min = {0}", min);

            double max = a[0];
            for (i = 1; i < n; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine("max = {0}", max);

        }




















        }

    }
    




