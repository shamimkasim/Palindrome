namespace Palindrome
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (IsPalindrome(word))
            {
                Console.WriteLine($"{word} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrome.");
            }
        }
    
        public static bool IsPalindrome(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);

            return word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase);
        }
    }

}