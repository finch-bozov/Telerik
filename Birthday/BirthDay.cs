using System;
class BirthDay
{
    static void Main()
    {
        Console.WriteLine("How old are you now?");
        var ageAsString = Console.ReadLine();
        int age;
        //bool parseSuccess = int.TryParse(ageAsString, out age);
        //    if (parseSuccess)
        //        Console.WriteLine("You are {0} years old.", age);
        //    else
        //        Console.WriteLine("This is not a number!");
        while (!int.TryParse(ageAsString, out age))
            {
                Console.WriteLine("This is not a number!");
                ageAsString = Console.ReadLine();
            }

        Console.WriteLine($"Your age is: {age}");
        int a = age + 10;
        Console.Write("In 10 years you will be ");
        Console.Write(a);
        Console.Write(" years old");
        Console.WriteLine();
    }
}
//Program accepts user input for age and then gives result for age after 10 years
//The program refuses strings and values above the limit of ints.