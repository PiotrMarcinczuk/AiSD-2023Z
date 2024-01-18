package algorithm;

public class MyClass{
    public <T> boolean compareThree(T arg1, T arg2, T arg3){
        if(arg1.equals(arg2) && arg1.equals(arg3)){
            return true;
        }
        return false;
    }
}
