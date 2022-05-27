// See https://aka.ms/new-console-template for more information
//using System;
using Assignment3.ColorBall;
using Assignment3;

//ReverseArray r = new ReverseArray();
//int[] numbers = r.GenerateNumbers();

//r.Reverse(ref numbers);
//r.PrinttNumbersMethod(numbers);


//FibonacciSequence f = new FibonacciSequence();
//int[] fibona = f.Fibonacci(10);

//foreach (int i in fibona)
//    Console.Write($"{i} ");

//ProGamer pg = new ProGamer();
//pg.GamingDevice();

//RegGamer rg = new RegGamer();
//rg.Description();
//rg.Description("good");

//Student s = new Student();
//s.Descripion();
//Instructor i = new Instructor();
//i.Descripion();

//IPersonService ip = new IPersonService();
//ip.Age(10);
//Console.WriteLine(ip.Age(100));

Color c = new Color(20,30,40);
//Console.WriteLine(c.GrayScale());
Ball b = new Ball(c, 2, 0);
b.Throw();
b.Throw();
Console.WriteLine(b.NumOfTimesThrown()); 
b.Pop();


