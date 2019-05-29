using System;
    class DateAndTime
{
        static void Main()
        {
        DateTime localDate = DateTime.Now;
        DateTime utcdate = DateTime.UtcNow;
        Console.WriteLine(localDate);
        }
}
//Program prints the current date and time