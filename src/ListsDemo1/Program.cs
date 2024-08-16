using System.Text.RegularExpressions;

List<string> list1 = new List<string> { "Paracetamol 500mg Tablet", "Ibuprofen 200mg Tablet", "Aspirin 100mg Tablet", "Amoxicillin 250mg Capsule" };
//List<string> list2 = new List<string> { "Ibuprofen 200mg Tablet", "Aspirin 100mg Tablet", "Metformin 500mg Tablet", "Paracetamol 500mg Tablet" };
List<string> list2 = new List<string> { "Ibuprofen 200mg Tablet", "Aspirin 100mg Tablet", "Metformin 500mg Tablet", "Paracetamol 500 mg Tab" };

//string pattern = @"(?<name>[A-Za-z\s]+)\s\d+mg\s[A-Za-z]+";
string pattern = @"(?<name>[A-Za-z\s]+)\s\d+mg\s\btab(le)?\b";

var commonTablets = list1.Where(item1 => list2.Any(item2 => Regex.Match(item1, pattern).Groups["name"].Value == Regex.Match(item2, pattern).Groups["name"].Value));

Console.WriteLine("Common Tablets:");
foreach (var tablet in commonTablets)
{
    Console.WriteLine(tablet);
}

Console.ReadKey();