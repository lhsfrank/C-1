//// See https://aka.ms/new-console-template for more information
using System;

////sbyte, byte, short, ushort, int, uint, long, ulong,
////float, double, and decimal.

//Console.WriteLine("sbyte max is " + sbyte.MaxValue);
//Console.WriteLine("sbyte min is " + sbyte.MinValue);
//Console.WriteLine();


//Console.WriteLine("byte max is " + byte.MaxValue);
//Console.WriteLine("byte min is " + byte.MinValue);
//Console.WriteLine();


//Console.WriteLine("short max is " + short.MaxValue);
//Console.WriteLine("short min is " + short.MinValue);
//Console.WriteLine();


//Console.WriteLine("ushort max is " + ushort.MaxValue);
//Console.WriteLine("ushort min is " + ushort.MinValue);
//Console.WriteLine();



//Console.WriteLine("int max is " + int.MaxValue);
//Console.WriteLine("int min is " + int.MinValue);
//Console.WriteLine();



//Console.WriteLine("uint max is " + uint.MaxValue);
//Console.WriteLine("uint min is " + uint.MinValue);
//Console.WriteLine();



//Console.WriteLine("long max is " + long.MaxValue);
//Console.WriteLine("long min is " + long.MinValue);
//Console.WriteLine();



//Console.WriteLine("ulong max is " + ulong.MaxValue);
//Console.WriteLine("ulong min is " + ulong.MinValue);
//Console.WriteLine();



//Console.WriteLine("float max is " + float.MaxValue);
//Console.WriteLine("float min is " + float.MinValue);
//Console.WriteLine();



//Console.WriteLine("double max is " + double.MaxValue);
//Console.WriteLine("double min is " + double.MinValue);
//Console.WriteLine();



//Console.WriteLine("decimal max is " + decimal.MaxValue);
//Console.WriteLine("decimal min is " + decimal.MinValue);
//Console.WriteLine();

////double num1 = 2.0;
////int num2 = 0;
////Console.WriteLine(num1 / num2);

//byte cen;
//uint years;
//uint days;
//ulong hours;
//ulong minutes;
//ulong seconds;
//ulong milliseconds;
//ulong microseconds;
//ulong nanoseconds;

//Console.WriteLine("Please input num of centuries: ");

//cen = Convert.ToByte(Console.ReadLine());

//years = (uint)(cen * 100);
//days = (uint)(years * 365.24219);
//hours = days * 24;
//minutes = hours * 60;
//seconds = minutes * 60;
//milliseconds = seconds * 1000;
//microseconds = milliseconds * 1000;
//nanoseconds = microseconds * 1000;

//Console.WriteLine(cen + " centuries = " + years + " years = " + days + " days = " + hours + " hours = " + minutes + " minutes = " + seconds + " seconds = " + 
//    milliseconds + " milliseconds = " + microseconds + " microseconds = " + nanoseconds + " nanoseconds");


////1.Create a console application in Chapter03 named Exercise03 that outputs a simulated
////FizzBuzz game counting up to 100. The output should look something like the following
////screenshot:

//int max = 500;
//for (byte i = 0; i < max; i++)
//{
//    Console.WriteLine(i);
//}
////The code above is a infnite loop, since the max of byte i is 255. i would be reset to 0 when excedding 255.

//int max = 500;
//checked
//{
//    try
//    {
//        for (byte i = 0; i < max; i++)
//        {
//            Console.WriteLine(i);
//        }
//    }
//    catch (OverflowException)
//    {
//        Console.WriteLine("Exception: i > {0}", byte.MaxValue);
//    }
//}





////2.Print-a-Pyramid
//for (int i = 0; i < 5; i++)
//{
//    //Console.WriteLine(i);
//    for (int j = 0; j < 4 - i; j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 0; k < i * 2 + 1; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

////3.
//int correctNumber = new Random().Next(3) + 1;
//int guessedNumber = Convert.ToInt32(Console.ReadLine());
//if (guessedNumber == correctNumber)
//    Console.WriteLine("You are correct!");
//else if (guessedNumber > 3 || guessedNumber < 1)
//    Console.WriteLine("Out of range!");
//else if (guessedNumber > correctNumber)
//    Console.WriteLine("You guessed high!");
//else if (guessedNumber < correctNumber)
//    Console.WriteLine("You guessed low!");

//Console.WriteLine("Correct number is {0}.", correctNumber);

////4. Write a simple program that defines a variable representing a birth date and calculates
////how many days old the person with that birth date is currently.
//Console.Write("Please enter your birth year in integer: ");
//int birthYear = Convert.ToInt32(Console.ReadLine());

//Console.Write("Please enter your birth month in integer: ");
//int birthMonth = Convert.ToInt32(Console.ReadLine());

//Console.Write("Please enter your birth day in integer: ");
//int birthDay = Convert.ToInt32(Console.ReadLine());

//int currentYear = DateTime.Now.Year;
////Console.WriteLine(currentYear);

//int currentMonth = DateTime.Now.Month;
////Console.WriteLine(currentMonth);

//int currentDay = DateTime.Now.Day;
////Console.WriteLine(currentDay);

//int calYear = currentYear - birthYear;

//int calMonth = 0;
//int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

//if (birthMonth > currentMonth)
//{
//    calYear = calYear - 1;
//    calMonth = currentMonth + 12 - birthMonth;
//}
//else
//    calMonth = currentMonth - birthMonth;

//int calDay = 0;
//if (birthDay > currentDay)
//{
//    calMonth = calMonth - 1;
//    calDay = currentDay + month[birthMonth] - birthDay;
//}
//else
//    calDay = currentDay - birthDay;

//int days = calYear * 365 + calMonth * 30 + calDay;
//Console.WriteLine(days);

//int daysToNextAnniversary = 10000 - (days % 10000);
//Console.WriteLine(daysToNextAnniversary);


////5.Write a program that greets the user using the appropriate greeting for the time of day.
//DateTime date1 = DateTime.Now;

//if (date1.Hour > 4 && date1.Hour < 10)
//    Console.WriteLine("Good Morning");
//else if (date1.Hour > 10 && date1.Hour < 16)
//    Console.WriteLine("Good Afternoon");
//else if (date1.Hour > 16 && date1.Hour < 22)
//    Console.WriteLine("Good Evening");
//else
//    Console.WriteLine("Good Night");


//6.Write a program that prints the result of counting up to 24 using four different increments.
for (int i = 1; i < 5; i++)
{
    for (int j = 0; j < 25; j += i)
    {
        if (j == 24)
        {
            Console.WriteLine(j);
            break;
        }
        Console.Write(j + ", ");
    }
}
