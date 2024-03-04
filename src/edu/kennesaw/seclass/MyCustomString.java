package edu.kennesaw.seclass;

public class MyCustomString implements MyCustomStringInterface {
    private String string;

    @Override
    public String getString() {
        return string;
    }

    @Override
    public void setString(String string) {
        this.string = string;
    }

    @Override
    public int countNumbers() {
        StringBuffer tmpString = new StringBuffer();
        int count=0;
        boolean inNumber=false;
        //avoid null pointer exception!
        if(string==null || string.isEmpty())
            return 0;
        for (int i = 0; i < string.length(); i++) {
            char ch = string.charAt(i);
            if (Character.isDigit(ch)) {
                if (!inNumber) {
                    count++;
                    inNumber = true;
                }
            }
            else {
                if (inNumber) {
                    inNumber = false;
                }
            }
        }
        return count;
    }

    @Override
    public String reverseNCharacters(int n, boolean padded) {
        if (string == null) {
            throw new NullPointerException();
        }
        if (n <= 0) {
            throw new IllegalArgumentException();
        }
        StringBuffer tmpString = new StringBuffer();
        StringBuffer resultString = new StringBuffer();
        StringBuffer currString = new StringBuffer(string);

        int i;
        for (i = 0; i + n < currString.length(); i+=n) {
                tmpString = tmpString.append(new StringBuffer(currString.substring(i,i+n)).reverse());
        }
        if (padded)
        {
            for (int x = n - (currString.length() - i); x > 0; x--)
                currString.append('X');
        }
        tmpString = tmpString.append(new StringBuffer(currString.substring(i)).reverse());

        return tmpString.toString();
    }

    @Override
    public void convertDigitsToNamesInSubstring(int startPosition, int endPosition) {
        if (string == null) {
            throw new NullPointerException();
        }
        if ((startPosition > endPosition)) {
            throw new IllegalArgumentException();
        }

        if  (endPosition > string.length() || (startPosition < 1)){
            throw new MyIndexOutOfBoundsException();
        }
        StringBuffer tmpString = new StringBuffer();
        String tmpDigit = new String();
        boolean look_back = false;
        for (int i = 0; i < string.length(); i++) {
            char ch = string.charAt(i);
            if ((i < startPosition - 1) || (i > endPosition - 1)) {
                if(look_back) {
                    look_back = false;
                }
                tmpString.append(ch);
                continue;
            } else {
                if (Character.isDigit(ch)) {
                    switch (ch) {
                        case '0':
                            tmpDigit = "Zero";
                            break;
                        case '1':
                            tmpDigit = "One";
                            break;
                        case '2':
                            tmpDigit = "Two";
                            break;
                        case '3':
                            tmpDigit = "Three";
                            break;
                        case '4':
                            tmpDigit = "Four";
                            break;
                        case '5':
                            tmpDigit = "Five";
                            break;
                        case '6':
                            tmpDigit = "Six";
                            break;
                        case '7':
                            tmpDigit = "Seven";
                            break;
                        case '8':
                            tmpDigit = "Eight";
                            break;
                        case '9':
                            tmpDigit = "Nine";
                            break;
                    }
                    if(look_back)
                        tmpString.append(tmpDigit.toLowerCase());
                    else
                        tmpString.append(tmpDigit);
                    look_back = true;
                } else {
                    if(look_back){
                        look_back = false;}
                    tmpString.append(ch);

                }
            }
        }
        string = tmpString.toString();
    }
}
