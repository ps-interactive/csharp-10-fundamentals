using System.Text;

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append("Welcome ");
stringBuilder.Append("to ");
stringBuilder.AppendLine("Bethany's Pie Shop!");
stringBuilder.Append("Please log in!");

Console.WriteLine(stringBuilder.ToString());    

Console.ReadLine();