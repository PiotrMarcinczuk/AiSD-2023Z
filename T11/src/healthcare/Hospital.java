package healthcare;

public class Hospital implements Cloneable{
    private String name;
    private double capacity;

    public Hospital(String name, double capacity) {
        if(name != null){
            this.name = name;
        }else{
            this.name = "";
        }

        if(capacity > 0){
            this.capacity = capacity;
        }else{
            this.capacity = 50.0;
        }
    }

    @Override
    public String toString() {
        return "Hospital{" +
                "name='" + name + '\'' +
                ", capacity=" + capacity +
                '}';
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone();
    }
}
