
public class Employee
{
    public string name;
    public int age;
    public int numberOfHoursWorked = 0;

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked};");
    }

    public void Work(int hours, bool resetHours)
    {
        if (resetHours)
            numberOfHoursWorked = 0;

        numberOfHoursWorked += hours;
    }
}
