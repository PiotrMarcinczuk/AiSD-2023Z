package date;

import java.security.PublicKey;

public class TestImmutableDate {
    public static void main(String[] args){
        ImmutableDate i1 = new ImmutableDate(2020, 10, 14);
        ImmutableDate i2 = new ImmutableDate(2019, 9, 29);
        System.out.println(i1.toString());
        System.out.println(i2.toString());
        System.out.println(i1.equals(i2));
        System.out.println(i1.hashCode());
        System.out.println(i2.hashCode());
    }
}
