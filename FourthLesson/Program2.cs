using System;
using System.IO;

namespace Example2
{
    static class StaticClass
    {
        public static void ExampleA(int[] Array)
        {
            bool lsthree = Array[0] % 3 == 0;
            int pair = 0;

            Console.WriteLine($"{0} - {Array[0]} = {lsthree}");

            for (int a = 1; a < Array.Length; a++)
            {
                Console.WriteLine($"{a} - {Array[a]} = {Array[a] % 3 == 0}"); // False - Число не делится на 3, True - обратное
                if (Array[a] % 3 == 0 && lsthree == false || Array[a] % 3 != 0 && lsthree == true)
                {
                    pair++;
                }
                lsthree = Array[a] % 3 == 0 ? lsthree = true : lsthree = false;
            }
            Console.WriteLine($"Количество пар = {pair}");
            Console.ReadLine();
        }
        //public static int[] ExampleB()
        //{
        //    StreamReader sr = new StreamReader("..\\..\\Array.txt");
        //    int a = int.Parse(sr.ReadLine());
        //    int[] Array = new int[a];
        //    for(int b = 0;b < a;b++)
        //    {
        //        Array[b] = int.Parse(sr.ReadLine());
        //    }
        //    sr.Close();
        //    return Array;
            
        //}

        public static int[] ExampleC()
        {
                try
                {
                StreamReader sr = new StreamReader("..\\..\\Array.txt");
                int a = int.Parse(sr.ReadLine());
                int[] Array = new int[a];
                for (int b = 0; b < a; b++)
                    {
                        Array[b] = int.Parse(sr.ReadLine());
                    }
                sr.Close();

                return Array;

                }
                catch(Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    return null;
                }
            
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region А
            Random rnd = new Random();

            int[] MyArray = new int[20];

            for (int a = 0; a < MyArray.Length; a++)
            {
                MyArray[a] = rnd.Next(-10_000, 10_000);
            }
            StaticClass.ExampleA(MyArray);
            #endregion
            #region Б
            //int[] ExamB = StaticClass.ExampleB();
            //StaticClass.ExampleA(ExamB);
            #endregion
            #region В
            int[] ExamС = StaticClass.ExampleC();
            if (ExamС == null) Console.ReadLine();
            else StaticClass.ExampleA(ExamС);
            
            #endregion
        }
    }
}
