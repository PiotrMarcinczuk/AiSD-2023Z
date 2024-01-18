package sports;

import java.util.Objects;

public class Stadium {
    private String name;
    private String location;
    private int capacity;
    private String hometeam;

    public Stadium(String name, String location, int capacity, String hometeam) {
        this.name = name;
        this.location = location;
        this.capacity = capacity;
        this.hometeam = hometeam;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getLocation() {
        return location;
    }

    public void setLocation(String location) {
        this.location = location;
    }

    public int getCapacity() {
        return capacity;
    }

    public void setCapacity(int capacity) {
        this.capacity = capacity;
    }

    public String getHometeam() {
        return hometeam;
    }

    public void setHometeam(String hometeam) {
        this.hometeam = hometeam;
    }

    @Override
    public String toString() {
        return "Stadium{" +
                "name='" + name + '\'' +
                ", location='" + location + '\'' +
                ", capacity=" + capacity +
                ", hometeam='" + hometeam + '\'' +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Stadium stadium = (Stadium) o;
        return capacity == stadium.capacity && Objects.equals(name, stadium.name) && Objects.equals(location, stadium.location) && Objects.equals(hometeam, stadium.hometeam);
    }

    @Override
    public int hashCode() {
        return Objects.hash(name, location, capacity, hometeam);
    }
}
