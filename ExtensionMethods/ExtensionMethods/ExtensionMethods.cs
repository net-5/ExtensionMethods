using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {
        public static string CapitalizeFirstLetterOfaString(this string first)
        {
            if (string.IsNullOrEmpty(first))
            {
                
                return "You didn't typed anything";
            }
            return first[0].ToString().ToUpper()+ first.Substring(1);
           
        }
        public static string Pluralize(this string second)
        {
            if (string.IsNullOrEmpty(second))
            {
                return "You didn't typed anything";
            }
            if (second.EndsWith("s"))
            {
               return "Your word already ends with \"s\"";
            }
            return second + "s";
        }
        public static string CapitalizeWord(this string third)
        {
            if (string.IsNullOrEmpty(third))
            {
                return "You didn't typed anything";
            }
            return third.ToUpper();
        }
        public static string CapitalizeAndPluralize(this string fourth)
        {
            if (string.IsNullOrEmpty(fourth))
            {
                return "You didn't typed anything";
            }
            if (fourth.EndsWith("s"))
            {
                return "Your word already ends with \"s\"";
            }
            return (fourth + "s").ToUpper();
        }
        public static string CountCharacters(this string fifth)
        {
            if (string.IsNullOrEmpty(fifth))
            {
                return "You didn't typed anything";
            }
            return fifth.Count().ToString();
        }
        public static decimal VAT(this decimal sixth)
        {
            return sixth * 0.24M;
        }
    }
}
