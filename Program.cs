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
           // 2.1 прочитать букву с экрана и вывести следующую за ней по алфавиту
            Console.WriteLine("Введите букву: ");
            string ch1 = Console.ReadLine();
            if (ch1.Length == 1)
            {
                char ch = Convert.ToChar(ch1);
                int ch2 = Convert.ToInt32(ch);
                Console.WriteLine(ch2);
                if (ch2 > 65 && ch2 < 91 || ch2 > 96 && ch2 < 123 || ch2 > 191 && ch2 < 256)
                {
                    char output = (char)(ch + 1);
                    Console.WriteLine(Convert.ToChar(output));
                }
            }
            else
            {
                Console.WriteLine("ОШИБКА!! Вы ввели не один символ.");
            }
            // 2.2 найти корни квадратного уравнения(коэффициента задаются пользователем с клавиатуры)
            
            Console.WriteLine("Ввести значение коэффициента a: ");
            string stra = Console.ReadLine();
            double aa = double.Parse(stra);
            Console.WriteLine("Ввести значение коэффициента b: ");
            string strb = Console.ReadLine();
            double bb = double.Parse(strb);
            Console.WriteLine("Ввести значение коэффициента c: ");
            string strc = Console.ReadLine();
            double cc = double.Parse(strc);
            double D = (bb * bb) - (4 * aa * cc);
            if (D < 0)
            {
                Console.WriteLine("корней нет");
            }
            
            else if (D > 0)
            {
                double d = Math.Sqrt(D);
                Console.WriteLine("Первый корень: " + ((-bb + d) / (2 * aa)));
                Console.WriteLine("Второй корень: " + ((-bb - d) / (2 * aa)));
            }
            
            else
            {
                Console.WriteLine("Корнем уравнения будет: " + ((-bb) / (2 * aa)));
            }
        }
    }
}
