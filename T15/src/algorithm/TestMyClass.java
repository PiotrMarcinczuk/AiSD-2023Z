package algorithm;

public class TestMyClass {
    public static void main(String[] args){
        Integer[] tab = {1,25,6,3,6,8};
        MyClass.fillWithDefaultValue(tab, 54);
        for(var item : tab){
            System.out.println(item);
        }
    }
}
