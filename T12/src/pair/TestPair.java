package pair;

public class TestPair {
    public static void main(String[] args){
        Pair<Integer, String> p1 = new Pair<>(2, "niezle");
        Pair<Integer, Boolean> p2 = new Pair<>(5, false);

        System.out.println(p1.toString());
        System.out.println(p2.toString());
    }
}
