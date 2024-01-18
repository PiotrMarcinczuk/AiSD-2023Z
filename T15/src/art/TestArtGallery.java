package art;

import art.ArtGallery;
import art.ContemporaryGallery;

import java.util.ArrayList;

public class TestArtGallery {
    public static void main(String[] args){
        ArrayList<String> list = new ArrayList<>();
        list.add("Madonna");
        list.add("Bitwa pod Grunwaldem");

        ArtGallery a1 = new ArtGallery("galeria", "Olsztyn", list);
        a1.addPainting("KKK");
        System.out.println(a1.toString());
        a1.removePainting("KKK");
        a1.removePainting("Madonna");
        System.out.println(a1.toString());

        ArrayList<String> list2 = new ArrayList<>();
        list2.add("fOn");
        list2.add("Bitwa pod Grunwaldem");
        ContemporaryGallery c1 = new ContemporaryGallery("galeria_dwa", "Wrocław", list2, 4);
        c1.addPainting("fd");
        c1.addPainting("fsdfsdfsd");
        c1.removePainting("Bitwa pod Grunwaldem");
        System.out.println(c1.toString());

    }
}
