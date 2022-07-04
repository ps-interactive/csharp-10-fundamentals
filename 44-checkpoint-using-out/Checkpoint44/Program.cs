int defaultBonus = 1000;
int tax;

Employee employee = new Employee("Gill", 42, 10);

int bonus = employee.CalculateBonusAndTax(defaultBonus, tax);

Console.ReadLine();
