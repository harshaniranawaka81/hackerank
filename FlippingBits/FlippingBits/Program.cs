// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text;

Console.WriteLine("Hello, World!");

long n = 4;

var bitsForNum  = new StringBuilder();
var bitsForFlippedNum = new StringBuilder();

var bitsForNumValues = new List<int>();

var remainder = n;

while(remainder > 0)
{
    bitsForNumValues.Add((int)(remainder % 2));
    remainder /= 2;
}

for (int i = bitsForNumValues.Count - 1; i >= 0; i--)
{
    bitsForNum.Append(bitsForNumValues[i]);
}

var formattedBinaryNum = bitsForNum.ToString().PadLeft(32, '0');

Console.WriteLine(formattedBinaryNum);

for (int i = 0; i < formattedBinaryNum.Length; i++)
{
    if (formattedBinaryNum[i] == '0')
    {
        bitsForFlippedNum.Append(1);
    }
    else if (formattedBinaryNum[i] == '1')
    {
        bitsForFlippedNum.Append(0);
    }
}

Console.WriteLine(bitsForFlippedNum.ToString());

var sum = 0l;

for (int i = bitsForFlippedNum.Length - 1; i >= 0; i--)
{
    var value = int.Parse(bitsForFlippedNum.ToString(i,1));
    var index = bitsForFlippedNum.Length - i - 1;
    var power = (long)Math.Pow(2, index);
    sum += value * power;
}

Console.WriteLine(sum);