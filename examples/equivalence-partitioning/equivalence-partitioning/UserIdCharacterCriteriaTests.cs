namespace equivalence_partitioning;

[TestFixture]
public class UserIdCharacterCriteriaTests
{
    [Datapoints]
    private static readonly KeyValuePair<string, bool>[] UserIdPartitions =
    [
        new("super long sentence 12345", false),
        new("123456789", false),
        new("JeffAd12", true),
        new("JeffA123", true),
        new("Jeff1234", true),
        new("Jeff1234", true),
        new("Jef12345", true),
        new("Je123456", true),
        new("J1234567", true),
        new("12345678", true),
        new("J12345678", false),
        new("J123456", false),
        new("        ", true),
        new("", false)
    ];
    
    [Theory]
    public void UserId_AtLeastTwoNonAlphabeticCharacters_IsValid(
        KeyValuePair<string, bool> userIdCriteria)
    {
        //arrange
        const int maximumAlphabeticCharacterCount = 6;
        const int minimumNonAlphabeticCharacterCount = 2;
        const int expectedLength = maximumAlphabeticCharacterCount + 
                                   minimumNonAlphabeticCharacterCount;
        
        //act
        var alphabeticCharacterCount = userIdCriteria.Key.Count(char.IsLetter);
        var nonAlphabeticCharacterCount = userIdCriteria.Key.Length - alphabeticCharacterCount;
        var actualIsValid = nonAlphabeticCharacterCount >= minimumNonAlphabeticCharacterCount &&
                            alphabeticCharacterCount <= maximumAlphabeticCharacterCount &&
                            alphabeticCharacterCount + nonAlphabeticCharacterCount == expectedLength;
        
        Console.WriteLine($"Expect: [{userIdCriteria.Key}] is {userIdCriteria.Value}, Actual: {actualIsValid}");
        Console.WriteLine($"Total Length: [{userIdCriteria.Key.Length}]");
        Console.WriteLine($"Alphabetic Characters: [{alphabeticCharacterCount}]");
        Console.WriteLine($"Non-Alphabetic Characters: [{nonAlphabeticCharacterCount}]");
        
        //assert
        Assert.That(actualIsValid, Is.EqualTo(userIdCriteria.Value));}
}