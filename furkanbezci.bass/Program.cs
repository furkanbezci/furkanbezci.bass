using System;

namespace furkanbezci.bass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("furkanbezci.bass!");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 100; i >= 1; --i)
            {
                Console.WriteLine(i);
            }
            
            Console.Write("Input n :");
            var nstr = Console.ReadLine(); //kullanıcıdan değer oku
             
            if(!int.TryParse(nstr, out int n))
            {
                Console.WriteLine("Lütfen int bir değer giriniz");
            }
            else
            {
                Console.WriteLine("Sum: " + Sum(n));
                Console.WriteLine("Sum_A: " + Sum_A(n));
            }
        }

        public static int Sum(int n)
        {
            return n*(n+1) / 2;
        }
        public static int Sum_A(int n)
        {
            int result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
