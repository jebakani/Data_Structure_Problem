using System;

namespace Calender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying Calender");
            MonthlyCalender calender = new MonthlyCalender();
            calender.PrintCalender("July",2021);
            calender.DisplayCalender();
            calender.DisplayQueue();
        }
    }
}
