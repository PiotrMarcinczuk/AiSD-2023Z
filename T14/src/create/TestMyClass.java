package create;

import java.sql.Array;

public class TestMyClass {
    public static void main(String[] args){
        Number[] result = new Number[2];
        try{
            MyClass.createArray(5, 4.2, result);
            for(var item : result){
                System.out.println(item);
            }
        }catch(IllegalArgumentException e){
            System.out.println(e);
        }
    }
}
