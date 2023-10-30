// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var arr = new List<long>() { 1, 3, 5, 7, 9 };

var minArr = arr.ToList();
var maxArr = arr.ToList();

var minList = new List<long>();
var maxList = new List<long>();

for (int i = 1; i <= 4; i++)
{
    minList.Add(minArr.Min());
    minArr.Remove(minArr.Min());

    maxList.Add(maxArr.Max());
    maxArr.Remove(maxArr.Max());
}

Console.WriteLine($"{minList.Sum()} {maxList.Sum()}");