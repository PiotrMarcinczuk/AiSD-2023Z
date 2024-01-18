package printing;

public class Utilities {
    public static <T> void printEverySecond(T[] tab){
        if(tab == null){
            System.out.println("Tablica null");
        }
        for(int i=1; i<tab.length; i++){
            if(i%2 != 0){
                System.out.println(tab[i]);
            }
        }

    }
}
