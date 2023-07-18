using Xunit;
using Palindrome;

namespace ProgramTests
{
    public class ProgramTests
    {
        [Fact]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            string word = "level";

            // Act
            bool result = Program.IsPalindrome(word);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPalindrome_ValidNonPalindrome_ReturnsFalse()
        {
            // Arrange
            string word = "hello";

            // Act
            bool result = Program.IsPalindrome(word);

            // Assert
            Assert.False(result);
        } 
    }
}