using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace dz20._04
{
    class Program
    {
        delegate T akmal<T>(T x, T y);
        static void Main(string[] args)
        {
            bool s = true;
            while (s)
            {

                System.Console.WriteLine("Ввыберите вашу операцию(*,/,+,-):");
                System.Console.WriteLine("Нажмите 1 для умножения  mul(*)");
                System.Console.WriteLine("Нажмите 2 для деления div(/)");
                System.Console.WriteLine("Нажмите 3 для сложения add (+)");
                System.Console.WriteLine("Нажмите 4 для отнятия min(-)");
                System.Console.WriteLine("Нажмите 5 для выхода");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            System.Console.WriteLine("Введите первое число");
                            double x = Convert.ToDouble(Console.ReadLine());
                            System.Console.WriteLine("Введите второе число");
                            double y = Convert.ToDouble(Console.ReadLine());
                            akmal<double> mult = mul<double>;
                            double result = mult.Invoke(x, y);
                            System.Console.WriteLine("======");
                            System.Console.WriteLine("$ Result is :{result}");
                            System.Console.WriteLine("======");
                        } break;
                }
            }
        }
        static T mul<T>(T x, T y)
        {
            return (dynamic)x * (dynamic)y;
        }
        static T div<T>(T x, T y)
        {
            return (dynamic)x / (dynamic)y;
        }
        static T sum<T>(T x, T y)
        {
            return (dynamic)x + (dynamic)y;
        }
        static T min<T>(T x, T y)
        {
            return (dynamic)x - (dynamic)y;
        }
    }
}