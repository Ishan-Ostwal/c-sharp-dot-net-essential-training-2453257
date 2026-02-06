//See https://aka.ms/new-console-template for more information
string? res;
Console.WriteLine("Whats your name?");
res = Console.ReadLine();
Console.WriteLine($"enjoy the course, {res}");
OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);