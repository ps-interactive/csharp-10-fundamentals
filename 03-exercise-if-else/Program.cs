﻿

Console.WriteLine("Enter a first number:");
string stringValue1 = Console.ReadLine();
Console.WriteLine("Enter a second number:");
string stringValue2 = Console.ReadLine();

int intValue1 = int.Parse(stringValue1);
int intValue2 = int.Parse(stringValue2);

if (intValue1 == intValue2)
{
    Console.WriteLine("The values are equal!");
}
else if (intValue1 < intValue2)
{
    Console.WriteLine("The first value is smaller!");
}
else
{
    Console.WriteLine("The second value is smaller!");
}