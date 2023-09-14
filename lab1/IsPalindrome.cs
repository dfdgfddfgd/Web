using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите слово:");
        string word = Console.ReadLine().ToLower();

        if (IsPalindrome(word))
        {
            Console.WriteLine("Слово является палиндромом.");
        }
        else
        {
            Console.WriteLine("Слово не является палиндромом.");
        }
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
