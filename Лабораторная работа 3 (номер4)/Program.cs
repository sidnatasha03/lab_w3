using System;

namespace Shershnev.Lab3.Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату рождения 1 человека");
            Console.WriteLine("Год: ");
            string year1 = "";
            //Почему-то некорректная форма конвертирования
            int y1 = Convert.ToInt32(year1);
            Console.WriteLine("Месяц: ");
            string month1 = "";
            var m1 = Convert.ToInt32(month1);
            Console.WriteLine("День: ");
            string day1 = "";
            var d1 = Convert.ToInt32(day1);

            Console.WriteLine("Введите дату рождения 2 человека");
            Console.WriteLine("Год: ");
            string year2 = "";
            var y2 = Convert.ToInt32(year2);
            Console.WriteLine("Месяц: ");
            string month2 = "";
            var m2 = Convert.ToInt32(month2);
            Console.WriteLine("День: ");
            string day2 = "";
            var d2 = Convert.ToInt32(day2);

            if (y1 <= y2 & m1 <= m2 & d1 < d2)
            {
                Console.WriteLine("1 человек старше 2");
            }
            if (y1 >= y2 & m1 >= m2 & d1 > d2)
            {
                Console.WriteLine("2 человек старше 1");
            }
            if (y1 == y2 & m1 == m2 & d1 == d2)
            {
                Console.WriteLine("Они ровесники");
            }
        }
    }
}

