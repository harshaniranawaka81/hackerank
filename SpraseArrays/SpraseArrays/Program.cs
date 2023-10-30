// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var strings = new List<string>() { "ab", "ab", "abc" };
var queries = new List<string>() { "ab", "abc", "bc" };

var result = new List<int>();

int count = 0;

foreach (string q in queries)
{
    result.Add(strings.Count(s=>s == q));
}

foreach (var item in result)
{
    Console.WriteLine(item);
}