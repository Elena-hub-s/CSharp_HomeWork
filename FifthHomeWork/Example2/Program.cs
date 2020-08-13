using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
 /* Разработать статический класс Message,содержащий следующие статические методы для обработки текста:
    а) Вывести только те слова сообщения, которые содержат не более n букв.
    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    в) Найти самое длинное слово сообщения
    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    д) Создать метод, который производит частотный анализ текста. В качества параметра в него 
    передается массив слов и текст,в качества результата метод возращает сколько раз
    каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictonary    */



    //Фамилия выполняющего - Супрун
    public static class Message
    {
        //А)
        public static void MaxWord(string text, int maxvalue)
        {
            string[] Arraytext = text.Split();
            for (int a = 0; a < Arraytext.Length; a++)
            {
                if (Arraytext[a].Length <= maxvalue)
                {
                    Console.Write(Arraytext[a] + " ");

                }
            }
        }
        //Б)
        public static void DeleteWord(string text, char LastLetter)
        {
            string lst = LastLetter.ToString();
            lst.ToLower();
            string[] Arraytext = text.Split();
            for (int a = 0; a < Arraytext.Length; a++)
            {
                Arraytext[a].ToLower();
                if (Arraytext[a] != " " && Arraytext[a].LastIndexOf(lst) == Arraytext[a].Length - 1)
                {
                    Console.Write(Arraytext[a] + " ");
                }
            }
        }
        //В)
        public static void LongWord(string text)
        {
            string lastWord = "";
            string[] Arraytext = text.Split();
            for (int a = 0; a < Arraytext.Length; a++)
            {
                if (Arraytext[a].Length > lastWord.Length)
                {
                    lastWord = Arraytext[a];
                }
            }
            for (int b = 0; b < Arraytext.Length; b++)
            {
                if (Arraytext[b].Length >= lastWord.Length)
                {
                    Console.Write(Arraytext[b] + " ");
                }
            }

        }
        //Г)
        public static void LongWorldString(string text)
        {
            StringBuilder strb = new StringBuilder();
            string lastWord = "";
            string[] Arraytext = text.Split();

            for (int a = 0; a < Arraytext.Length; a++)
            {
                if (Arraytext[a].Length > lastWord.Length)
                {
                    lastWord = Arraytext[a];
                }
            }
            for (int b = 0; b < Arraytext.Length; b++)
            {
                if (Arraytext[b].Length >= lastWord.Length)
                {
                    strb.Append(Arraytext[b] + " ");
                }
            }
            Console.Write(strb);
        }
        public static int TextAnalization(string[] Word, string text)
        {
            int rpt = 0;
            string[] ArrayText = text.Split();
            Dictionary<int, string> dict = new Dictionary<int, string>(Word.Length);
            Dictionary<int, string> dict2 = new Dictionary<int, string>(ArrayText.Length);

            for (int a = 0;a < Word.Length;a++)
            {
                dict.Add(a, Word[a]);
            }
            for (int b = 0; b < ArrayText.Length; b++)
            {
                dict2.Add(b,ArrayText[b]);
            }
            for(int c = 0;c<Word.Length;c++)
            {
                for(int d = 0;d < ArrayText.Length;d++)
                {
                    if(dict[c] == dict2[d])
                    {
                        rpt++;
                    }
                }
            }
            return rpt;
            


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Message.MaxWord("Не рой яму другому – сам в нее попадешь", 3);
            //Message.DeleteWord("Не рой яму другому – сам в нее попадешь", 'е');
            //Message.LongWord("Не рой яму другому – сам в нее попадешь");
            //Message.LongWorldString("Не рой яму другому – сам в нее попадешь");\
            //string[] a = { "рой", "яму" , "другому" };
            //Console.WriteLine(Message.TextAnalization(a, "Не рой яму другому – сам в нее попадешь"));

            //Console.ReadLine();
        }
    }
}


