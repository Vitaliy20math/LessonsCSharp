using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введи количество прожитых дней: ");
            int num = int.Parse(Console.ReadLine());
            int years = num / 365;
            int month = (num - years*365)/30;
            int day = num - years * 365 - month * 30;
            Console.WriteLine($"Тебе {years} лет, {month} месяцев, {day} дней");
           

            if(years >= 18)
            {
                for(int i=1; i<=10; ++i)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadLine();



        }
    }
}
