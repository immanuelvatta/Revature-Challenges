using System;
using Palindrome.Domain.Models.Palindrome;
using Palindrome.Client;
using Xunit;

namespace Palindrome.Testing
{
    public class PalindromeTest
    {
     public void PalindromeTrueTest()
     {
       bool input = true;
       bool output = Program.PalindromeChecker("civic");
       Assert.True(output == input);
       output = Program.PalindromeChecker("racecar");
       Assert.True(output = input);
     }

     public void PalindromeFalseTest()
     {
       bool input = false;
       bool output = Program.PalindromeChecker("test");
       Assert.False(output == input);
     }

    } 
}