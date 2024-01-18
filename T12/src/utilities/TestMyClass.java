package utilities;

import java.util.List;
import java.util.ArrayList;
import utilities.MyClass;

public class TestMyClass {
    public static void main(String[] args){
        List<Object> destinationList = new ArrayList<>();
        List<String> sourceList = new ArrayList<>();

        sourceList.add("One");
        sourceList.add("Two");
        sourceList.add("Three");

        boolean isTrue = false;
        destinationList.add(isTrue);

        MyClass.appendFromEnd(destinationList, sourceList);
        for(var item : destinationList){
            System.out.println(item);
        }
    }

}
