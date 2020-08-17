using System;
using System.Collections;
using System.IO;

namespace Example3
{
     class Program
    {
        private static void Main(string[] args)
        {
            int b = 0;
            int c = 0;
            int d = 0;
            int l = 0;


            int[] Kr = new int[7];

            StreamReader sr = new StreamReader("students_1.txt");
            string[] asds;
            ArrayList list = new ArrayList();
            ArrayList list2 = new ArrayList();
            //StreamWriter srwr = new StreamWriter("students_1.txt");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');

                    list.Add(s[3] + " лет  - " + s[0] + " " + s[1]);
                    list2.Add(" " + s[2] + "      " + s[3] + " лет - " + s[0] + " " + s[1]);


                    if (int.Parse(s[2]) == 5 || int.Parse(s[2]) == 6)
                    {
                        c++;
                    }
                    if (int.Parse(s[3]) >= 18 && int.Parse(s[3]) <= 22)
                    {
                        b++;
                        for (int a = 1; a <= 6; a++)
                        {
                            if (int.Parse(s[2]) == a)
                            {
                                Kr[a]++;
                            }
                        }
                    }
                    d++;
                    l++;

                }
                catch
                {
                }
            }
            list.Sort();
            list2.Sort();

            





            sr.Close();



            Console.WriteLine($"Студентов на 5-6 курсах : {c} ");

            




            Console.WriteLine($"\nСтудентов в возрасте 18 - 22 лет - {b}");
            for (int a = 0; a < Kr.Length; a++)
            {
                if (Kr[a] > 0)
                {
                    Console.WriteLine($"На {a} курсе учатся - {Kr[a]}");
                }
            }
            Console.WriteLine();
            foreach(var f in list)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine($"\nКУРС   ВОЗРАСТ     ФИ    ");
            foreach (var fa in list2)
            {
                
                Console.WriteLine(fa);
            }








            Console.ReadLine();
        }

    }
}
