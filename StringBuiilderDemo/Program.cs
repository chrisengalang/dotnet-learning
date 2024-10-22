using System.Text;

var jumpCount = 10;
string[] animals = { "goats", "cats", "pigs" };
var sb = new StringBuilder("Initial String.", 200);

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

sb.AppendLine();

sb.Append("The quick brown fox ");
sb.Append("jumped over the lazy dog.");

sb.AppendLine();

sb.Append($"He did this {jumpCount} times.");
sb.AppendLine();

sb.Append("He also jumped over ");
sb.AppendJoin(", ", animals);

sb.Replace("fox", "cat");

Console.WriteLine(sb.ToString());

