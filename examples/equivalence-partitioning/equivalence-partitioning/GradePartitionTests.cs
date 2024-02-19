namespace equivalence_partitioning;

[TestFixture]
public class GradePartitionTests
{
    [Datapoints]
    private KeyValuePair<int, string>[] _gradePartitions =
    [
        new KeyValuePair<int, string>(int.MaxValue, "~"),
        new KeyValuePair<int, string>(101, "~"),
        new KeyValuePair<int, string>(100, "A"),
        new KeyValuePair<int, string>(90, "A"),
        new KeyValuePair<int, string>(89, "B"),
        new KeyValuePair<int, string>(80, "B"),
        new KeyValuePair<int, string>(79, "C"),
        new KeyValuePair<int, string>(70, "C"),
        new KeyValuePair<int, string>(69, "D"),
        new KeyValuePair<int, string>(60, "D"),
        new KeyValuePair<int, string>(59, "F"),
        new KeyValuePair<int, string>(0, "F"),
        new KeyValuePair<int, string>(-1, "F"),
        new KeyValuePair<int, string>(int.MinValue, "F")
    ];
    
    [Theory]
    public void Grade_KeyValuePairNumberAndLetter_MatchesGradeScale(
        KeyValuePair<int, string> grade)
    {
        //arrange
        var score = grade.Key;
        var expectedGrade = grade.Value;
        
        //act
        var actualGrade = GradeScale.GradeScales
            .Single(g => g.Min <= score && g.Max >= score);
        Console.WriteLine($"{score}, {expectedGrade}, Min={actualGrade.Min}, " +
                          $"Max={actualGrade.Max}, Letter={actualGrade.Letter}");
        
        //assert
        Assert.That(expectedGrade, Is.EqualTo(actualGrade.Letter));
    }
}