

Console.WriteLine("Enter a value:");
int sum = 0;

string stringValue = Console.ReadLine();
int startValue = int.Parse(stringValue);

for (int i = startValue; i > 0; i--)
{
    sum += i;

}

Console.WriteLine("The sum is " + sum);