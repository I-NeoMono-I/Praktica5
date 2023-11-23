using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktica5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 2
            /*
            Console.WriteLine("Введите число.");
            string name1 = Console.ReadLine();
            Console.Clear();
            int name2 = Int32.Parse(name1);
            if (name2 % 3 != 0)
            {
                Console.WriteLine($"Число: {name2} не делится на 3");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число {name2} делится на 3");
                Console.ReadKey();
            }
            */

            //Задание 3
            /*
            Console.WriteLine("Введите число.");
            string name1 = Console.ReadLine();
            Console.Clear();
            int name2 = Int32.Parse(name1);
            if (name2 % 5 == 2)
            {
                Console.WriteLine($"Число {name2} делится на 5 с остатком 2");
                Console.ReadKey();
            }
            else if (name2 % 7 == 1)
            {
                Console.WriteLine($"Число {name2} делится на 7 с остатком 1");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число {name2} не делится на 5 с остатком 2 и на 7 с остатком 1");
                Console.ReadKey();
            }
            */


            //Задание 4
            /*
            Console.WriteLine("Введите число.");
            string name1 = Console.ReadLine();
            Console.Clear();
            int name2 = Int32.Parse(name1);
            if (name2 %4 != 0 && name2 <10)
            {
                Console.WriteLine($"Число {name2} не соответствует критериям");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число {name2} соответствует критериям");
                Console.ReadKey();
            }
            */


            //Задание 5
            /*
            Console.WriteLine("Введите число.");
            string name1 = Console.ReadLine();
            Console.Clear();
            int name2 = Int32.Parse(name1);
            if (name2 >=5 && name2 <=10)
            {
                Console.WriteLine($"Число {name2} соответствует критериям");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число {name2} не соответствует критериям");
                Console.ReadKey();
            }
            */


            //Задание 6
            /*
            Console.WriteLine("Введите число.");
            string name1 = Console.ReadLine();
            Console.Clear();
            int name2 = Int32.Parse(name1);
            int name3 = name2 / 1000;
            Console.WriteLine($"В числе{name2} - {name3} тысяч(и)");
            Console.ReadKey();
            */


            //Задание 7
            /*
            Console.WriteLine("Введите число.");
            string name1 = Console.ReadLine();
            Console.Clear();
            int name2 = Int32.Parse(name1);
            string name3 = Convert.ToString(name2, 8);
            int name4 = Int32.Parse(name3);


            Console.WriteLine($"{name4}");
            Console.WriteLine(name4 / 10 % 10);
            Console.ReadKey();
            */


            //Задание 8
            /*
            Console.WriteLine("Введите число.");
            string name1 = Console.ReadLine();
            Console.Clear();
            int name2 = Int32.Parse(name1);
            string name3 = Convert.ToString(name2, 2);
            int name4 = Int32.Parse(name3);

            Console.WriteLine($"{name4}");
            int name5 = name4 << 2;
            for (int i = 0; i <= name5; i++)
            {
                if (name5 > 2)
                {
                    name5 = name5 << 1;
                }
                else
                    break;
                break;
            }
            Console.WriteLine(name5);
            Console.ReadKey();
            */

            //
        }
    }
}
