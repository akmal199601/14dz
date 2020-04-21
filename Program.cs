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
                    case "2":
                        {
                            System.Console.WriteLine("Введите первое число");
                            double x = Convert.ToDouble(Console.ReadLine());
                            System.Console.WriteLine("Введите второе число");
                            double y = Convert.ToDouble(Console.ReadLine());
                            if (x != 0 && y != 0)
                            {
                                akmal<double> mult = div<double>;
                                double result = mult.Invoke(x, y);
                                System.Console.WriteLine("======");
                                System.Console.WriteLine("$ Result is :{result}");
                                System.Console.WriteLine("======");
                            }
                            else
                            {
                                System.Console.WriteLine("=======");
                                System.Console.WriteLine("if(User==AkiAziz){на ноль делить нельзя}else{Короче придурок на ноль делить нельзя в школе неучили ЧМО}})");
                                System.Console.WriteLine("=======");
                            }
                        } break;
                    case "3":
                        {
                            System.Console.WriteLine("Введите ваше первое число");
                            double x = Convert.ToDouble(Console.ReadLine());
                            System.Console.WriteLine("Введите ваше второе число");
                            double y = Convert.ToDouble(Console.ReadLine());
                            akmal<double> mult = sum<double>;
                            double result = mult.Invoke(x, y);
                            System.Console.WriteLine("======");
                            System.Console.WriteLine("$ result is :{result}");
                            System.Console.WriteLine("======");
                        } break;
                    case "4":
                        {
                            System.Console.WriteLine("Введите ваше первое число");
                            double x = Convert.ToDouble(Console.ReadLine());
                            System.Console.WriteLine("Введите ваше второе число");
                            double y = Convert.ToDouble(Console.ReadLine());
                            akmal<double> mult = min<double>;
                            double result = mult.Invoke(x, y);
                            System.Console.WriteLine("======");
                            System.Console.WriteLine("$ result is :{result}");
                            System.Console.WriteLine("======");
                        } break;
                    case "5": s = false; break;
                        {
                            System.Console.WriteLine("======");
                            System.Console.WriteLine("Выход");
                            Console.WriteLine("=======");
                        } break;
                    default:
                        break;
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