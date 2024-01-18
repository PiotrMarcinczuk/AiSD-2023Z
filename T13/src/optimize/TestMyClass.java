package optimize;
import optimize.MyClass;
public class TestMyClass {
    public static void main(String[] args){
        int a = 2;
        int b = 67;
        int c = 4;
        MyClass instance = new MyClass();
        Number result = instance.findMax(a, b, c);
        System.out.println("Max value: " + result);
    }
}
