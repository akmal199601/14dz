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