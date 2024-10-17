namespace CA1;

public class RaceEvent
{
    public string Name { get; set; }
    public string Location { get; set; }
    public int NumberOfRaces { get; set; }
    public RaceStatus Status { get; set; }
    public List<Race> Races { get; set; }

    public RaceEvent(string name, string location, int numberOfRaces, RaceStatus status)
    {
        Name = name;
        Location = location;
        NumberOfRaces = numberOfRaces;
        Status = status;
        Races = new List<Race>();
    }

    public void AddRace(Race race)
    {
        Races.Add(race);
    }

    public Race GetRace(string raceName)
    {
        for (int i = 0; i < Races.Count; i++)
        {
            if (Races[i].Name == raceName)
            {
                return Races[i];
            }
        }
        return null;
    }
}