package sports;

import java.util.Arrays;

public class Athlete implements Cloneable{
    private String name;
    private double[] times;

    public Athlete(String name, double[] times) {
        this.name = name;
        this.times = times;
    }

    @Override
    public String toString() {
        return "Athlete{" +
                "name='" + name + '\'' +
                ", times=" + Arrays.toString(times) +
                '}';
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        Athlete a1 = (Athlete) super.clone();
        a1.times = Arrays.copyOf(times, times.length);
        return a1;
    }
}
