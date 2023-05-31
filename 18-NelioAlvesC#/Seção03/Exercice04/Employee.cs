namespace Exercice04
{
    public class Employee
    {
        private int _employeeNumber { get; set; }
        private int _workedHours { get; set; }
        private double _hourlyWage { get; set; }

        public Employee(int employeeNumber, int workedHours, double hourlyWage)
        {
            _employeeNumber = employeeNumber;
            _workedHours = workedHours;
            _hourlyWage = hourlyWage;
        }

        public void Print()
        {
            System.Console.WriteLine("--------------------------------------------------");
            System.Console.WriteLine($"Número do Funcionário: {_employeeNumber}");
            System.Console.WriteLine($"Salário: {(_workedHours * _hourlyWage).ToString("F2")}");
            System.Console.WriteLine("--------------------------------------------------");
        }
    }
}