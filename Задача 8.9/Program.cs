using System;


namespace Задача_8._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            String[] arr = data.Split(' ');
            int B = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());

            if (B >= arr.Length || B < 0)
            {
                Console.WriteLine("Число В должно быть в интервале {0}", arr.Length);
                return;
            }
            if (E >= arr.Length || E < 0)
            {
                Console.WriteLine("Число E должно быть в интервале {0}", arr.Length);
                return;
            }
            while (B == E)
            {
                Console.Write("{0} ", arr[E]);
                return;
            }

            while (B < arr.Length-1 && arr.Length <= 5)
            {
                Console.Write("{0} ", arr[B]);
                B++;

            }

            while (B < E && B < arr.Length && arr.Length > 5)
            {
                Console.Write("{0} ", arr[B]);
                B++;

            }

            while (B >= E && E <= arr.Length && arr.Length > 6)
            {
                Console.Write("{0} ", arr[E]);
                E++;

            }


        }
    }
}
