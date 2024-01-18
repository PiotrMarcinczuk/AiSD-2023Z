package testing;

public class MyClass {
    public static <T> void compareAndPrint(T a, T b){
        if(a.equals(b)){
            System.out.println("Są sobie równe");
            return;
        }else{
            System.out.println("NIE Są sobie równe");
        }
    }
}
