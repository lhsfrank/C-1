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


////Create a console application in Chapter03 named Exercise03 that outputs a simulated
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




//Print-a-Pyramid
//String pyramid = "";
int i = 0;
while (i < 5)
{
    for (int j = 4; j > 0; j--)
    {
        Console.Write(" ");
        //pyramid = pyramid + " ";
        //for (int k = ; k > 0; k--)
    }
    for (int k = 0; k < 5; k++)
    {
        Console.Write("*");
        //pyramid = pyramid + "*";
    }
    Console.WriteLine();
    i++;
}