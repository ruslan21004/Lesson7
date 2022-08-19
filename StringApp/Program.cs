using System.Text;

//static void DisplayArrayInt(int[] arr) => Console.WriteLine(string.Join(" ", arr));
//// Change the array by reversing its elements.
//static void ChangeArrayInt(int[] arr) => Array.Reverse(arr);
//static void ChangeArrayElementsInt(int[] arr)
//{
//    // Change the value of the first three array elements.
//    arr[0] = 8;
//    arr[1] = 9;
//    arr[2] = 10;
//}

//// Declare and initialize an array.

//            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
//// Display the array elements.
//DisplayArrayInt(numbers);
//Console.WriteLine();
//// Reverse the array.
//ChangeArrayInt(numbers);
//// Display the array again to verify that it stays reversed.
//Console.WriteLine("Array weekDays after the call to ChangeArray:");

//DisplayArrayInt(numbers);
//Console.WriteLine();
//// Assign new values to individual array elements.
//ChangeArrayElementsInt(numbers);
//// Display the array again to verify that it has changed.
//Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
//DisplayArrayInt(numbers);

// Снизу главный пример!!!

//void Increment( int n)
//{
//    n++;
//    Console.WriteLine($"Число в методе Increment: {n}");
//}
//int number = 5;
//Console.WriteLine($"Число до метода Increment: {number}");
//Increment(number);
//Console.WriteLine($"Число после метода Increment: {number}");


//string s1 = "hello";

//string s2 = new String('a', 6);

//string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
//string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3);

//Console.WriteLine(s1);  // hello
//Console.WriteLine(s2);  // aaaaaaa
//Console.WriteLine(s3);  // world
//Console.WriteLine(s4);  // orl

//==========================================================================================

//string message = "hello";

//char firstChar = message[1];

//Console.WriteLine(firstChar);

//Console.WriteLine(message.Length);

//for (var i = 0; i < message.Length; i++)
//{
//    Console.WriteLine(message[i]);
//}
//foreach (var ch in message)
//{
//    Console.WriteLine(ch);
//}


//==========================================================================================

//string message1 = "hello";
//string message2 = "hello";
//Console.WriteLine(message1 == message2);

//==========================================================================================

//string s1 = "hello";
//string s2 = "world";
//string s3 = s1 + "  " + s2;
//string s4 = string.Concat(s3, "!!!");
//Console.WriteLine(s3);
//Console.WriteLine(s4);

//==========================================================================================

//string s5 = "apple";
//string s6 = "a day";
//string s7 = "keeps";
//string s8 = "a doctor";
//string s9 = "away";
//string[] values = new string[] { s5, s6, s7, s8, s9 };
//string s10 = string.Join(" ", values);
//Console.WriteLine(s10);

//==========================================================================================

//string s1 = "hello";
//string s2 = "world";
//int result = string.Compare(s1, s2);
//if (result < 0)
//{
//    Console.WriteLine("String s1 before string s2");
//}
//else if (result > 0)
//{
//    Console.WriteLine("String s1 is after string s2");
//}
//else
//{
//    Console.WriteLine("Strings s1 and s2 are identical");
//}

//==========================================================================================

//string s1 = "hello world";
//char ch = 'o';
//int indexOfChar = s1.IndexOf(ch);

//Console.WriteLine(indexOfChar);

//string substring = "wor";
//int indexOfSubstring = s1.IndexOf(substring);

//Console.WriteLine(indexOfSubstring);

//==========================================================================================

//var files = new string[]
//{
//    "myapp.exe",
//    "forest.jpg",
//    "main.exe",
//    "book.pdf",
//    "river.png"
//};
//for (int i = 0; i < files.Length; i++)
//{
//    if (files[i].EndsWith(".exe"))
//        Console.WriteLine(files[i]);

//    if (files[i].StartsWith("main"))
//        Console.WriteLine(files[i]);
//}

//==========================================================================================


//string text = "And thus all happened in such manner, And thus all happened in such manner";
//string[] words = text.Split(new char[] { ',' ,' '});
//foreach (string s in words)
//{
//    Console.WriteLine(s);
//}


//==========================================================================================


//using System.Text;

//StringBuilder sb = new StringBuilder();
//var sb1 = new StringBuilder("Hello World");
//Console.WriteLine(sb1.ToString());

//==========================================================================================

//StringBuilder sb = new StringBuilder("Hello World");
//Console.WriteLine($"Length: {sb.Length}");       // Длина: 10
//Console.WriteLine($"Capacity: {sb.Capacity}");

//==========================================================================================

//var sb = new StringBuilder("Hello world");
//sb.Append("!");
//sb.Insert(6, "computer ");
//Console.WriteLine(sb);
//sb.Replace("world", "universe");
//Console.WriteLine(sb);
//sb.Remove(7, 13);
//Console.WriteLine(sb);

//==========================================================================================

//var chars = new[]
//{
//    'j',
//    '\u006A',
//    '\x006A',
//    (char)106,
//};
//Console.WriteLine(string.Join(" ", chars));

using System;
using System.Text;
using System.Linq;

class Homework
{
    static void Compare()
    {
        Console.WriteLine("Введите два числа");
        var str1 = Console.ReadLine();
        var str2 = Console.ReadLine();

        if (str1 == str2)
        {
            bool isTrue = true;
            Console.WriteLine(isTrue);
        }
        else
        {
            bool isTrue = false;
            Console.WriteLine(isTrue);
        }
    }

    static void Analyze()
    {
        Console.WriteLine("Введите слово или предложение");
        var str3 = Convert.ToString(Console.ReadLine());
        Console.WriteLine(str3.Length);
    }

    static void Dublicate()
    {
        Console.WriteLine("Введите два слова или предложения");
        var FirstWord = Convert.ToString(Console.ReadLine());
        var SecondWord = Convert.ToString(Console.ReadLine());

        for (int i = 0; i < FirstWord.Length; i++)
        {
            for (int j = 0; j < SecondWord.Length; j++)
            {
                if (FirstWord[i] == SecondWord[j])
                {
                    Console.Write(FirstWord[i] + " ");
                }
            }
        }
    }

    static void Sort()
    {
        Console.WriteLine("Введите слово. Он вернет все символы, отсортированные в алфавитном порядке");
        String str4 = Console.ReadLine();

        str4 = String.Concat(str4.OrderBy(ch => ch));

        Console.WriteLine(str4);
    }

    public static void Main()
    {
        Compare();
        Analyze();
        Dublicate();
        Sort();
    }
}
//checked
