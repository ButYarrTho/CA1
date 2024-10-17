namespace CA1;

public class Horse
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string HorseID { get; set; }

    public Horse(string name, int age, string horseID)
    {
        Name = name;
        Age = age;
        HorseID = horseID;
    }
}