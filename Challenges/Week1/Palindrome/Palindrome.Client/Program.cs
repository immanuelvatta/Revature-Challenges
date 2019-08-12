using System;
using System.Linq;
using static Palindrome.Domain.Models.Palindrome;

namespace Palindrome.Client
{
  class Program
  {
    private static void Main(string[] args)
    {
      Console.Write("Enter a word:");
      string str = Console.ReadLine();
      
      if(PalindromeChecker(str) == true)
      {
         Console.WriteLine(PalindromeChecker(str)+ " " + str + " is a Palindrome");
      }
      else
      {
         Console.WriteLine(PalindromeChecker(str)+ " " + str + " is not a Palindrome");
      }
    }
  }
}
