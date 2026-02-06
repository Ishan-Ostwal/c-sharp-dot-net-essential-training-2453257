// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for searching string content

string teststr = "The quick brown Fox jumps over the lazy Dog";

// TODO: Contains determines whether a string contains certain content
Console.WriteLine(teststr.Contains("quick"));

// TODO: StartsWith and EndsWith determine if a string starts 
// or ends with a given test string
Console.WriteLine(teststr.StartsWith("fox",StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine(teststr.EndsWith("Dog"));
// TODO: IndexOf, LastIndexOf finds the index of a substring
Console.WriteLine(teststr.IndexOf("jumps", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine(teststr.LastIndexOf("g"));

// TODO: Determining empty, null, or whitespace
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;
