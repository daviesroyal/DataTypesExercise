using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(firstLine);
            Console.WriteLine("Please enter a search term: ");
            string searchTerm = Console.ReadLine();
            int termPosition = firstLine.ToLower().IndexOf(searchTerm.ToLower());
            if (termPosition >= 0)
            {
                Console.WriteLine("We found that at index " + termPosition + ". It is " + searchTerm.Length + " characters long.");
                string newLine = firstLine.Remove(termPosition, searchTerm.Length);
                Console.WriteLine(newLine);
            } else
            {
                Console.WriteLine("Sorry, we couldn't find that!");
            }
        }
    }
}
