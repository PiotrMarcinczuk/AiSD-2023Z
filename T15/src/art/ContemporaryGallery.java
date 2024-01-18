package art;

import java.util.ArrayList;
import java.util.Objects;

public class ContemporaryGallery extends ArtGallery{
    private int numberOfInstallations;

    public ContemporaryGallery(String name, String city, ArrayList<String> paintings, int numberOfInstallations) {
        super(name, city, paintings);
        this.numberOfInstallations = numberOfInstallations;
    }

    public int getNumberOfInstallations() {
        return numberOfInstallations;
    }

    public void setNumberOfInstallations(int numberOfInstallations) {
        this.numberOfInstallations = numberOfInstallations;
    }

    @Override
    public String toString() {
        return "ContemporaryGallery{" +
                "numberOfInstallations=" + numberOfInstallations +
                "} " + super.toString();
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        ContemporaryGallery that = (ContemporaryGallery) o;
        return numberOfInstallations == that.numberOfInstallations;
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), numberOfInstallations);
    }
}
