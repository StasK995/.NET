using System;

public class Skill
{
    public string Name { get; set; }
    public int Proficiency { get; set; } // Від 1 до 10

    public Skill(string name, int proficiency)
    {
        Name = name;
        Proficiency = proficiency;
    }

    public override string ToString()
    {
        return $"{Name} (Рівень: {Proficiency})";
    }
}
