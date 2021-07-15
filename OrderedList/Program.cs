using System;
using System.IO;

namespace OrderedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ordered list");
            SortedLinkedList<string> ordered = new SortedLinkedList<string>();
            string filePath = @"C:\Users\HP1\source\repos\DS\DataStructureProblems\OrderedText.txt";
            string text = File.ReadAllText(filePath);
            string[] textArray = text.Split(" ");
            for (int i = 0; i < textArray.Length; i++)
            {
                ordered.Add(textArray[i]);
            }
            Console.WriteLine("enter the word to be searched:");
            string word = Console.ReadLine();
            int found = ordered.SearchNode(word);
            if (found == 1)
            {
                ordered.Remove(word);
            }
            else
            {
                ordered.Add(word);
            }
            string newText = ordered.DisplayList();
            File.WriteAllText(filePath, newText);
        }
    }
}
