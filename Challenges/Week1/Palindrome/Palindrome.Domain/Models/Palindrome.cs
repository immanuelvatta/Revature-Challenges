using System;
using System.Linq;
namespace Palindrome.Domain.Models
{
  public class Palindrome
  {
    public static bool PalindromeChecker(string text)
    {
      return text == new String(text.Reverse().ToArray());
    }
  }
}