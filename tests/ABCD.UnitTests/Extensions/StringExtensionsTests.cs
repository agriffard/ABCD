namespace ABCD.UnitTests.Extensions;

public class StringExtensionsTests
{
    [Theory]
    [InlineData("Hello, World!", 5, "Hello")]
    [InlineData("Hello, World!", 13, "Hello, World!")]
    [InlineData("Hello, World!", 50, "Hello, World!")]
    public void Truncate_ReturnsTruncatedString(string input, int maxLength, string expected)
    {
        // Act
        var result = input.Truncate(maxLength);

        // Assert
        Assert.Equal(expected, result);
    }
}
