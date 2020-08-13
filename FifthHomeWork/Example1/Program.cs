using System;

namespace Example1
{
    class Program
    {
        //Создать программу, которая будет проверять корректность ввода логина. 
        //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита
        //или цифры, при этом цифра не может быть первой :
        //а) без исиспользования регулярных выражений
        //б)**с использованием регулярных значений

        //Фамилия выполняющего - Супрун
        static void Main(string[] args)
        {
            #region А
            bool error = false;
            Console.Write("Введите логин : ");
            string log = Console.ReadLine();
            log.Trim();
            if (log.Length >= 2 && log.Length <= 10)
            {
                for (int a = 0; a < 9; a++)
                {
                    if (log.StartsWith($"{a}"))
                    {
                        Console.WriteLine("Ошибка,доступа!");
                        error = true;
                        break;
                    }
                }

                for (int i = 0; i < log.Length && error == false; i++)
                {
                    if (!(Char.IsDigit(log[i]) || log[i] >= 'a' && log[i] <= 'z' || log[i] >= 'A' && log[i] <= 'Z'))
                    {
                        error = true;
                        Console.WriteLine("Ошибка,доступа!");
                        break;
                    }
                }
                if (error == false)
                {
                    Console.WriteLine("Логин корректен");

                }
            }
            else
            {
                Console.WriteLine("Ошибка,доступа!");
                Console.ReadLine();
            }
            #endregion
            #region Б
            //while (true)
            //{
            //    Console.Write("Введите логин : ");
            //    if (Regex.IsMatch(Console.ReadLine(), "^[a-zA-Z][a-zA-Zа-яА-Я0-9]{2,9}$"))
            //    {
            //        Console.WriteLine("Добро пожаловать!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ошибка,доступа!");
            //        Console.WriteLine("Попробуйте еще раз!");
            //        Console.ReadLine();
            //        Console.Clear();
            //        continue;
            //    }
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
