package student;

public class TestStudentRecord {
    public static void main(String[] args){
        StudentRecord s1 = new StudentRecord("Karol", "32b", 3.6);
        StudentRecord s2 = new StudentRecord("Karolina", "55c", 3.5);
        s1.printDetails();
        s2.printDetails();
        System.out.println(s1.isHonorStudent());
        System.out.println(s2.isHonorStudent());
    }
}
