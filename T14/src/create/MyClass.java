package create;

public class MyClass {
    public static <T> void createArray(T a, T b, T[] tab){
        if(tab.length != 2){
            throw new IllegalArgumentException("Tablica powinna miec dwa elementy");
        }

        tab[0] = a;
        tab[1] = b;
    }
}
