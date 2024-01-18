package vacation;

public interface TravelPlanner {
    default void cancelTrip(){
        System.out.println("Trip Cancelled");
    }
    void planRoute(String destination);
    static String getTravelMode(){
        return(new String("Travel mode"));
    }
}
