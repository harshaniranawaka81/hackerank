// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var a = new List<int>() { 1, 2, 3, 4, 3, 2, 1 };

var occurances = new Dictionary<int, int>();

foreach (int i in a)
{
    if(!occurances.ContainsKey(i))
        occurances.Add(i, a.Count(n => n == i));
}
    

var unique = occurances.First(s => s.Value == 1).Key;

Console.WriteLine(unique);
