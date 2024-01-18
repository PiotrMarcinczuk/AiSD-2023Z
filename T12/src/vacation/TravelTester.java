package vacation;

public class TravelTester {
    public static void main(String[] args){
        RoadTripPlanner r1 = new RoadTripPlanner();
        FlightPlanner f1 = new FlightPlanner();

        r1.planRoute("Malediwy");
        f1.planRoute("Wyspy Kanaryjskie");
        r1.cancelTrip();
        f1.cancelTrip();
        System.out.println(TravelPlanner.getTravelMode());
    }
}
