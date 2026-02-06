// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// TODO: Length of a string 
Console.WriteLine(str1.Length);


// TODO: Access individual characters
Console.WriteLine(str2[5]);

// TODO: Iterate over a string like any other sequence of values
foreach(char ch in str3)
{
    Console.WriteLine(ch);
}

// TODO: String Concatenation         
string outstr=string.Concat(str1,str2);
Console.WriteLine(outstr);


// TODO: Joining strings together with Join
outstr = string.Join(",", strs);
Console.WriteLine(outstr);

// TODO: String Comparison
Console.WriteLine(str1.CompareTo(str2));
// Equals just returns a regular Boolean
 bool isEqual = str2.Equals(str3);
 Console.WriteLine($"{isEqual}");

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order


// TODO: Replacing content
Console.WriteLine(str1.Replace("fox","cat"));