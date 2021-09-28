using System;

namespace Shershnev.Lab3.Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Присваиваем х, у и z значения, при которых выражение "f(x, y, z) = !z|!x&!z&!y" будет возвращать false
            bool x = true, y = true, z = true;
            Console.WriteLine(!z | !x & !z & !y); // вышло false
        }
    }
}


