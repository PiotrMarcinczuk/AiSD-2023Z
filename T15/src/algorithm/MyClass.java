package algorithm;
import java.util.Arrays;
public class MyClass {
    public static <T> void fillWithDefaultValue(T[] tab, T a){
        if(tab == null){
            throw new IllegalArgumentException("Tablica to null");
        }

        Arrays.fill(tab, a);
    }
}
