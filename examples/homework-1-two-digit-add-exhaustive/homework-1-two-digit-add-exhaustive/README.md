# Homework 1 Exhaustive Two Digit Sum Testing

You can exhaustively test all possible two digit sums.

## Positive Only

1. [10..99] = 90 cases, inclusive
2. All cases = 90 * 90 = 8100 cases.
    - 10 + 10 = 20
    - 10 + 11 = 21
    - 10 + 12 = 22
    - 10 + 13 = 23
    - [ ... ]
    - 99 + 98 = 197
    - 99 + 99 = 198

## Positive and Negative

1. [10..99] = 90 cases, inclusive
2. [-99..-10] = 90 cases, inclusive
3. All combinations = 90 + 90 = 180
4. All cases = 180 * 180 = 32400 cases.
    - -99 + -99 = -198
    - -99 + -98 = -197
    - [ ... ]
    - 99 + 98 = 197
    - 99 + 99 = 198

## ALL Two Digit Integers (includes Leading Zeros for 00 to 09)

If you assume that two digit integers can include leading zeros, then the test cases increases. 
The solution remains exhaustively possible to test.

Positive Only:
- [00..99] = 100 cases, inclusive = 100 * 100 = 10,000 cases.

Positive and Negative:
- [-99..99] = 199 cases, inclusive = 199 * 199 = 39,601 cases<br>(includes 00 once, cases would be 40,000 if -00 and +00).

This example does not test for leading zeros.

# NUnit Solution

The solution uses an array of records called `TwoDigitIntegerCombination`:

```csharp
public record TwoDigitIntegerCombination(int Left, int Right, int Expected);
```

The `TwoDigitIntegerCombination` array is initialized with all possible combinations 
of two digit integers via the `TwoDigitIntegerCombinationGenerator` class. This class implements
the `IEnumerable<TwoDigitIntegerCombination>` interface to allow the `TwoDigitIntegerCombination`
to be passed to the test via the `TestCaseSource` attribute.

```csharp
 [Test, TestCaseSource(typeof(TwoDigitIntegerCombinationGenerator))]
public async Task Add_TwoDigitIntegerCombination_ReturnsCorrectSum(
        TwoDigitIntegerCombination testCriteria
)
```

# Executing the Tests

From a terminal, execute the following command in the folder container the `.csproj` file:

```bash
❯ ls
GlobalUsings.cs
README.md
TwoDigitIntegerCombination.cs
TwoDigitIntegerCombinationGenerator.cs
TwoDigitIntegerPositiveNegativeSumExhaustiveTests.cs
homework-1-two-digit-add-exhaustive.csproj # <--- If you see this file, you are in the right place

dotnet test
```

# Example Results

```bash
left: 99, right: 95, expected: 194

left: 99, right: 96, expected: 195

left: 99, right: 97, expected: 196

left: 99, right: 98, expected: 197

left: 99, right: 99, expected: 198


Passed!  - Failed:     0, Passed: 32400, Skipped:     0, Total: 32400, Duration: 330 ms - homework-1-two-digit-add-exhaustive.dll (net8.0)
```