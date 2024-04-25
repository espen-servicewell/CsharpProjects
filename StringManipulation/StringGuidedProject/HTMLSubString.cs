const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string subStringer(string divider, string input)
{
    int openingPosition = input.IndexOf($"<{divider}>");
    int closingPosition = input.IndexOf($"</{divider}>");

    openingPosition += 2 + divider.Length;
    int length = closingPosition - openingPosition;
    return input.Substring(openingPosition, length);
}

quantity = subStringer("span", input);
output = subStringer("div", input).Replace("trade", "reg");

Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output);