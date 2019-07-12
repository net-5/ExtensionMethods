using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Capital Letter
            Console.WriteLine("Please type a word and this method will caitalize the first letter");
            string first = Console.ReadLine();
            string rezultFirst = first.CapitalizeFirstLetterOfaString();
            Console.WriteLine($"The result is : {rezultFirst}");
            //Pluralize : 's
            Console.WriteLine("Pleas type a word and this method will pluralize it");
            string second = Console.ReadLine();
            string rezultSecond = second.Pluralize();
            Console.WriteLine($"The pluralized word is : {rezultSecond}");
            //Capitalize A Word
            Console.WriteLine("Please type a word and this method will capitalize all letters");
            string third = Console.ReadLine();
            string rezultThird = third.CapitalizeWord();
            Console.WriteLine($"The word with all the capitalize letters is : {rezultThird}");
            //Capitalize And Pluralize A Word
            Console.WriteLine("Please type  word and this method will, at the same time, apitalize all the letters and pluralize the word");
            string fourth = Console.ReadLine();
            string rezultfourth = fourth.CapitalizeAndPluralize();
            Console.WriteLine($"The final word : {rezultfourth}");
            //Count Number Of Characters
            Console.WriteLine("Please type something and this method will count the number of characters from this string");
            string fifth = Console.ReadLine();
            string rezultFifth = fifth.CountCharacters();
            Console.WriteLine($"There are {rezultFifth} characters in this string.");
            //Plus VAT 24% on input decimal or int value
            Console.WriteLine("Please type a decimal or int number and this method will add a 24% VAT");
            decimal sixth = decimal.Parse(Console.ReadLine());
            decimal rezultSixth = sixth.VAT();
            Console.WriteLine($"The tax is : {rezultSixth}");
        }
    }
}
