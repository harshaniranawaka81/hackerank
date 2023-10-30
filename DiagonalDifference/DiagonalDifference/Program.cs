// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Hello, World!");

var arr = new List<List<int>>
{
    new List<int>() { 11, 2, 4 },
    new List<int>() { 4, 5, 6 },
    new List<int>() { 10, 8, -12 }
};

var side1sum = 0;

for (int i = 0; i < arr[0].Count; i++)
{
    for (int j = 0; j < arr.Count; j++)
    {
        if (i == j)
        {
            side1sum += arr[i][j];
        }
    }
}

var side2sum = 0;

for (int i = 0; i < arr[0].Count; i++)
{
    arr[i].Reverse();
}

for (int i = 0; i < arr[0].Count; i++)
{
    for (int j = 0; j < arr.Count; j++)
    {
        if (i == j)
        {
            side2sum += arr[i][j];
        }
    }
}

Console.WriteLine(side1sum);
Console.WriteLine(side2sum);
Console.WriteLine(Math.Abs(side1sum - side2sum));

