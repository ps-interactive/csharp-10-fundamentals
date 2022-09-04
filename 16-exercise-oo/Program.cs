

SunFlower s1 = new SunFlower("Sunflower", 100, 35);
s1.Grow();
s1.Grow();
s1.Grow();
s1.Grow();


SunFlower s2 = new SunFlower("Sunflower", 200, 50);
s2.Grow();
s2.Grow();
s2.Grow();
s2.Grow();

List<SunFlower> sunFlowers = new List<SunFlower>();
sunFlowers.Add(s1);

sunFlowers.Add(s2);


Console.WriteLine(s1.DisplayDetails());
Console.WriteLine(s2.DisplayDetails());

Console.ReadLine();
