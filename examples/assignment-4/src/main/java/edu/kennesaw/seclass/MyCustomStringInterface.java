package edu.kennesaw.seclass;

/**
 * This is an interface for a simple class that represents a string, defined
 * as a sequence of characters.
 *
 * This interface should NOT be altered in any way.
 */
public interface MyCustomStringInterface {

    /**
     * Returns the current string. If the string is null, it should return null.
     *
     * @return Current string
     */
    String getString();

    /**
     * Sets the value of the current string.
     *
     * @param string The value to be set
     */
    void setString(String string);

    /**
     * Returns the number of numbers in the current string, where a number is defined as an
     * unbroken sequence of digits.
     *
     * If the current string is null, empty, or uninitialized, the method should return 0.
     *
     * Examples:
     * - countNumbers would return 2 for string "My numbers are 11 and 9".
     *
     * @return Number of numbers in the current string
     */
    int countNumbers();

    /**
     * Returns a string that consists of all characters in the original string with each segment of n characters
     * reversed.
     * If padded is true, the final segment of characters will have the character 'X' added to it enough time to make
     * a full segment.
     * <p>
     * <p>
     * Examples:
     * - For n=2 and padded=true, the method would return the string with every pair of characters swapped in place, and
     * if there were an odd number of characters, an X would be added to the last segment before it is reversed.
     * - For n=3 and padded=false, the method would return the string with every segment of 3 characters reversed in place,
     * and the final segment would be reversed even if less than 3 characters without any additional characters added.
     * <p>
     * Values n and padded are passed as parameters. The starting character is considered to be in Position 1.
     *
     * @param n       Determines size of the string segments to be reversed
     * @param padded Determines whether an incomplete final segment will be padded with 'X'.
     * @return String with the segments in their original order and the contents of the segments reversed.
     * @throws NullPointerException        If the current string is null or uninitialized.
     * @throws IllegalArgumentException    If "n" less than or equal to zero, and the current string is not null.
     */
    String reverseNCharacters(int n, boolean padded);

    /**
     * Replace the individual digits in the current string, between startPosition and endPosition
     * (included), with the corresponding English names of those digits, with the first letter of a number (unbroken
     * string of digits) capitalized. The first character in the string is considered to be in Position 1.
     *
     * Examples:
     * - String 460 would be converted to Foursixzero
     * - String 416 would be converted to Fouronesix
     *
     * @param startPosition Position of the first character to consider
     * @param endPosition   Position of the last character to consider

     * @throws NullPointerException        If the current string is null or uninitialized.
     * @throws IllegalArgumentException    If "startPosition" > "endPosition"
     * @throws MyIndexOutOfBoundsException If "startPosition" < 1 or "endPosition" is out of bounds (greater than the
     * length of the string) and "startPosition" <= "endPosition"
     */
    void convertDigitsToNamesInSubstring(int startPosition, int endPosition);
}
