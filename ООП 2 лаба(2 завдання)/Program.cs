namespace ООП_2_лаба_2_завдання_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyTime time = new MyTime(9, 30, 0);
            Console.WriteLine("Поточний час: " + time);
            Console.WriteLine("Через секунду: " + time.AddOneSecond());
            Console.WriteLine("Через хвилину: " + time.AddOneMinute());
            Console.WriteLine("Через годину: " + time.AddOneHour());
            Console.WriteLine("Час у секундах: " + time.ToSecSinceMidnight());
            Console.WriteLine("Поточна пара: " + time.WhatLesson());

            MyTime other = new MyTime(8, 30, 0);
            Console.WriteLine("Різниця між часом: " + time.Difference(other));
            Console.WriteLine("Нормалізація часу: " + new MyTime(25, 70, 80).Normalize());
        }
    }
}
