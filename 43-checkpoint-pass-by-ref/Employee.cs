internal class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public Employee(string employeeName, int employeeAge, int hours)
    {
        name = employeeName;
        age = employeeAge;
        numberOfHoursWorked = hours;
    }

    public int CalculateBonusAndTax(int bonus, ref int tax)
    {
        if (numberOfHoursWorked > 10)
            bonus *= 2;

        if (bonus >= 200)
        {
            tax = bonus / 10;
        }

        Console.WriteLine($"The employee got a bonus of {bonus} and the tax is {tax}");
        return bonus;
    }
}
