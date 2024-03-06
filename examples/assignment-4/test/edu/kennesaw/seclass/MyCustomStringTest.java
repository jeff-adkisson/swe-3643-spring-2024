package edu.kennesaw.seclass;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class MyCustomStringTest {

    private MyCustomStringInterface mycustomstring;

    @BeforeEach
    public void setUp() {
        //arrange
        mycustomstring = new MyCustomString();
    }

    @AfterEach
    public void tearDown() {
        mycustomstring = null;
    }

    @Test
    public void MyCustomString_NumbersInString_Count_EXAMPLE() {

        //arrange
        mycustomstring.setString("H3y, l3t'5 put s0me d161ts in this 5tr1n6!11!!");
        int countOfNumbers = mycustomstring.countNumbers();

        //assert
        assertEquals(9,
                countOfNumbers);
    }

    @Test
    public void MyCustomString_NullString_ReverseNCharactersThrowsNullPointerException_EXAMPLE() {
        //arrange
        mycustomstring.setString(null);

        //act
        Exception exception = assertThrows(NullPointerException.class, () -> {
            mycustomstring.reverseNCharacters(0, false);
        });

        //assert
        assertInstanceOf(NullPointerException.class, exception);
    }

    @Test
    public void MyCustomString_Phrase_Reverse_EXAMPLE() {

        //arrange
        mycustomstring.setString("Peter Piper picked a peck of pickled peppers.");

        //act
        String reversed = mycustomstring.reverseNCharacters(4, false);

        //assert
        assertEquals(
                "etePiP r repkcipa decep fo kcip delkpep srep.",
                reversed);
    }

    @Test
    public void  MyCustomString_PhraseWithDigits_ConvertToDigits_EXAMPLE()
    {
        //arrange
        mycustomstring.setString("H3y, l3t'5 put 50me d161ts in this 5tr1n6!11!!");

        //act
        mycustomstring.convertDigitsToNamesInSubstring(17, 24);
        String converted = mycustomstring.getString();

        //asset
        assertEquals(
                "H3y, l3t'5 put 5Zerome dOnesixonets in this 5tr1n6!11!!",
                converted);
    }

//    public void MyCustomString_State_ExpectedBehavior() {
//        fail("This test should fail");
//    }
}
