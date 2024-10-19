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
    
    public void CreateRaceEvent()
    {
        Console.Write("Enter event name: ");
        string name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Event name cannot be empty.");
            return;
        }

        Console.Write("Enter event location: ");
        string location = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(location))
        {
            Console.WriteLine("Event location cannot be empty.");
            return;
        }

        Console.Write("Enter number of races: ");
        if (!int.TryParse(Console.ReadLine(), out int numberOfRaces) || numberOfRaces <= 0)
        {
            Console.WriteLine("Invalid number of races. Please enter a positive integer.");
            return;
        }

        RaceEvent newEvent = new RaceEvent(name, location, numberOfRaces, RaceStatus.Scheduled);
        raceEvents.Add(newEvent);
        Console.WriteLine("Race event created successfully.");
    }
    
    public void AddRacesToEvent()
    {
        Console.Write("Enter event name to add races to: ");
        string eventName = Console.ReadLine();

        RaceEvent raceEvent = FindRaceEventByName(eventName);
        if (raceEvent == null)
        {
            Console.WriteLine("Event not found.");
            return;
        }

        for (int i = 0; i < raceEvent.NumberOfRaces; i++)
        {
            Console.Write($"Enter name for race {i + 1} (or press Enter to use default name 'Race {i + 1}'): ");
            string raceName = Console.ReadLine();
            if (string.IsNullOrEmpty(raceName))
            {
                raceName = $"Race {i + 1}";
            }

            Console.Write($"Enter start time for {raceName} (HH:MM): ");
            string startTime = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(startTime))
            {
                Console.WriteLine("Start time cannot be empty.");
                return;
            }

            Race newRace = new Race(raceName, startTime);
            raceEvent.AddRace(newRace);
        }

        Console.WriteLine("Races added successfully.");
    }
    
    private RaceEvent FindRaceEventByName(string eventName)
    {
        for (int i = 0; i < raceEvents.Count; i++)
        {
            if (raceEvents[i].Name == eventName)
            {
                return raceEvents[i];
            }
        }
        return null;
    }
    
    public void ListUpcomingEvents()
    {
        if (raceEvents.Count == 0)
        {
            Console.WriteLine("No upcoming events available.");
            return;
        }

        foreach (var raceEvent in raceEvents)
        {
            Console.WriteLine($"\nEvent: {raceEvent.Name}, Location: {raceEvent.Location}, Status: {raceEvent.Status}");
            foreach (var race in raceEvent.Races)
            {
                Console.WriteLine($"  Race: {race.Name}, Start Time: {race.StartTime}");
                foreach (var horse in race.Horses)
                {
                    Console.WriteLine($"    Horse: {horse.Name}, Age: {horse.Age}, ID: {horse.HorseID}");
                }
            }
        }
    }

}