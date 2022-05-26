// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Text.RegularExpressions;

////1. Copying an Array
//class Array
//{
//    static void Main()
//    {
//        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int[] array2 = new int[array.Length];

//        for (int i = 0; i < array.Length; i++)
//        {
//            array2[i] = array[i];
//        }

//        foreach (int n in array)
//            Console.Write(n);
//        Console.WriteLine();
//        foreach (int n in array2)
//            Console.Write(n);
//    }
//}


////2. Write a simple program that lets the user manage a list of elements.
//StringBuilder shopList = new StringBuilder();
//while (true)
//{
//    StringBuilder temp = new StringBuilder();

//    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
//    temp.Append(Console.ReadLine());
//    //Console.WriteLine(temp.ToString());
//    string op = $"{temp[0]}{temp[1]}";
//    temp.Remove(0, 1);

//    if (op == "+ ")
//        shopList.Append(temp);
//    else if (op == "- ")
//    {
//        int pos = shopList.ToString().IndexOf(temp.ToString());
//        shopList.Remove(pos, temp.Length);
//    }
//    else if (op == "--")
//        shopList.Clear();

//    Console.WriteLine(shopList.ToString());
//}

////3.Write a method that calculates all prime numbers in given range and returns them as array
////of integers
//class primeNum
//{
//    static void Main()
//    {
//        int[] a = new int[FindPrimesInRange(1, 50).Length];
//        a = FindPrimesInRange(1, 50);
//        for (int i = 0; i < a.Length; i++)
//            Console.WriteLine(a[i]);

//    }

//    static int[] FindPrimesInRange(int startNum, int endNum)
//    {
//        int[] primes = new int[endNum-startNum];
//        int count = 0;
//        for (int i = startNum; i < endNum; i++)
//        {
//            int n = 0;

//            for (int j = 2; j <= i/2; j++)
//            {
//                if(i%j == 0)
//                {
//                    n++;
//                    break;
//                }
//            }

//            if (n == 0 && i != 1)
//            {
//                primes[count++] = i;
//            }
//        }
//        return primes;
//    }
//}

////4. Write a program to read an array of n integers (space separated on a single line) and an
////integer k, rotate the array right k times and sum the obtained arrays after each rotation as
////shown below.
//int[] n = new int[] {3,2,4,-1};
//int k = 2;
//int[] sum = new int[n.Length];


//for (int r = 1; r < k+1; r++)
//{
//    for (int l = 0; l < n.Length; l++)
//    {
//        int pos = (l+r) % n.Length;
//        int temp = n[l];

//        n[pos] = n[l];
//        sum[l] += n[l];
//        Console.WriteLine(sum[l]);
//    }
//}
//Console.WriteLine();

//for (int i = 0; i < n.Length; i++)
//{
//    Console.WriteLine(sum[i]);
//}

////5.Write a program that finds the longest sequence of equal elements in an array of integers.
////If several longest sequences exist, print the leftmost one.
//int[] n = new[] { 1,1,1,2,3,1,3,3 };

////c = count, longc = longgestcount, longn = longgest number so far
//int c = 1;
//int longc = 0;
//int longn = n[0];

//for (int i = 0; i < n.Length - 1; i++)
//{
//    if (n[i] != n[i+1])
//    {
//        c = 0;
//    }

//    //count+1 if n[i] == n[i+1]
//    c++;

//    //find longgest count and number
//    if (c > longc)
//    {
//        longc = c;
//        longn = n[i];
//    }
//}
//int[] result = new int[longc];
//Array.Fill(result, longn);
//foreach (int i in result)
//{
//    Console.Write($"{i} ");
//}


//7. Write a program that finds the most frequent number in a given sequence of numbers.
//1. Write a program that reads a string from the console, reverses its letters and prints the
//result back at the console.
//2. Write a program that reverses the words in a given sentence without changing the
//punctuation and spaces
////3. Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
////and prints them on the console on a single line, separated by comma and space.
//string t = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
//string word = string.Empty;

//static bool isPalindrome(string str)
//{
//    int i = 0, j = str.Length - 1;

//    // traversing from both the ends
//    while (i < j)
//    {

//        // not palindrome
//        if (str[i++] != str[j--])
//            return false;
//    }

//    // palindrome
//    return true;
//}

//for (int i = 0; i < t.Length; i++)
//{
//    if (t[i] != ' ' && t[i] != ',' && t[i] != '.' && t[i] != '?' && t[i] != '!')
//        word += t[i];
//    else
//    {
//        if (isPalindrome(word))
//            Console.WriteLine(word);
//        word = string.Empty;
//    }
//}


//4. Write a program that parses an URL given in the following format
string url = "https://www.apple.com/iphone";

char[] c = url.ToCharArray();
string proto = "";
string server = "";
string resource = "";

for (int i = 0; i < c.Length; i++)
{
    if (c[i] != ':')
        proto += c[i];
    else
    {
        if (c[i] != '/')
            server += c[i];
        else
        {
            if (c[i-1] != 'm')
                resource += c[i];
        }
    }
}
Console.WriteLine("protocal = {0}, server = {1}, resource = {2}", proto, server, resource);

//Regex r = new Regex(@"^(?<proto>\w+)://(?<server>\w+)/(?<resource>\w+)",
//                    RegexOptions.None, TimeSpan.FromMilliseconds(150));
//Match m = r.Match(url);
//if (m.Success)
//    Console.WriteLine(m.Result("${proto}${server}${resource}"));
