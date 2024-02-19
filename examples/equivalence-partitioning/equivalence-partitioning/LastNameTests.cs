using System.Text.RegularExpressions;

namespace equivalence_partitioning;

[TestFixture]
public class LastNameTests
{
    [Datapoints]
    private static readonly KeyValuePair<string, bool>[] LastNamePartitions =
    [
        new("JeffAdkisson", true),
        new("Jeff Adkisson", true),
        new("Jeff-Adkisson", true),
        new("Jeff-Adkissonaa", true),
        new("Jeff Adkisson  ", true),
        new("       ", true),
        new("jjjjjjjjjjjjjjjj", false),
        new("j", true),
        new("", false),
        new ("Jeff1Adkisson", false),
        new ("Jeff1Adkisson     ", false)
    ];
    
    private static readonly Regex LastNameValidatorRegex = 
        new(@"^[a-zA-Z -]{1,15}$");
    
    
    [Theory]
    public void LastName_IsValid_WhenMeetsNameCriteria(
        KeyValuePair<string, bool> lastNameCriteria)
    {
        //arrange
        var expectedIsValid = lastNameCriteria.Value;
        
       //act
       var actualIsValid = LastNameValidatorRegex.IsMatch(lastNameCriteria.Key);
       Console.WriteLine($"Expect: [{lastNameCriteria.Key}] is {expectedIsValid}, Actual: {actualIsValid}");
       Console.WriteLine($"Length: [{lastNameCriteria.Key.Length}]");
       
       //assert
        Assert.That(actualIsValid, Is.EqualTo(expectedIsValid));


    }
}