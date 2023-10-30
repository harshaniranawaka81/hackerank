// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string s = "07:45:00PM";

string amPmPart = s.Substring(s.Length - 2);
int hour = int.Parse(s.Substring(0, 2));
int minute = int.Parse(s.Substring(3, 2));
int second = int.Parse(s.Substring(6, 2));

if (amPmPart == "PM")
{
    if (hour > 12)
        hour -= 12;
    else if (hour < 12)
        hour += 12;
}
else if (amPmPart == "AM")
{
    if (hour == 12)
        hour -= 12;    
}

string convertedTime = $"{hour.ToString("00")}:{minute.ToString("00")}:{second.ToString("00")}";

Console.WriteLine(convertedTime);

