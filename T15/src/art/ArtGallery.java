package art;

import java.util.ArrayList;
import java.util.Objects;

public class ArtGallery {
    private String name;
    private String city;
    private ArrayList<String> paintings;

    public ArtGallery(String name, String city, ArrayList<String> paintings) {
        this.name = name;
        this.city = city;
        this.paintings = paintings;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public ArrayList<String> getPaintings() {
        return new ArrayList<>(paintings);
    }

    public void setPaintings(ArrayList<String> paintings) {
        this.paintings = paintings;
    }

    @Override
    public String toString() {
        return "ArtGallery{" +
                "name='" + name + '\'' +
                ", city='" + city + '\'' +
                ", paintings=" + paintings +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        ArtGallery that = (ArtGallery) o;
        return Objects.equals(name, that.name) && Objects.equals(city, that.city) && Objects.equals(paintings, that.paintings);
    }

    @Override
    public int hashCode() {
        return Objects.hash(name, city, paintings);
    }

    public void addPainting(String painting){
        paintings.add(painting);
    }

    public void removePainting(String painting){
        paintings.remove(painting);
    }
}
