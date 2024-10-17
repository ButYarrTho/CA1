namespace CA1;

public class RaceEventManager
{
    private List<RaceEvent> raceEvents = new List<RaceEvent>();

    public RaceEventManager()
    {
        // Hardcoded race events and horses
        RaceEvent event1 = new RaceEvent("Spring Derby", "New York", 2, RaceStatus.Scheduled);
        RaceEvent event2 = new RaceEvent("Summer Classic", "Los Angeles", 3, RaceStatus.Scheduled);

        Race race1 = new Race("Race 1", "10:00");
        Race race2 = new Race("Race 2", "12:00");
        Race race3 = new Race("Race 3", "14:00");

        Horse horse1 = new Horse("Thunder", 5, "H001");
        Horse horse2 = new Horse("Lightning", 3, "H002");
        Horse horse3 = new Horse("Shadow", 4, "H003");
        Horse horse4 = new Horse("Blaze", 6, "H004");
        Horse horse5 = new Horse("Storm", 2, "H005");

        race1.AddHorse(horse1);
        race1.AddHorse(horse2);
        race2.AddHorse(horse3);
        race3.AddHorse(horse4);
        race3.AddHorse(horse5);

        event1.AddRace(race1);
        event1.AddRace(race2);
        event2.AddRace(race3);

        raceEvents.Add(event1);
        raceEvents.Add(event2);
    }
}