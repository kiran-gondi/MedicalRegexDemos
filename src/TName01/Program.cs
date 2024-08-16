using System.Text.RegularExpressions;

string input = "OLANZAPINE 10 MG - ORODISPERSIBLE TABLET";
string pattern = @"\b[A-Z]+\b(?:\s+\d+\s+[A-Z]+)?(?:\s+-\s+[A-Z]+)?";

Regex regex = new Regex(pattern);
MatchCollection matches = regex.Matches(input);

foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}
Console.ReadKey();