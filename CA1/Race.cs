namespace CA1;

public class Race
{
    public string Name { get; set; }
    public string StartTime { get; set; }
    public List<Horse> Horses { get; set; }

    public Race(string name, string startTime)
    {
        Name = name;
        StartTime = startTime;
        Horses = new List<Horse>();
    }

    public void AddHorse(Horse horse)
    {
        Horses.Add(horse);
    }
}