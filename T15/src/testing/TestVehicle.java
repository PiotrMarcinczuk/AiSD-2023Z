package testing;

public class TestVehicle {
    public static void main(String[] args){
        Vehicle v1 = new Vehicle("A6", 201);
        Vehicle v2 = new Vehicle("A6", 201);
        MyClass.compareAndPrint(v1, v2);
    }
}
