package university;

import java.util.Arrays;

public class MyClass{
    public static <T extends Comparable<T>> T findMedian(T[] tab){
        if(tab == null || tab.length == 0){
            throw new IllegalArgumentException("blad");
        }
        Arrays.sort(tab);
        int mid = tab.length / 2;
        return tab[mid];
    }
}
