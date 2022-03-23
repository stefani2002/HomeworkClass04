using System;

namespace HomeworkTask1
{
    class Program
    {
        static void FunWithStrings(string word)
        {
            char[] charArray = word.ToCharArray();
            string reversed = String.Empty;

            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reversed += charArray[i];
            }
            Console.WriteLine($"Your input reversed is: {reversed}");

    
            int sumOfWovels = 0;
            for(int i = 0; i < charArray.Length; i++)
            {
                if(charArray[i]=='a'|| charArray[i] == 'e'||charArray[i] == 'i'|| charArray[i] == 'o'|| charArray[i] == 'u')
                {
                    sumOfWovels++;
                }
            }
            Console.WriteLine($"The number of wovels is: {sumOfWovels}");

            if (word == reversed)
            {
                Console.WriteLine("Your input is a palindrome! :)");
            }
            else
            {
                Console.WriteLine("Your input is not a palindrome! :(");
            }



            string[] splited = word.Split(' ');

            int counter = 0;
            for (int i = 0; i < splited.Length; i++)
            {
                counter++;
                
            }
            Console.WriteLine($"Your string has {counter} words!");


            string LongestWord = "";
            string ShortestWord = "";
            int counter1 = 0;
            foreach (String s in splited)
            {
                if (s.Length > counter1)
                {
                    LongestWord = s;
                    counter1 = s.Length;
                }
            }
            

            foreach (String s in splited)
            {
                if (s.Length < counter1)
                {
                    ShortestWord = s;
                    counter1 = s.Length;
                }
            }

            Console.WriteLine($"The longest word in your string is: {LongestWord} ");
            Console.WriteLine($"The shortest word in your string is: {ShortestWord} ");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("===========TASK 1============");
            Console.WriteLine("\nInput a string: ");
            string userInput = Console.ReadLine().ToLower();
            FunWithStrings(userInput);


            Console.ReadLine();

        }
    }
}