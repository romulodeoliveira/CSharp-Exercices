namespace Exercice01;

public class Form
{
    private string _name { get; set; }
    private int _age { get; set; }

    public Form(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public static void AverageAge(Form person1, Form person2)
    {
        if (person1._age > person2._age)
        {
            Console.WriteLine($"{person1._name} tem a maior idade, com {person1._age} anos de idade.");
        }

        else
        {
            Console.WriteLine($"{person2._name} tem a maior idade, com {person2._age} anos de idade.");
        }
    }
}