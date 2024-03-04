package edu.kennesaw.seclass;

import org.junit.jupiter.api.AfterEach;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.fail;
import static org.junit.jupiter.api.Assertions.assertEquals;

public class MyCustomStringTest {

    private MyCustomStringInterface mycustomstring;

    @BeforeEach
    public void setUp() {
        mycustomstring = new MyCustomString();
    }

    @AfterEach
    public void tearDown() {
        mycustomstring = null;
    }

    @Test
    public void testCountNumbers1() {
        mycustomstring.setString("H3y, l3t'5 put s0me d161ts in this 5tr1n6!11!!");
        assertEquals(9, mycustomstring.countNumbers());
    }

    @Test
    public void testCountNumbers2() {
        fail("Not yet implemented");
    }

    @Test
    public void testCountNumbers3() {
        fail("Not yet implemented");
    }

    @Test
    public void testCountNumbers4() {
        fail("Not yet implemented");
    }

    @Test
    public void testCountNumbers5() {
        fail("Not yet implemented");
    }

    @Test
    public void testCountNumbers6() {
        fail("Not yet implemented");
    }

    @Test
    public void testReverseNCharacters1() {
        mycustomstring.setString("Peter Piper picked a peck of pickled peppers.");
        assertEquals("etePiP r repkcipa decep fo kcip delkpep srep.", mycustomstring.reverseNCharacters(4, false));
    }

    @Test
    public void testReverseNCharacters2() {
        mycustomstring.setString("Peter Piper picked a peck of pickled peppers.");
        assertEquals("etePiP r repkcipa decep fo kcip delkpep srepXXX.", mycustomstring.reverseNCharacters(4, true));
    }

    @Test
    public void testReverseNCharacters3() {
        fail("Not yet implemented");
    }

    @Test
    public void testReverseNCharacters4() {
        fail("Not yet implemented");
    }

    @Test
    public void testReverseNCharacters5() {
        fail("Not yet implemented");
    }

    @Test
    public void testReverseNCharacters6() {
        fail("Not yet implemented");
    }

    @Test
    public void testReverseNCharacters7() {
        fail("Not yet implemented");
    }

    @Test
    public void testReverseNCharacters8() {
        fail("Not yet implemented");
    }

    @Test
    public void testReverseNCharacters9() {
        fail("Not yet implemented");
    }

    @Test
    public void testReverseNCharacters10() {
        fail("Not yet implemented");
    }

    @Test
    public void testReverseNCharacters11() {
        fail("Not yet implemented");
    }


    @Test
    public void testConvertDigitsToNamesInSubstring1() {
        mycustomstring.setString("H3y, l3t'5 put 50me d161ts in this 5tr1n6!11!!");
        mycustomstring.convertDigitsToNamesInSubstring(17, 24);
        assertEquals("H3y, l3t'5 put 5Zerome dOnesixonets in this 5tr1n6!11!!", mycustomstring.getString());
    }

    @Test
    public void testConvertDigitsToNamesInSubstring2() {
        fail("Not yet implemented");
    }

    @Test
    public void testConvertDigitsToNamesInSubstring3() {
        fail("Not yet implemented");
    }

    @Test
    public void testConvertDigitsToNamesInSubstring4() {
        fail("Not yet implemented");
    }

    @Test
    public void testConvertDigitsToNamesInSubstring5() {
        fail("Not yet implemented");
    }

    @Test
    public void testConvertDigitsToNamesInSubstring6() {
        fail("Not yet implemented");
    }

    @Test
    public void testConvertDigitsToNamesInSubstring7() {
        fail("Not yet implemented");
    }

    @Test
    public void testConvertDigitsToNamesInSubstring8() {
        fail("Not yet implemented");
    }

    @Test
    public void testConvertDigitsToNamesInSubstring9() {
        fail("Not yet implemented");
    }

    @Test
    public void testConvertDigitsToNamesInSubstring10() {
        fail("Not yet implemented");
    }

    @Test
    public void testConvertDigitsToNamesInSubstring11() {
        fail("Not yet implemented");
    }

}
