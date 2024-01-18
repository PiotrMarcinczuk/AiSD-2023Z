package utilities;
import java.util.List;

public class MyClass {
    public static <E> void appendFromEnd(List<? super E> destination, List<? extends E> source){
        int destinationSize = destination.size();
        int sourceSize = source.size();

        for (int i = sourceSize - 1; i >= 0; i--) {
            destination.add(destinationSize, source.get(i));
            destinationSize++;
        }

    }
}
