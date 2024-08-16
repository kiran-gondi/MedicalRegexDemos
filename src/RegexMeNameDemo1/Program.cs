using System.Text.RegularExpressions;
using System.Xml.Linq;

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

//string input11 = "Paracetamol 1.5g Tab";
string input1 = "Paracetamol 1.5g Tabet";
string pattern1 = @"(?<name>[A-Za-z\s]+)\s(?<dosage>\d+(\.\d+)?\s?(mg|g))\s(?<form>[A-Za-z]+)";

Regex regex1 = new Regex(pattern1);
Match match1 = regex1.Match(input1);

if (match1.Success)
{
    string name = match1.Groups["name"].Value;
    string dosage = match1.Groups["dosage"].Value;
    string form = match1.Groups["form"].Value;

    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Dosage: {dosage}");
    Console.WriteLine($"Form: {form}");
}
else
{
    Console.WriteLine("No match found.");
}

Console.ReadLine();