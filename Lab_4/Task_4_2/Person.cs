using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    private List<Skill> skills; // Композиційний зв'язок

    public Person(string name)
    {
        Name = name;
        skills = new List<Skill>(); // Ініціалізація списку навичок
    }

    public void AddSkill(Skill skill)
    {
        skills.Add(skill);
        Console.WriteLine($"Додано навичку: {skill}");
    }

    public void RemoveSkill(Skill skill)
    {
        if (skills.Remove(skill))
        {
            Console.WriteLine($"Видалено навичку: {skill}");
        }
        else
        {
            Console.WriteLine($"Навичка не знайдена: {skill}");
        }
    }

    public void ShowSkills()
    {
        Console.WriteLine($"{Name} має наступні навички:");
        foreach (var skill in skills)
        {
            Console.WriteLine(skill);
        }
    }
}
