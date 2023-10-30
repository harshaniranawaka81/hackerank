// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<int> arr = new List<int>() { -4, 3, -9, 0, 4, 1 };


int positiveCount = 0;
int negativeCount = 0;
int zeroCount = 0;

for (int i = 0; i < arr.Count(); i++)
{
    if (arr[i] > 0)
        positiveCount++;
    else if (arr[i] < 0)
        negativeCount++;
    else if (arr[i] == 0)
        zeroCount++;
}

decimal positiveRatio = Convert.ToDecimal(positiveCount) / Convert.ToDecimal(arr.Count());
decimal negativeRatio = Convert.ToDecimal(negativeCount) / Convert.ToDecimal(arr.Count());
decimal zeroRatio = Convert.ToDecimal(zeroCount) / Convert.ToDecimal(arr.Count());


Console.WriteLine(string.Format("{0:N6}", positiveRatio));
Console.WriteLine(string.Format("{0:N6}", negativeRatio));
Console.WriteLine(string.Format("{0:N6}", zeroRatio));