using System;
class Program
{
    static void Main()
    {
        int max = 0;
        string longest = "";
        Console.WriteLine("Вводите слова, завершая каждое нажатием Enter");
        Console.WriteLine("Для выхода наберите 'exit'");

        string input = Console.ReadLine();
        LongestWord.LongestWord.Counter(input);
        if (LongestWord.LongestWord.Counter(input) > max)
        {
            max = LongestWord.LongestWord.Counter(input);
            longest = input;
        }

        while (!input.Equals("exit"))
        {
            input  = Console.ReadLine();
            LongestWord.LongestWord.Counter(input);
            if (LongestWord.LongestWord.Counter(input) > max && !input.Equals("exit"))
            {
                max = LongestWord.LongestWord.Counter(input);
                longest = input;
            }
        } 
            Console.WriteLine("Считывание завершено.");
        Console.WriteLine("Самое длинное слово: " + longest + "(" + max + ")");
    }
}