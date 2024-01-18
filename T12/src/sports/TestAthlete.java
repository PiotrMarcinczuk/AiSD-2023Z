package sports;

public class TestAthlete {
    public static void main(String[] args){
        double[] tab = {5.4, 6.2, 7.0, 6.1, 5.9};
        Athlete a1 = new Athlete("Piotr", tab);
        System.out.println(a1.toString());
        try {
            Athlete a1Clone = (Athlete) a1.clone();
            System.out.println(a1Clone.toString());
        } catch (CloneNotSupportedException e) {
            throw new RuntimeException(e);
        }
    }
}
