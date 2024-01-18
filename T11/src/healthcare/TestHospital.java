package healthcare;

public class TestHospital {
    public static void main(String[] args) throws CloneNotSupportedException {
        Hospital h1 = new Hospital("Dobry", 51);
        Hospital h2 = new Hospital(null, -4);
        Hospital cloned = null;
        try{
            cloned = (Hospital) h1.clone();
        }catch(CloneNotSupportedException e){
            e.printStackTrace();
        }
        System.out.println(cloned.toString());
    }
}
