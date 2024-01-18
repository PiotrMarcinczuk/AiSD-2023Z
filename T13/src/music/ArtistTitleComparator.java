package music;

import java.util.Comparator;

public class ArtistTitleComparator implements Comparator<Song> {
    @Override
    public int compare(Song o1, Song o2) {
        int result = Integer.compare(o2.getArtist().length(), (o1.getArtist().length()));
        if(result == 0){
            return Integer.compare(o2.getTitle().length(), (o1.getTitle().length()));
        }else{
            return result;
        }
    }
}
