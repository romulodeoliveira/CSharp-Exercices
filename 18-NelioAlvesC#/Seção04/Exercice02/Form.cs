namespace Exercice02;

public class Form
{
    private string _name { get; set; }
    private double _salary { get; set; }

    public Form(string name, double salary)
    {
        _name = name;
        _salary = salary;
    }

    public static double AverageSalary(Form employee1, Form employee2)
    {
        double average = (employee1._salary + employee2._salary) / 2;
        return average;
    }
}