using System;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int pair = 0;
            int[] MyArray = new int[20];

            MyArray[0] = rnd.Next(-10_000, 10_000);

            Console.WriteLine($"{0} - {MyArray[0]} = {MyArray[0] % 3 == 0}");

            bool lsthree = MyArray[0] % 3 == 0;

            for (int a = 1; a < MyArray.Length; a++)
            {
                MyArray[a] = rnd.Next(-10_000, 10_000);
                Console.WriteLine($"{a} - {MyArray[a]} = {MyArray[a] % 3 == 0}"); // False - Число не делится на 3, True - обратное
                if (MyArray[a] % 3 == 0 && lsthree == false || MyArray[a] % 3 != 0 && lsthree == true)
                {
                    pair++;
                }
                lsthree = MyArray[a] % 3 == 0 ? lsthree = true : lsthree = false;
            }
            Console.WriteLine($"Количество пар = {pair}");
            Console.ReadLine();
        }
    }
}
