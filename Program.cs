namespace HashTable;
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        var dictionary = new Dictionary();
        var lines = File.ReadAllLines("C:/Users/annmy/RiderProjects/Hash Table/testDict.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(';');
            string key = parts[0].Trim();
            string value = parts[1].Trim();
            dictionary.Add(key, value);
        }

        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        string meaning = dictionary.Get(word);
        if (meaning != null)
        {
            Console.WriteLine($"'the {word}' means: {meaning}");
        }
        else
        {
            Console.WriteLine($"'{word}' was not found.");
        }
    }
}
