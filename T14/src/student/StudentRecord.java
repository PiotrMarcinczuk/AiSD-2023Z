package student;

public record StudentRecord (String name, String id, double gpa){
    public StudentRecord{
        if(gpa < 0.0 || gpa > 4.0){
            throw new IllegalArgumentException("Średnia ocen nieprawidłowa");
        }
    }
    public boolean isHonorStudent(){
        if(gpa > 3.5){
            return true;
        }
        return false;
    }

    public void printDetails(){
        System.out.println("Imie: " + name + ", Identyfikator: " + id + ", Średnia ocen: " + gpa);
    }
}
