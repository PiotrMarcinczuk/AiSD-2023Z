package music;

import java.util.Arrays;

public class TestSong {
    public static void main(String[] args){
        Song[] tab = {
                new Song("Jestem Bogiem", "qwer", 43),
                new Song("fDA", "qwerty", 55),
                new Song("kASZTANI", "qwer", 31),
                new Song("Krol", "qwertyuiop", 42),
        };

        System.out.println("Przed sortowaniem: ");
        for(Song item : tab){
            System.out.println(item.toString());
        }
        Arrays.sort(tab, new DurationCompartaor());
        System.out.println("Po sortowaniu duration: ");
        for(Song item : tab){
            System.out.println(item.toString());
        }
        Arrays.sort(tab, new ArtistTitleComparator());
        System.out.println("Po sortowaniu title/artist: ");
        for(Song item : tab){
            System.out.println(item.toString());
        }

    }
}
