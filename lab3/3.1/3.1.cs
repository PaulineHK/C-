using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static Boolean Check(string Str) {
            
            bool check = true;
            if (Str == String.Empty) {
                check = false;
                Console.WriteLine("Строка пуста");
                return check;
            }
            if (Str.Length > 200) {
                check = false;
                Console.WriteLine("Сообщение содержит больше 200 символов");
            }
            if (Str[0] == ' ')
            {
                check = false;
                Console.WriteLine("Перед первым словом не должно быть пробелов.");
                if (!char.IsUpper(Str[1]))
                {
                   
                    Console.WriteLine("Первое слово не с большой буквы");
                }

            }
            else if (!char.IsUpper(Str[0]))
            {
                check = false;
                Console.WriteLine("Первое слово не с большой буквы");
            }
           
            try
            {
                for (int i = 0; i < Str.Length; i++)
                {
                    if ((Str[i] == '.'||Str[i]==','||Str[i]==':') && Str[i - 1] == ' ') {//Проверка на пробел после знака 
                        check = false;
                        Console.WriteLine("Лишний пробел между словом и знаком препинания");
                    }
                    if (Str[i] == '!' || Str[i] == '?'|| Str[i]==';'){ //Проверка на точки

                        check = false;
                        Console.WriteLine("Любое предложение должно заканчиваться точкой");
                    }
                    if (Str[i] == '.' && i != Str.Trim().Length - 1 && Str[i + 1] != ' ') {//Проверка на пробел после точки
                        check = false;
                        Console.WriteLine("После точки не следует пробел");
                    }
                    else if (Str[i] == '.' && i != Str.Trim().Length - 1 && !char.IsUpper(Str[i + 2])) {//Проверка на заглавную букву 
                        check = false;
                        Console.WriteLine("Предложение не начинается с большой буквы");
                    }
                    if (Str[i] == ' ' && i != Str.Trim().Length - 1 && Str[i + 1] == ' ') {//проверка на пробелы между словами
                        check = false;
                        Console.WriteLine("Лишний пробел между словами");
                    }

                }

            }
            catch (System.IndexOutOfRangeException) { }

            
            return check;
        }
        static void Main(string[] args)
        {
            string Str;
            int repeat = 0;
            do
            {

                Console.WriteLine("Сформируйте в текстовом поле TextBox строку согласно следующим правилам:\r\n" +
                    "– исходный текст состоит из строки, содержащей не более 200 символов;\r\n" +
                    "– в конце каждого предложения есть точка;\r\n" +
                    "– каждому слову, кроме первого, предшествует один пробел;\r\n" +
                    "– внутри слов пробелов нет;\r\n" +
                    "– знаки препинания, если они есть, пишутся сразу после слова.");
            
                    Str = Console.ReadLine().Trim();
                while (!Check(Str)) {
                    Console.WriteLine("Попробуйте ещё раз");
                    Str = Console.ReadLine().Trim();
                }
               
                Console.WriteLine("Вариант 2. Если длина строки L больше 15 символов, " +
                    "то удаляется подстрока в [ ] скобках.\r\nРазделить слова запятыми.");
                if (Str.Trim().Length > 15)
                {
                    bool ok = false;
                    for (int i = 0; i < Str.Length; i++)
                    {
                        if (Str[i] == '[')
                        {
                            ok = true;
                           
                            for (int j = i + 1; j < Str.Length; j++)
                            {
                                if (Str[j] == ']')
                                {
                                    ok = false;
                                    Str = Str.Remove(i + 1, j - i - 1);
                                    break;
                                }
                            }
                            if (ok)
                            {
                                Console.WriteLine("Скобка ] не была найдена");
                                break;
                            }
                            ok = true;
                        }
                       
                    }
                    if(!ok) Console.WriteLine("Скобка [ не была найдена");
                    else Console.WriteLine(Str);
                }
                else Console.WriteLine("Длина строки меньше 15 символов.");
                for(int i = 0; i < Str.Trim().Length; i++)
                {
                    if ((Str[i] == ' ') && (Str[i - 1] != '.' && Str[i - 1] != ',' && Str[i - 1] != ':'))
                    {
                        Str = Str.Insert(i, ",");
                    }
                }
                Console.WriteLine(Str);
                Console.WriteLine("Если хотите выйти - введите 1");
                Int32.TryParse(Console.ReadLine(), out repeat);
            } while (repeat != 1);
        }
    }   

}
