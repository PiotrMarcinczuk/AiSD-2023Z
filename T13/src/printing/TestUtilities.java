package printing;

public class TestUtilities {
    public static void main(String[] args){
        Integer[] intTab = {1, 4, 5, 2, 3};
        Double[] doubleTab = {2.2, 1.54, 6.1, 5.0, 4.2};
        String[] stringTab = {"jeden", "dwa", "trzy", "cztery"};
        Utilities.printEverySecond(intTab);
        Utilities.printEverySecond(doubleTab);
        Utilities.printEverySecond(stringTab);
    }
}
