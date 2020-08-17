using System;

namespace HomeWork
{
    public delegate double Fun(double x, double a);
    class Program
    {
        public static void Table(Fun F, double x, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }
        public static double Sinus(double x, double a)
        {
            return a * Math.Sin(x);
        }
        private static void Main()
        {
            Console.WriteLine("Таблица функции Myfunc : ");
            Table(MyFunc, -2, 3, 2);
            Console.WriteLine("Таблица функции Sinus : ");
            Table(Sinus, -2, 3, 2);

            Console.ReadLine();
        }
    }

}
