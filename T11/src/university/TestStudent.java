package university;


import static university.MyClass.findMedian;

public class TestStudent {
    public static void main(String[] args){
        Student[] tab = {
                new Student("Piotr", 1),
                new Student("Pawel", 5),
                new Student("Karolina", 2),
                new Student("Jan", 4),
        };

        Student medianStudent = findMedian(tab);
        System.out.println(medianStudent.toString());

    }
}
