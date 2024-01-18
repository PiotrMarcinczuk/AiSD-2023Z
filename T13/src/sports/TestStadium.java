package sports;

public class TestStadium {
    public static void main(String[] args){
        Stadium s1 = new Stadium("Stadion", "Olsztyn", 15000, "Stomil Olsztyn");
        AthleteProfile a1 = new AthleteProfile("Karol", "Piłka nożna", s1);
        System.out.println(a1.toString());
    }
}
