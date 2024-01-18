package games;

import java.util.ArrayList;
import java.util.Arrays;

public class TestVideoGame {
    public static void main(String[] args){
        VideoGame[] list = new VideoGame[]{
                new VideoGame("HOI4", "DeveloperA", 8.5f),
                new VideoGame("EU4", "DeveloperB", 9.0f),
                new VideoGame("WIEDZMIN 3", "DeveloperC", 7.8f),
                new VideoGame("MINECRAFT", "DeveloperD", 8.2f)
        };
        for(VideoGame item : list){
            System.out.println(item.getName());
        }
        Arrays.sort(list);
        System.out.println("PO SORTOWANIU: \n");
        for(VideoGame item : list){
            System.out.println(item.getName());
        }
    }
}
