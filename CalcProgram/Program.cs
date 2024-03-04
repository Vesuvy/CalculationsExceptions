using ExceptionLib;
using System;

namespace CalcProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Бесконечный цикл
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите два числа (A и B):");
                    double A = double.Parse(Console.ReadLine());
                    double B = double.Parse(Console.ReadLine());

                    double result = B / A;

                    Console.WriteLine($"Результат деления B на A: {result}");
                }
                catch (FormatException) //неверный формат чисел
                {
                    Console.WriteLine("Ошибка: неверный формат ввода чисел.");
                }
                catch (DivideByZeroMyException ex) //деление на ноль
                {
                    Console.WriteLine($"У вас ошибка: {ex.Message}");
                }
                catch (OutOfRangMyException ex)
                {
                    Console.WriteLine($"У вас ошибка: {ex.Message}"); //выход за пределы диапазона
                }
                finally
                {
                    Console.WriteLine("!Нажмите клавишу для продолжения...!");
                    Console.ReadKey();
                    //Console.Clear(); 
                }
            }
        }
    }
}
