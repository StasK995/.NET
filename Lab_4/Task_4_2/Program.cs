using System;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Створення об'єкта людини
        Person person = new Person("Андрій");

        // Створення навичок
        Skill skill1 = new Skill("Програмування", 8);
        Skill skill2 = new Skill("Гра на гітарі", 6);

        // Додавання навичок до людини
        person.AddSkill(skill1);
        person.AddSkill(skill2);

        // Показ навичок
        person.ShowSkills();

        // Видалення навички
        person.RemoveSkill(skill1);

        // Показ навичок після видалення
        person.ShowSkills();
    }
}
