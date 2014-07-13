using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1._3_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа перевода чисел ");
            Console.WriteLine("в различные системы счисления. ");
            Console.WriteLine("Чтобы перевести число в требуемую систему счисления");
            Console.WriteLine("воспользуйтесь цифрами 2, 8, 16");

            Console.WriteLine("Введите чиcло: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите систему счисления: ");
            int y = int.Parse(Console.ReadLine());

            switch(y)
            {
                case 2:
                    string s = Convert.ToString(x, 2);
                    Console.WriteLine("Ваше число: {0} ", s);
                    break;
                case 8:
                    string e = Convert.ToString(x, 8);
                    Console.WriteLine("Ваше число: {0}", e);
                    break;
                case 16:
                    string d = Convert.ToString(x, 16);
                    Console.WriteLine("Ваше число: {0}", d);
                    break;
            }
            Console.WriteLine("Чтобы выйти, нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
