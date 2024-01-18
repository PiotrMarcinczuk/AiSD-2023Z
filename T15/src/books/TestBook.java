package books;

import java.util.ArrayList;
import java.util.Arrays;

public class TestBook {
    public static void main(String[] args){
        ArrayList<Book> list = new ArrayList<>();
        list.add(new Book("Jan w Koninie", "Karol", 2012));
        list.add(new Book("JK", "Magdalena", 2011));
        list.add(new Book("Akademia sznycera", "Karol", 2019));
        list.add(new Book("W pustyni i puszczy", "Michał", 2010));

        for(Book item : list){
            System.out.println(item.toString());
        }
        list.sort(null);
        System.out.println("-------------------");
        for(Book item : list){
            System.out.println(item.toString());
        }


    }
}
