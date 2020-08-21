using System;
using System.Reflection;

/*
С помощью рефлексии выведите все свойства структуры DateTime
*/

// Супрун

namespace GeekBrains_CSharpBasics_Ln8_Tsk1
{
    class Program
    {
        static PropertyInfo GetPropertyInfo(object obj, string str)
        {
            return obj.GetType().GetProperty(str);
        }

        static void Main(string[] args)
        {
            DateTime homework = DateTime.Now;
            PropertyInfo[] properties = homework.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"{property} - {property.GetValue(homework)}");
            }
            Console.ReadLine();
        }

    }
}
