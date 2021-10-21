using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b = 0;
            double result;
            try
            {
                Console.WriteLine("Введите два целых числа в диапазоне от -2147483648 до 2147483647");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException exRange)
            {
                Console.WriteLine(exRange.Message);
            }
            Console.WriteLine("Выберите арифметическое действие вводом числа от 1 до 4, где:");
            Console.WriteLine("'1' - операция сложения");
            Console.WriteLine("'2' - операция вычитания");
            Console.WriteLine("'3' - операция умножения");
            Console.WriteLine("'4' - операция деления");
            int c;
            try
            {
                c = Convert.ToInt32(Console.ReadLine());
                if (c<1 || c>4)  
                throw new Exception("Неправильно указан номер арифметического действия");
                if (c == 1)
                {
                    result = a + b;
                    Console.WriteLine("Сумма={0} ", result);
                }
                else if (c == 2)
                {
                    result = a - b;
                    Console.WriteLine("Разность={0} ", result);
                }
                else if (c == 3)
                {
                    result = a * b;
                    Console.WriteLine("Произведение={0} ", result);
                }
                else if (c == 4)
                {
                    if (b==0)
                    {
                        Console.WriteLine("Деление на ноль!");
                    }
                    else
                    {
                        result = Convert.ToDouble(a) / b;
                        Console.WriteLine("Частное={0:f4} ", result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
