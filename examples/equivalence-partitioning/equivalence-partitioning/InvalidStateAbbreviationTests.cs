namespace equivalence_partitioning;

public class InvalidStateAbbreviationLengthTests
{
    [DatapointSource] private readonly string[] _invalidStateAbbreviations =
        ["A", "AAA", "", "   "];

    [Theory]
    public void State_AbbreviationLength_IsInvalidLength(string invalidStateAbbreviation)
    {
        //arrange
        var minLength = States.Abbreviations.Min(s => s.Length);
        var maxLength = States.Abbreviations.Max(s => s.Length);
        
        //assert
        Assert.That(invalidStateAbbreviation,
            Has.Length.LessThan(minLength).Or.Length.GreaterThan(maxLength));
    }
}

public class InvalidStateAbbreviationTests
{
    [DatapointSource] private readonly string[] _invalidStateAbbreviations =
        ["A", "AAA", "", "   ", "ga", "nv"];
    
    [Theory]
    public void State_Abbreviation_IsNotInAbbreviationList(string invalidStateAbbreviation)
    {
        //assert
        Assert.That(States.Abbreviations, Does.Not.Contain(invalidStateAbbreviation));
    }
}