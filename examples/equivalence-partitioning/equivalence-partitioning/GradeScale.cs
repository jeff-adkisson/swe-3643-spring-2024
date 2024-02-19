namespace equivalence_partitioning;

public record GradeScale
{
    public int Min { get; init; } = int.MinValue;
    public int Max { get; init; } = 59;
    public string Letter { get; init; } = "F";
    
    public static readonly List<GradeScale> GradeScales =
    [
        new GradeScale(101, int.MaxValue, "~"),
        new GradeScale(90, 100, "A"),
        new GradeScale(80, 89, "B"),
        new GradeScale(70, 79, "C"),
        new GradeScale(60, 69, "D"),
        new GradeScale(0, 59, "F"),
        new GradeScale(int.MinValue, -1, "F")
    ];

    public GradeScale(int min, int max, string letter)
    {
        Min = min;
        Max = max;
        Letter = letter;
    }
}