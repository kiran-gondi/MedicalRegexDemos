using System.Text.RegularExpressions;

string input = "tab table";
string pattern = @"\btab(le)?\b";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    Console.WriteLine("Match found: " + match.Value);
}
Console.ReadLine();