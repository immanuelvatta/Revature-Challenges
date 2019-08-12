using System;
using static Palindrome.Domain.Models.Palindrome;
using Xunit;

namespace Palindrome.Testing {
  public class PalindromeTest {
    
    
    public void PalindromeTrueTest () {

      bool input = true;
      bool output = PalindromeChecker ("civic");
      Assert.True (output == input);
      output = PalindromeChecker ("racecar");
      Assert.True (output = input);
    }
    public void PalindromeFalseTest () {
      bool input = false;
      bool output = PalindromeChecker ("test");
      Assert.False (output == input);
    }

  }
}