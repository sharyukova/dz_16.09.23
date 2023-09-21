using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_16._09._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2.1 приветствовать пользователя по введенному имени
            Console.WriteLine("Введите Ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name);

            // 2.2 деление одного числа на другое
            Console.WriteLine("Введите первое ЦЕЛОЕ число: ");
            string a = Console.ReadLine();
            int number1;
            bool success = int.TryParse(a, out number1);
            if (success) 
            {
                Console.WriteLine("первое ЦЕЛОЕ число: " + number1);
                Console.WriteLine("Введите второе ЦЕЛОЕ число, не равное нулю: ");
                string b = Console.ReadLine();
                int number2;
                bool success2 = int.TryParse(b, out number2);
                if (success2 && number2 != 0)
                {
                    Console.WriteLine("второе ЦЕЛОЕ число: " + number2);
                    Console.WriteLine("n1 : n2 = " + double(number1 / number2));
                }
                else
                {
                    Console.WriteLine("ОШИБКА!!!");
                }
            }
            else 
            {
                Console.WriteLine("ОШИБКА! Вы ввели НЕЦЕЛОЕ число");
            }
           
        }
    }
}
