string input = "CBCABDJ";

string output = string.Empty;

foreach(char c in input)
{
    if(char.IsNumber(c))
    {
        output += c;
    }
    else
    {
        output += ((byte)c).ToString();

        Console.WriteLine(output);
    }           
}