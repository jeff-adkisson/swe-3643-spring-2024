namespace equivalence_partitioning;

public class ValidStateAbbreviationTests
{
    [DatapointSource] 
    private readonly string[] _stateAbbreviations = States.Abbreviations.ToArray();
    
    [Theory]
    public void State_TwoLetterAbbreviation_IsValid(string stateAbbreviation)
    {
        //act
        Assert.That(_stateAbbreviations, Does.Contain(stateAbbreviation));
    }
}