using System.Text.RegularExpressions;

string input = "Paracetamol 500mg Tablet";
string pattern = @"(?<name>[A-Za-z\s]+)\s(?<dosage>\d+mg)\s(?<form>[A-Za-z]+)";

Regex regex = new Regex(pattern);
Match match = regex.Match(input);

if (match.Success)
{
    Console.WriteLine("Medicine Name: " + match.Groups["name"].Value);
    Console.WriteLine("Dosage: " + match.Groups["dosage"].Value);
    Console.WriteLine("Form: " + match.Groups["form"].Value);
}
else
{
    Console.WriteLine("No match found.");
}

Console.WriteLine("The other match");
string inputToMatch = "Paracetamol 500mg Tab";
Regex regex1 = new Regex(pattern);
Match match1 = regex.Match(inputToMatch);

if (match.Success)
{
    Console.WriteLine("Medicine Name: " + match1.Groups["name"].Value);
    Console.WriteLine("Dosage: " + match1.Groups["dosage"].Value);
    Console.WriteLine("Form: " + match1.Groups["form"].Value);
}
else
{
    Console.WriteLine("No match1 found.");
}

Console.ReadLine();