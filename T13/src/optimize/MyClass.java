package optimize;

public class MyClass {
    public <T extends Comparable<T>> T findMax(T a, T b, T c){
        T max = a;
        if(b.compareTo(max) > 0){
            max = b;
        }

        if(c.compareTo(max) > 0){
            max = c;
        }
        return max;
    }
}
